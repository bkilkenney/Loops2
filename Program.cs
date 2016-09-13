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

            //For study session. Do-While were stuck on

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




            //for Loop

            // Console.WriteLine("Enter a number.");
            // int userNumber = int.Parse(Console.ReadLine());

            // Console.WriteLine("Enter a larger number as an exponent.");
            // int userExponent = int.Parse(Console.ReadLine());

            // int result = 1;

            //for(int i = 0; i < userExponent; i++)
            // {
            //     userNumber *= userExponent;
            // }
            // Console.WriteLine(userNumber);



            //Continue.  


            //sums all odd numbers 1 to n.
            //except if number is evenly divisible by 7

            //int n = int.Parse(Console.ReadLine());
            //int sum = 0;
            //for (int i = 1; i <= n; i += 2)
            //{
            //    if (i % 7 == 0)
            //    {
            //        continue;
            //    }
            //    sum += i;
            //}
            //Console.WriteLine("sum = " + sum);




            ////sum even numbers unless number is divisible by 6
            //            int n = int.Parse(Console.ReadLine());
            //            int sum = 0;

            //            for (int i = 1; i <= n; i += 2)
            //            {
            //                if (i % 6 == 0)
            //                {
            //                    continue;
            //                }

            //            sum += i;
            //            }

            //            Console.WriteLine("sum = " + sum);



            //For each loops
            //string[] cities = { "New York", "London", "Paris" };

            //foreach(string newStringCity in cities)
            //{
            //    Console.WriteLine("I love " + newStringCity);
            //}







            string[] favFoods = { "Nestle", "Lamb", "Pizza" };

            foreach (string individualFoods in favFoods)
            {
                Console.WriteLine("I love " + individualFoods);
            }

        }
    }
}
