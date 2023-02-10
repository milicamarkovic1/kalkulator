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
        public int pom1;
        public int pom2;
        public int pom3;
        public int pom4;
        public int pom5;
        public int pom6;
        public int pom7;
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
        public string i;
        public string v;
        public string x;
        public string l;
        public string c;
        public string d;
        public string m;

        private void button1_Click(object sender, EventArgs e)
        {
            if (button18.Enabled == true)
            {
                if (textBox2.Text == "") textBox2.Text = textBox2.Text + i;
                pom = Convert.ToString(Convert.ToInt32(textBox2.Text) % 10);
                if (pom == "I")
                {
                    if (pom1 <= 3) textBox2.Text = textBox2.Text + i;
                }
                else if (pom != "I") textBox2.Text = textBox2.Text + i;
            }
            else
            {
                if (textBox1.Text == "") textBox1.Text = textBox1.Text + i;
                else
                {
                    if (textBox1.Text.Last() == 'I')
                    {
                        if (pom1 <= 3) textBox1.Text = textBox1.Text + i;
                    }
                    else if (textBox1.Text.Last() == 'X') //string sample= "sample"; string lastThree = sample.Substring(sample.Length - 3);
                    {
                        pom = textBox1.Text;
                        pompom = pom.Substring(pom.Length - 2);
                        if (pompom != "IX")
                        {
                            if (pom1 <= 3) textBox1.Text = textBox1.Text + i;
                        }
                    }
                }
            }
            pom1++;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (button18.Enabled == true)
            {
                if ((textBox2.Text.Length % 10) > vbr) textBox2.Text = textBox2.Text + v;
                if (pom2 == 1) textBox2.Text = textBox2.Text + v;
            }
            else
            {
                if ((textBox1.Text.Length % 10) > vbr) textBox1.Text = textBox1.Text + v;
                if (pom2 == 1) textBox1.Text = textBox1.Text + v;
            }
            pom2++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button18.Enabled == true)
            {
                textBox2.Text = textBox2.Text + x;
            }
            else textBox1.Text = textBox1.Text + x;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button18.Enabled == true)
            {
                textBox2.Text = textBox2.Text + l;
            }
            else textBox1.Text = textBox1.Text + l;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button18.Enabled == true)
            {
                textBox2.Text = textBox2.Text + c;
            }
            else textBox1.Text = textBox1.Text + c;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button18.Enabled == true)
            {
                textBox2.Text = textBox2.Text + d;
            }
            else textBox1.Text = textBox1.Text + d;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button18.Enabled == true)
            {
                textBox2.Text = textBox2.Text + m;
            }
            else textBox1.Text = textBox1.Text + m;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button18.Enabled = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button15.Enabled = false;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
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
            else textBox3.Text = Convert.ToString(res);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            res = br1 - br2;
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
            else if (Convert.ToInt32(textBox3.Text) < 0)
            {
                res = br2 - br1;
                textBox3.Text = "-" + Convert.ToString(res);
            }
            else textBox3.Text = Convert.ToString(res);
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
            i = "I";
            v = "V";
            x = "X";
            l = "L";
            c = "C";
            d = "D";
            m = "M";
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
    }
}
