using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AdventOfCode2018.Day4
{
    public class GuardSleeping
    {
        public int GuardId { get; set; }

        public List<(int start, int end)> Times { get; set; } = new List<(int start, int end)>();


        public int TotalMinutes() => (int)Times.Sum(x => x.end - x.start);

    }
    public class GuardLog
    {
        public int GetGuardMostAsleepMin(string input)
        {
            var log = ParseLog(input);
            var sleeping = BuildSleepingGuards(log);

            var guardSleeping = sleeping.OrderByDescending(x => x.TotalMinutes())
                .First();

            var minute = Enumerable.Range(0, 59)
                .Select(x => new
                {
                    Minute = x,
                    Count = guardSleeping.Times.Count(r => x >= r.start && x < r.end)
                }).OrderByDescending(x => x.Count)
                .First().Minute;

            return minute * guardSleeping.GuardId;

        }

        public int GetGuardMostAsleepOnMinute(string input)
        {
            var log = ParseLog(input);
            var sleeping = BuildSleepingGuards(log);

            var first = sleeping.Select(x => Enumerable.Range(0, 59)
                    .Select(y => new
                    {
                        x.GuardId,
                        Minute = y,
                        Count = x.Times.Count(r => y >= r.start && y < r.end)
                    }))
                .SelectMany(x => x)
                .OrderByDescending(x => x.Count)
                .First();

            return first.GuardId * first.Minute;
        }

        private static List<GuardSleeping> BuildSleepingGuards(List<GuardLogItem> logItems)
        {
            var sleepingGuards = new List<GuardSleeping>();
            GuardSleeping sleeping = null;

            int? start = null;
            foreach (var logItem in logItems)
            {
                if (logItem.Message.EndsWith("begins shift"))
                {
                    var guardSleeping = new GuardSleeping
                    {
                        GuardId = int.Parse(Regex.Match(logItem.Message, @"#(\d+)")
                            .Groups[1].Value)
                    };

                    sleepingGuards.Add(guardSleeping);
                }
                else if (logItem.Message.EndsWith("falls asleep"))
                {
                    start = logItem.Seconds;
                }
                else if (logItem.Message.EndsWith("wakes up"))
                {
                    var end = logItem.Seconds;

                    sleepingGuards.Last()
                        .Times.Add((start.Value, end));
                }
            }

            return sleepingGuards
                .GroupBy(x => x.GuardId)
                .Select(x => new GuardSleeping()
                {
                    GuardId = x.Key,
                    Times = x.SelectMany(y => y.Times).ToList()
                }).ToList();
        }

        private static List<GuardLogItem> ParseLog(string input)
        {
            return input.Split(Environment.NewLine)
                .OrderBy(x => x)
                .Select(line =>
                {
                    var match = Regex.Match(line, @"\[\d{4}-\d{2}-\d{2} \d{2}:(\d{2})\] (.*)");

                    return new GuardLogItem()
                    {
                        Seconds = int.Parse(match.Groups[1].Value),
                        Message = match.Groups[2].Value
                    };
                }).ToList();
        }
    }

    public class GuardLogItem
    {
        public int Seconds { get; set; }

        public string Message { get; set; }
    }
}
