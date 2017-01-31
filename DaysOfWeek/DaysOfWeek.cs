namespace DaysOfWeek
{
    using System;

    public class DaysOfWeek
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            //Console.WriteLine(Day(n));
            switch(n)
            {
                case 1: Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default: Console.WriteLine("Invalid day!");
                    break;
            }
        }

        //private static string Day(int n)
        //{
        //    if (n < 0 || n > 7)
        //    {
        //        return "Invalid day!";
        //    }
        //    string[] days = {"Invalid day!", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday",
        //    "Saturday", "Sunday"};
        //    return Day(n);
        //}
    }
}
