using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn.Tables
{
    public class Adres
    {
        public int idAd { set; get; }
        public string street { set; get; }
        public string number { set; get; }
        public string city { set; get; }
        public string pcode { set; get; }
    }
}