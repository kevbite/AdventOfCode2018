using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace AdventOfCode2018.Day18
{
    public class Day18
    {
        public int GetResourceValueAfter(int minutes, string input)
        {
            var lumberCollectionArea = LumberCollectionArea.Parse(input);

            for (var i = 0; i < minutes; i++)
            {
                lumberCollectionArea = lumberCollectionArea.Tick();
            }

                var allAcres = lumberCollectionArea.Acres.SelectMany(x => x);
                var trees = allAcres.OfType<TreesAcre>().Count();
                var lumberyard = allAcres.OfType<LumberyardAcre>().Count();

                var resourceValue = trees * lumberyard;

                return resourceValue;

        }

        public int GetResourceValueAfterWithPrediction(int minutes, string input)
        {
            var lumberCollectionArea = LumberCollectionArea.Parse(input);

            var sumBuffer = new Buffer<int>(2);
            var peakMaxs = new List<(int minutes, int sum)> ();
            var peakMins = new List<(int minutes, int sum)>();

            for (var i = 0; i < minutes; i++)
            {
                lumberCollectionArea = lumberCollectionArea.Tick();
                var allAcres = lumberCollectionArea.Acres.SelectMany(x => x);
                var sum = allAcres.OfType<TreesAcre>().Count() + allAcres.OfType<LumberyardAcre>().Count();

                if (sumBuffer.AllPositivelyCorrelate() && sum <= sumBuffer.LastOrDefault())
                {
                    peakMaxs.Add((i, sumBuffer.Last()));

                    if (peakMaxs.Count > 3 && WaveStable(peakMins, peakMaxs))
                    {
                        // y = aSin(B(x-D))+C

                        var lastTwoPeakMaxs = peakMaxs.TakeLast(2);
                        var secondLastMaxPeak = lastTwoPeakMaxs.First();
                        var LastMaxPeak = lastTwoPeakMaxs.Last();

                        var a = (LastMaxPeak.sum - peakMins.Last().sum) / 2;
                        var c = peakMins.Last().sum + a;

                        var d = (LastMaxPeak.minutes - secondLastMaxPeak.minutes) / 2
                                + LastMaxPeak.minutes;

                        var b = LastMaxPeak.minutes - secondLastMaxPeak.minutes;

                        var y = a * Math.Sin(b * (i - d)) + c;

                        return (int)y;
                    }
                }

                if (sumBuffer.AllNegativelyCorrelate() && sum >= sumBuffer.LastOrDefault())
                {
                    peakMins.Add((i, sumBuffer.Last()));
                }

                sumBuffer.Add(sum);
            }

            {
                var allAcres = lumberCollectionArea.Acres.SelectMany(x => x);
                var trees = allAcres.OfType<TreesAcre>().Count();
                var lumberyard = allAcres.OfType<LumberyardAcre>().Count();

                var resourceValue = trees * lumberyard;

                return resourceValue;
            }
        }

        private bool WaveStable(List<(int minutes, int sum)> peakMins, List<(int minutes, int sum)> peakMaxs)
        {
            return peakMins.TakeLast(3).Select(x => x.sum).Distinct().Count() == 1
                && peakMaxs.TakeLast(3).Select(x => x.sum).Distinct().Count() == 1;
        }
    }
}