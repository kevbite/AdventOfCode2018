using System.Collections.Generic;

namespace AdventOfCode2018.Day7
{
    public class Step
    {
        public static int BaseSeconds = 60;

        public Step(string stepId)
        {
            StepId = stepId;
            SecondsToComplete = BaseSeconds + (stepId[0] - 'A' + 1);
        }

        public string StepId { get; }

        public List<Step> DependentSteps { get; set; } = new List<Step>();
        public List<Step> RequiredBy { get; private set; } = new List<Step>();
        public bool Completed { get; set; }

        public int SecondsToComplete { get; set; }
    }
}