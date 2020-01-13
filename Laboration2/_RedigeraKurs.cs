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
                    if (valdKurs == item)
                    {
                        Kurs.TaBortKurs(item);

                        VisaAllaKurserListBox.DataSource = null;
                        VisaAllaKurserListBox.DataSource = kursLista;

                        VisaAllaKurserListBox.DisplayMember = "Kursnamn";
                        VisaAllaKurserListBox.DisplayMember = "KursID";

                        break;
                    }
                
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void _RedigeraKurs_Load(object sender, EventArgs e)
        {
            var kursLista = Kurs.HämtaKursLista();


            VisaAllaKurserListBox.DataSource = kursLista;


            VisaAllaKurserListBox.DisplayMember = "Kursnamn";
            VisaAllaKurserListBox.ValueMember = "KursID";

        }

        private void VisaAllaKurserListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void StartdatumVäljare_ValueChanged(object sender, EventArgs e)
        {

        }

        private void KursNamnTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudenterListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LärarlagText_Click(object sender, EventArgs e)
        {

        }

        private void LärareListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SparaÄndringar_Click(object sender, EventArgs e)
        {

        }
    }
}
