using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    class Kurs : IKurs
    {
        public DateTime startDatum { get; set; }
        public DateTime slutDatum { get; set; }
        public string betyg { get; set; }
        public string kursID { get; set; }
        public string kursnamn { get; set; }
        public string lärarlagID { get; set; }


        private List<Lärare> lärarlag = new List<Lärare>();

        public List<Lärare> HämtaLärare()
        {
            return lärarlag;
        }

        private List<Student> studentlag = new List<Student>();

        public List<Student> HämtaStudent()
        {
            return studentlag;
        }

        public Kurs(DateTime startDatum, DateTime slutDatum)
        {
            this.startDatum = startDatum;

        }

        public Kurs(DateTime startdatum, DateTime slutdatum, string betyg, string kursID, string kursnamn, string lärarlagID, List<Lärare> lärare, List<Student> studenter)
        {
            this.startDatum = startdatum;
            this.slutDatum = slutdatum;
            this.betyg = betyg;
            this.kursID = kursID;
            this.kursnamn = kursnamn;
            this.lärarlagID = lärarlagID;
            this.lärarlag = lärare;
            this.studentlag = studenter;

        }

        private static List<Kurs> kursLista { get; set; } = new List<Kurs>();
        
        public static List<Kurs> HämtaKursLista() 
        {
            return kursLista;
        }




    }

}
