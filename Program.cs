using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factor_GivenNum
{
    class Program
    {
        static void Main(string[] args)

        {

            int num, x;

            Console.WriteLine("Enter a number:");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("factors: ");

            for (x = 1; x <= num; x++)
            {
                if (num % x== 0)
                {
                    Console.WriteLine(x);
                }
            }
            Console.ReadLine();
        }
    }
}
