using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Malathi_CSharp_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10, j = 20, k = 30;

            if (i > j && i > k)   //Highest number of 3 numbers
            {
                Console.WriteLine("Highest of 3 numbers are: " + i);

            }

            if (j > i && j > k)
            {
                Console.WriteLine("Highest of 3 numbers are:" + j);
            }

            if (k > i && k > j)
            {
                Console.WriteLine("Highest of 3 numbers are:" + k);
            }
            Console.ReadLine();


            if (i < j && i < k)   //Lowest number of 3 numbers
            {
                Console.WriteLine("Lowest of 3 numbers are: " + i);

            }

            if (j < i && j < k)
            {
                Console.WriteLine("Lowest of 3 numbers are:" + j);
            }

            if (k < i && k < j)
            {
                Console.WriteLine("Lowest of 3 numbers:" + k);
            }
            Console.ReadLine();

            int a, b, c;
            Console.WriteLine("enter 3 numbers:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)   //Highest number of 3 numbers
            {
                Console.WriteLine("Highest of 3 numbers are: " + a);

            }

            if (b > a && b > c)
            {
                Console.WriteLine("Highest of 3 numbers are:" + b);
            }

            if (c > a && c > b)
            {
                Console.WriteLine("Highest of 3 numbers:" + c);
            }
            //Console.ReadLine();


            if (a < b && a < c)   //Lowest number of 3 numbers
            {
                Console.WriteLine("Lowest of 3 numbers are: " + a);

            }

            if (b < a && b < c)
            {
                Console.WriteLine("Lowest of 3 numbers are:" + b);
            }

            if (c < a && c < b)
            {
                Console.WriteLine("Lowest of 3 numbers:" + c);
            }
            //Console.ReadLine();


            //Even number of 3 numbers

            if (a % 2 == 0)
            {
                Console.WriteLine("This is even number:" + a);
            }

            if (b % 2 == 0)
            {
                Console.WriteLine("This is even number:" + b);
            }

            if (c % 2 == 0)
            {
                Console.WriteLine("This is even number:" + c);
            }



            //Console.ReadLine();

            //Odd number of 3 numbers

            if (a % 2 != 0)
            {
                Console.WriteLine("This is odd number:" + a);
            }

            if (b % 2 != 0)
            {
                Console.WriteLine("This is odd number:" + b);
            }

            if (c % 2 != 0)
            {
                Console.WriteLine("This is odd number:" + c);
            }



            Console.ReadLine();

            int[] numbers = { 428, 8, 105, 0, 06, 45 };

            Console.WriteLine("One or more numbers has eight: {0}",
                Array.Exists(numbers, element => element.Equals(8)));

            Console.ReadLine();
        }
    }
}
