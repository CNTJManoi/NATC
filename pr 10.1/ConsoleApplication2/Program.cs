using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, sum;
            int d = 1;
            string g;
            Console.WriteLine("Введите x:");
            g = Console.ReadLine();
            x = Convert.ToInt32(g);
            sum = x;
            Console.WriteLine("Делители числа:");
            while(x>d)
            {
                if (x % d == 0)
                {
                    sum = sum + d;
                    Console.WriteLine(d);
                    d = d + 1;
                }
                else d = d + 1;
            }
            Console.WriteLine("Сумма делителей:{0}", sum);
            Console.ReadLine();
        }
    }
}
