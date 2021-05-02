using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_10._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, i, n, s, e, u, z,b,j, factorial, q;
            string g;
            e = 0.01;
            Console.WriteLine("Введите x");
            g = Console.ReadLine();
            x = Convert.ToDouble(g);
            b = x * 3;
            i = 1;
            s = 0;
            factorial = 1;
            Console.WriteLine("№ Интерации \tСлагаемое \t\tСумма");
            do
            {
                q = 2 * i - 1;
                for(int l = 2;l <= q;l++)
                {
                    factorial = factorial * l;
                }
                j = Math.Pow(b, 2 * i - 1) / factorial;
                Console.WriteLine("{0} \t\t{1:0.##}",i,j);
                s = s + j;
                i = i + 1;
            } while (j > e);
            j = s;
            Console.WriteLine("\t\t\t\t\t{0:0.##}", s);
            z = x - 0.5;
            i = 1;
            factorial = 1;
            s = 0;
            do
            {
                q = 2 * i - 1;
                for (int l = 2; l <= q; l++)
                {
                    factorial = factorial * l;
                }
                u = Math.Pow(z, 2 * i - 1) / factorial;
                Console.WriteLine("{0} \t\t{1:0.##}", i, u);
                s = s + u;
                i = i + 1;
            } while (u > e);
            Console.WriteLine("\t\t\t\t\t{0:0.##}", s);
            u = s;
            n = Math.Sqrt(j/u);
            Console.WriteLine("F(x):{0:.0.##}", n);
            Console.ReadLine();
        }
    }
}