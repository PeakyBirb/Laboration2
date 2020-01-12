using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboration2
{
    public partial class _SkapaKurs : Form
    {

        public _SkapaKurs()
        {
            
            InitializeComponent();
            //STUDENT
            ListBox StudenterlistBox = new ListBox();
            StudenterListBox.Items.Clear();

            StudenterListBox.DisplayMember = "förnamn";
            StudenterListBox.ValueMember = "studentID";

            //LÄRARE
            ListBox LärareListBox = new ListBox();
            LärareListBox.Items.Clear();

            LärareListBox.DisplayMember = "förnamn";
            LärareListBox.ValueMember = "lärarID";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void _SkapaKurs_Load(object sender, EventArgs e)
        {   
            //STUDENTLISTA
            var studentLista = Student.StudentLista();

            foreach (var item in studentLista)
            {
                StudenterListBox.Items.Add(String.Format("{0} {1} {2}", item.studentID.ToUpper(), item.förnamn.ToUpperInvariant(), item.efternamn.ToUpperInvariant()));
            }

            StudenterListBox.Sorted = true;
            StudenterListBox.TopIndex = 0;

            //LÄRARLISTA
            var lärarLista = Lärare.LärareLista();

            foreach (var item in lärarLista)
            {
                LärareListBox.Items.Add(String.Format("{0} {1} {2}", item.LärarID.ToUpper(), item.förnamn.ToUpperInvariant(), item.efternamn.ToUpperInvariant()));
            }

            LärareListBox.Sorted = true;
            LärareListBox.TopIndex = 0;



        }

        private void StudenterListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void LärareListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void KursnamnTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void KlarKnapp_Click(object sender, EventArgs e)
        {
            string kursnamn = KursnamnTextBox.Text;
            DateTime startDatum = StartdatumVäljare.Value;
            DateTime slutDatum = SlutdatumVäljare.Value;
            string betyg = "-";
            string kursID = KursIDTextBox.Text;
            string lärarlagID = LärarlagIDTextBox.Text;
            var lärarlag = LärareListBox.SelectedItems;
            var studentlag = StudenterListBox.SelectedItems;

            //LÄRARMATCHNING
            var lärareLista = Lärare.LärareLista();
            List<Lärare> Lärarlag = new List<Lärare>();

            foreach (var item in lärareLista)
            {
                foreach (var item2 in lärarlag)
                {
                    if (item2.ToString().ToUpper().Contains(item.LärarID.ToString().ToUpper()))
                    {
                        Lärarlag.Add(item);
                    }
                }
            }

            //STUDENTMATCHNING
            var studentLista = Student.StudentLista();
            List<Student> Studentlag = new List<Student>();

            foreach (var item in studentLista)
            {
                foreach (var item2 in studentlag)
                {
                    if (item2.ToString().ToUpper().Contains(item.studentID.ToString().ToUpper()))
                    {
                        Studentlag.Add(item);
                    }

                }
            }

            Kurs nyKurs = new Kurs(startDatum, slutDatum, betyg, kursID, kursnamn, lärarlagID, Lärarlag, Studentlag);

            this.Close();

            
        }

        private void KursIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
