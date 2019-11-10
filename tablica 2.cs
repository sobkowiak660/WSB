using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablica_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //tablice prostokatne
            int[,] tab = new int[,]
            {
                { 1, 2, 3 },  //wiersz 0
                { 4, 5, 6 },  //wiersz 1
                { 7, 8, 9 }, //wiersz 2
            };

            Console.WriteLine("Ilość elementów tablicy: {0}",tab.Length);
            Console.WriteLine(tab.GetLength(0)); //rozmiar tablicy, w sensie ile elementow ma wiersz 0
            Console.WriteLine(tab.GetLength(1)); // a tu wiersz 1

            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    Console.Write("{0}\t",tab[i,j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
