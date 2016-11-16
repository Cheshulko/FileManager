using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Manager2
{
    class FolderCreator : IFileCreator
    {
        public void create(string path)
        {
            int i = 0;
            string name = "NewFolder" + i.ToString();
            string s = Path.Combine(path, name);
            while (Directory.Exists(s))
            {
                ++i;
                name = "NewFolder" + i.ToString();
                s = Path.Combine(path, name);
            }
            Directory.CreateDirectory(s);
        }
    }
}
