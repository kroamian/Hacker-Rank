using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";
            int sumi = 0;
            double sumd = 0.0;
            string adds = string.Empty;
            int.TryParse(Console.ReadLine(), out sumi);
            double.TryParse(Console.ReadLine(), out sumd);
            adds = Console.ReadLine();
            
            Console.WriteLine(sumi + i);
            Console.WriteLine(string.Format("{0:0.0}", d + sumd));
            Console.WriteLine(s + adds);
            

            Console.Read();
            
        }
    }
}
