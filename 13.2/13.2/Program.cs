using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._2
{
    class Program
    {
        public static Random rand = new Random();
        static double yrav(int p, int q, int r, double d)
        {
            double x;
            x = (-q + Math.Sqrt(d) / 2 * p);
            return x;
        }
        static void Print(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static int[,] Generate(int Length1,int Length2)
        {
            int[,] arr = new int[Length1, Length2];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(1, 12);
                }
            }
            return arr;
        }
        static int Min(int[,] arr)
        {
            int min;
            min = arr[0,0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < min) min = arr[i, j];
                }
            }
            return min;
        }
        static void Main(string[] args)
        {
                double d;
                int p, q, r;
                double x1, x2;
                int[,] A = new int[3, 3];
                int[,] B = new int[4, 4];
                int[,] C = new int[5, 5];
                Random rand = new Random();
                A = Generate(A.GetLength(0),A.GetLength(1));
                B = Generate(B.GetLength(0), B.GetLength(1));
                C = Generate(C.GetLength(0), C.GetLength(1));
                p = A[0, 0];
                q = B[0, 0];
                r = C[0, 0];
                Console.WriteLine("Матрица A:");
                Print(A);
                p = Min(A);
                Console.WriteLine("Ее минимальный элемент:" + p);
                Console.WriteLine("Матрица B:");
                Print(B);
                q = Min(B);
                Console.WriteLine("Ее минимальный элемент:" + q);
                Console.WriteLine("Матрица C:");
                Print(C);
                r = Min(C);
                Console.WriteLine("Ее минимальный элемент:" + r);
                Console.WriteLine("Уравнение: {0}x^2+({1}x)+{2}=0", p, q, r);
                d = Math.Pow(q, 2) - 4 * p * r;
                Console.WriteLine("Дискриминант:" + d);
                if (d > 0)
                {
                    x1 = yrav(p, q, r, d);
                    x2 = yrav(p, q, r, d);
                    Console.WriteLine("Дискриминант больше 0,корни:{0},{1}", x1, x2);
                }
                if (d == 0)
                {
                    x1 = yrav(p, q, r, d);
                    Console.WriteLine("Дискриминант равен 0,корень:{0}", x1);
                }
                if (d < 0) Console.WriteLine("Корней нет");
                Console.ReadKey();
            }
        }
    }

