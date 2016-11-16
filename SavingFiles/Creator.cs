using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager2.SavingFiles
{
    public abstract class Creator
    {
        protected string path;
        protected int t;
        protected string tx;
        public Creator(string path, int t, string tx)
        {
            this.path = path;
            this.t = t;
            this.tx = tx;
        }
        public abstract Product FactoryMethod(int t, string path, string tx);

        public void Create()
        {
            Product pr = FactoryMethod(t, path, tx);
        }
    }
}
