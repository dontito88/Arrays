﻿namespace LastKnumbersSum
{
    using System;

    public class LastKnumbersSum
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            n = Math.Abs(n);
            k = Math.Abs(k);

            int[] sequence = new int[n];
            sequence[0] = 1;
            if (n > k)
            {
                for (int i = 1; i <= k; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        sequence[i] += sequence[j];
                    }
                }

                for (int i = k + 1; i < n; i++)
                {
                    for (int j = i - k; j < i; j++)
                    {
                        sequence[i] += sequence[j];
                    }
                }
            }
            else
            {
                for (int i = 1; i < n; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        sequence[i] += sequence[j];
                    }
                }
            }


            foreach (var item in sequence)
            {
                Console.Write(item + " ");
            }
        }
    }
}
