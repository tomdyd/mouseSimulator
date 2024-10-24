using Gma.System.MouseKeyHook;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace testClick
{
    public partial class HomeForm : Form
    {
        [DllImport("user32.dll")]
        private static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

        private const uint MOUSEEVENTF_MOVE = 0x0001;
        private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const uint MOUSEEVENTF_LEFTUP = 0x0004;
        private const uint MOUSEEVENTF_WHEEL = 0x0800;

        private ManageSteps _manageSteps;

        private IKeyboardMouseEvents _hook;
        private bool isRunning = true; // Flaga do zatrzymywania pêtl
        private BindingList<Step> _steps = new BindingList<Step>();


        public HomeForm()
        {
            InitializeComponent();
            this.KeyPreview = true; // Pozwala formularzowi nas³uchiwaæ na zdarzenia klawiatury
            _hook = Hook.GlobalEvents();
            _hook.KeyDown += Hook_KeyDown;
            _manageSteps = new ManageSteps();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Zwalniamy hook przed zamkniêciem formularza
            _hook.Dispose();
        }

        private void Hook_KeyDown(object sender, KeyEventArgs e)
        {
            // Jeœli wciœniêto klawisz 'Q', zatrzymaj mulacjê
            if (e.KeyCode == Keys.Q)
            {
                isRunning = false;
                MessageBox.Show($"Zatrzymano symulacjê! Wartoœæ zmiennej isRunning {isRunning}");
            }
        }

        private void StartSimulationButton_Click(object sender, EventArgs e)
        {
            // Uruchom symulacjê w osobnym w¹tku, aby interfejs u¿ytkownika nie by³ zablokowany
            Thread simulationThread = new Thread(SimulateMouseClickLoop);
            isRunning = true;
            simulationThread.Start();
        }

        private void SimulateScroll(int scrollAmount)
        {
            mouse_event(MOUSEEVENTF_WHEEL, 0, 0, (uint)scrollAmount, 0);
        }


        private void SimulateMouseClickLoop()
        {
            string sleepTimeTemp = sleepTime.Text;
            if (double.TryParse(sleepTimeTemp, out double sleepTimeDoubleTemp))
            {
                sleepTimeDoubleTemp *= 1000;
                int sleep = (int)sleepTimeDoubleTemp;
                while (isRunning)
                {
                    foreach (Step step in _steps)
                    {
                        step.Execute();
                        Thread.Sleep(sleep);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nieprawid³owa wartoœæ opóŸnienia!");
                isRunning = false;
            }
        }

        private void AddStepBtn_Click(object sender, EventArgs e)
        {            
            AddStep addStep = new AddStep(this, _steps, _manageSteps);

            addStep.Show();
        }

        public void AddPointList(Point item)
        {
            _steps.Add(new ClickStep(item));
        }

        public void AddScrollList(int value)
        {
            _steps.Add(new ScrollStep(value));
        }

        private void ManageSteps_Click(object sender, EventArgs e)
        {
            _manageSteps.Show();
        }
    }
}