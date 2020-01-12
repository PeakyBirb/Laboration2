using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    class Kurs : IKurs
    {
        public DateTime StartDatum { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime SlutDatum { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string[] möjligaBetyg { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string kursID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string lärarlagID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string slutbetyg { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string[] deltagandeStudenter { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Kurs()
        {
            this.StartDatum = StartDatum;

        }


        static List<Kurs> kursLista { get; set; } = new List<Kurs>();

        public static void LäggTillNyKurs()
        {

        }







    }

}
