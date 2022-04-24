
namespace Logistic
{
    partial class TreatieEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.UntilDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.ForceEntryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.CounterAgentsBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TreatieNumberBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(135, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Редактирование договора";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(371, 405);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(268, 46);
            this.CancelButton.TabIndex = 33;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(94, 405);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(268, 46);
            this.button3.TabIndex = 32;
            this.button3.Text = "Применить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(402, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Действителен до:";
            // 
            // UntilDatePicker
            // 
            this.UntilDatePicker.Location = new System.Drawing.Point(402, 250);
            this.UntilDatePicker.Name = "UntilDatePicker";
            this.UntilDatePicker.Size = new System.Drawing.Size(200, 27);
            this.UntilDatePicker.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Дата вступления в силу:";
            // 
            // ForceEntryDatePicker
            // 
            this.ForceEntryDatePicker.Location = new System.Drawing.Point(402, 168);
            this.ForceEntryDatePicker.Name = "ForceEntryDatePicker";
            this.ForceEntryDatePicker.Size = new System.Drawing.Size(200, 27);
            this.ForceEntryDatePicker.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Заказчик:";
            // 
            // CounterAgentsBox
            // 
            this.CounterAgentsBox.FormattingEnabled = true;
            this.CounterAgentsBox.ItemHeight = 20;
            this.CounterAgentsBox.Location = new System.Drawing.Point(136, 245);
            this.CounterAgentsBox.Name = "CounterAgentsBox";
            this.CounterAgentsBox.Size = new System.Drawing.Size(200, 24);
            this.CounterAgentsBox.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Номер договора:";
            // 
            // TreatieNumberBox
            // 
            this.TreatieNumberBox.Location = new System.Drawing.Point(136, 168);
            this.TreatieNumberBox.Name = "TreatieNumberBox";
            this.TreatieNumberBox.Size = new System.Drawing.Size(200, 27);
            this.TreatieNumberBox.TabIndex = 24;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Активен",
            "В ожидании",
            "Завершен"});
            this.comboBox1.Location = new System.Drawing.Point(402, 337);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 28);
            this.comboBox1.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Статус:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(136, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Сумма по договору:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 337);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 27);
            this.textBox1.TabIndex = 36;
            // 
            // TreatieEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 513);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.UntilDatePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ForceEntryDatePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CounterAgentsBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TreatieNumberBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TreatieEdit";
            this.Text = "Редактирование договора";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker UntilDatePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker ForceEntryDatePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox CounterAgentsBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TreatieNumberBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
    }
}