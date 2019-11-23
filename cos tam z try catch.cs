using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace czemu
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, dzielnik = 0, liczba=0;
            string we;
            while(true)
            { 
            we = Console.ReadLine();
            Console.Write("Podaj liczbę: ");
            try
            {
                    liczba = int.Parse(we);
                    break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Wprowadzono liczbę w złym formacie");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Wprowadzona liczba jest poza dopuszczalnym zakresem");
            }
            catch (ArgumentNullException) // ^Z
            {
                Console.WriteLine("Napotkano koniec strumienia");
            }
            Console.WriteLine("Spróbuj jeszcze raz");
        }
            //koniec wprowadzania liczby
        
        bool[] sito = new bool[liczba + 1];
                for (int i = 0; i <= liczba; i++)
                    sito[i] = true;
                //sito Eratostenesa

                for (int i = 2; i <= liczba; i++)
                {
                    if (sito[i])
                    {
                        x = i;
                        x = x + i;
                        while (x <= liczba)
                        {
                            sito[x] = false;
                            if (x == liczba)
                                dzielnik = i;
                            x = x + i;
                        }
                        if (dzielnik > 1) break;
                    }
                }
                //wyswietlenie liczb pierwszych
                /* Console.WriteLine("Liczby pierwsze z podanego zakresu to: ");
                 for (int i = 1; i <= liczba; i++)
                     if (sito[i])
                         Console.Write(i + ", ");
                 */

                if (sito[liczba]) Console.WriteLine("Liczba {0} jest liczbą pierwszą", liczba);
                else Console.WriteLine("Liczba {0} jest liczbą złożoną, podzielną przez {1}", liczba, dzielnik);
            Console.ReadKey();
            }
        }
    }

