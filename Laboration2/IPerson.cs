using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    public interface IPerson
    {
        string personnummer { get; }
        string förnamn { get; }
        string efternamn { get; }
        string adress { get; }
        string telefonnummer { get; }
        string epostadress { get; }
        string lösenord { get; }

        string HämtaPersonuppgifter (string personID);

    }
}
