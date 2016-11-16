using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager2.HelpForms
{
    public partial class changeStringForm : Form
    {
        public string st;
        public string ne;
        public changeStringForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            st = this.textBox1.Text;
            ne = this.textBox2.Text;
            this.Close();
        }
    }
}
