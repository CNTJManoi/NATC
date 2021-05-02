using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr11._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            int n, i, j;
            double temp;
            n = Convert.ToInt32(textBox1.Text);
            string[] B = textBox2.Text.Split('.');
            if (n < B.Length)
            {
                MessageBox.Show("Размер массива не соотвествует введеному!");
                return;
            }
            i = 0;
            double[]A = new double[n];
            for (; i < A.Length; i++)
            {
                A[i] = int.Parse(B[i]);
            }
            i = 0;
            bool m = checkBox1.Checked;
            bool k = checkBox2.Checked;
            if (m == true)
            {
                label1.Text = "";
                for (; i < A.Length; i++)
                {
                    for(j=i+1; j < A.Length; j++)
                    {
                        if (A[i] > A[j])
                        {
                            temp = A[i];
                            A[i] = A[j];
                            A[j] = temp;
                        }
                    }
                }
                i = 0;
                for (; i < A.Length; i++)
                {
                    label1.Text += A[i].ToString() + ",";
                }
            }
                if (k == true)
                {
                    label1.Text = "";
                    double x;
                    for (i = 0; i < A.Length; i++)
                    {
                        x = A[i];
                   j = i - 1;
                        while(j >= 0 && A[j] > x)
                    {
                        A[j + 1] = A[j];
                        j--;
                    }
                    A[j + 1] = x;
                }
                i = 0;
                for (i = 0; i < A.Length; i++)
                {
                    label1.Text += A[i].ToString() + ",";
                }
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
