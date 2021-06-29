using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn.Tables
{
    class Tow
    {
        public int idTow { set; get; }
        public string name { set; get; }
        public string nrSer { set; get; }
        public string dim { set; get; }
        public Prod prod { set; get; }
    }
}
