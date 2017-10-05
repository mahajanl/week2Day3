using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = Add(2, 3);
            Console.WriteLine(answer);
        }

        public static int Add(int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber;

            return sum;
        }

    }
}
