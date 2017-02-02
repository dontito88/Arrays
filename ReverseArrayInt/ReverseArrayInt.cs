namespace ReverseArrayInt
{
    using System;

    public class ReverseArrayInt
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            int [] numbers = new int [n];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
