using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suma_cyfr_w_liczbie
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine(Add(1234));
            Console.ReadKey();
            
        }
        static int Add(int x)
        {
            int result = 0;

            do
            {
                result += x % 10;
                x /= 10;
            } while (x != 0);
            return result;
        }

       
    }   
}

