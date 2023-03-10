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
            double m = Convert.ToDouble(textBox1.Text);
            double n = Convert.ToDouble(textBox2.Text);
            double o = Convert.ToDouble(textBox3.Text);
            double p = Convert.ToDouble(textBox4.Text);
            kompleksni a = new kompleksni(m, n);
            kompleksni b = new kompleksni(o, p);
            textBox5.Text = kompleksni.saberi(a, b);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double m = Convert.ToDouble(textBox1.Text);
            double n = Convert.ToDouble(textBox2.Text);
            double o = Convert.ToDouble(textBox3.Text);
            double p = Convert.ToDouble(textBox4.Text);
            kompleksni a = new kompleksni(m, n);
            kompleksni b = new kompleksni(o, p);
            textBox5.Text = kompleksni.oduzmi(a, b);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double m = Convert.ToDouble(textBox1.Text);
            double n = Convert.ToDouble(textBox2.Text);
            double o = Convert.ToDouble(textBox3.Text);
            double p = Convert.ToDouble(textBox4.Text);
            kompleksni a = new kompleksni(m, n);
            kompleksni b = new kompleksni(o, p);
            textBox5.Text = kompleksni.pomnozi(a, b);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            double m = Convert.ToDouble(textBox1.Text);
            double n = Convert.ToDouble(textBox2.Text);
            double o = Convert.ToDouble(textBox3.Text);
            double p = Convert.ToDouble(textBox4.Text);
            kompleksni a = new kompleksni(m, n);
            kompleksni b = new kompleksni(o, p);
            textBox5.Text = kompleksni.podeli(a, b);
        }
    }
}
