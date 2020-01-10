using System;
namespace Speedlimit
{
    public class Calculator
    {
        public int Max(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine("Your are going to fast by " + (a - b) + "km/h, Please slow down. ");
                //calculate points
                var points = (a - b) / 5;
                // your license loses .. points
                Console.WriteLine("You lost " + points + " points");
                if (points > 12)
                {
                    Console.WriteLine("This causes you to lose your license.");
                }
                return 1;
            }
            else
            {
                Console.WriteLine("You are driving the speed limit");
                return 0;
            }
        }
    }
}
