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
    public partial class AddCounteragent : Form
    {

        public AddCounteragent()
        {
            InitializeComponent();

            OkpoComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            OkpoComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            List<Okpo> okpos = Program.db.OkpoList.ToList();
            OkpoComboBox.DataSource = okpos;
            OkpoComboBox.AutoCompleteCustomSource.AddRange( okpos.Select(i => i.ID_OKPO.ToString() ).ToArray() ) ;
            OkpoComboBox.SelectedIndex = -1;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool addNewCustomer()
        {
            if ( String.IsNullOrWhiteSpace( OrganizationNameTextBox.Text ) ||
                String.IsNullOrWhiteSpace( OrganizationFormTextBox.Text ) ||
                String.IsNullOrWhiteSpace( FioTextBox.Text ) ||
                String.IsNullOrWhiteSpace( LawAddressTextBox.Text ) ||
                String.IsNullOrWhiteSpace( InnTextBox.Text ) ||
                String.IsNullOrWhiteSpace( KppTextBox.Text ) ||
                String.IsNullOrWhiteSpace( CheckingAccountTextBox.Text ) ||
                String.IsNullOrWhiteSpace( BikTextBox.Text ) ||
                OkpoComboBox.SelectedItem == null || OkpoComboBox.SelectedIndex == -1 // ||
                //FiasCombobox.SelectedItem == null || FiasCombobox.SelectedIndex == -1)
                )
            {
                MessageBox.Show("Чтобы добавить запись заполните все поля!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            Customer newCustomer = new Customer();

            newCustomer.Organization_Name = this.OrganizationNameTextBox.Text;
            newCustomer.Organization_Form = this.OrganizationFormTextBox.Text;
            newCustomer.Director_FIO = this.FioTextBox.Text;
            newCustomer.Law_Address = this.LawAddressTextBox.Text;
            newCustomer.Mail_Address = this.InnTextBox.Text;
            newCustomer.KPP = this.KppTextBox.Text;
            newCustomer.INN = this.InnTextBox.Text;
            newCustomer.Checking_Account = this.CheckingAccountTextBox.Text;
            newCustomer.Korr_Account = this.CorrAccountTextBox.Text;
            newCustomer.BIK = this.BikTextBox.Text;
            newCustomer.ID_OKPO = ( ( Okpo )this.OkpoComboBox.SelectedItem ).ID_OKPO;
            newCustomer.ID_FIAS = 1; // ( ( Fias )this.FiasCombobox.SelectedItem ).ID_FIAS;


            Program.db.CustomersList.Add( newCustomer );
            Program.db.SaveChanges();
            MessageBox.Show("Успешно добавлено!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return true;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            addNewCustomer();
        }
    }
}
