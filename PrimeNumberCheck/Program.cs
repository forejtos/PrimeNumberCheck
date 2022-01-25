using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            Console.Write("Zadej číslo: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            if ( num1 == 0 || num1 == 1)
            {
                Console.WriteLine(num1 + " není prvočíslo");
                Console.ReadLine();
            }
            else
            {
                for (int i = 2; i < num1 / 2; i++)
                {
                    if (num1 % i == 0)
                    {
                        Console.WriteLine(num1 + " není prvočíslo");
                        Console.ReadLine();
                        return;
                    }
                }   
                Console.WriteLine(num1 + " je prvočíslo");
                Console.ReadLine();
            }   
        }
    }
}
