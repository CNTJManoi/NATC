using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x; double y,u; string g;
            Console.WriteLine("Введите пункт приема звонка \nМурманск-1 \nСургут-2 \nАбакан-3 \nБрянск-4 \nМагас-5 \nМахачкала-6 \nКурск-7 \nВолгоград-8");
            g = Console.ReadLine();
            x = Convert.ToInt32(g);
            Console.WriteLine("Укажите длительность разговора");
            g = Console.ReadLine();
            y = Convert.ToDouble(g);
            switch (x)
            {
                case 1:
                    u = y * 1.6;
                    Console.WriteLine("Стоимость разговора:{0}", u);
                    break;
                case 2:
                    u = y * 2.3;
                    Console.WriteLine("Стоимость разговора:{0}", u);
                    break;
                case 3:
                    u = y * 1.6;
                    Console.WriteLine("Стоимость разговора:{0}", u);
                    break;
                case 4:
                    u = y * 1.9;
                    Console.WriteLine("Стоимость разговора:{0}", u);
                    break;
                case 5:
                    u = y * 3.4;
                    Console.WriteLine("Стоимость разговора:{0}", u);
                    break;
                case 6:
                    u = y * 8.4;
                    Console.WriteLine("Стоимость разговора:{0}", u);
                    break;
                case 7:
                    u = y * 1.09;
                    Console.WriteLine("Стоимость разговора:{0}", u);
                    break;
                case 8:
                    u = y * 42.6;
                    Console.WriteLine("Стоимость разговора:{0}", u);
                    break;
            }
            Console.ReadLine();
        }
    }
}
