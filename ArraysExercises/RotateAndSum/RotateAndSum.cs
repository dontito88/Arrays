using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateAndSum
{
    class RotateAndSum
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] parsedNumbers = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                parsedNumbers[i] = int.Parse(input[i]);
            }

            int n = int.Parse(Console.ReadLine());
            int[] sum = new int[parsedNumbers.Length];

            for (int i = 0; i < n; i++)
            {
                int lastNumber = parsedNumbers[parsedNumbers.Length - 1];

                for (int j = parsedNumbers.Length - 1; j > 0; j--)
                {
                    parsedNumbers[j] = parsedNumbers[j - 1];
                }
                parsedNumbers[0] = lastNumber;

                for (int j = 0; j < parsedNumbers.Length; j++)
                {
                    sum[j] += parsedNumbers[j];
                }
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
