using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundingNumbers
{
    class RoundingNumbers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().Trim();
            var numbers = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            double[] array = new double[numbers.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = double.Parse(numbers[i]);

                Console.WriteLine("{0} => {1}", array[i], Math.Round(array[i], MidpointRounding.AwayFromZero));
            }
        }
    }
}
