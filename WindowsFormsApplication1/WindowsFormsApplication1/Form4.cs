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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void button19_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            decimal a = Convert.ToDecimal(textBox1.Text);
            decimal b = Convert.ToDecimal(textBox2.Text);
            jakodugacki x = new jakodugacki(a);
            jakodugacki y = new jakodugacki(b);
            textBox3.Text = jakodugacki.saberi(x, y);
        }
    }
}
