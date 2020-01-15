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
        public string GetPersonnummer()
        {
            return personnummer;
        }

        private string förnamn;
        public string GetFörnamn()
        {
            return förnamn;
        }

        private string efternamn;
        public string GetEfternamn()
        {
            return efternamn;
        }

        private string adress;
        public string GetAdress()
        {
            return adress;
        }

        private string telefonnummer;
        public string GetTelefonnummer()
        {
            return telefonnummer;
        }

        private string epostadress;
        public string GetEpostadress()
        {
            return epostadress;
        }

        private string lösenord;
        public string GetLösenord()
        {
            return lösenord;
        }


        public virtual string HämtaPersonuppgifter(string personID)
        {
            throw new NotImplementedException();
        }


    }
}
