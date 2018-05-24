using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    class Program
    {
        static void Main(string[] args)
        {
            int entries = Convert.ToInt32(Console.ReadLine());

            Dictionary<string, string> PhoneBook = new Dictionary<string, string>();
            for(int i = 0; i>entries; i++)
            {
                string entry = Console.ReadLine();
                string[] arrentry = entry.Split(' ');
                PhoneBook.Add(arrentry[0], arrentry[1]);
            }
  

            List<string> search = new List<string>();

            string toserach = string.Empty;
            while(Console.ReadLine().Length > 0)
            {
                Console.Write(Console.ReadLine());
            }

        }
    }
}
