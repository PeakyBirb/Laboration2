using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    public abstract class Person : IPerson
    {
        public virtual string personnummer { get; }
        public virtual string förnamn { get; }
        public virtual string efternamn { get; }
        public virtual string adress { get; }
        public virtual string telefonnummer { get; }
        public virtual string epostadress { get; }
        public virtual string lösenord { get; }


        





        public virtual string HämtaPersonuppgifter(string personID)
        {
            throw new NotImplementedException();
        }
    }
}
