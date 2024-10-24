using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testClick
{
    public partial class AddStep : Form
    {
        private HomeForm _home;
        private ManageSteps _manageSteps;
        private BindingList<Step> _steps;
        public AddStep(HomeForm home, BindingList<Step> steps, ManageSteps manageSteps)
        {
            InitializeComponent();

            timerCursor.Interval = 100;
            timerCursor.Tick += TimerCursor_Tick;
            timerCursor.Start();
            _home = home;
            _manageSteps = manageSteps;
            _steps = steps;
            _manageSteps.SetDataSource(steps);
        }

        private void TimerCursor_Tick(object sender, EventArgs e)
        {
            Point cursorPosition = Cursor.Position;

            currentX.Text = $"X: {cursorPosition.X}"; // Ustawianie wartości X
            currentY.Text = $"Y: {cursorPosition.Y}"; // Ustawianie wartości Y
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string xTempValue = xPos.Text;
            bool xIsNumber = int.TryParse(xTempValue, out int x);
            if (!xIsNumber)
            {
                MessageBox.Show("Nieprawidłowa wartość na osi x");
                return;
            }

            string yTempValue = yPos.Text;
            bool yIsNumber = int.TryParse(yTempValue, out int y);
            if (!yIsNumber)
            {
                MessageBox.Show("Nieprawidłowa wartość na osi y");
                return;
            }

            _home.AddPointList(new Point(x, y));

            xPos.Clear();
            yPos.Clear();
        }

        private void Ok_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddScroll_btn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(scrollValue.Text, out int scroll))
            {
                _home.AddScrollList(scroll);
                scrollValue.Clear();
            }
        }

        private void ScrollOk_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
