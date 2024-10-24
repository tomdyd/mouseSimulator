using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace testClick
{
    public class ClickStep : Step
    {
        
        public Point Position { get; set; }

        public ClickStep(Point position)
        {
            Position = position;
        }
        public override void Execute()
        {
            Cursor.Position = Position;
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }
        public override string ToString()
        {
            return $"Click at {Position}";
        }
    }
}
