using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public static kompleksni saberi(kompleksni x, kompleksni y)
        {
            kompleksni k = new kompleksni();
            k.realni = x.realni + y.realni;
            k.imaginarni = x.imaginarni + y.imaginarni;
            return k;
        }
        public static kompleksni oduzmi(kompleksni x, kompleksni y)
        {
            kompleksni k = new kompleksni();
            k.realni = x.realni - y.realni;
            k.imaginarni = x.imaginarni - y.imaginarni;
            return k;
        }
        public static kompleksni pomnozi(kompleksni x, kompleksni y)
        {
            kompleksni k = new kompleksni();
            k.realni = x.realni * y.realni - x.imaginarni * y.imaginarni;
            k.imaginarni = x.realni * y.imaginarni + x.imaginarni * y.realni;
            return k;
        }
        public static kompleksni podeli(kompleksni x, kompleksni y)
        {
            kompleksni k = new kompleksni();
            double a = x.realni * y.realni + x.imaginarni * y.imaginarni;
            double b = x.imaginarni * y.realni - x.realni * y.imaginarni;
            double c = y.realni * y.realni + y.imaginarni * y.imaginarni;
            /*if (a == 0 || b == 0 || c == 0)
            {
                string p = "Ne moze se deliti nulom! Unesite druge brojeve.";
                string naslov = "Greska u unosu";
                MessageBoxButtons dugme = MessageBoxButtons.OK;
                DialogResult rez;
                rez = MessageBox.Show(p, naslov, dugme);
                return "0";
            }
            else
            */
            {
                k.realni = a / c;
                k.imaginarni = b / c;
            }
            return k;
        }
    }
}
