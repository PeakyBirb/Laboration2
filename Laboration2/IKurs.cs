using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    public interface IKurs
    {
        DateTime startDatum { get; set; }
        DateTime slutDatum { get; set; }
        string betyg{ get; set; }
        string kursID { get; set; }
        string kursnamn { get; set; }
        string lärarlagID { get; set; }

       


    }
}
