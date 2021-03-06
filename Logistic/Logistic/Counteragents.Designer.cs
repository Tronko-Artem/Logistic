
namespace Logistic
{
    partial class Counteragents
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddCounteragentButton = new System.Windows.Forms.Button();
            this.EditCounteragentButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.OkpoTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BikTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CorrAccountTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CheckingAccountTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.KppTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.InnTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MailAddressTextBox = new System.Windows.Forms.TextBox();
            this.LawAddressTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FioTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OrganizationNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OrganizationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrganizationType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DirectorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrganizationAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrganizationMailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrganizationINN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrganizationKPP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrganizationCheckingAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrganizationCorrespondentAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrganizationBIK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrganizationOKPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FindButton = new System.Windows.Forms.Button();
            this.ClearFilterButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(471, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Клиентская база";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrganizationName,
            this.OrganizationType,
            this.DirectorName,
            this.OrganizationAddress,
            this.OrganizationMailAddress,
            this.OrganizationINN,
            this.OrganizationKPP,
            this.OrganizationCheckingAccount,
            this.OrganizationCorrespondentAccount,
            this.OrganizationBIK,
            this.OrganizationOKPO});
            this.dataGridView1.Location = new System.Drawing.Point(13, 296);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1197, 374);
            this.dataGridView1.TabIndex = 1;
            // 
            // AddCounteragentButton
            // 
            this.AddCounteragentButton.Location = new System.Drawing.Point(14, 677);
            this.AddCounteragentButton.Name = "AddCounteragentButton";
            this.AddCounteragentButton.Size = new System.Drawing.Size(206, 29);
            this.AddCounteragentButton.TabIndex = 2;
            this.AddCounteragentButton.Text = "Добавить";
            this.AddCounteragentButton.UseVisualStyleBackColor = true;
            this.AddCounteragentButton.Click += new System.EventHandler(this.AddCounteragentButton_Click);
            // 
            // EditCounteragentButton
            // 
            this.EditCounteragentButton.Location = new System.Drawing.Point(226, 677);
            this.EditCounteragentButton.Name = "EditCounteragentButton";
            this.EditCounteragentButton.Size = new System.Drawing.Size(206, 29);
            this.EditCounteragentButton.TabIndex = 3;
            this.EditCounteragentButton.Text = "Редактировать";
            this.EditCounteragentButton.UseVisualStyleBackColor = true;
            this.EditCounteragentButton.Click += new System.EventHandler(this.EditCounteragentButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1004, 676);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 29);
            this.button3.TabIndex = 4;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ClearFilterButton);
            this.panel1.Controls.Add(this.FindButton);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.OkpoTextBox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.BikTextBox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.CorrAccountTextBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.CheckingAccountTextBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.KppTextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.InnTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.MailAddressTextBox);
            this.panel1.Controls.Add(this.LawAddressTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.FioTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.OrganizationNameTextBox);
            this.panel1.Location = new System.Drawing.Point(13, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1196, 193);
            this.panel1.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(971, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "ОКПО:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(971, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "БИК:";
            // 
            // OkpoTextBox
            // 
            this.OkpoTextBox.Location = new System.Drawing.Point(971, 117);
            this.OkpoTextBox.Name = "OkpoTextBox";
            this.OkpoTextBox.Size = new System.Drawing.Size(189, 27);
            this.OkpoTextBox.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(743, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(186, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Корреспондентский счет:";
            // 
            // BikTextBox
            // 
            this.BikTextBox.Location = new System.Drawing.Point(971, 49);
            this.BikTextBox.Name = "BikTextBox";
            this.BikTextBox.Size = new System.Drawing.Size(189, 27);
            this.BikTextBox.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(743, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Расчетный счет:";
            // 
            // CorrAccountTextBox
            // 
            this.CorrAccountTextBox.Location = new System.Drawing.Point(743, 117);
            this.CorrAccountTextBox.Name = "CorrAccountTextBox";
            this.CorrAccountTextBox.Size = new System.Drawing.Size(189, 27);
            this.CorrAccountTextBox.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(514, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "КПП:";
            // 
            // CheckingAccountTextBox
            // 
            this.CheckingAccountTextBox.Location = new System.Drawing.Point(743, 49);
            this.CheckingAccountTextBox.Name = "CheckingAccountTextBox";
            this.CheckingAccountTextBox.Size = new System.Drawing.Size(189, 27);
            this.CheckingAccountTextBox.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(514, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "ИНН:";
            // 
            // KppTextBox
            // 
            this.KppTextBox.Location = new System.Drawing.Point(514, 117);
            this.KppTextBox.Name = "KppTextBox";
            this.KppTextBox.Size = new System.Drawing.Size(189, 27);
            this.KppTextBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Почтовый адрес:";
            // 
            // InnTextBox
            // 
            this.InnTextBox.Location = new System.Drawing.Point(514, 49);
            this.InnTextBox.Name = "InnTextBox";
            this.InnTextBox.Size = new System.Drawing.Size(189, 27);
            this.InnTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Юридический адрес:";
            // 
            // MailAddressTextBox
            // 
            this.MailAddressTextBox.Location = new System.Drawing.Point(270, 117);
            this.MailAddressTextBox.Name = "MailAddressTextBox";
            this.MailAddressTextBox.Size = new System.Drawing.Size(189, 27);
            this.MailAddressTextBox.TabIndex = 7;
            // 
            // LawAddressTextBox
            // 
            this.LawAddressTextBox.Location = new System.Drawing.Point(270, 49);
            this.LawAddressTextBox.Name = "LawAddressTextBox";
            this.LawAddressTextBox.Size = new System.Drawing.Size(189, 27);
            this.LawAddressTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "ФИО директора:";
            // 
            // FioTextBox
            // 
            this.FioTextBox.Location = new System.Drawing.Point(32, 117);
            this.FioTextBox.Name = "FioTextBox";
            this.FioTextBox.Size = new System.Drawing.Size(189, 27);
            this.FioTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Название организации:";
            // 
            // OrganizationNameTextBox
            // 
            this.OrganizationNameTextBox.Location = new System.Drawing.Point(32, 49);
            this.OrganizationNameTextBox.Name = "OrganizationNameTextBox";
            this.OrganizationNameTextBox.Size = new System.Drawing.Size(189, 27);
            this.OrganizationNameTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Фильтр";
            // 
            // OrganizationName
            // 
            this.OrganizationName.HeaderText = "Название организации";
            this.OrganizationName.MinimumWidth = 6;
            this.OrganizationName.Name = "OrganizationName";
            this.OrganizationName.ReadOnly = true;
            // 
            // OrganizationType
            // 
            this.OrganizationType.HeaderText = "Форма организации";
            this.OrganizationType.MinimumWidth = 6;
            this.OrganizationType.Name = "OrganizationType";
            this.OrganizationType.ReadOnly = true;
            // 
            // DirectorName
            // 
            this.DirectorName.HeaderText = "ФИО директора";
            this.DirectorName.MinimumWidth = 6;
            this.DirectorName.Name = "DirectorName";
            this.DirectorName.ReadOnly = true;
            // 
            // OrganizationAddress
            // 
            this.OrganizationAddress.HeaderText = "Юридический адрес";
            this.OrganizationAddress.MinimumWidth = 6;
            this.OrganizationAddress.Name = "OrganizationAddress";
            this.OrganizationAddress.ReadOnly = true;
            // 
            // OrganizationMailAddress
            // 
            this.OrganizationMailAddress.HeaderText = "Почтовый адрес";
            this.OrganizationMailAddress.MinimumWidth = 6;
            this.OrganizationMailAddress.Name = "OrganizationMailAddress";
            this.OrganizationMailAddress.ReadOnly = true;
            // 
            // OrganizationINN
            // 
            this.OrganizationINN.HeaderText = "ИНН";
            this.OrganizationINN.MinimumWidth = 6;
            this.OrganizationINN.Name = "OrganizationINN";
            this.OrganizationINN.ReadOnly = true;
            // 
            // OrganizationKPP
            // 
            this.OrganizationKPP.HeaderText = "КПП";
            this.OrganizationKPP.MinimumWidth = 6;
            this.OrganizationKPP.Name = "OrganizationKPP";
            this.OrganizationKPP.ReadOnly = true;
            // 
            // OrganizationCheckingAccount
            // 
            this.OrganizationCheckingAccount.HeaderText = "Расчетный счет";
            this.OrganizationCheckingAccount.MinimumWidth = 6;
            this.OrganizationCheckingAccount.Name = "OrganizationCheckingAccount";
            this.OrganizationCheckingAccount.ReadOnly = true;
            // 
            // OrganizationCorrespondentAccount
            // 
            this.OrganizationCorrespondentAccount.HeaderText = "Корреспондентский счет";
            this.OrganizationCorrespondentAccount.MinimumWidth = 6;
            this.OrganizationCorrespondentAccount.Name = "OrganizationCorrespondentAccount";
            this.OrganizationCorrespondentAccount.ReadOnly = true;
            // 
            // OrganizationBIK
            // 
            this.OrganizationBIK.HeaderText = "БИК";
            this.OrganizationBIK.MinimumWidth = 6;
            this.OrganizationBIK.Name = "OrganizationBIK";
            this.OrganizationBIK.ReadOnly = true;
            // 
            // OrganizationOKPO
            // 
            this.OrganizationOKPO.HeaderText = "ОКПО";
            this.OrganizationOKPO.MinimumWidth = 6;
            this.OrganizationOKPO.Name = "OrganizationOKPO";
            this.OrganizationOKPO.ReadOnly = true;
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(1066, 159);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(125, 29);
            this.FindButton.TabIndex = 9;
            this.FindButton.Text = "Найти";
            this.FindButton.UseVisualStyleBackColor = true;
            // 
            // ClearFilterButton
            // 
            this.ClearFilterButton.Location = new System.Drawing.Point(1162, 3);
            this.ClearFilterButton.Name = "ClearFilterButton";
            this.ClearFilterButton.Size = new System.Drawing.Size(29, 29);
            this.ClearFilterButton.TabIndex = 10;
            this.ClearFilterButton.Text = "X";
            this.ClearFilterButton.UseVisualStyleBackColor = true;
            this.ClearFilterButton.Click += new System.EventHandler(this.ClearFilterButton_Click);
            // 
            // Counteragents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 716);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.EditCounteragentButton);
            this.Controls.Add(this.AddCounteragentButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Counteragents";
            this.Text = "Клиентская база";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddCounteragentButton;
        private System.Windows.Forms.Button EditCounteragentButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox OkpoTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox BikTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CorrAccountTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CheckingAccountTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox KppTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox InnTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MailAddressTextBox;
        private System.Windows.Forms.TextBox LawAddressTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FioTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OrganizationNameTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganizationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganizationType;
        private System.Windows.Forms.DataGridViewTextBoxColumn DirectorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganizationAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganizationMailAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganizationINN;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganizationKPP;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganizationCheckingAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganizationCorrespondentAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganizationBIK;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganizationOKPO;
        private System.Windows.Forms.Button ClearFilterButton;
        private System.Windows.Forms.Button FindButton;
    }
}