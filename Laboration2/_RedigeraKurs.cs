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
    public partial class _RedigeraKurs : Form
    {
        public _RedigeraKurs()
        {
            InitializeComponent();
            //KURS
            ListBox VisaAllaKurserListBox = new ListBox();
            VisaAllaKurserListBox.Items.Clear();

            VisaAllaKurserListBox.DisplayMember = "kursnamn";
            VisaAllaKurserListBox.ValueMember = "kursID";

        }

        private void TaBortKnapp(object sender, EventArgs e)
        {
            var valdKurs = VisaAllaKurserListBox.SelectedItem;

            var kursLista = Kurs.HämtaKursLista();

            foreach (var item in kursLista)
            {
                    if (valdKurs.ToString().ToUpper().Contains(item.kursnamn.ToString().ToUpper()))
                    {
                        Kurs.TaBortKurs(item);
                    }
                
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void _RedigeraKurs_Load(object sender, EventArgs e)
        {
            var kursLista = Kurs.HämtaKursLista();

            foreach (var item in kursLista)
            {
                VisaAllaKurserListBox.Items.Add(String.Format("{0} {1}", item.kursID.ToUpper(), item.kursnamn.ToUpperInvariant()));
            }

            VisaAllaKurserListBox.Sorted = true;
            VisaAllaKurserListBox.TopIndex = 0;
        }

        private void VisaAllaKurserListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
