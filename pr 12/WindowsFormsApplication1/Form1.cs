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
            label4.Text = "";
            label10.Text = "";
            label5.Text = "";
            label8.Text = "";

            int i,g=0, j,k,l;//k-номер строки,l=номер столбца,m-количество четных элементов в строке
            int sum = 0, m = 0;
            i = int.Parse(textBox3.Text);
            j = int.Parse(textBox2.Text);
            int[] srmass = new int[i];
            int[,] A = new int[i, j];
            Random rand = new Random();
            for (k = 0; k < i; k++)
            {
                for (l = 0; l < j; l++)
                {
                    A[k, l] = rand.Next(0, 255);
                    label4.Text += A[k, l].ToString() + ",";
                }
                label4.Text += "\n";
            }
            for (g=0,k = 0; k < i; k++,g++)
            {
                label5.Text += String.Format("{0} Строка:", k + 1);
                label10.Text += String.Format("{0} Строка:", k + 1);
                label8.Text += String.Format("{0} Строка:", k + 1);
                for (l = 0; l < j; l++)
                {
                    if (A[k, l] % 2 == 0)
                    {
                        sum = sum + A[k, l];
                        m=m+1;
                        label5.Text += A[k, l].ToString() + ",";
                    }
                }
                label10.Text += sum.ToString() + "\n";
                var sr = (double)sum / m;
                label8.Text += sr.ToString() + "\n";
                m = 0;
                sum = 0;
                sr = 0;
                label5.Text += "\n";
                label10.Text += "\n";
                label8.Text += "\n";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
