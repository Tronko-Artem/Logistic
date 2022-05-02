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
using Logistic.Additions;

namespace Logistic
{
    public partial class TreatieExport : Form
    {

        private Treatie treatie = null;
        private Customer customer = null;

        OfficeExport.ExportData exportData;
        OfficeExport officeExport;

        public TreatieExport(Treatie _treatie = null)
        {
            InitializeComponent();

            textBox1.BackColor = ClaimsDaysTextBox.BackColor = SwapDaysTextBox.BackColor = SupplyDaysTextBox.BackColor = FinetextBox.BackColor = CustomerTextBox.BackColor = CustomerTextBox.BackColor = Color.White;
            textBox1.ForeColor = ClaimsDaysTextBox.ForeColor = SwapDaysTextBox.ForeColor = SupplyDaysTextBox.ForeColor = FinetextBox.ForeColor = CustomerTextBox.ForeColor = CustomerTextBox.ForeColor = Color.White;

            ForceEntryDatePicker.BackColor = UntilDatePicker.BackColor  = Color.White;
            ForceEntryDatePicker.ForeColor = UntilDatePicker.ForeColor = Color.Black;

            treatie = _treatie;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TreatieExport_Load(object sender, EventArgs e)
        {
            if( treatie == null ) return;


            TreatieNumberBox.Text = treatie.Number_Of_Treatie;
            ClaimsDaysTextBox.Text = treatie.Claims_Days.ToString();
            SwapDaysTextBox.Text = treatie.Swap_Days.ToString();
            SupplyDaysTextBox.Text = treatie.Supply_Delay.ToString();
            FinetextBox.Text = treatie.Fine.ToString();
            ForceEntryDatePicker.Value = treatie.Start_Date.Date;
            UntilDatePicker.Value = treatie.End_Date.Date;
			CustomerTextBox.Text = treatie.customer.Organization_Name;
			OrganizationDirectorLabel.Text = treatie.customer.Director_FIO;
			OrganizationINNLabel.Text = treatie.customer.INN;
			OrganizationNameLabel.Text = treatie.customer.Organization_Name;

        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            if (treatie == null)
            {
                MessageBox.Show("Что-то пошло не так! Не найден договор для экспорта...");
                return;
            }


            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Документ Word (*.docx)|*.docx",
                RestoreDirectory = true
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                buttonExport.Enabled = false;

               // ExportDoc(saveFileDialog.FileName);

                officeExport = new OfficeExport(exportData);
                officeExport.ReplaceText();
				officeExport.Close();
            }
        }

/*        
		private void ExportDoc(string nameFileExport) {

			exportData = new OfficeExport.ExportData();

			exportData.nameFileTemplate = Application.StartupPath + "\\..\\..\\resources\\docs\\leasing_contract_template.docx";
			exportData.nameFileExport = nameFileExport;         
			exportData.tableIndex = 3;                          // номер таблицы в доке
			exportData.textToReplace = new List<string>() {
				"[<номер_договора>]",						// 123
				"[<шапка_город>]",							// г. Барнаул
				"[<шапка_дата>]",							// «1» апрель 2021 г.
				"[<организация_лизингодатель>]",			// ООО "Хомячки"
				"[<представитель_лизингодатель>]", 			// Хомяков Х.Х.
				"[<организация_мы>]", 						// ООО "Хомячки2"
				"[<представитель_мы>]", 					// Хомяков Х.Х.2

				"[<1.3_стоимость_оборудования>]",			// хз - пропись или цифры
				"[<1.4_дата_поставки_оборудования>]", 		// «1» апрель 2021

				"[<2.2_срок_пользования_оборудованием>]", 	// 5 лет, 11 месяцев
				"[<2.3_дата_окончания_договора>]",			// «1» апреля 2021 года

				"[<3.1.1_дата_договора>]",					// «1» апрель 2021
				"[<3.2.1_пункт_поставки>]",					// ну какой-то адрес

				"[<4.1_лизингодатель_расчетный_счет>]",
				"[<4.1_лизингодатель_банк>]",
				"[<4.1_лизингодатель_бик>]",

				"[<4.4_дней_для_первого_платежа>]",			// 10

				"[<5.1_пункт_поставки>]",					// дублирование п1.4
				"[<5.4_срок_отказа>]",						// 3

				"[<6.1_пеня>]",								// 0,5
				"[<6.1_макс_платеж>]",						// 5
				"[<6.2_неустойка>]",						// хз - пропись или цифры

				"[<7.1_дней_форс_мажора>]",

				"[<9.3_лизингодатель_юр_адрес_и_телефон>]",
				"[<9.3_мы_юр_адрес_и_телефон>]",


				"[<лизингодатель_юр_адрес>]",
				"[<лизингодатель_почт_адрес>]",
				"[<лизингодатель_телефон>]",
				"[<лизингодатель_инн>]",
				"[<лизингодатель_расчет_счет>]",
				"[<лизингодатель_банк>]",
				"[<лизингодатель_корресп_счет>]",
				"[<лизингодатель_бик>]",

				"[<мы_юр_адрес>]",
				"[<мы_почт_адрес>]",
				"[<мы_телефон>]",
				"[<мы_инн>]",
				"[<мы_расчет_счет>]",
				"[<мы_банк>]",
				"[<мы_корресп_счет>]",
				"[<мы_бик>]",

				"[<приложение_номер_договора>]",
				"[<приложение_дата_договора>]",				//«1» апрель 2021 года

				"[<приложение_лизингодатель>]",
				"[<приложение_лизингополучат>]"
			};

			string rubles = new MoneyToStr("RUR", "RUS", "NUMBER").convertValue(Convert.ToDouble(LeasingContractTotalCost));

			// тут какие-то текстбоксы видимо с формы
			exportData.textReplaceWith = new List<string>() {
				contract.contract_number,
				"г. " + textBox_City.Text,
				DateToString.Translate(contract.date, "г."),
				leaser.name,
				textBox_FIO_Leaser.Text,
				lessee.name,
				textBox_FIO_Lessee.Text,

				rubles,
				DateToString.Translate(contract.date_delivery),

				ConvertYearsMonths.Translate(contract.period_of_use),
				DateToString.Translate(contract.date_end, "года"),

				DateToString.Translate(contract.date),
				contract.address_delivery,

				leaser.payment_account,
				leaser.bank,
				leaser.BIK,

				contract.days_for_first_payment.ToString(),

				contract.address_delivery,
				contract.days_for_report.ToString(),

				contract.penalty.ToString(),
				contract.max_penalty.ToString(),
				contract.penalty_fee.ToString(),

				contract.days_for_force_majeure.ToString(),

				leaser.legal_address + " " + leaser.phone,
				lessee.legal_address + " " + lessee.phone,

				leaser.legal_address,
				leaser.mailing_address,
				leaser.phone,
				leaser.INN,
				leaser.payment_account,
				leaser.bank,
				leaser.correspondent_account,
				leaser.BIK,

				lessee.legal_address,
				lessee.mailing_address,
				lessee.phone,
				lessee.INN,
				lessee.payment_account,
				lessee.bank,
				lessee.correspondent_account,
				lessee.BIK,

				contract.contract_number,
				DateToString.Translate(contract.date, "года"),

				leaser.name + " " + textBox_FIO_Leaser.Text,
				lessee.name + " " + textBox_FIO_Lessee.Text
			};

			// если надо открыть файл после экспорта автоматически
			exportData.openFileExport = checkBox_OpenFileExport.Checked;

			// и самый интересный момент - таблица
			// количество строк с учетом что одна строка по умолчанию есть внутри шаблона
			// какой столбик из datagridview в какой столбик в доке
			// и еще есть столбцы по умолчанию
			exportData.indicesDefaultValues = new List<int>() {
				5	// наименование ед. измерения
			};
			exportData.valuesDefaultValues = new List<string>();

			exportData.indicesCustomValues = new List<int>();

			exportData.valuesCustomValues = new List<List<string>>();

			foreach (DataGridViewRow row in dataGridView_Data.Rows) {
				string name = row.Cells[0].Value.ToString();
				string cost_per_one = row.Cells[1].Value.ToString();
				string amount = row.Cells[2].Value.ToString();
				string cost_per_all = row.Cells[4].Value.ToString();

				exportData.valuesCustomValues.Add(
					new List<string>() {
						name,
						cost_per_one,
						amount,
						cost_per_all
				});
			}
		}
*/


    }
}
