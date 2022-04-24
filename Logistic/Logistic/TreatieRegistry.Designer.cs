
namespace Logistic
{
    partial class TreatieRegistry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TreatieNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfConclusion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Counterparty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Summary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CounterpartyTextBox = new System.Windows.Forms.ComboBox();
            this.DateOfEndTextBox = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.DateOfConclusionTextBox = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TreatieNumberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TreatieNumber,
            this.DateOfConclusion,
            this.DateOfEnd,
            this.Counterparty,
            this.Summary,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(11, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(973, 432);
            this.dataGridView1.TabIndex = 0;
            // 
            // TreatieNumber
            // 
            this.TreatieNumber.HeaderText = "Номер договора";
            this.TreatieNumber.MinimumWidth = 6;
            this.TreatieNumber.Name = "TreatieNumber";
            // 
            // DateOfConclusion
            // 
            this.DateOfConclusion.HeaderText = "Дата заключения";
            this.DateOfConclusion.MinimumWidth = 6;
            this.DateOfConclusion.Name = "DateOfConclusion";
            // 
            // DateOfEnd
            // 
            this.DateOfEnd.HeaderText = "Дата окончания действия";
            this.DateOfEnd.MinimumWidth = 6;
            this.DateOfEnd.Name = "DateOfEnd";
            // 
            // Counterparty
            // 
            this.Counterparty.HeaderText = "Контрагент";
            this.Counterparty.MinimumWidth = 6;
            this.Counterparty.Name = "Counterparty";
            // 
            // Summary
            // 
            this.Summary.HeaderText = "Сумма по договору";
            this.Summary.MinimumWidth = 6;
            this.Summary.Name = "Summary";
            // 
            // Status
            // 
            this.Status.HeaderText = "Статус";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(345, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Реестр договоров";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(783, 723);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(202, 37);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Закрыть";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.CounterpartyTextBox);
            this.panel1.Controls.Add(this.DateOfEndTextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.DateOfConclusionTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TreatieNumberTextBox);
            this.panel1.Location = new System.Drawing.Point(11, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 167);
            this.panel1.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(694, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Сумма по договору:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(694, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 27);
            this.textBox1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(694, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Статус:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Активен",
            "Завершен"});
            this.comboBox1.Location = new System.Drawing.Point(694, 120);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 28);
            this.comboBox1.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(410, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Контрагент:";
            // 
            // CounterpartyTextBox
            // 
            this.CounterpartyTextBox.FormattingEnabled = true;
            this.CounterpartyTextBox.Location = new System.Drawing.Point(410, 51);
            this.CounterpartyTextBox.Name = "CounterpartyTextBox";
            this.CounterpartyTextBox.Size = new System.Drawing.Size(182, 28);
            this.CounterpartyTextBox.TabIndex = 11;
            // 
            // DateOfEndTextBox
            // 
            this.DateOfEndTextBox.Location = new System.Drawing.Point(410, 122);
            this.DateOfEndTextBox.Name = "DateOfEndTextBox";
            this.DateOfEndTextBox.Size = new System.Drawing.Size(182, 27);
            this.DateOfEndTextBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Дата окончания:";
            // 
            // DateOfConclusionTextBox
            // 
            this.DateOfConclusionTextBox.Location = new System.Drawing.Point(94, 122);
            this.DateOfConclusionTextBox.Name = "DateOfConclusionTextBox";
            this.DateOfConclusionTextBox.Size = new System.Drawing.Size(182, 27);
            this.DateOfConclusionTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Дата заключения:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Номер договора:";
            // 
            // TreatieNumberTextBox
            // 
            this.TreatieNumberTextBox.Location = new System.Drawing.Point(94, 52);
            this.TreatieNumberTextBox.Name = "TreatieNumberTextBox";
            this.TreatieNumberTextBox.Size = new System.Drawing.Size(182, 27);
            this.TreatieNumberTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Фильтры";
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(11, 723);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(202, 37);
            this.EditButton.TabIndex = 4;
            this.EditButton.Text = "Редактировать";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(246, 723);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TreatieRegistry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 776);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TreatieRegistry";
            this.Text = "Реестр договоров";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TreatieNumberTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CounterpartyTextBox;
        private System.Windows.Forms.DateTimePicker DateOfEndTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DateOfConclusionTextBox;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TreatieNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfConclusion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Counterparty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Summary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}