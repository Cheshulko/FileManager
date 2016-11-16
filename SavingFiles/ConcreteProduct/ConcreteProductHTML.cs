using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager2.SavingFiles.ConcreteProduct
{
    class ConcreteProductHTML : Product
    {
        public ConcreteProductHTML(string path, string tx)
            : base(path, tx)
        {
            var Writer = new StreamWriter(path + ".html", false, Encoding.GetEncoding(1251));
            Writer.WriteLine(tx);
            Writer.Close();
        }
    }
}
