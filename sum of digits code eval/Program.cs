using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_digits_code_eval
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "496";// assign a string variable already assigned in code evil
            char[] digits = line.ToCharArray();
            int sumTotal = 0;
            foreach (char digit in digits)
            {
                sumTotal += int.Parse(char.ToString(digit));
            }

            Console.WriteLine(sumTotal); 
        }
    }
}
