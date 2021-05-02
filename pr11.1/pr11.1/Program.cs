using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr11._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[100000];
            Random rand = new Random();
            int n, i = 1, j = 0;
            double x, y, r,m;
            string g;
            Console.WriteLine("Число окружностей:");
            g = Console.ReadLine();
            n = Convert.ToInt32(g);
            Console.WriteLine("x:");
            g = Console.ReadLine();
            x = Convert.ToInt32(g);
            Console.WriteLine("y:");
            g = Console.ReadLine();
            y = Convert.ToInt32(g);
            r = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            Console.WriteLine("Радиус:{0}",r);
            Console.WriteLine("Элементы массива:");
            for (;i<=n;i++)
            {
                A[i] = rand.Next(1,254);
                Console.Write(A[i]);
            }
            i = 1;
            j = 1;
            for (; i <= n; i++)
            {
                j = j + 1;
                if (((A[i] < r) && (A[j] > r))) Console.WriteLine("Точка между окружностями {0} и {1}", i, j);
            }
            i = 1;
            Console.WriteLine("Индексы четных элементов массива и их значение:");
            for(;i <= n; i++)
            {
                m = A[i] % 2;
                if (m == 0 && A[i] != 0) Console.WriteLine("i={0},Значение={1}",i,A[i]);
            }
            Console.ReadLine();
        }
    }
}
