using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltYaziBulucu.Models
{
    public class DowloandResult
    {

        public string link { get; set; }
        public string fname { get; set; }
        public int requests { get; set; }
        public int allowed { get; set; }
        public int remaining { get; set; }
        public string message { get; set; }

    }
}
