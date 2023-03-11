using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public int br1;
        public int br2;
        public int res;
        public int brojac;
        public int ibr;
        public int vbr;
        public int xbr;
        public int lbr;
        public int dbr;
        public int cbr;
        public int mbr;
        public char i;
        public char v;
        public char x;
        public char l;
        public char c;
        public char d;
        public char m;

        private void button19_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text.ToUpper();
            string y = textBox2.Text.ToUpper();
            br1 = rti(x);
            br2 = rti(y);
            res = br1 + br2;
            if (res > 3999)
            {
                string p = "Rezultat je veci od 3999! Unesite druge brojeve.";
                string naslov = "Greska u unosu";
                MessageBoxButtons dugme = MessageBoxButtons.OK;
                DialogResult rez;
                rez = MessageBox.Show(p, naslov, dugme);
                if (rez == System.Windows.Forms.DialogResult.OK)
                {
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                }
            }
            else
            {
                string r = itr(Convert.ToInt32(res));
                textBox3.Text = r;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text.ToUpper();
            string y = textBox2.Text.ToUpper();
            br1 = rti(x);
            br2 = rti(y);
            res = br1 - br2;
            if (res < 0)
            {
                string p = "Rezultat je manji od 0! Unesite druge brojeve.";
                string naslov = "Greska u unosu";
                MessageBoxButtons dugme = MessageBoxButtons.OK;
                DialogResult rez;
                rez = MessageBox.Show(p, naslov, dugme);
                if (rez == System.Windows.Forms.DialogResult.OK)
                {
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                }
            }
            else
            {
                string r = itr(Convert.ToInt32(res));
                textBox3.Text = r;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text.ToUpper();
            string y = textBox2.Text.ToUpper();
            br1 = rti(x);
            br2 = rti(y);
            res = br1 * br2;
            if (res > 3999)
            {
                string p = "Rezultat je veci od 3999! Unesite druge brojeve.";
                string naslov = "Greska u unosu";
                MessageBoxButtons dugme = MessageBoxButtons.OK;
                DialogResult rez;
                rez = MessageBox.Show(p, naslov, dugme);
                if (rez == System.Windows.Forms.DialogResult.OK)
                {
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                }
            }
            else
            {
                string r = itr(Convert.ToInt32(res));
                textBox3.Text = r;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string x = textBox1.Text.ToUpper();
                string y = textBox2.Text.ToUpper();
                br1 = rti(x);
                br2 = rti(y);
                res = br1 / br2;
                if (res > 3999 || res < 0)
                {
                    string p = "Rezultat je veci od 3999! Unesite druge brojeve.";
                    string naslov = "Greska u unosu";
                    MessageBoxButtons dugme = MessageBoxButtons.OK;
                    DialogResult rez;
                    rez = MessageBox.Show(p, naslov, dugme);
                    if (rez == System.Windows.Forms.DialogResult.OK)
                    {
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                    }
                }
                else
                {
                    string r = itr(Convert.ToInt32(res));
                    textBox3.Text = r;
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            i = 'I';
            v = 'V';
            x = 'X';
            l = 'L';
            c = 'C';
            d = 'D';
            m = 'M';
            ibr = 1;
            vbr = 5;
            xbr = 10;
            lbr = 50;
            cbr = 100;
            dbr = 500;
            mbr = 1000;
        }
        public int prebaci(char t)
        {
            int n;
            if (t == i) return n = ibr;
            else if (t == v) return n = vbr;
            else if (t == x) return n = xbr;
            else if (t == l) return n = lbr;
            else if (t == c) return n = cbr;
            else if (t == d) return n = dbr;
            else if (t == m) return n = mbr;
            else return 0;
        }
        public int rti(string s)
        {
            int sum = 0;
            int num;
            int pom;
            bool pr = provera(s);
            for (int i = 0; i < s.Length; i++)
            {
                char trenutni = s[i];
                num = prebaci(trenutni);
                pom = prebaci(s[(i + 1) % s.Length]);
                if ((i + 1) < s.Length && pom > num) sum -= num;
                else sum += num;
            }
            if (sum > 3999 || pr == false)
            {
                string p = "Ovaj broj se ne moze zapisati rimskim ciframa! Pokusajte ponovo.";
                string naslov = "Greska u unosu";
                MessageBoxButtons dugme = MessageBoxButtons.OK;
                DialogResult rez;
                rez = MessageBox.Show(p, naslov, dugme);
                return 0;
            }
            return sum;
        }
        public string itr(int n)
        {
            string[] sym = { "MMM", "MM", "M", "CM", "DCCC", "DCC", "DC", "D", "CD", "CCC", "CC", "C", "XC", "LXXX", "LXX", "LX", "L", "XL", "XXX", "XX", "X", "IX", "VIII", "VII", "VI", "V", "IV", "III", "II", "I" };
            int[] br = { 3000, 2000, 1000, 900, 800, 700, 600, 500, 400, 300, 200, 100, 90, 80, 70, 60, 50, 40, 30, 20, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            var s = new StringBuilder();
            int pom = 0;
            while (n != 0)
            {
                if (n >= br[pom])
                {
                    n -= br[pom];
                    s.Append(sym[pom]);
                }
                else
                {
                    pom++;
                }
            }
            return s.ToString();
        }
        public bool provera(string s)
        {
            string str = @"^M{0,3}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})$";
            Regex re = new Regex(str);
            if (re.IsMatch(s)) return true;
            return false;
        }
    }
}
