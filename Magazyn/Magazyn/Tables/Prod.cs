using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn.Tables
{
    class Prod
    {
        public int idProd { set; get; }
        public string name { set; get; }
        public string person { set; get; }
        public string tel { set; get; }
        public Adres adres { set; get; }
    }
}
