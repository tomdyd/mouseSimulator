using Gma.System.MouseKeyHook;
using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace testClick
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        private static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

        private const uint MOUSEEVENTF_MOVE = 0x0001;
        private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const uint MOUSEEVENTF_LEFTUP = 0x0004;


        private IKeyboardMouseEvents _hook;
        private bool isRunning = true; // Flaga do zatrzymywania pêtl

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true; // Pozwala formularzowi nas³uchiwaæ na zdarzenia klawiatury
            _hook = Hook.GlobalEvents();
            _hook.KeyDown += Hook_KeyDown;
            
            timerCursor.Interval = 100;
            timerCursor.Tick += TimerCursor_Tick;
            timerCursor.Start();
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

        private void SimulateMouseClickLoop()
        {
            // Przyk³adowe wspó³rzêdne (mo¿esz je zmieniæ na dowolne)
            string xTempValue = xPos.Text;
            bool xIsNumber = int.TryParse(xTempValue, out int x);
            if (!xIsNumber)
            {
                MessageBox.Show("Nieprawid³owa wartoœæ na osi x");
            }

            string yTempValue = yPos.Text;
            bool yIsNumber = int.TryParse(yTempValue, out int y);
            if (!yIsNumber)
            {
                MessageBox.Show("Nieprawid³owa wartoœæ na osi y");
            }

            string sleepTimeTemp = sleepTime.Text;
            bool sleepIsNumber = int.TryParse(sleepTimeTemp, out int sleep);

            // Pêtla, która symuluje klikniêcia, dopóki flaga isRunning jest true
            while (isRunning)
            {
                // Ustawienie kursora w okreœlone miejsce
                Cursor.Position = new Point(x, y);
                Thread.Sleep(sleep * 1000); // Krótkie opóŸnienie przed klikniêciem

                // Symulowanie klikniêcia
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0); // Naciœnij lewy przycisk
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);   // Zwolnij lewy przycisk
            }
        }

        private void TimerCursor_Tick(object sender, EventArgs e)
        {
            Point cursorPosition = Cursor.Position;

            // Aktualizacja etykiet z aktualn¹ pozycj¹ kursora
            currentX.Text = $"X: {cursorPosition.X}"; // Ustawianie wartoœci X
            currentY.Text = $"Y: {cursorPosition.Y}"; // Ustawianie wartoœci Y
        }
    }
}
