using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    public class Lärare : Person
    {
        public override string personnummer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string förnamn { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string efternamn { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string adress { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string telefonnummer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string epostadress { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string lösenord { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual string HämtaPersonuppgifter(string personID)
        {
            throw new NotImplementedException();
        }

        
        private string lärarID { get; set; }


    }
}
