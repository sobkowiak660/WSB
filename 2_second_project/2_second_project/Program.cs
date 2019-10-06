using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_second_project
{
    class Program
    {
        static void Main(string[] args)
        {
            //uzytkownik podaje z klawiatury dlugoc boku
            //oblicz pole kwadratu

            //Podawanie dlugosci bokow:

            Console.Write("Podaj bok a: ");
            string a = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("bok a = {0}",a);
            Console.WriteLine();

            //Liczenie pola: 

            double bok_a = double.Parse(a);
            //double pole = bok_a * bok_a;      pierwszy sposob
            bok_a *= bok_a;          //drugi sposob
            Console.WriteLine("Pole kwadratu wynosi: {0}",bok_a);    //do 1 zamiast bok_a pole
            Console.ReadLine();   //trzeba pamietac o tym readline bo inaczej jak jest potem clear to calosc zniknie od razu


            Console.Clear();  //czysci konsole

            //POLE TROJKATA

            //Podawanie dlugosci bokow

            Console.Write("Podaj podstawe trójkątka: ");        
            string b = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Podaj wysokosc trojkata: ");
            string h = Console.ReadLine();
            Console.WriteLine();

            // liczenie pola:

            // double podstawa = double.Parse(b);
            // double wysokosc = double.Parse(h);
            //double pole = podstawa * wysokosc / 2;      wtedy zamiast result musi byc pole w wyswietlaniu wyniku

            //albo:

            double result = 0.5 * double.Parse(b) * double.Parse(h);
            Console.WriteLine("Pole trojkata wynosi: {0}",result);
            Console.ReadLine();
            Console.Clear();

            //Sprawdzanie, czy dane podane przez uzytkownika sa prawidlowe

            string str;
            int liczba;
            Console.Write("Podaj liczbę całkowitą: ");
            str = Console.ReadLine();
            Console.WriteLine( );
            //liczba = int.Parse(str);

            if (int.TryParse(str, out liczba) == false)
                Console.WriteLine("Zły format liczby");
            else
                Console.WriteLine("Liczba wynosi {0}",liczba);
            Console.ReadLine();
            Console.Clear();

            //Sprawdzanie, czy liczba podana z klawiatury jest dodatnia całkowita, następnie czy jest parzysta

            Console.WriteLine("Podaj liczbę całkowitą: ");
            string number = Console.ReadLine();
            Console.WriteLine();
            uint numberUint;

                 if (uint.TryParse(str, out numberUint) == true)
            {
                     if (numberUint % 2 == 0)
                     { Console.WriteLine("Liczba {0} jest parzysta", numberUint); }
                       else
                      { Console.WriteLine("Liczba {0} jest nieparzysta", numberUint
                          ); }
                    
            }
            else
                Console.WriteLine("Podane dane są błędne");
            Console.ReadLine();
            Console.Clear();

            //Switch                to nie wiem, do rozkminienia
            Console.WriteLine("Podaj liczbe: ");

            sbyte wiek = 18;
            switch (wiek)
            {
               
              case 5:
                    Console.WriteLine("Jesteś niepełnoletni");
              break;
              case 18:
                    Console.WriteLine("Jesteś pełnoletni");
              break;
               default:
                    Console.WriteLine("Default");
               break;
            }
            

            Console.ReadKey();
        }
    }
}
