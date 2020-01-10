using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    abstract class Person : IPerson
    {
        public string personnummer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string personID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string förnamn { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string efternamn { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string adress { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string telefonnummer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string epostadress { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string lösenord { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string HämtaPersonuppgifter(string personID)
        {
            throw new NotImplementedException();
        }
    }
}
