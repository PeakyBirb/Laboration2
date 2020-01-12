using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboration2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new _Välkommen());

            
            //List<Student> studentLista = new List<Student>();
            //Student Student = new Student("199001011111", "Lisa", "Svensson", "Rönngatan 4", "0721489696", "lisasvensson@gmail.com", "hbvjucyghu68", "s168820");

            //studentLista = a;
        }

        
    }
}
