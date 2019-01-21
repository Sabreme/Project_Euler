using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            //problem2();

            problem3();
            Console.ReadKey();
        }

        private void problem1()
        {
            int max = 1000;
            int sum = 0;
            for (int i = 0; i < max; i++)
            {
                if (i % 3 == 0)
                {
                    sum += i;
                    continue;
                }

                if (i % 5 == 0)
                {
                    sum += i;
                    continue;
                }
            }
            Console.WriteLine(sum);
        }

        private static void problem2()
        {
            Functions myFunction = new Functions();
            int max = 40;
            int sum = 0;
            int value = 0;

            for (int i = 1; i <= max; i++)
            {
                value = myFunction.fib(i);
                if (value > 4000000)
                    break;

                if (value % 2 == 0)
                {
                    sum += value;
                    
                }

                Console.Write($"{value}, ");
            }

            Console.WriteLine("Final sum is: " + sum);
        }

        private static void problem3()
        {
            Functions functions = new Functions();

            Console.WriteLine(
                functions.IsPrime(13)
                    ? "prime"
                    : "Not Prime");
                

        }

        


    }    
}
