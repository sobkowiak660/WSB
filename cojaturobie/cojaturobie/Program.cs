using System;


namespace cojaturobie
{
    class Program
    {
        static void Main(string[] args)
        {
            int oper;
            double a, b, wynik = 0;
            bool wybor;
            string operacja = ""; 
            Console.WriteLine("Program wykonuje podstawowe działania arytmetyczne na dwóch liczbach.");
            Console.Write("Podaj pierwszą liczbę: ");
            while (true)
            {
                if (!double.TryParse(Console.ReadLine(), out a))
                    Console.WriteLine("Wprowadzono niepoprawną wartość");
                else break;
            }
            Console.Write("Podaj drugą liczbę: ");
            while (true)
            {
                if (!double.TryParse(Console.ReadLine(), out b))
                    Console.WriteLine("Wprowadzono niepoprawną wartość");
                else break;
            }

           
            do
            {

                while (true)
                {

                    Console.WriteLine("1. Suma dwóch liczb");
                    Console.WriteLine("2. Różnica dwóch liczb");
                    Console.WriteLine("3. Iloczyn dwóch liczb");
                    Console.WriteLine("4. Iloraz dwóch liczb");
                    Console.Write("Wybierz jedną z dozwolonych operacji: ");
                    if (!int.TryParse(Console.ReadLine(), out oper))
                        Console.WriteLine("Wprowadzono niepoprawną wartość");
                    else break;
                }
                wybor = true;
                switch (oper)
                {
                    case 1: wynik = a + b; operacja = "dodawania"; break;
                    case 2: wynik = a - b; operacja = "odejmowania"; break;
                    case 3: wynik = a * b; operacja = "mnożenia"; break;
                    case 4: wynik = a / b; operacja = "dzielenia"; break;
                    default:
                        Console.WriteLine("Wybrano niedostępną operację!");
                        wybor = false; break;
                }
            } while (!wybor); 
            Console.WriteLine("Wynik {0} liczb {1} i {2} to {3}",operacja,a,b,wynik);

            Console.ReadKey();
        }
    }
}
