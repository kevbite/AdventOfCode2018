namespace AdventOfCode2018.Day7
{
    public class Worker
    {
        public Step CurrentStep { get; set; }


        public void Work()
        {
            if (CurrentStep != null)
            {
                CurrentStep.SecondsToComplete -= 1;
                if (CurrentStep.SecondsToComplete == 0)
                {
                    CurrentStep.Completed = true;
                    CurrentStep = null;
                }
            }
        }
    }
}