using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace S
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    };
    class settings
    {
        public static bool Clon { get; set; }
        public static int Wigth { get; set; }
        public static int Heigth { get; set; }
        public static int Points { get; set; }
        public static int Speed { get; set; }
        public static int Score { get; set; }
        public static bool GameOver { get; set; }

        public static Direction direction {get;set;}

        public settings()
        {
            Wigth = 16;
            Heigth = 16;
            Points = 1;
            Speed = 10;
            Score = 0;
            GameOver = false;
        }




    }
}
