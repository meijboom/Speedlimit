using System;

namespace Speedlimit
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("What is the Speedlimit?");
            var speedlimit = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your current speed?");
            var currentSpeed = int.Parse(Console.ReadLine());
            calculator.Max(currentSpeed, speedlimit);
        }
    }
}
