
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
            this.button1 = new System.Windows.Forms.Button();
            this.ClearFilterButton = new System.Windows.Forms.Button();
            this.EndDateCheckBox = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.EndDateListBox2 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.EndDateListBox1 = new System.Windows.Forms.DateTimePicker();
            this.StartDateCheckBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.StartDateListBox2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.StartDateListBox1 = new System.Windows.Forms.DateTimePicker();
            this.SummaryTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.StatusListBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CounteragentListBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TreatieNumberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ExportTreatieButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(11, 362);
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
            this.label1.Location = new System.Drawing.Point(345, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Реестр договоров";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(778, 810);
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
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ClearFilterButton);
            this.panel1.Controls.Add(this.EndDateCheckBox);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.StartDateCheckBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.SummaryTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.StatusListBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.CounteragentListBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TreatieNumberTextBox);
            this.panel1.Location = new System.Drawing.Point(11, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 257);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(817, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 29);
            this.button1.TabIndex = 22;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ClearFilterButton
            // 
            this.ClearFilterButton.Location = new System.Drawing.Point(938, 3);
            this.ClearFilterButton.Name = "ClearFilterButton";
            this.ClearFilterButton.Size = new System.Drawing.Size(30, 29);
            this.ClearFilterButton.TabIndex = 21;
            this.ClearFilterButton.Text = "Х";
            this.ClearFilterButton.UseVisualStyleBackColor = true;
            this.ClearFilterButton.Click += new System.EventHandler(this.ClearFilterButton_Click);
            // 
            // EndDateCheckBox
            // 
            this.EndDateCheckBox.AutoSize = true;
            this.EndDateCheckBox.Location = new System.Drawing.Point(660, 66);
            this.EndDateCheckBox.Name = "EndDateCheckBox";
            this.EndDateCheckBox.Size = new System.Drawing.Size(213, 24);
            this.EndDateCheckBox.TabIndex = 20;
            this.EndDateCheckBox.Text = "Дата окончания действия:";
            this.EndDateCheckBox.UseVisualStyleBackColor = true;
            this.EndDateCheckBox.CheckedChanged += new System.EventHandler(this.EndDateCheckBox_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.EndDateListBox2);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.EndDateListBox1);
            this.panel3.Location = new System.Drawing.Point(660, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 121);
            this.panel3.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "По:";
            // 
            // EndDateListBox2
            // 
            this.EndDateListBox2.Enabled = false;
            this.EndDateListBox2.Location = new System.Drawing.Point(46, 74);
            this.EndDateListBox2.Name = "EndDateListBox2";
            this.EndDateListBox2.Size = new System.Drawing.Size(182, 27);
            this.EndDateListBox2.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "С:";
            // 
            // EndDateListBox1
            // 
            this.EndDateListBox1.Enabled = false;
            this.EndDateListBox1.Location = new System.Drawing.Point(46, 30);
            this.EndDateListBox1.Name = "EndDateListBox1";
            this.EndDateListBox1.Size = new System.Drawing.Size(182, 27);
            this.EndDateListBox1.TabIndex = 4;
            // 
            // StartDateCheckBox
            // 
            this.StartDateCheckBox.AutoSize = true;
            this.StartDateCheckBox.Location = new System.Drawing.Point(344, 66);
            this.StartDateCheckBox.Name = "StartDateCheckBox";
            this.StartDateCheckBox.Size = new System.Drawing.Size(154, 24);
            this.StartDateCheckBox.TabIndex = 18;
            this.StartDateCheckBox.Text = "Дата заключения:";
            this.StartDateCheckBox.UseVisualStyleBackColor = true;
            this.StartDateCheckBox.CheckedChanged += new System.EventHandler(this.StartDateCheckBox_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Сумма по договору:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.StartDateListBox2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.StartDateListBox1);
            this.panel2.Location = new System.Drawing.Point(344, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 121);
            this.panel2.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "По:";
            // 
            // StartDateListBox2
            // 
            this.StartDateListBox2.Enabled = false;
            this.StartDateListBox2.Location = new System.Drawing.Point(46, 74);
            this.StartDateListBox2.Name = "StartDateListBox2";
            this.StartDateListBox2.Size = new System.Drawing.Size(182, 27);
            this.StartDateListBox2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "С:";
            // 
            // StartDateListBox1
            // 
            this.StartDateListBox1.Enabled = false;
            this.StartDateListBox1.Location = new System.Drawing.Point(46, 30);
            this.StartDateListBox1.Name = "StartDateListBox1";
            this.StartDateListBox1.Size = new System.Drawing.Size(182, 27);
            this.StartDateListBox1.TabIndex = 4;
            // 
            // SummaryTextBox
            // 
            this.SummaryTextBox.Location = new System.Drawing.Point(63, 158);
            this.SummaryTextBox.Name = "SummaryTextBox";
            this.SummaryTextBox.Size = new System.Drawing.Size(198, 27);
            this.SummaryTextBox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Статус:";
            // 
            // StatusListBox
            // 
            this.StatusListBox.FormattingEnabled = true;
            this.StatusListBox.Items.AddRange(new object[] {
            "Не выбрано",
            "Активен",
            "Завершен"});
            this.StatusListBox.Location = new System.Drawing.Point(63, 209);
            this.StatusListBox.Name = "StatusListBox";
            this.StatusListBox.Size = new System.Drawing.Size(198, 28);
            this.StatusListBox.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Контрагент:";
            // 
            // CounteragentListBox
            // 
            this.CounteragentListBox.FormattingEnabled = true;
            this.CounteragentListBox.Location = new System.Drawing.Point(63, 103);
            this.CounteragentListBox.Name = "CounteragentListBox";
            this.CounteragentListBox.Size = new System.Drawing.Size(198, 28);
            this.CounteragentListBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Номер договора:";
            // 
            // TreatieNumberTextBox
            // 
            this.TreatieNumberTextBox.Location = new System.Drawing.Point(63, 51);
            this.TreatieNumberTextBox.Name = "TreatieNumberTextBox";
            this.TreatieNumberTextBox.Size = new System.Drawing.Size(198, 27);
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
            this.EditButton.Location = new System.Drawing.Point(219, 810);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(202, 37);
            this.EditButton.TabIndex = 4;
            this.EditButton.Text = "Редактировать";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(427, 810);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ExportTreatieButton
            // 
            this.ExportTreatieButton.Location = new System.Drawing.Point(11, 810);
            this.ExportTreatieButton.Name = "ExportTreatieButton";
            this.ExportTreatieButton.Size = new System.Drawing.Size(202, 37);
            this.ExportTreatieButton.TabIndex = 6;
            this.ExportTreatieButton.Text = "Экспортировать";
            this.ExportTreatieButton.UseVisualStyleBackColor = true;
            this.ExportTreatieButton.Click += new System.EventHandler(this.ExportTreatieButton_Click);
            // 
            // TreatieRegistry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 857);
            this.Controls.Add(this.ExportTreatieButton);
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
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TreatieNumberTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CounteragentListBox;
        private System.Windows.Forms.DateTimePicker StartDateListBox1;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TreatieNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfConclusion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Counterparty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Summary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SummaryTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox StatusListBox;
        private System.Windows.Forms.Button ClearFilterButton;
        private System.Windows.Forms.CheckBox EndDateCheckBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker EndDateListBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker EndDateListBox1;
        private System.Windows.Forms.CheckBox StartDateCheckBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker StartDateListBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ExportTreatieButton;
        private System.Windows.Forms.Button button1;
    }
}