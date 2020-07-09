using DesignPatternSimple.StatePattern;
using DesignPatternSimple.StatePattern.StopwatchTool;
using System;

namespace DesignPatternSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            var canvas = new Canvas();
            canvas.SetTool(new SelectTool());
            canvas.SetTool(new BrushTool());

            var sw = new Stopwatch();
            sw.StartOrStop();
            sw.StartOrStop();
            sw.StartOrStop();
            sw.StartOrStop();
        }
    }
}
