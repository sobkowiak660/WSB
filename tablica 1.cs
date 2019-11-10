using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablice_na_kiju
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[5] { 10, 20, 30, 40, 50 };
            Console.WriteLine(tab[1]);
            Console.WriteLine("Rozmiar tablicy: {0}", tab.Length);

            //wyswietlanie konsoli - metoda 1
            int element;
            for (int i = 0; i < tab.Length; i++)  //po "for" tabulator, od razu sie uzupelnia
            {
                //Console.Write("{0} ", tab[i]);    wyswietla po kolei wszystkie elementy
                element = i + 1;
                Console.WriteLine("Element {1}: {0} ", tab[i],element);

            }
            //metoda 2
            int elem = 1;
            foreach (int x in tab)
            {
                
                Console.WriteLine("Element {1}: {0} ",x,elem);
                elem++;
            }
            //uzytkownik podaje z klawiatury swoje 3 ulubione kolory. przypisz je do tablicy o nazwie colors a nastepnie wyswietl na ekranie w formacie:
            //kolor 1: ...
            //kolor 2: ...
            //do przypisania kolorow do tablicy wykorzystaj pętlę for. do wyswietlenia kolorow z tablicy wykorzystaj pętlę while


            
            string[] colors = new string[3];
            string color;
            for(int i = 0; i < colors.Length; i++)
{
                Console.Write("Podaj kolor: ");
                color = Console.ReadLine();
                colors[i] = color;
            }
            uint a = 0,count;

            while (a < colors.Length)
            {
                count = a + 1;
                Console.WriteLine("Kolor {1}: {0}",colors[a],count);
                a++;
            }
            
               

            Console.ReadKey();
        }
    }
}
