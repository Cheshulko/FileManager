using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Manager2.SavingFiles;
using Manager2.HelpForms;

namespace Manager2.Controllers
{
    class TextPadController
    {
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;

        public TextPadController(
            System.Windows.Forms.OpenFileDialog openFileDialog1,
            System.Windows.Forms.SaveFileDialog saveFileDialog1,
            System.Windows.Forms.RichTextBox richTextBox1)
        {
            this.openFileDialog1 = openFileDialog1;
            this.saveFileDialog1 = saveFileDialog1;
            this.richTextBox1 = richTextBox1;
        }
        public void openFile(string filePath)
        {
            openFileDialog1.FileName = filePath;
            try
            {
                var reader = new StreamReader(openFileDialog1.FileName, Encoding.GetEncoding(1251));
                richTextBox1.Text = reader.ReadToEnd();
                reader.Close();
            }
            catch (Exception) { }
        }
        public void saveFile()
        {
            saveFileDialog1.Filter = "Txt file (*.txt)|*.txt|Html file (*.html)|*.html";
            saveFileDialog1.FileName = openFileDialog1.FileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Creator cr = new ConcreteCreator(saveFileDialog1.FileName.Split('.')[0],
                    saveFileDialog1.FilterIndex, richTextBox1.Text);
                cr.Create();
            }
        }
        public void changeStrings()
        {
            changeStringForm ch = new changeStringForm();
            ch.ShowDialog();
            richTextBox1.Text = richTextBox1.Text.Replace(ch.st, ch.ne);
            richTextBox1.Update();
        }
        public void newFile()
        {
            this.richTextBox1.Clear();
        }
        public void findSimilarWords()
        {
            string word;
            string[] text = richTextBox1.Text.Split(' ', '\n', '\t');
            FindSimilarWordsForm find = new FindSimilarWordsForm();
            find.ShowDialog();
            word = find.word;
            var res = new List<string>();
            while (word.Length > 0)
            {
                foreach (var st in text)
                {
                    if (st.IndexOf(word) != -1)
                    {
                        res.Add(st);
                    }
                }
                if (res.Count > 0) break;
                else word = word.Substring(0, word.Length - 1);
            }
            string ans = "";
            foreach(var st in res){
                ans = ans + st + "\n";
            }
            MessageBox.Show(ans);
        }
    }
}
