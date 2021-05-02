using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    public class ReverseComparer : IComparer
    {
        public int Compare(Object x, Object y)
        {
            return (new CaseInsensitiveComparer()).Compare(y, x);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, j = 0, b = 0, z = 0, c, kol2, t = 0, a = 0, f = 0, kol = 4, h = 0;
            double sr, sum = 0;
            string[] FIO = new string[10];
            string[] Adress = new string[10];
            int[] Ochenki = new int[100];
            string[] Bl = new string[10];
            var s = new StreamReader("H:\\VS\\14\\pp.txt", Encoding.Default);
            string read = null;
            while ((read = s.ReadLine()) != null)
            {
                string[] N = read.Split(',');
                c = N.Length - 2;
                FIO[i] = N[j];
                j++;
                Adress[i] = N[j];
                j++;
                while (z != c)
                {
                    Ochenki[b] = Convert.ToInt32(N[j]);
                    j++;
                    b++;
                    z++;
                }
                z = 0;
                i++;
                j = 0;
            }
                s.Close();
                kol2 = i;
            b = 0;
                for (i = 0, j = 0, h = 0; i < kol2; i++)
                {
                    for (j = 0; j < 4; j++,b++)
                    {
                        sum += Ochenki[b];
                    }
                    sr = (double)sum / kol;
                    if (Adress[i] == "Новосибирск" && sr >= 4.5)
                    {
                        Bl[a] = FIO[i];
                        t++;
                        a++;
                    }
                    sum = 0;
                    sr = 0;
                    h++;
                }
                IComparer RevComparer = new ReverseComparer();
                string[] P = new string[Bl.Length];
                Array.Sort(Bl);
                for (i = 0; i < Bl.Length; i++)
                {
                    if (Bl[i] != null)
                    {
                        P[f] = Bl[i];
                        f++;
                    }
                }
                Console.WriteLine("Количество студентов живущих в Новосибирске и имеющих средний бал выше 4.5:" + a);
                for (i = 0; i < a; i++)
                {
                    Console.WriteLine(P[i]);
                }
                Console.ReadKey();
            }
        }
    }
