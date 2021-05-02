using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public static double Formula(int x)
        {
            try
            {
                if (x<=1)
                {
                    throw new DivideByZeroException();   
                }
                double y;
                y = Math.Log(Math.Pow(x, 4) - 1) * Math.Log(1 + x);
                return y;
            }
            catch (DivideByZeroException)
            {
                double y;
                string g = Convert.ToString(x);
                MessageBox.Show(String.Format("В точке {0} не существует функции",g));
                y = 0;
                return y;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int x, a, b, h;
            double y;
            DataTable dt = new DataTable();
            dt.Columns.Add("x");
            dt.Columns.Add("y");
            try
            {
                a = int.Parse(textBox2.Text);
                b = int.Parse(textBox3.Text);
                h = int.Parse(textBox4.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены неверные переменные");
                return;
            }
            for (x = a; x <= b;)
            {
                y = Formula(x);
                DataRow r = dt.NewRow();
                if (y == 0)
                {
                    r["y"] = "Не существует";
                    goto a;
                }
                r["y"] = y;
                a: r["x"] = x;
                x += h;
                dt.Rows.Add(r);
            }
            dataGridView1.DataSource = dt;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
