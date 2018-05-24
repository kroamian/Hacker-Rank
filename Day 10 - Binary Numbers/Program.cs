using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());



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
            if (rem[i] == '1')
            {
                count++;
                if (Max < count)
                {
                    Max = count;
                }
            }
            else
            {
                count = 0;
            }
        }

        Console.WriteLine(Max);
        Console.Read();
    }
}
