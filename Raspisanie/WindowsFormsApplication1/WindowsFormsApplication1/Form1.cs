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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n,i,j=0,b,z=0;
            n = int.Parse(textBox1.Text);
            int[] s = new int[n];
            int[] t = new int[n];
            int[] p = new int[n];
            if (2 >= n || n >= 10000)
            {
                MessageBox.Show("Введите число в диапазоне 2<=n<=10000");
            }
            string[] S = textBox2.Text.Split(',');
            string[] T = textBox3.Text.Split(',');
            for (i = 0; i < n; i++)
            {
                s[i] = int.Parse(S[i]);
                t[i] = int.Parse(T[i]);
            }
            i = 0;
            b = 0;
            j = i + 1;
            for (; j < n;j++)
            {
                if (t[i] <= s[j] || t[j] <= s[i])
                {
                    if (i == 0)
                    {
                        p[b] = i + 1;
                        z = i;
                        label4.Text += p[b].ToString() + ",";
                        i = j;
                        i++;
                        label4.Text += i.ToString() + ",";
                        i--;
                        goto b;
                    }
                    i = j;
                    p[b] = i+1;
                    label4.Text += p[b].ToString() + ",";
                    b: b++;
                }
            }
            i = z;
            i++;
            z++;
            j = i + 1;
            for (; j < n; j++)
            {
                if (t[i] <= s[j] || t[j] <= s[i])
                {
                    if (i == z)
                    {
                        p[b] = i + 1;
                        z = i;
                        label7.Text += p[b].ToString() + ",";
                        i = j;
                        i++;
                        label7.Text += i.ToString() + ",";
                        i--;
                        goto b;
                    }
                    i = j;
                    p[b] = i + 1;
                    label7.Text += p[b].ToString() + ",";
                b: b++;
                }
            }

            //for (i = 100; i < b;i++)
            //{
            // label4.Text += p[i].ToString()+",";
            //}
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
