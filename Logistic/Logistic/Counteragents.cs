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
    public partial class Counteragents : Form
    {
        public Counteragents()
        {
            InitializeComponent();
        }

        private void AddCounteragentButton_Click(object sender, EventArgs e)
        {
            Form AddCounteragent = new AddCounteragent();
            AddCounteragent.Show();
        }

        private void EditCounteragentButton_Click(object sender, EventArgs e)
        {
            Form EditCounteragent = new EditCounteragent();
            EditCounteragent.Show();
        }
    }
}
