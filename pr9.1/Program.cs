using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            string g;
            Console.WriteLine("Введите x:");
            g = Console.ReadLine();
            x = Convert.ToDouble(g);
            Console.WriteLine("Введите y:");
            g = Console.ReadLine();
            y = Convert.ToDouble(g);
            if (-x+y>=0 && 2*x+y>=0 && (Math.Pow(x,2)+Math.Pow(y,2)<=4) && y>=0)
            {
                Console.WriteLine("Точка попадает");
            } else Console.WriteLine("Точка не попадает");
            Console.ReadLine();
        }
    }
}
