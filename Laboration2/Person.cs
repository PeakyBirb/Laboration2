using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    public abstract class Person : IPerson
    {
        private string personnummer;

        private string förnamn;

        private string efternamn;

        private string adress;

        private string telefonnummer;

        private string epostadress;

        private string lösenord;

        public virtual string HämtaPersonuppgifter(string personID)
        {
            throw new NotImplementedException();
        }

    }
}
