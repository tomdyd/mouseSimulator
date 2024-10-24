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
        public EditPoint(ListBox stepsList)
        {
            InitializeComponent();
            _stepsList = stepsList;
        }

        private void Ok_btn_Click(object sender, EventArgs e)
        {
            Step selectedPoint = (Step)_stepsList.SelectedItem;
            BindingList<Step> source = (BindingList<Step>)_stepsList.DataSource;

            if (int.TryParse(xPos.Text, out int x))
            {
                if (int.TryParse(yPos.Text, out int y))
                {
                    _stepsList.DataSource = null;
                    var selectedIndex = source.IndexOf(selectedPoint);
                    source.RemoveAt(selectedIndex);
                    source.Insert(selectedIndex, new ClickStep(new Point(x, y)));
                    _stepsList.DataSource = source;
                }
            }
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
