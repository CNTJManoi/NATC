using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Example
{
    public partial class Form1 : Form
    {
        public Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            Settings.Evro = 10;
            Settings.Popitki = 0;
        }

        static int i = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonOk.Enabled = true;
            buttonStart.Enabled = false;

        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            i++;
            Settings.Popitki = i;
            Settings.ChicloRand = rand.Next(-1, 15);
            lblKatse.Text = Convert.ToString(Settings.Popitki);
            lblRand.Text += Settings.ChicloRand;
            lblRand.Text += "\n";
            int zaplatit = Settings.Popitki * Settings.Evro;
            if ((Settings.ChicloRand == 0 || Settings.ChicloRand == 10) && Settings.Popitki < 10)
            {
                MessageBox.Show(string.Format("Вы выйграли,попыток меньше 10.Заплати {0} евро", zaplatit));
                pilt2.Visible = true;
                buttonOk.Enabled = false;
            }
            else
            if ((Settings.ChicloRand == 0 || Settings.ChicloRand == 10) && Settings.Popitki == 10)
            {
                MessageBox.Show(string.Format("Вы выйграли,попыток ровно 10.Заплати {0} евро", zaplatit));
                pilt1.Visible = true;
                buttonOk.Enabled = false;
            }
            else
            if ((Settings.ChicloRand == 0 || Settings.ChicloRand == 10) && Settings.Popitki > 10)
            {
                MessageBox.Show(string.Format("Вы выйграли,попыток больше 10.Заплати {0} евро", zaplatit));
                pilt1.Visible = true;
                buttonOk.Enabled = false;
            }
            
        }
    }
}
