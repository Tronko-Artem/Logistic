
namespace Logistic
{
    partial class Treaties
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
            this.CreateTreatieButton = new System.Windows.Forms.Button();
            this.TreatieRegistryButton = new System.Windows.Forms.Button();
            this.SpecificationRegistryButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AddSpecificationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateTreatieButton
            // 
            this.CreateTreatieButton.Location = new System.Drawing.Point(-10, 118);
            this.CreateTreatieButton.Name = "CreateTreatieButton";
            this.CreateTreatieButton.Size = new System.Drawing.Size(500, 100);
            this.CreateTreatieButton.TabIndex = 0;
            this.CreateTreatieButton.Text = "Создать договор";
            this.CreateTreatieButton.UseVisualStyleBackColor = true;
            this.CreateTreatieButton.Click += new System.EventHandler(this.CreateTreatieButton_Click);
            // 
            // TreatieRegistryButton
            // 
            this.TreatieRegistryButton.Location = new System.Drawing.Point(-10, 224);
            this.TreatieRegistryButton.Name = "TreatieRegistryButton";
            this.TreatieRegistryButton.Size = new System.Drawing.Size(500, 100);
            this.TreatieRegistryButton.TabIndex = 2;
            this.TreatieRegistryButton.Text = "Реестр договоров";
            this.TreatieRegistryButton.UseVisualStyleBackColor = true;
            this.TreatieRegistryButton.Click += new System.EventHandler(this.TreatieRegistryButton_Click);
            // 
            // SpecificationRegistryButton
            // 
            this.SpecificationRegistryButton.Location = new System.Drawing.Point(-10, 330);
            this.SpecificationRegistryButton.Name = "SpecificationRegistryButton";
            this.SpecificationRegistryButton.Size = new System.Drawing.Size(247, 100);
            this.SpecificationRegistryButton.TabIndex = 3;
            this.SpecificationRegistryButton.Text = "Реестр спецификаций";
            this.SpecificationRegistryButton.UseVisualStyleBackColor = true;
            this.SpecificationRegistryButton.Click += new System.EventHandler(this.SpecificationRegistryButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(-10, 436);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(500, 100);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(65, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "Работа с договорами";
            // 
            // AddSpecificationButton
            // 
            this.AddSpecificationButton.Location = new System.Drawing.Point(243, 330);
            this.AddSpecificationButton.Name = "AddSpecificationButton";
            this.AddSpecificationButton.Size = new System.Drawing.Size(247, 100);
            this.AddSpecificationButton.TabIndex = 7;
            this.AddSpecificationButton.Text = "Добавить спецификацию";
            this.AddSpecificationButton.UseVisualStyleBackColor = true;
            this.AddSpecificationButton.Click += new System.EventHandler(this.AddSpecificationButton_Click);
            // 
            // Treaties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 529);
            this.Controls.Add(this.AddSpecificationButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SpecificationRegistryButton);
            this.Controls.Add(this.TreatieRegistryButton);
            this.Controls.Add(this.CreateTreatieButton);
            this.Name = "Treaties";
            this.Text = "Договоры";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateTreatieButton;
        private System.Windows.Forms.Button TreatieRegistryButton;
        private System.Windows.Forms.Button SpecificationRegistryButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddSpecificationButton;
    }
}