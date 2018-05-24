using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Program
    {
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            string[] Words = new string[10];
            int tests = Convert.ToInt16(Console.ReadLine());
            while(tests >= 10)
            {
                Console.Write("Please intoduce a number minor");
                tests = Convert.ToInt16(Console.ReadLine());
            }
            for (int i = 0; i < tests; i++)
            {
                Words[i] = Console.ReadLine();
            }

            for (int i = 0; i < tests; i++)
            {
                ModiyString(Words[i]);
            }


        }

        static void ModiyString(string word)
        {
            string odd = string.Empty;
            string Pair = string.Empty;
            for (int i = 0; i < word.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Pair += word.Substring(i, 1);
                }
                else
                {
                    odd += word.Substring(i, 1);
                }
            }
            Console.WriteLine("{0} {1}", Pair, odd);

        }
    }
}
