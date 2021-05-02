using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 0, b = 0, i = 0, z = 0;
            Console.WriteLine("Введите текст:");
            string Text = Console.ReadLine();
            for(i = 0; i < Text.Length; i++)
            {
                if(Text[i] == '(')
                {
                    j = i;
                    z = i;
                    while(Text[z] != ')')
                    {
                        b++;
                        z++;
                    }
                    b++;
                    Text = Text.Remove(j, b);
                    b = 0;
                    z = 0;
                }
            }
            Console.WriteLine(Text);
            Console.ReadKey();
        }
    }
}
