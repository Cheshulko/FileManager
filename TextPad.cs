using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Manager2.SavingFiles;
using Manager2.Controllers;

namespace Manager2
{
    public partial class TextPad : Form
    {
        TextPadController textPadController;
        public TextPad(String filePath)
        {            
            if (Properties.Settings.Default.Language == "en-US")
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
            }
            InitializeComponent();
            textPadController = new TextPadController(
                this.openFileDialog1,
                this.saveFileDialog1, 
                this.richTextBox1);
            textPadController.openFile(filePath);
        }

        private void TextPad_FormClosed(object sender, FormClosedEventArgs e)
        {
            richTextBox1.Clear();            
        }

        private void копіюватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void вирізатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void вставитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textPadController.saveFile();            
        }

        private void замінитиПослідовністьЛітерToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textPadController.changeStrings();
        }

        private void новийФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textPadController.newFile();
        }

        private void знайтиСхожіСловаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textPadController.findSimilarWords();
        }

    }
}
