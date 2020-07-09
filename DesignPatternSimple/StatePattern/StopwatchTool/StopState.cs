using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSimple.StatePattern.StopwatchTool
{
    public class StopState : IWatchState
    {
        private Stopwatch _stopWatch;
        public StopState(Stopwatch stopwatch)
        {
            _stopWatch = stopwatch;
        }
        public void click()
        {
            _stopWatch.CurrentState = new RuningState(_stopWatch);
        }
    }
}
