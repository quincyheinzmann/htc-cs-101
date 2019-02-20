using System;

namespace Week03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Make a decision!

            Console.WriteLine("What is the temperature ouside?");
            int outsideTemperature = Convert.ToInt32(Console.ReadLine());

            if (outsideTemperature <= 25) {
                Console.WriteLine("You should probably wear a coat.");
            }
            else if ((outsideTemperature >= 26) && (outsideTemperature <= 50)) {
                Console.WriteLine("Wear sunglasses :)");
            }
            else {
                Console.WriteLine("Try not to die.");
            }
            Console.WriteLine("Guess a number between one (1) and ten (10).");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 4) {
                Console.WriteLine("Too high!");
            }
            else if (num < 4) {
                Console.WriteLine("Too low");
            }
            else {
                Console.WriteLine("Just right :)");
            }
        }
    }
}
