using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn.Tables
{
    class Company
    {
        public int idCom { set; get; }
        public string name { set; get; }
        public string person { set; get; }
        public string nip { set; get; }
        public Adres adres { set; get; }
    }
}
