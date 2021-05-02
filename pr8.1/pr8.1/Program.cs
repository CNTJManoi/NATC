using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 235;
            double f = 413.1477565465;
            Console.WriteLine("Преобразуем int в другие целые типы");
            Console.WriteLine("Типы \tint \tInt16 \tInt32 \tInt64 \tByte \tsByte");
            Console.WriteLine("Значения {0}\t {1}\t {2}\t {3}\t {4}\t {5}", (int)n,(Int16)n,(Int32)n,(Int64)n,(Byte)n,(SByte)n);
            Console.WriteLine("Байты \t {0}\t {1}\t {2}\t {3}\t {4}\t {5}", sizeof(int), sizeof(Int16), sizeof(Int32), sizeof(Int64), sizeof(Byte), sizeof(SByte));
            Console.WriteLine("Нажмите Enter");
            Console.ReadLine();
            Console.WriteLine("Преобразуем int в типы с плавающей точкой");
            Console.WriteLine("Типы \tint \tDouble \tSingle");
            Console.WriteLine("Значения {0}\t {1}\t {2}", (int)n, (double)n, (Single)n);
            Console.WriteLine("Байты \t {0}\t {1}\t {2}", sizeof(int), sizeof(double), sizeof(Single));
            Console.WriteLine("Нажмите Enter");
            Console.ReadLine();
            Console.WriteLine("Преобразуем double в Single и int");
            Console.WriteLine("Типы \tint \tDouble \t\tSingle");
            Console.WriteLine("Значения {0}\t {1:F3} \t {2:F3}", (int)f, (double)f, (Single)f);
            Console.WriteLine("Байты \t {0}\t {1}\t\t {2}", sizeof(int), sizeof(double), sizeof(Single));
            Console.WriteLine("Нажмите Enter");
            Console.ReadLine();
        }
    }
}
