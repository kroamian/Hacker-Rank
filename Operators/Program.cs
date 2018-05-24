using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine());
            int tip_percent = Convert.ToInt32(Console.ReadLine());
            int tax_percent = Convert.ToInt32(Console.ReadLine());
            double tip = meal_cost * (tip_percent / 100.00);
            double tax = meal_cost * (tax_percent / 100.00);

            double total_meal = meal_cost + tip + tax;
            Console.Write(string.Format("The total meal cost is {0} dollars.", Math.Round(total_meal)));
        }
    }
}
