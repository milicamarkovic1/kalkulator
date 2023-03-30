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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void button19_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            kompleksni x = new kompleksni();
            kompleksni y = new kompleksni();
            if (textBox1.Text == "") x.realni = 0;
            else x.realni = Convert.ToDouble(textBox1.Text);
            if (textBox2.Text == "") x.imaginarni = 0;
            else x.imaginarni = Convert.ToDouble(textBox2.Text);
            if (textBox3.Text == "") y.realni = 0;
            else y.realni = Convert.ToDouble(textBox3.Text);
            if (textBox4.Text == "") y.imaginarni = 0;
            else y.imaginarni = Convert.ToDouble(textBox4.Text);
            kompleksni z = kompleksni.saberi(x, y);
            if (z.imaginarni > 0) textBox5.Text = Convert.ToString(z.realni) + "+" + Convert.ToString(z.imaginarni) + "i";
            else if (z.imaginarni == 0) textBox5.Text = Convert.ToString(z.realni);
            else if (z.realni == 0) textBox5.Text = Convert.ToString(z.imaginarni);
            else textBox5.Text = Convert.ToString(z.realni) + Convert.ToString(z.imaginarni) + "i";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            kompleksni x = new kompleksni();
            kompleksni y = new kompleksni();
            if (textBox1.Text == "") x.realni = 0;
            else x.realni = Convert.ToDouble(textBox1.Text);
            if (textBox2.Text == "") x.imaginarni = 0;
            else x.imaginarni = Convert.ToDouble(textBox2.Text);
            if (textBox3.Text == "") y.realni = 0;
            else y.realni = Convert.ToDouble(textBox3.Text);
            if (textBox4.Text == "") y.imaginarni = 0;
            else y.imaginarni = Convert.ToDouble(textBox4.Text);
            kompleksni z = kompleksni.oduzmi(x, y);
            if (z.imaginarni > 0) textBox5.Text = Convert.ToString(z.realni) + "+" + Convert.ToString(z.imaginarni) + "i";
            else if (z.imaginarni == 0) textBox5.Text = Convert.ToString(z.realni);
            else if (z.realni == 0) textBox5.Text = Convert.ToString(z.imaginarni);
            else textBox5.Text = Convert.ToString(z.realni) + Convert.ToString(z.imaginarni) + "i";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            kompleksni x = new kompleksni();
            kompleksni y = new kompleksni();
            if (textBox1.Text == "") x.realni = 0;
            else x.realni = Convert.ToDouble(textBox1.Text);
            if (textBox2.Text == "") x.imaginarni = 0;
            else x.imaginarni = Convert.ToDouble(textBox2.Text);
            if (textBox3.Text == "") y.realni = 0;
            else y.realni = Convert.ToDouble(textBox3.Text);
            if (textBox4.Text == "") y.imaginarni = 0;
            else y.imaginarni = Convert.ToDouble(textBox4.Text);
            kompleksni z = kompleksni.pomnozi(x, y);
            if (z.imaginarni > 0) textBox5.Text = Convert.ToString(z.realni) + "+" + Convert.ToString(z.imaginarni) + "i";
            else if (z.imaginarni == 0) textBox5.Text = Convert.ToString(z.realni);
            else if (z.realni == 0) textBox5.Text = Convert.ToString(z.imaginarni);
            else textBox5.Text = Convert.ToString(z.realni) + Convert.ToString(z.imaginarni) + "i";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            kompleksni x = new kompleksni();
            kompleksni y = new kompleksni();
            if (textBox1.Text == "") x.realni = 0;
            else x.realni = Convert.ToDouble(textBox1.Text);
            if (textBox2.Text == "") x.imaginarni = 0;
            else x.imaginarni = Convert.ToDouble(textBox2.Text);
            if (textBox3.Text == "") y.realni = 0;
            else y.realni = Convert.ToDouble(textBox3.Text);
            if (textBox4.Text == "") y.imaginarni = 0;
            else y.imaginarni = Convert.ToDouble(textBox4.Text);
            kompleksni z = kompleksni.podeli(x, y);
            if (z.imaginarni > 0) textBox5.Text = Convert.ToString(z.realni) + "+" + Convert.ToString(z.imaginarni) + "i";
            else if (z.imaginarni == 0) textBox5.Text = Convert.ToString(z.realni);
            else if (z.realni == 0) textBox5.Text = Convert.ToString(z.imaginarni);
            else textBox5.Text = Convert.ToString(z.realni) + Convert.ToString(z.imaginarni) + "i";
            if ((y.realni == 0) && (y.imaginarni == 0))
            {
                MessageBox.Show("Ne sme se deliti sa nulom.");
                textBox5.Text = "";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
