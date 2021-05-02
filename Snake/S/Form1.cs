using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S
{
    public partial class Form1 : Form
    {
        private int s { get; set; }
        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();
        public Form1()
        {
            InitializeComponent();
            new settings();
            s = settings.Speed;
        }
        private void StartGame()
        {
            timer1.Interval = 1000 / settings.Speed;
            timer1.Start();
            result.Visible = true;
            new settings();
            s = settings.Speed;
            Circle head = new Circle();
            head.X = 10;
            head.Y = 10;
            Snake.Clear();
            Snake.Add(head);
            result.Text = settings.Score.ToString();
            GenerateFood();
        }
        private void GenerateFood()
        {
            int Xmax = Pole.Size.Width / settings.Wigth;
            int Ymax = Pole.Size.Height / settings.Heigth;

            Random rand = new Random();
            food = new Circle();
            food.X = rand.Next(0, Xmax);
            food.Y = rand.Next(0, Ymax);
        }
        private void Death(object sender,EventArgs e)
        {
            if (Input.KeyPressed(Keys.Enter))
            {
                timer2.Stop();
                StartGame();
            }
        }
        private void UpdateScreen(object sender,EventArgs e)
        {
            if (settings.GameOver == true)
            {
                    MessageBox.Show(string.Format("Вы набрали {0} Очков.", settings.Score));
                if (Input.KeyPressed(Keys.Enter))
                {
                    StartGame();
                }
            }
            else
            {
                if (Input.KeyPressed(Keys.Left) && settings.direction != Direction.Right)
                    settings.direction = Direction.Left;
                else if (Input.KeyPressed(Keys.Right) && settings.direction != Direction.Left)
                    settings.direction = Direction.Right;
                else if (Input.KeyPressed(Keys.Up) && settings.direction != Direction.Down)
                    settings.direction = Direction.Up;
                else if (Input.KeyPressed(Keys.Down) && settings.direction != Direction.Up)
                    settings.direction = Direction.Down;

                MovePlayer();
            }
            Pole.Invalidate();
        }
        private void Pole_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            if (!settings.GameOver)
            {
                for(int i = 0; i < Snake.Count; i++)
                {
                    Brush snakeColour;
                    if (i == 0) snakeColour = Brushes.Black;
                    else snakeColour = Brushes.Green;
                    canvas.FillEllipse(snakeColour, new Rectangle(Snake[i].X * settings.Wigth, Snake[i].Y * settings.Heigth, settings.Wigth, settings.Heigth));
                    canvas.FillEllipse(Brushes.Red, new Rectangle(food.X * settings.Wigth, food.Y * settings.Heigth, settings.Wigth, settings.Heigth));
                }
            }
        }
        public void MovePlayer()
        {
            for(int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (settings.direction)
                    {
                        case Direction.Right:
                            Snake[i].X++;
                            break;
                        case Direction.Left:
                            Snake[i].X--;
                            break;
                        case Direction.Up:
                            Snake[i].Y--;
                            break;
                        case Direction.Down:
                            Snake[i].Y++;
                            break;
                    }
                    int Xmax = Pole.Size.Width / settings.Wigth;
                    int Ymax = Pole.Size.Height / settings.Heigth;
                    if (Snake[i].X < 0 || Snake[i].Y <0 || Snake[i].X >= Xmax || Snake[i].Y >= Ymax)
                    {
                        Die();
                    }
                    for(int j = 1; j < Snake.Count; j++)
                    {
                        if(Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            Die();
                        }
                    }
                    if(Snake[i].X == food.X && Snake[i].Y == food.Y)
                    {
                        Eat();
                    }
                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
        }
        public void Eat()
        {
            Circle circle = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };
            Snake.Add(circle);
            settings.Score += settings.Points;
            result.Text = settings.Score.ToString();
            s = s + 1;
            timer1.Interval = 1000 / s;
            GenerateFood(); 
        }
        private void Die()
        {
            Form1 f = new Form1();
            settings.GameOver = true;
            timer2.Interval = 1000;
            timer2.Tick += Death;
            timer2.Start();
            Thread t = new Thread(print);
            t.Start();
            timer1.Stop();

        }
        private void print()
        {
            int score = int.Parse(result.Text);
            if (settings.GameOver == true)
            {
                MessageBox.Show(string.Format("Вы набрали {0} Очков.", score));
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Pole_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000 / settings.Speed;
            timer1.Tick += UpdateScreen;
            timer1.Start();
            Snake.Clear();
            settings.GameOver = false;
            StartGame();
            button1.Enabled = false;
        }
    }
}
