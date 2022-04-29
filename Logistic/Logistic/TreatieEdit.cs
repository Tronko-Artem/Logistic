﻿using System;
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
    public partial class TreatieEdit : Form
    {

        private Treatie EditTreatie = null;

        public TreatieEdit( Treatie treatie )
        {
            InitializeComponent();

            CounterAgentsComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CounterAgentsComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            List<Customer> customers = Program.db.CustomersList.ToList();
            CounterAgentsComboBox.DataSource = customers;
            CounterAgentsComboBox.AutoCompleteCustomSource.AddRange( customers.Select(i => i.ToString() ).ToArray());
            CounterAgentsComboBox.SelectedIndex = customers.Count > 0 ? 0 : -1;

            this.EditTreatie = treatie;

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if ( String.IsNullOrWhiteSpace( TreatieNumberBox.Text ) ||
                String.IsNullOrWhiteSpace( ClaimsDaysTextBox.Text ) ||
                String.IsNullOrWhiteSpace( SwapDaysTextBox.Text ) ||
                String.IsNullOrWhiteSpace( SupplyDaysTextBox.Text ) ||
                String.IsNullOrWhiteSpace( FinetextBox.Text ) ||
                String.IsNullOrWhiteSpace( SummaryTextBox.Text ) ||

                CounterAgentsComboBox.SelectedItem == null || CounterAgentsComboBox.SelectedIndex == -1 ||
                StatusComboBox.SelectedItem == null || StatusComboBox.SelectedIndex == -1
                )
            {
                MessageBox.Show("Чтобы изменить запись заполните все поля!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            decimal summary = -1;
            decimal fine = -1;
            int claims = -1;
            int supply = -1;
            int swap = -1;
            try
            {
                summary = Decimal.Parse(SummaryTextBox.Text);
                fine = Decimal.Parse(FinetextBox.Text);
                claims = Int32.Parse(ClaimsDaysTextBox.Text);
                supply = Int32.Parse(SupplyDaysTextBox.Text);
                swap = Int32.Parse(SwapDaysTextBox.Text);

            }
            catch (Exception /*exception*/ )
            {
                MessageBox.Show("Числовые поля заполнены неверно!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.EditTreatie.Number_Of_Treatie = this.TreatieNumberBox.Text;
            this.EditTreatie.Start_Date = this.ForceEntryDatePicker.Value.Date;
            this.EditTreatie.End_Date = this.UntilDatePicker.Value.Date;
            this.EditTreatie.Summary = summary;
            this.EditTreatie.Status = this.StatusComboBox.Text;
            this.EditTreatie.Claims_Days = claims;
            this.EditTreatie.Swap_Days = swap;
            this.EditTreatie.Supply_Delay = supply;
            this.EditTreatie.Fine = fine;
            this.EditTreatie.ID_Customer = ( ( Customer )this.CounterAgentsComboBox.SelectedItem ).ID_Customer;

            Program.db.TreatiesList.Update( this.EditTreatie );
            MessageBox.Show( "Успешно изменено!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information );
            Program.db.SaveChanges();
        }
    }
}
