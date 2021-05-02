using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr_18._3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter s = new StreamWriter("H:\\VS\\pr 18 . 3.1\\agmed.txt");
            s.WriteLine("{0},{1}", NameTB.Text, CodeTB.Text);
            s.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string line;
            StreamReader s = new StreamReader("H:\\VS\\pr 18 . 3.1\\agmed.txt", Encoding.Default);
            while((line = s.ReadLine()) != null)
            {
                string[] N = line.Split(',');
            }
        }
    }
}
