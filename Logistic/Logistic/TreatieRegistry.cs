using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logistic
{
    public partial class TreatieRegistry : Form
    {
        public TreatieRegistry()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Form TreatieEdit = new TreatieEdit();
            TreatieEdit.Show();
        }

        private void StartDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (StartDateCheckBox.Checked == false)
            {
                StartDateListBox1.Enabled = false;
                StartDateListBox2.Enabled = false;
            }
            else 
            {
                StartDateListBox1.Enabled = true;
                StartDateListBox2.Enabled = true;
            }
        }

        private void EndDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EndDateCheckBox.Checked == false)
            {
                EndDateListBox1.Enabled = false;
                EndDateListBox2.Enabled = false;
            }
            else
            {
                EndDateListBox1.Enabled = true;
                EndDateListBox2.Enabled = true;
            }
        }

        private void ClearFilterButton_Click(object sender, EventArgs e)
        {
            TreatieNumberTextBox.Text = "";
            CounteragentListBox.Text = "";
            SummaryTextBox.Text = "";
            StatusListBox.SelectedItem = "Не выбрано";
            StartDateCheckBox.Checked = false;
            EndDateCheckBox.Checked = false;
        }

        private void ExportTreatieButton_Click(object sender, EventArgs e)
        {
            Form TreatieExport = new TreatieExport();
            TreatieExport.Show();
        }
    }
}
