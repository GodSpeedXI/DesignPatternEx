using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSimple.StatePattern.StopwatchTool
{
    public class Stopwatch
    {
        public IWatchState CurrentState{ get;set; }

        public Stopwatch()
        {
            CurrentState = new StopState(this);
        }
        public void StartOrStop() 
        {
            CurrentState.click();
            Console.WriteLine("CurrentStateIs : " + CurrentState);
        }
    }
}
