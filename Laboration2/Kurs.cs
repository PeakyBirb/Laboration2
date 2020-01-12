using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    class Kurs : IKurs
    {
        public DateTime StartDatum { get; set; }
        public DateTime SlutDatum { get; set; }
        public string möjligaBetyg { get; set; }
        public string kursID { get; set; }
        public string kursnamn { get; set; }
        public string lärarlagID { get; set; }
        public string slutbetyg { get; set; }


        private List<Lärare> Lärare = new List<Lärare>();

        public List<Lärare> HämtaLärare()
        {
            return Lärare;
        }

        private List<Student> Studenter = new List<Student>();

        public List<Student> HämtaStudent()
        {
            return Studenter;
        }

        public Kurs(DateTime StartDatum, DateTime SlutDatum)
        {
            this.StartDatum = StartDatum;

        }

        public Kurs(DateTime startdatum, DateTime slutdatum, string möjligabetyg, string kursID, string kursnamn, string lärarlagID, string slutBetyg, List<Lärare> lärare, List<Student> studenter)
        {
            this.StartDatum = startdatum;
            this.SlutDatum = slutdatum;
            this.möjligaBetyg = möjligabetyg;
            this.kursID = kursID;
            this.kursnamn = kursnamn;
            this.lärarlagID = lärarlagID;
            this.slutbetyg = slutBetyg;
            this.Lärare = lärare;
            this.Studenter = studenter;

        }

        static List<Kurs> kursLista { get; set; } = new List<Kurs>();
        

        public static void LäggTillNyKurs()
        {




        }







    }

}
