using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testClick
{
    public class ScrollStep : Step
    {
        public int ScrollAmount { get; set; }

        public ScrollStep(int scrollAmount)
        {
            ScrollAmount = scrollAmount;
        }

        public override void Execute()
        {
            mouse_event(MOUSEEVENTF_WHEEL, 0, 0, (uint)ScrollAmount, 0);
        }

        public override string ToString()
        {
            return $"Scroll by {ScrollAmount} units";
        }
    }
}
