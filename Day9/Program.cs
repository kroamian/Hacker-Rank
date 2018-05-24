using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    class Program
    {
        static int factorial(int n)
        {
            // Complete this function
            int resulte = 1;
            if (n > 0)
            {
                resulte = n * factorial(n - 1);
            }

            return resulte;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int result = factorial(n);
            Console.WriteLine(result);



            int num;
            Console.Write("Enter a Number : ");
            num = int.Parse(Console.ReadLine());
            int quot;
            string rem = "";
            while (num >= 1)
            {
                quot = num / 2;
                rem += (num % 2).ToString();
                num = quot;
            }
            string bin = "";
            int count = 0;
            int Max = 0;
            for (int i = rem.Length - 1; i >= 0; i--)
            {
                bin = bin + rem[i];
                if(rem[i]=='1')
                {
                    count++;
                    if(Max < count)
                    {
                        Max = count;
                    }
                }
                else
                {
                    count = 0;
                }
            }
          
            Console.WriteLine("The Binary format for given number is {0}, {1}", bin, Max);
            Console.Read();
        }
    }
}
