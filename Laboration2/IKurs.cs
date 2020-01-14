using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    public interface IKurs
    {
        DateTime startDatum { get; }
        DateTime slutDatum { get; }
        string betyg{ get; }
        string kursID { get; }
        string kursnamn { get; }
        string lärarlagID { get; }

       


    }
}
