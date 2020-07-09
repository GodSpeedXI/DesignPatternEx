using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSimple.StatePattern.StopwatchTool
{
    public class RuningState : IWatchState
    {
        private Stopwatch _stopWatch;
        public RuningState(Stopwatch stopwatch)
        {
            _stopWatch = stopwatch;
        }
        public void click()
        {
            _stopWatch.CurrentState = new StopState(_stopWatch);
        }
    }
}
