using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    public class Student : Person
    {
        public new string personnummer { get; private set; }
        public new string förnamn { get; private set; }
        public new string efternamn { get; private set; }
        public new string adress { get; private set; }
        public new string telefonnummer { get; private set; }
        public new string epostadress { get; private set; }
        public new string lösenord { get; private set; }

        public string studentID { get; set; }

        public string Personnummer
        {
            get { return personnummer; }
        }

        public string Förnamn
        {
            get { return förnamn; }
        }

        public string Efternamn
        {
            get { return efternamn; }
        }


        public string Adress
        {
            get { return adress; }
        }

        public string Telefonnumer
        {
            get { return telefonnummer; }
        }

        public string Epostadress
        {
            get { return epostadress; }
        }

        public string Lösenord
        {
            get { return lösenord; }
        }




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
