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
    public partial class RenameForm : Form
    {
        public string name;
        public RenameForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.name = textBox1.Text;
            this.Close();
        }
    }
}
