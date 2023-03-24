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
using System.Numerics;
using Singulink.Numerics;
using Singulink.Numerics.BigDecimal;

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
        static List<int>[] napred(List<int> x, List<int> y)
        {
            int a = x.Count;
            int b = y.Count;
            int raz = Math.Abs(a - b);
            if (a < b)
            {
                for (int i=0; i<raz; i++)
                {
                    x.Insert(0, 0);
                }
            }
            else
            {
                for (int i = 0; i < raz; i++)
                {
                    y.Insert(0, 0);
                }
            }
            return new[] { x, y };
        }
        static List<int>[] nazad(List<int> x, List<int> y)
        {
            int a = x.Count;
            int b = y.Count;
            int raz = Math.Abs(a - b);
            if (a < b)
            {
                for (int i = 0; i < raz; i++)
                {
                    x.Add(0);
                }
            }
            else
            {
                for (int i = 0; i < raz; i++)
                {
                    y.Add(0);
                }
            }
            return new[] { x, y };
        }
        static string veci(string x, string y)
        {
            if (x.Length > y.Length) return x;
            else if (x.Length < y.Length) return y;
            else
            {
                for (int i=x.Length-1; i>=0; i--)
                {
                    if (Convert.ToInt32(x[i]) > Convert.ToInt32(y[i])) return x;
                    else if (Convert.ToInt32(x[i]) < Convert.ToInt32(y[i])) return y;
                }
                return x;
            }
        }
        static string saberi(string s1, string s2)
        {
            int index = s1.IndexOf('-');
            string ss1 = (index < 0)
                ? s1
                : s1.Remove(index, s1.Length);
            int index2 = s2.IndexOf('-');
            string ss2 = (index2 < 0)
                ? s2
                : s2.Remove(index2, s2.Length);
            int i;
            List<int> n1 = new List<int>();
            List<int> n2 = new List<int>();
            List<int> m1 = new List<int>();
            List<int> m2 = new List<int>();
            for (i=s1.Length-1; i>-1; i--)
            {
                if (s1[i] == '.') break;
                m1.Add(s1[i] - '0');
            }
            i--;
            for(; i>-1; i--) n1.Add(s1[i] - '0');
            for (i = s2.Length - 1; i > -1; i--)
            {
                if (s2[i] == '.') break;
                m2.Add(s2[i] - '0');
            }
            i--;
            for (; i > -1; i--) n2.Add(s2[i] - '0');
            List<int>[] res1 = napred(m1, m2);
            List<int>[] res2 = nazad(n1, n2);
            m1 = res1[0];
            m2 = res1[1];
            n1 = res2[0];
            n2 = res2[1];
            int n = m1.Count;
            int m = m2.Count;
            i = 0;
            int ostatak = 0;
            while (i < n && i < m)
            {
                int sum = m1[i] + m2[i] + ostatak;
                m1[i] = sum % 10;
                ostatak = (sum >= 10) ? 1 : 0;
                i++;
            }
            int N = n1.Count;
            int M = n2.Count;
            i = 0;
            while (i < N && i < M)
            {
                int sum = n1[i] + n2[i] + ostatak;
                n1[i] = sum % 10;
                ostatak = (sum >= 10) ? 1 : 0;
                i++;
            }
            if (ostatak != 0)
                n1.Add(ostatak);
            n1.Reverse();
            m1.Reverse();
            string celi = string.Join(string.Empty, n1);
            string decimalni = string.Join(string.Empty, m1);
            return celi + '.' + decimalni;
        }
        static string oduzmi(string s1, string s2)
        {
            int index = s1.IndexOf('-');
            string ss1 = (index < 0)
                ? s1
                : s1.Remove(index, s1.Length);
            int index2 = s2.IndexOf('-');
            string ss2 = (index2 < 0)
                ? s2
                : s2.Remove(index2, s2.Length);
            int i;
            List<int> n1 = new List<int>();
            List<int> n2 = new List<int>();
            List<int> m1 = new List<int>();
            List<int> m2 = new List<int>();
            for (i = s1.Length - 1; i > -1; i--)
            {
                if (s1[i] == '.') break;
                m1.Add(s1[i] - '0');
            }
            i--;
            for (; i > -1; i--) n1.Add(s1[i] - '0');
            for (i = s2.Length - 1; i > -1; i--)
            {
                if (s2[i] == '.') break;
                m2.Add(s2[i] - '0');
            }
            i--;
            for (; i > -1; i--) n2.Add(s2[i] - '0');
            List<int>[] res1 = napred(m1, m2);
            List<int>[] res2 = nazad(n1, n2);
            m1 = res1[0];
            m2 = res1[1];
            n1 = res2[0];
            n2 = res2[1];
            int n = m1.Count;
            int m = m2.Count;
            i = 0;
            int ostatak = 0;
            if (veci(s1, s2) == s1)
            {
                while (i < n && i < m)
                {
                    if ((m1[i] - m2[i] + ostatak) < 0)
                    {
                        m1[i] = 10 + (m1[i] - m2[i] + ostatak);
                        ostatak = -1;
                    }
                    else
                    {
                        m1[i] = (m1[i] - m2[i]) + ostatak;
                        ostatak = 0;
                    }
                    i++;
                }
            }
            else
            {
                while (i < n && i < m)
                {
                    if ((m2[i] - m1[i] + ostatak) < 0)
                    {
                        m1[i] = 10 + (m2[i] - m1[i] + ostatak);
                        ostatak = -1;
                    }
                    else
                    {
                        m1[i] = (m2[i] - m1[i]) + ostatak;
                        ostatak = 0;
                    }
                    i++;
                }
            }
            string celi;
            string decimalni;
            int N = n1.Count;
            int M = n2.Count;
            i = 0;
            if (veci(s1, s2) == s1)
            {
                while (i < N && i < M)
                {
                    if ((n1[i] - n2[i] + ostatak) < 0)
                    {
                        n1[i] = 10 + (n1[i] - n2[i] + ostatak);
                        ostatak = -1;
                    }
                    else
                    {
                        n1[i] = (n1[i] - n2[i]) + ostatak;
                        ostatak = 0;
                    }
                    i++;
                }
                n1.Reverse();
                m1.Reverse();
                celi = string.Join(string.Empty, n1);
                decimalni = string.Join(string.Empty, m1);
                return celi + '.' + decimalni;
            }
            else
            {
                while (i < N && i < M)
                {
                    if ((n2[i] - n1[i] + ostatak) < 0)
                    {
                        n1[i] = 10 + (n2[i] - n1[i] + ostatak);
                        ostatak = -1;
                    }
                    else
                    {
                        n1[i] = (n2[i] - n1[i]) + ostatak;
                        ostatak = 0;
                    }
                    i++;
                }
                n1.Reverse();
                m1.Reverse();
                celi = string.Join(string.Empty, n1);
                decimalni = string.Join(string.Empty, m1);
                return '-' + celi + '.' + decimalni;
            }
        }
        public static string pomnozi(string s1, string s2)
        {
            s1 = s1.TrimStart('0').TrimEnd('.');
            s2 = s2.TrimStart('0').TrimEnd('.');
            int dec1 = s1.Length - s1.IndexOf('.') - 1;
            int dec2 = s2.Length - s2.IndexOf('.') - 1;
            s1 = s1.Replace(".", "");
            s2 = s2.Replace(".", "");
            int[] rez = new int[s1.Length + s2.Length];
            for (int i=s2.Length-1; i>=0; i--)
            {
                int ostatak = 0;
                for (int j=s1.Length-1; j>=0; j--)
                {
                    int p = (s2[i] - '0') * (s1[j] - '0') + ostatak + rez[i + j + 1];
                    ostatak = p / 10;
                    rez[i + j + 1] = p % 10;
                }
                rez[i] += ostatak;
            }
            StringBuilder sb = new StringBuilder();
            int pom = 0;
            while (pom < rez.Length && rez[pom] == 0)
            {
                pom++;
            }
            if (pom == rez.Length)
            {
                return "0";
            }
            while (pom < rez.Length - dec1 - dec2)
            {
                sb.Append(rez[pom++]);
            }
            if (dec1 + dec2 > 0)
            {
                sb.Append(".");
            }
            while (pom < rez.Length)
            {
                sb.Append(rez[pom++]);
            }
            return sb.ToString();
        }
        public static string podeli(string s1, string s2, int br)
        {
            BigDecimal x = BigDecimal.Parse(s1);
            BigDecimal y = BigDecimal.Parse(s2);
            return BigDecimal.Divide(x, y, 20).ToString();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            textBox3.Text = saberi(textBox1.Text, textBox2.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox3.Text = oduzmi(textBox1.Text, textBox2.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox3.Text = pomnozi(textBox1.Text, textBox2.Text);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox3.Text = podeli(textBox1.Text, textBox2.Text, 50);
        }
    }
}
