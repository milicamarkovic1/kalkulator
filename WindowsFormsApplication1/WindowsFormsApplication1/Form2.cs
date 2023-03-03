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
        public int pom1 = 1;
        public int pom2 = 1;
        public int pom3 = 1;
        public int pom4 = 1;
        public int pom5 = 1;
        public int pom6 = 1;
        public int pom7 = 1;
        public int pom8 = 1;
        public int pom9 = 1;
        public int pom10 = 1;
        public int pom11 = 1;
        public int pom12 = 1;
        public int pom13 = 1;
        public int pom14 = 1;
        public string pom;
        public string pompom;
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


        private void button1_Click(object sender, EventArgs e)
        {
            if (button18.Enabled == true)
            {
                if (pom2 <= 3) textBox2.Text = textBox2.Text + i;
                pom2++;
            }
            else
            {
                if (pom1 <= 3) textBox1.Text = textBox1.Text + i;
                pom1++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button18.Enabled == true)
            {
                if (pom4 == 1) textBox2.Text = textBox2.Text + v;
                pom4++;
            }
            else
            {
                if (pom3 == 1) textBox1.Text = textBox1.Text + v;
                pom3++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button18.Enabled == true)
            {
                if (pom6 <= 3) textBox2.Text = textBox2.Text + x;
                pom6++;
            }
            else
            {
                if (pom5 <= 3) textBox1.Text = textBox1.Text + x;
                pom5++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button18.Enabled == true)
            {
                if (pom8 == 1) textBox2.Text = textBox2.Text + l;
                pom8++;
            }
            else
            {
                if (pom7 == 1) textBox1.Text = textBox1.Text + l;
                pom7++;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button18.Enabled == true)
            {
                if (pom10 <= 3) textBox2.Text = textBox2.Text + c;
                pom10++;
            }
            else
            {
                if (pom9 <= 3) textBox1.Text = textBox1.Text + c;
                pom9++;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button18.Enabled == true)
            {
                if (pom12 == 1)  textBox2.Text = textBox2.Text + d;
                pom12++;
            }
            else
            {
                if (pom11 == 1) textBox1.Text = textBox1.Text + d;
                pom11++;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button18.Enabled == true)
            {
                if (pom14 <= 3) textBox2.Text = textBox2.Text + m;
                pom14++;
            }
            else
            {
                if (pom13 <= 3) textBox1.Text = textBox1.Text + m;
                pom13++;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button18.Enabled = true;
            //br1 = rti(textBox1.Text);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button15.Enabled = false;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            //br2 = rti(textBox2.Text);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button18.Enabled == true)
            {
                if (textBox2.Text != "")
                {
                    textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1, 1);
                }
            }
            else if (textBox1.Text != "") textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button18.Enabled = false;
            button15.Enabled = true;
            pom1 = 1;
            pom2 = 1;
            pom3 = 1;
            pom4 = 1;
            pom5 = 1;
            pom6 = 1;
            pom7 = 1;
            pom8 = 1;
            pom9 = 1;
            pom10 = 1;
            pom11 = 1;
            pom12 = 1;
            pom13 = 1;
            pom14 = 1;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            res = br1 + br2;
            textBox3.Text = Convert.ToString(res);
            if (Convert.ToInt32(textBox3.Text) > 3999)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button18.Enabled = false;
                button15.Enabled = true;
            }
            else
            {

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
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button18.Enabled = false;
                button15.Enabled = true;
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
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button18.Enabled = false;
                button15.Enabled = true;
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
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button18.Enabled = false;
                button15.Enabled = true;
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
            pom1 = 1;
            pom2 = 1;
            pom3 = 1;
            pom4 = 1;
            pom5 = 1;
            pom6 = 1;
            pom7 = 1;
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
