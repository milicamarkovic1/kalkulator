using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class kompleksni
    {
        public double realni;
        public double imaginarni;
        public kompleksni()
        {
            realni = 0;
            imaginarni = 0;
        }
        public kompleksni(double r, double i)
        {
            realni = r;
            imaginarni = i;
        }
        public string toString()
        {
            char pom;
            if (Math.Sign(imaginarni) == 1) pom = '+';
            else pom = '-';
            return Convert.ToString(realni) + pom + Convert.ToString(imaginarni) + 'i';
        }
        public static string saberi(kompleksni x, kompleksni y)
        {
            kompleksni k = new kompleksni();
            k.realni = x.realni + y.realni;
            k.imaginarni = x.imaginarni + y.imaginarni;
            return k.toString();
        }
        public static string oduzmi(kompleksni x, kompleksni y)
        {
            kompleksni k = new kompleksni();
            k.realni = x.realni - y.realni;
            k.imaginarni = x.imaginarni - y.imaginarni;
            return k.toString();
        }
        public static string pomnozi(kompleksni x, kompleksni y)
        {
            kompleksni k = new kompleksni();
            k.realni = x.realni * y.realni - x.imaginarni * y.imaginarni;
            k.imaginarni = x.realni * y.imaginarni + x.imaginarni * y.realni;
            return k.toString();
        }
        public static string podeli(kompleksni x, kompleksni y)
        {
            kompleksni k = new kompleksni();
            double a = x.realni * y.realni + x.imaginarni * y.imaginarni;
            double b = x.realni * (-y.imaginarni) + x.realni * y.realni;
            double c = x.realni * x.realni - y.imaginarni * y.imaginarni;
            k.realni = a / c;
            k.imaginarni = b / c;
            return k.toString();
        }
    }
}
