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
    public partial class ManageSteps : Form
    {
        public ManageSteps()
        {
            InitializeComponent();
        }

        public void AddToStepsList(Point item)
        {
            stepsList.Items.Add(item);
        }

        public void SetDataSource(BindingList<Step> source)
        {
            stepsList.DataSource = source;
            stepsList.DisplayMember = "ToString";
        }

        private void ManageSteps_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();

            e.Cancel = true;
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (stepsList.SelectedItem != null)
            {
                Step selectedPoint = (Step)stepsList.SelectedItem;
                BindingList<Step> source = (BindingList<Step>)stepsList.DataSource;
                stepsList.DataSource = null;

                // Usuń zaznaczony element
                source.Remove(selectedPoint);
                stepsList.DataSource = source;
            }
            else
            {
                // Jeśli nic nie jest zaznaczone, pokaż wiadomość
                MessageBox.Show("Proszę zaznaczyć element do usunięcia.");
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (stepsList.SelectedItem != null)
            {
                EditPoint editPoit = new EditPoint(stepsList);
                editPoit.Show();
            }
            else
            {
                MessageBox.Show("Proszę zaznaczyć element do edycji.");
            }
        }
    }
}
