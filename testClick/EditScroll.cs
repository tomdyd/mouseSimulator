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
        private Step _selectedPoint;
        private BindingList<Step> _source;
        public EditScroll(ListBox stepsList)
        {
            InitializeComponent();
            _stepsList = stepsList;
            _selectedPoint = (Step)_stepsList.SelectedItem;
            _source = (BindingList<Step>)_stepsList.DataSource;

            if (_selectedPoint is ScrollStep scrollStep)
            {
                scrollValue.Text = scrollStep.ScrollAmount.ToString();
            }
        }

        private void Ok_btn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(scrollValue.Text, out int newScrollValue))
            {
                _stepsList.DataSource = null;
                var selectedIndex = _source.IndexOf(_selectedPoint);
                _source.RemoveAt(selectedIndex);
                _source.Insert(selectedIndex, new ScrollStep(newScrollValue));
                _stepsList.DataSource = _source;
            }
            this.Close();
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
