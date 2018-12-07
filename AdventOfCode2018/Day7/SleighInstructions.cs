using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AdventOfCode2018.Day7
{
    public class SleighInstructions
    {
        public string FindOrder(string input)
        {
            var stepDepencies = BuildSteps(input);

            Step next = null;
            string s = "";
            while ((next = GetNextStep(stepDepencies))!= null)
            {
                s += next.StepId;
                next.Completed = true;
            }

            return s;
        }

        public static Step GetNextStep(List<Step> stepDepencies)
        {
            return stepDepencies.Where(x => x.DependentSteps.All(y => y.Completed) && !x.Completed).OrderBy(x => x.StepId)
                .FirstOrDefault();
        }

        public static List<Step> BuildSteps(string input)
        {
            var parsed = ParseInstructions(input);

            var stepDepencies = parsed.SelectMany(x => new[] {x.Step, x.DependentStep})
                .Distinct()
                .Select(x => new Step(x))
                .ToList();

            foreach (var step in stepDepencies)
            {
                var requiredBy = parsed.Where(x => x.DependentStep == step.StepId)
                    .Select(x => stepDepencies.First(y => y.StepId == x.Step))
                    .OrderBy(x => x.StepId);

                var dependentSteps = parsed.Where(x => x.Step == step.StepId)
                    .Select(x => stepDepencies.First(y => y.StepId == x.DependentStep));

                step.RequiredBy.AddRange(requiredBy);
                step.DependentSteps.AddRange(dependentSteps);
            }

            return stepDepencies;
        }

        private static ICollection<Instruction> ParseInstructions(string input)
        {
            return input.Split(Environment.NewLine)
                .Select(ParseLine)
                .ToList();
        }

        private static Instruction ParseLine(string line)
        {
            var match = Regex.Match(line, "Step ([A-Z]) must be finished before step ([A-Z]) can begin.");
            return new Instruction()
            {
                Step = match.Groups[2].Value,
                DependentStep = match.Groups[1].Value
            };
        }
    }
}
