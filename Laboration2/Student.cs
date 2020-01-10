using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    public class Student : Person
    {
        public override string personnummer { get { return personnummer; } set { personnummer = value; } }
        public override string förnamn { get { return förnamn; } set { förnamn = value; } }
        public override string efternamn { get { return efternamn; } set { efternamn = value; } }
        public override string adress { get { return adress; } set { adress= value; } }
        public override string telefonnummer { get { return telefonnummer; } set { telefonnummer = value; } }
        public override string epostadress { get { return epostadress; } set { epostadress = value; } }
        public override string lösenord { get { return personnummer; } set { lösenord = value; } }

        private string studentID { get { return studentID; } set { studentID = value; } }

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


        List<Student> studentLista = new List<Student>();
        
        //FORTSÄTT DENNA METODENNENE
        public void Skapa()
        {
            studentLista.Add(new Student())
        }


        public override string HämtaPersonuppgifter(string personID)
        {
            throw new NotImplementedException();
        }
    }
}
