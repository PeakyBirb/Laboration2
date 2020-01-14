using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    public class Student : Person
    {
        public string personnummer { get; private set; }
        public override string förnamn { get; set; }
        public override string efternamn { get; set; }
        public override string adress { get; set; }
        public override string telefonnummer { get; set; }
        public override string epostadress { get; set; }
        public override string lösenord { get; set; }

        public string studentID { get; set; }

        



        //Detta är konstruktor
        public Student(string personnummer, string förnamn, string efternamn, string adress, string telefonnummer, string epostadress, string lösenord, string studentID)
        {
            this.personnummer = personnummer;
            this.förnamn = förnamn;
            this.efternamn = efternamn;
            this.adress = adress;
            this.telefonnummer = telefonnummer;
            this.epostadress = epostadress;
            this.lösenord = lösenord;
            this.studentID = studentID;
        }


        public static List<Student> studentLista { get; set; } = new List<Student>();

        public static List<Student> StudentLista()
        {
            return studentLista;
        }


        public override string HämtaPersonuppgifter(string personID)
        {
            throw new NotImplementedException();
        }
    }
}
