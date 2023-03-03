using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public string res2;
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
                if (rez == System.Windows.Forms.DialogResult.OK) this.Close(); //stavi {} i upisi da textboxovi budu prazni
            }
            else
            {
                //int r=itr(res); textBox3.text=convert.tostring(r);
                textBox3.Text = Convert.ToString(res);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            res = br1 - br2;
            textBox3.Text = Convert.ToString(res);
            if (Convert.ToInt32(textBox3.Text) > 3999 || Convert.ToInt32(textBox3.Text) < 0)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            else
            {

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            res = br1 * br2;
            if (Convert.ToInt32(textBox3.Text) > 3999)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            else textBox3.Text = Convert.ToString(res);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            res = br1 / br2;
            if (Convert.ToInt32(textBox3.Text) > 3999)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            else textBox3.Text = Convert.ToString(res);
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
            for (int i = 0; i < s.Length; i++)
            {
                char trenutni = s[i];
                num = prebaci(trenutni);
                pom = prebaci(s[(i + 1) % s.Length]);
                if ((i + 1) < s.Length && pom > num) sum -= num;
                else sum += num;
            }
            return sum;
        }
        public string itr(int n)
        {
            string res = "";

            return res;
        }
    }
}
