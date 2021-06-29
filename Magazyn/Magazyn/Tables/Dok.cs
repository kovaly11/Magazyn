using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn.Tables
{
    class Dok
    {
        public int idDok { set; get; }
        public Prac prac { set; get; }
        public Company company { set; get; }
        public string tdok{ set; get; }
        public DateTime data { set; get; }
    }
}
