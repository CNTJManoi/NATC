using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kosti
{
    public partial class Form1 : Form
    {
        private int sum1 { get; set; }
        private int sum2 { get; set; }
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Play1Player.Enabled = true;
            //Play2Player.Enabled = true;
            Player1_1.Text = 0.ToString();
            Player1_2.Text = 0.ToString();
            Player2_1.Text = 0.ToString();
            Player2_2.Text = 0.ToString();
            sumPl1.Text = 0.ToString();
            sumPl1.Text = 0.ToString();
            button2.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int x, y;
            x = rand.Next(1, 7);
            y = rand.Next(1, 7);
            Player1_1.Text = x.ToString();
            Player1_2.Text = y.ToString();
            int sum = x + y;
            sum1 = sum;
            sumPl1.Text = sum.ToString();
            Play1Player.Enabled = false;
            Play2Player.Enabled = true;
        }

        private void Play2Player_Click(object sender, EventArgs e)
        {
            int x, y;
            x = rand.Next(1, 7);
            y = rand.Next(1, 7);
            Player2_1.Text = x.ToString();
            Player2_2.Text = y.ToString();
            int sum = x + y;
            sum2 = sum;
            sumPl2.Text = sum.ToString();
            Play1Player.Enabled = false;
            Play2Player.Enabled = false;
            Result();
        }
        private void Result()
        {
            if (sum1 < sum2)
            {
                result.Text = "Победа второго игрока";
                sumPl2.ForeColor = Color.Red;
            }else if (sum1 == sum2)
            {
                result.Text = "Ничья";
                sumPl2.ForeColor = Color.Red;
                sumPl1.ForeColor = Color.Red;
            }
            else
            {
                result.Text = "Победа первого игрока";
                sumPl1.ForeColor = Color.Red;
            }
        }
    }
}
