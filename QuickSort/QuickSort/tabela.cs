using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Tabela
    {
        int[] tab;
        int stElementov;

        public Tabela(int velikost)
        {
            tab = new int[velikost];
            stElementov = 0;
        }

        public void Dodaj(int k)
        {
            tab[stElementov++] = k;
        }

        public void Izpis()
        {
            for(int k=0; k<tab.Length; k++)
            {
                Console.Write(tab[k] + "\t");
            }

            /*
            foreach(int x in tab)
            {
                Console.Write(x + "\t");
            }
            */

            Console.WriteLine();
        }

        public int Pivot(int zac, int konec)
        {
            int p = tab[zac];
            int m = zac;
            int n = konec + 1;

            //levo išči prvega večjega od p
            do
            {
                m++;
            } while (tab[m] <= p & m < konec);

            //desno išči prvega manjšega od p
            do
            {
                n--;
            } while (tab[n] > p);

            while (m < n)
            {
                //zamenjaj tab[m] in tab[n]
                int temp = tab[m];
                tab[m] = tab[n];
                tab[n] = temp;

                //nadaljuj iskanje
                do
                {
                    m++;
                } while (tab[m] <= p);

                do
                {
                    n--;
                } while (tab[n] > p);
            }

            //zamenjaj pivot in element na n-tem mestu
            int temp1 = tab[zac];
            tab[zac] = tab[n];
            tab[n] = temp1;

            return n;
        }

        public void QuickSort(int zac, int konec)
        {
            if (zac >= konec)
                return;

            int k = Pivot(zac, konec);
            QuickSort(zac, k - 1);
            QuickSort(k + 1, konec);
        }
    }
}