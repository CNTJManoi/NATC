using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            double m;
            int x, y;
            Console.WriteLine("Введите значение x:");
            n = Console.ReadLine();
            x = Convert.ToInt32(n);
            Console.WriteLine("Введите значение y:");
            n = Console.ReadLine();
            y = Convert.ToInt32(n);
            m = Math.Sqrt(Math.Abs(-3 * Math.Tan(x) * Math.Log10(Math.Pow(x,4) + y) / Math.Exp(-x) + 1));
            Console.WriteLine("Результат:{0}", m);
            Console.ReadLine();
        }
    }
}
