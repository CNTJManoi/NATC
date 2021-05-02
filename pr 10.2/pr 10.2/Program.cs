using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, c, k, s, p;
            string g;
            Console.WriteLine("Введите количество членов ряда:");
            g = Console.ReadLine();
            k = Convert.ToInt32(g);
            b = 2.0;
            c = 3.0;
            s = 0;
            for (int l = 1; l <= k; l++)
            {
                p = l / (b * c);
                Console.WriteLine("Результат {0} равен:{1:0.##}", l, p);
                b = b + 1;
                c = c + 1;
                s = s + p;
            }
            Console.WriteLine("Сумма равна:{0:0.##}", s);
            Console.ReadLine();
        }
    }
}
