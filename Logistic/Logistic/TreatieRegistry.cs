﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logistic
{
    public partial class TreatieRegistry : Form
    {
        public TreatieRegistry()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Form TreatieEdit = new TreatieEdit();
            TreatieEdit.Show();
        }
    }
}
