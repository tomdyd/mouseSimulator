using Gma.System.MouseKeyHook;
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
    public partial class EditPoint : Form
    {
        private ListBox _stepsList;
        private Step _selectedPoint;
        private BindingList<Step> _source;
        private IKeyboardEvents _hook;
        public EditPoint(ListBox stepsList)
        {
            InitializeComponent();
            _stepsList = stepsList;
            _selectedPoint = (Step)_stepsList.SelectedItem;
            _source = (BindingList<Step>)_stepsList.DataSource;
            _hook = Hook.GlobalEvents();
            _hook.KeyDown += SetPos;

            if (_selectedPoint is ClickStep clickStep)
            {
                xPos.Text = clickStep.Position.X.ToString();
                yPos.Text = clickStep.Position.Y.ToString();
            }
        }

        private void SetPos(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.H)
            {
                xPos.Text = Cursor.Position.X.ToString();
                yPos.Text = Cursor.Position.Y.ToString();
            }
        }

        private void Ok_btn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(xPos.Text, out int x))
            {
                if (int.TryParse(yPos.Text, out int y))
                {
                    _stepsList.DataSource = null;
                    var selectedIndex = _source.IndexOf(_selectedPoint);
                    _source.RemoveAt(selectedIndex);
                    _source.Insert(selectedIndex, new ClickStep(new Point(x, y)));
                    _stepsList.DataSource = _source;
                }
            }
            this.Close();
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
