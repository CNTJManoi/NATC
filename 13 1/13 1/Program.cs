using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_1
{
    class Program
    {
        static int del(int val1,int val2)
        {
            while((val1 != 0) && (val2 != 0))
            {
                if (val1 > val2) val1 -= val2;
                else val2 -= val1;
            }
            return Math.Max(val1, val2);
        }
        static void Main(string[] args)
        {
            int k;
            Console.WriteLine("Введите первое число:");
            int val1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int val2 = int.Parse(Console.ReadLine());
            int z = del(val1, val2);
            k = (val1 * val2) / z;
            Console.WriteLine("Наименьшее общее кратное:{0}", k);
            Console.ReadKey();
        }
    }
}
