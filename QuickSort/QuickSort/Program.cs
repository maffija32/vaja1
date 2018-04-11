using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Tabela a = new Tabela(10);
            a.Dodaj(6);
            a.Dodaj(24);
            a.Dodaj(80);
            a.Dodaj(4);
            a.Dodaj(19);
            a.Dodaj(84);
            a.Dodaj(1);
            a.Dodaj(10);
            a.Dodaj(13);
            a.Dodaj(7);

            Console.WriteLine("Neurejena tabela");
            Console.Write("\t");
            a.Izpis();

            a.QuickSort(0, 9);
            Console.WriteLine("Urejena tabela");
            Console.Write("\t");
            a.Izpis();
            */

            Tabela a = new Tabela(30000);
            Random r = new Random();

            for(int k = 0; k< 30000; k++)
            {
                a.Dodaj(r.Next(30000));
            }

            DateTime d = DateTime.Now;
            a.QuickSort(0, 29999);
            DateTime d1 = DateTime.Now;
            TimeSpan ts = d1 - d;
            Console.WriteLine("QuickSort " + ts.Milliseconds + " ms");

            Console.ReadLine();
        }
    }
}
