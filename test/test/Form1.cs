using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            Random rand = new Random();
            int[] B = new int[999999];
            B[i] = rand.Next(0, 9999999);
            i++;
            for (i = 1; i < B.Length; i++)
            {
                B[i] = rand.Next(0, 999);
                textBox1.Text += B[i].ToString(",");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}