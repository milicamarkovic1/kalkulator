using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class jakodugacki
    {
        public decimal broj;
        public jakodugacki()
        {
            broj = 0;
        }
        public jakodugacki(decimal br)
        {
            broj = br;
        }
        public string toString()
        {
            return Convert.ToString(broj);
        }
        public static string saberi(jakodugacki x, jakodugacki y)
        {
            jakodugacki n = new jakodugacki();
            n.broj = x.broj + y.broj;
            return n.toString();
        }
    }
}
