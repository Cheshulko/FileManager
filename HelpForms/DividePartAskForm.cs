using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager2
{
    public partial class DividePartAskForm : Form
    {
        private int cnt; 
        public DividePartAskForm()
        {
            InitializeComponent();
            cnt = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnt = (int)this.numericUpDown1.Value;
            this.Close();
        }
        public int GetCnt()
        {
            return this.cnt;
        }
    }
}
