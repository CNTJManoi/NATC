using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _15._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "";
            Console.WriteLine("Введите строки(пустая строка-конец ввода)");
            string st = Console.ReadLine();
            while(st != "")
            {
                text += "\n" + st;
                st = Console.ReadLine();
            }
            string pattern = @"((https?|ftp)\:\/\/)?([a-z0-9]{1})((\.[a-z0-0-])|([a-z0-9-]))*\.([a-z]{2,6})(\/?)";
            Regex newReg = new Regex(pattern);
            MatchCollection matches = newReg.Matches(text);
            foreach(Match mat in matches)
            {
                Console.WriteLine("значение найденного элемента:" + mat.Value);
            }
            Console.WriteLine("Число найденных совпадений:" + matches.Count);
            Console.ReadLine();
        }
    }
}
