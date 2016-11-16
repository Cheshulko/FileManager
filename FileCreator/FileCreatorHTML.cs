﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Manager2
{
    class FileCreatorHTML : IFileCreator
    {
        public void create(string path)
        {
            int i = 0;
            string name = "NewFile" + i.ToString() + ".html";
            string s = Path.Combine(path, name);
            while (File.Exists(s))
            {
                ++i;
                name = "NewFile" + i.ToString() + ".html";
                s = Path.Combine(path, name);
            }
            File.Create(s);
        }
    }
}
