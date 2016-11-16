using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Manager2
{
    class ImprovedFolder
    {
        public static void CopyTo(string source, string to, string name)
        {
            int c = to.IndexOf(Path.Combine(source, name));
            if (c != -1) return;
            string WhatNeedToCopy = Path.Combine(source, name);
            string newDirectory = Path.Combine(to, name);

            DirectoryInfo dir = new DirectoryInfo(source);
            DirectoryInfo[] dirs = dir.GetDirectories();
            
            FileInfo[] files = dir.GetFiles();            
            foreach(DirectoryInfo curDr in dirs)
            {
                if (WhatNeedToCopy == curDr.FullName)
                {
                    DirectoryInfo curDir = new DirectoryInfo(WhatNeedToCopy);
                    if (Directory.Exists(newDirectory)) continue;
                    Directory.CreateDirectory(newDirectory);                    
                   
                    DirectoryInfo[] curDirs = curDir.GetDirectories();
                    FileInfo[] curFiles = curDir.GetFiles();
                    foreach (DirectoryInfo dr in curDirs)
                    {
                        CopyTo(WhatNeedToCopy, newDirectory, dr.Name);
                    }
                    foreach (FileInfo fl in curFiles)
                    {
                        CopyTo(WhatNeedToCopy, newDirectory, fl.Name);
                    }
                }
            }
            foreach(FileInfo fl in files)
            {
                if(WhatNeedToCopy == fl.FullName)
                {
                    string newFile = Path.Combine(to, fl.Name);
                    FileInfo ff = new FileInfo(newFile);
                    if (ff.Exists) continue;
                    fl.CopyTo(newFile);
                }               
            }
        }

        public static void Delete(string source)
        {
            DirectoryInfo dir = new DirectoryInfo(source);
            DirectoryInfo[] dirs = dir.GetDirectories();
            FileInfo[] files = dir.GetFiles();
            foreach(FileInfo file in files)
            {
                file.Delete();
            }
            foreach(DirectoryInfo curDir in dirs)
            {
                Delete(curDir.FullName);
            }
            dir.Delete();
        }
    
        public static void MoveTo(string source, string nameFrom, string nameTo)
        {
            DirectoryInfo fr = new DirectoryInfo(Path.Combine(source, nameFrom));
            try
            {
                fr.MoveTo(Path.Combine(source, nameTo));
            }
            catch (Exception)
            {

            }
            
            
        }
    }
}
