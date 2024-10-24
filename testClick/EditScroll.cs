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
    public partial class EditScroll : Form
    {
        private ListBox _stepsList;
        public EditScroll(ListBox stepsList)
        {
            InitializeComponent();
            _stepsList = stepsList;
        }

        private void Ok_btn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(scrollValue.Text, out int newScrollValue))
            {
                Step selectedPoint = (Step)_stepsList.SelectedItem;
                BindingList<Step> source = (BindingList<Step>)_stepsList.DataSource;

                _stepsList.DataSource = null;
                var selectedIndex = source.IndexOf(selectedPoint);
                source.RemoveAt(selectedIndex);
                source.Insert(selectedIndex, new ScrollStep(newScrollValue));
                _stepsList.DataSource = source;
            }
            this.Close();
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
