using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    interface IPerson
    {
        string personnummer { get; set; }
        string personID { get; set; }
        string förnamn { get; set; }
        string efternamn { get; set; }
        string adress { get; set; }
        string telefonnummer { get; set; }
        string epostadress { get; set; }
        string lösenord { get; set; }

        static string HämtaPersonuppgifter(personID)
        {
            throw new NotImplementedException();
        }

        public int MyProperty { get; set; }
    }
}
