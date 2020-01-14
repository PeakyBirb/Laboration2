using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    public abstract class Person : IPerson
    {
        public virtual string personnummer { get; private set; }
        public virtual string förnamn { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public virtual string efternamn { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public virtual string adress { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public virtual string telefonnummer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public virtual string epostadress { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public virtual string lösenord { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        public string Personnummer
        {
            get { return personnummer; }
        }






        public virtual string HämtaPersonuppgifter(string personID)
        {
            throw new NotImplementedException();
        }
    }
}
