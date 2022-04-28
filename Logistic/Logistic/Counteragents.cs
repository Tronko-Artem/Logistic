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

            OkpoComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            OkpoComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

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
            OkpoComboBox.SelectedIndex = -1;

            dataGridView1.DataSource = Program.db.CustomersList.ToList();
            dataGridView1.ClearSelection();
        }

        private void Counteragents_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ReadOnly = true;
        }

        private void Counteragents_Activated(object sender, EventArgs e)
        {
            Okpo selectedOkpo = ( ( Okpo )OkpoComboBox.SelectedItem );
            List<Okpo> opkos = Program.db.OkpoList.ToList();
            OkpoComboBox.DataSource = opkos;

            if( selectedOkpo != null && opkos.Contains( selectedOkpo ) )
                OkpoComboBox.SelectedItem = selectedOkpo;
            else
                OkpoComboBox.SelectedItem = null;

            //updateTable();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            if( String.IsNullOrWhiteSpace( OrganizationNameTextBox.Text ) ) OrganizationNameTextBox.Text = "";
            if( String.IsNullOrWhiteSpace( FioTextBox.Text ) ) FioTextBox.Text = "";
            if( String.IsNullOrWhiteSpace( LawAddressTextBox.Text ) ) LawAddressTextBox.Text = "";
            if( String.IsNullOrWhiteSpace( InnTextBox.Text ) ) InnTextBox.Text = "";
            if( String.IsNullOrWhiteSpace( KppTextBox.Text ) ) KppTextBox.Text = "";
            if( String.IsNullOrWhiteSpace( CorrAccountTextBox.Text ) ) CorrAccountTextBox.Text = "";
            if( String.IsNullOrWhiteSpace( BikTextBox.Text ) ) BikTextBox.Text = "";

            List<Customer> allData = Program.db.CustomersList.ToList();
            List<Customer> searchResult = new List<Customer>();

            int ID_OKPO = -1;
            if (this.OkpoComboBox.SelectedItem != null)
                ID_OKPO = ( (Okpo)this.OkpoComboBox.SelectedItem ).ID_OKPO;

            foreach ( Customer customer in allData )
                if( customer.Organization_Name.ToLower().Contains( this.OrganizationNameTextBox.Text.ToLower() ) &&
                    customer.Director_FIO.ToLower().Contains( this.FioTextBox.Text.ToLower() ) &&
                    customer.Law_Address.ToLower().Contains( this.LawAddressTextBox.Text.ToLower() ) &&
                    customer.INN.ToLower().Contains( this.InnTextBox.Text.ToLower() ) &&
                    customer.KPP.ToLower().Contains( this.KppTextBox.Text.ToLower() ) &&
                    customer.Korr_Account.ToLower().Contains( this.CorrAccountTextBox.Text.ToLower() ) &&
                    customer.BIK.ToLower().Contains( this.BikTextBox.Text.ToLower() ) )
                {

                    if( ID_OKPO != -1 )
                    {
                        if( customer.ID_OKPO == ID_OKPO )
                            searchResult.Add( customer );
                    }
                    else
                        searchResult.Add( customer );
                }


            dataGridView1.DataSource = searchResult;
            dataGridView1.ClearSelection();
        }
    }
}
