using System;
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
    public partial class AddSpecification : Form
    {
        public AddSpecification()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            Form AddProductToSpecification = new AddProductToSpecification();
            AddProductToSpecification.Show();
        }
    }
}
