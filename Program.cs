using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops2_InfiniteLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a number.");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter another number.");
            //int m = int.Parse(Console.ReadLine());

            //int counter;
            //int result;

            //do
            //{
            //    if (n <= 1)
            //    {
            //        break;
            //    }
            //    m *= n;
            //    n--;
            //} while (true); //interesting! this loop has a semi-colon at the end.


            //Console.WriteLine(m);


            //int i;

            //for(i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}


            Console.WriteLine("Enter a number.");
            int userNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a larger number as an exponent.");
            int userExponent = int.Parse(Console.ReadLine());

            int result = 1;

           for(int i = 0; i < userExponent; i++)
            {
                userNumber *= userExponent;
            }
            Console.WriteLine(userNumber);

        }
    }
}
