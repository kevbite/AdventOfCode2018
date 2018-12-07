using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2018.Day7
{
    public class Workers
    {
        private readonly Worker[] _workers;

        public Workers(int numberOfWorkers)
        {
            _workers = Enumerable.Repeat(new Func<Worker>(() => new Worker()), numberOfWorkers)
                .Select(x => x())
                .ToArray();
        }
        public int Complete(string input)
        {
            var steps = SleighInstructions.BuildSteps(input);


            int elapsed = 0;

            var work = new List<Step>(steps);

            while (steps.Any(x => !x.Completed))
            {
                AssignWork(work);

                foreach (var worker in _workers)
                {
                    worker.Work();
                }

                elapsed++;
            }

            return elapsed;
        }

        private void AssignWork(List<Step> work)
        {
            foreach (var worker in _workers)
            {
                if (worker.CurrentStep == null)
                {
                    var workerCurrentStep = SleighInstructions.GetNextStep(work);
                    work.Remove(workerCurrentStep);
                    worker.CurrentStep = workerCurrentStep;
                }
            }
        }
    }
}