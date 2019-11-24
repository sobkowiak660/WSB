using System;


namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(2, 3);   //2 i 3 to argumenty
            Add(2, 3, 4);
            Console.WriteLine("Pole wynosi: {0}",SquareArea(5));
            Console.WriteLine("Suma wynosi: {0}",Add(9));
            //Console.WriteLine("Suma wynosi: {0}",Add(1, 2));
            Console.WriteLine("!!!Wynik dodawania: {0}",Add(1, d:2));
            Data("Janusz");
            Console.ReadKey();
        }

        static void Add(int a, int b)  // a i b to parametry
        {
            int result = a + b;
            Console.WriteLine("Wynik dodawania: {0}",result);
        }
        static void Add(int a, int b, int c)    //zeby nie bylo bledu nie moga byc takie same parametry jesli jest ta sama nazwa
        {
            int result = a + b +c;
            Console.WriteLine("Wynik dodawania: {0}", result);
        }

        static int SquareArea(int a)
        {
            return a * a;
        }

        static int Add(int a, int b =3, int c = 2, int d = 1)
        {
            return a + b + c + d;
        }

        static void Data(string name, string surname = "Nowak", int age = 20)
        {
            Console.WriteLine("Imię: {0}, nazwisko: {1}, wiek: {2}",name,surname,age);
        }
    }
}
