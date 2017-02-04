using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedStringArray
{
    class ReversedStringArray
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            Array.Reverse(input);
            foreach (var item in input)
            {
                Console.Write(item + " ");
            }
        }
    }
}
