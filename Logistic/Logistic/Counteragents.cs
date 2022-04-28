using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Logistic.Models;

namespace Logistic
{
    public partial class Counteragents : Form
    {
        public Counteragents()
        {
            InitializeComponent();

            dataGridView1.Columns[0].DataPropertyName = "ID_Customer";
            dataGridView1.Columns[1].DataPropertyName = "Organization_Name";
            dataGridView1.Columns[2].DataPropertyName = "Organization_Form";
            dataGridView1.Columns[3].DataPropertyName = "Director_FIO";
            dataGridView1.Columns[4].DataPropertyName = "Law_Address";
            dataGridView1.Columns[5].DataPropertyName = "Mail_Address";
            dataGridView1.Columns[6].DataPropertyName = "INN";
            dataGridView1.Columns[7].DataPropertyName = "KPP";
            dataGridView1.Columns[8].DataPropertyName = "Checking_Account";
            dataGridView1.Columns[9].DataPropertyName = "Korr_Account";
            dataGridView1.Columns[10].DataPropertyName = "BIK";
            dataGridView1.Columns[11].DataPropertyName = "OKPO";

        }

        private void updateTable()
        {
            List<Customer> customers = Program.db.CustomersList.ToList();
            dataGridView1.DataSource = customers;
        }

        private void AddCounteragentButton_Click(object sender, EventArgs e)
        {
            Form AddCounteragent = new AddCounteragent();
            AddCounteragent.Show();
        }

        private void EditCounteragentButton_Click(object sender, EventArgs e)
        {
            Form EditCounteragent = new EditCounteragent();
            EditCounteragent.Show();
        }

        private void ClearFilterButton_Click(object sender, EventArgs e)
        {
            OrganizationNameTextBox.Text = "";
            FioTextBox.Text = "";
            LawAddressTextBox.Text = "";
            MailAddressTextBox.Text = "";
            InnTextBox.Text = "";
            KppTextBox.Text = "";
            CheckingAccountTextBox.Text = "";
            CorrAccountTextBox.Text = "";
            BikTextBox.Text = "";
            OkpoTextBox.Text = "";
        }

        private void Counteragents_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ReadOnly = true;
        }

        private void Counteragents_Activated(object sender, EventArgs e)
        {
            updateTable();
        }
    }
}
