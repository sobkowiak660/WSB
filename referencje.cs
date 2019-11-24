using System;


namespace zadanko_znowu
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            Console.WriteLine("Wartość zmiennej x przed wywołaniem funkcji Increment: {0}",x);
            Increment(ref x);
            Increment(ref x);
            Increment(ref x);
            Increment(ref x);
            Console.ReadKey();
        }
        static void Increment(ref int x)
        {
            x += 10;
            Console.WriteLine("Zmienna x wewnątrz funkcji wynosi: {0}",x);
        }
    }
}
