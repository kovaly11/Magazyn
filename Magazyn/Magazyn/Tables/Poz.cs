using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn.Tables
{
    class Poz
    {
        public int idDok { set; get; }
        public int nrPoz { set; get; }
        public Tow tow { set; get; }
        public int qty { set; get; }
    }
}
