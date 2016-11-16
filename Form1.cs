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
using System.Collections.Specialized;
using System.Threading;
using System.Globalization;
using Manager2.Controllers;

namespace Manager2
{
    public partial class Form1 : Form
    {
        MainViewController mainViewController;
        public Form1()
        {
            if (Properties.Settings.Default.Language == "en-US")
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
            }    
            InitializeComponent();
            mainViewController = new MainViewController("", this.images, this.view);
                    
            mainViewController.buildLogicalDrives();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void view_DoubleClick(object sender, EventArgs e)
        {
            
            mainViewController.nextPage();
            adressView.Text = mainViewController.CurrentAdress;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            mainViewController.prevPage();
            adressView.Text = mainViewController.CurrentAdress;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e) // copy
        {
            mainViewController.copyToBuffer();
        }
        
        private void toolStripMenuItem2_Click(object sender, EventArgs e) // paste
        {
            mainViewController.pasteFromBuffer();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e) // delete
        {
            mainViewController.delete();             
        }
        
        private void копіюватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainViewController.copyToBuffer();
        }

        private void вставитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainViewController.pasteFromBuffer();
        }

        private void видалитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainViewController.delete();    
        }

        private void view_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                mainViewController.nextPage();
                adressView.Text = mainViewController.CurrentAdress;

            }
            else if ((int)e.KeyChar == (int)Keys.Back)
            {
                mainViewController.prevPage();
                adressView.Text = mainViewController.CurrentAdress;
            }
            else if((int)e.KeyChar == (int)Keys.Delete)
            {
                mainViewController.delete();
                adressView.Text = mainViewController.CurrentAdress;
            }
        }

        private void українськаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Language = "";
            Properties.Settings.Default.Save();
            Application.Restart();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Language = "en-US";
            Properties.Settings.Default.Save();
            Application.Restart();
        }

        private void txtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainViewController.create(new FileCreatorTXT());           
        }

        private void htmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainViewController.create(new FileCreatorHTML());   
        }

        private void папкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainViewController.create(new FolderCreator()); 
        }

        private void txtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mainViewController.create(new FileCreatorTXT());
        }

        private void htmlToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mainViewController.create(new FileCreatorHTML()); 
        }

        private void папкуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mainViewController.create(new FolderCreator());
        }

        private void поділитиФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DividePartAskForm div = new DividePartAskForm();
            div.ShowDialog();
            int cnt = div.GetCnt();
            mainViewController.divideFile(cnt);
        }

        private void створитиСписокФайлівЗГіпертекстовогоПосиланняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainViewController.createListFilesFromHtml();
        }

        private void перейменуватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainViewController.reName();
        }
  
    }
}
