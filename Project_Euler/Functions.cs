using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public class Functions
    {

        public  bool IsPrime(int value)
        {
            for (int i = 2; i < value / 2; i++)
            {
                if (value % i == 0)
                    return true;
            }
            return false;
        }

        public  int fib(int num1)
        {
            if (num1 == 1)
                return 1;

            if (num1 == 2)
                return 2;
            else

                //Console.WriteLine(num1);
                return fib(num1 - 1) + fib(num1 - 2);
        }
    }
}
