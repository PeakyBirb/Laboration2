using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    public interface IKurs
    {
        DateTime StartDatum { get; set; }
        DateTime SlutDatum { get; set; }
        string[] möjligaBetyg{ get; set; }
        string kursID { get; set; }
        string lärarlagID { get; set; }
        string slutbetyg { get; set; }
        string[] deltagandeStudenter { get; set; }

       


    }
}
