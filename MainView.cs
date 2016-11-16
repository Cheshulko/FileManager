using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Manager2
{
    class MainView : System.Windows.Forms.ListView
    {
        enum IMAGES_TYPE : int { FOLDER = 0, DRIVER, TEXT, PICTURE, EXE, OTHER, HTML, ZIP };
        private string currentAdress;
        private string buffer;
        private string name;
        private System.Windows.Forms.ImageList images;

        private bool isTXTorHTML(string text)
        {
            if (text.EndsWith(".txt")  || text.EndsWith(".TXT") ||
                text.EndsWith(".html") || text.EndsWith(".HTML"))
                 return true;
            else return false;
        } 
        public string CurrentAdress
        {
            get
            {
                return currentAdress;
            }
            set
            {
                currentAdress = value;
            }
        }
        public string Buffer
        {
            get
            {
                return buffer;
            }
            set
            {
                buffer = value;
            }
        }
        public System.Windows.Forms.ImageList Images
        {
            get
            {
                return images;
            }
            set
            {
                images = value;
            }
        }
        public MainView(string adress, System.Windows.Forms.ImageList im)
        {
            currentAdress = adress;
            images = im;
            name = buffer = "";
        }
        public void setImages(System.Windows.Forms.ImageList im)
        {
            this.images = im;
        }
        public void buildLogicalDrives()
        {
            currentAdress = "";
            this.Clear();
            string[] drivers = Directory.GetLogicalDrives();
            this.LargeImageList = images;
            foreach (string driver in drivers)
            {
                this.Items.Add(driver, (int)IMAGES_TYPE.DRIVER);
            }
        }
        private String getName(String name)
        {
            string[] newNames;
            newNames = name.Split('\\');
            return newNames[newNames.Length - 1];
        }
        private void selectIcons(string[] files)
        {
            foreach (string file in files)
            {
                if (file.EndsWith(".txt") || file.EndsWith(".TXT"))
                    this.Items.Add(getName(file), (int)IMAGES_TYPE.TEXT);
                else if (file.EndsWith(".jpg") || file.EndsWith(".JPG") ||
                         file.EndsWith(".png") || file.EndsWith(".PNG") ||
                         file.EndsWith(".bmp") || file.EndsWith(".BMP"))
                    this.Items.Add(getName(file), (int)IMAGES_TYPE.PICTURE);
                else if (file.EndsWith(".exe") || file.EndsWith(".EXE"))
                    this.Items.Add(getName(file), (int)IMAGES_TYPE.EXE);
                else if (file.EndsWith(".html") || file.EndsWith(".HTML"))
                    this.Items.Add(getName(file), (int)IMAGES_TYPE.HTML);
                else if (file.EndsWith(".zip") || file.EndsWith(".ZIP"))
                    this.Items.Add(getName(file), (int)IMAGES_TYPE.ZIP);
                else
                    this.Items.Add(getName(file), (int)IMAGES_TYPE.OTHER);
            }
        }
        public void buildDirectories(String text)
        {
            try
            {
                string[] directories = Directory.GetDirectories(text);
                string[] files = Directory.GetFiles(text);
                this.Clear();
                foreach (string directory in directories)
                {
                    this.Items.Add(getName(directory), (int)IMAGES_TYPE.FOLDER);
                }
                selectIcons(files);
                currentAdress = text;
            }
            catch (Exception)
            {
                if (isTXTorHTML(text))
                {
                    TextPad textpad = new TextPad(text);
                    textpad.ShowDialog();
                    this.buildDirectories(this.currentAdress);
                }
            }
        }
        public bool rebuildCureentAdressForBack()  
        {
            for (int i = currentAdress.Length - 3; i >= 0; --i)
            {
                if (currentAdress[i] == '\\')
                {
                    currentAdress = currentAdress.Substring(0, i + 1);
                    return true;
                }
            }
            return false;
        }        
        public void copyToBuffer()
        {
            if (this.CurrentAdress == "") return;
            DirectoryInfo directoryInfo = new DirectoryInfo(this.CurrentAdress);
            DirectoryInfo[] directories = directoryInfo.GetDirectories();
            FileInfo[] files = directoryInfo.GetFiles();
            foreach (DirectoryInfo folder in directories)
            {
                if (folder.Exists && folder.Name == this.SelectedItems[0].Text)
                {
                    this.Buffer = this.CurrentAdress;
                    name = this.SelectedItems[0].Text;
                    return;
                }
            }
            foreach (FileInfo file in files)
            {
                if (file.Exists && file.Name == this.SelectedItems[0].Text)
                {
                    this.Buffer = this.CurrentAdress;
                    name = this.SelectedItems[0].Text;
                    return;                    
                }
            }
        }    
        public void pasteFromBuffer()
        {
            if (this.name == "" || this.CurrentAdress == "") return;
            string target;
            if (this.SelectedItems.Count == 0) target = Path.Combine(this.CurrentAdress);
            else target = Path.Combine(this.CurrentAdress, Path.GetFileName(this.SelectedItems[0].Text));
            ImprovedFolder.CopyTo(this.Buffer, target, name);
            this.buildDirectories(this.CurrentAdress);
        }
        public void prevPage()
        {
            if (this.rebuildCureentAdressForBack() == true)
                this.buildDirectories(this.CurrentAdress);
            else
                this.buildLogicalDrives();

            this.FocusedItem = null;            
        }
        public void nextPage()
        {
            try
            {
                string text = this.FocusedItem.Text;
                string adress = Path.Combine(this.CurrentAdress, text);
                this.buildDirectories(adress);
            }
            catch (Exception) { }
        }
        public void delete()
        {
            if (this.CurrentAdress == "") return;
            DirectoryInfo directoryInfo = new DirectoryInfo(this.CurrentAdress); 
            DirectoryInfo[] directories = directoryInfo.GetDirectories();
            FileInfo[] files = directoryInfo.GetFiles();

            foreach (DirectoryInfo folder in directories)
            {
                if (folder.Exists && folder.Name == this.SelectedItems[0].Text)
                {
                    ImprovedFolder.Delete(folder.FullName);
                }
            }
            foreach (FileInfo file in files)
            {
                if (this.SelectedItems.Count > 0 && file.Exists && file.Name == this.SelectedItems[0].Text)
                {
                    file.Delete();
                }
            }  
            this.buildDirectories(this.CurrentAdress);
        }
        public void create(IFileCreator creator)
        {
            creator.create(this.currentAdress);
            this.buildDirectories(this.CurrentAdress);
        }
        public void reName() // NO
        {

        }
        public void divideFile(int cnt)
        {
            string text = this.FocusedItem.Text;
            if(isTXTorHTML(text))
            {
                string path = Path.Combine(currentAdress, text);
                var reader = new StreamReader(path, Encoding.GetEncoding(1251));
                string txt = reader.ReadToEnd();
                reader.Close();
                int part = txt.Length / cnt;

                string folferName = Path.Combine(currentAdress, (text.Split('.')[0] + "_folder"));
                Directory.CreateDirectory(folferName);
                for(int i = 0; i < cnt - 1; ++i)
                {
                    string newFileName = Path.Combine(folferName, (text.Split('.')[0] + (cnt - 1 - i).ToString() + ".txt"));
                    var Writer = new StreamWriter(newFileName, false, Encoding.GetEncoding(1251));
                    string toWrite = txt.Substring(txt.Length - part, part);
                    if(part != 0) txt = txt.Remove(txt.Length - part); 
                    Writer.Write(toWrite);
                    Writer.Close();
                    
                }
                string fileName = Path.Combine(folferName, (text.Split('.')[0] + "0.txt"));
                var writer = new StreamWriter(fileName, false, Encoding.GetEncoding(1251));
                writer.Write(txt);
                writer.Close();     
           }
            this.buildDirectories(this.currentAdress);

        }
        
    }
}
