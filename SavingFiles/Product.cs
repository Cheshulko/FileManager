using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager2.SavingFiles
{
    public abstract class Product
    {
        protected string path;
        protected string tx;
        public Product(string path, string tx)
        {
            this.path = path;
            this.tx = tx;
        }
    }
}
