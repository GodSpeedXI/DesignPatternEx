using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSimple.StatePattern
{
    public class Canvas
    {
        private ITool _currentTool;
        public Canvas()
        {

        }

        public string GetCurrentTool()
        {
            return _currentTool.ToString();
        }

        public void SetTool(ITool tool) { 
            _currentTool = tool;
            Console.WriteLine(GetCurrentTool());
        }
    }
}
