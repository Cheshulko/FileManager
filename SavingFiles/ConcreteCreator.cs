using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manager2.SavingFiles.ConcreteProduct;

namespace Manager2.SavingFiles
{
    class ConcreteCreator : Creator
    {
        public ConcreteCreator(string path, int t, string tx) 
            : base(path, t, tx)
        {

        }
        public override Product FactoryMethod(int t, string path, string tx)
        {
            switch(t)
            {
                case 1: return new ConcreteProductTXT(path, tx);
                case 2: return new ConcreteProductHTML(path, tx);
                default: throw new ArgumentException();
            }
        }
    }
}
