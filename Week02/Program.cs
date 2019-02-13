using System;

namespace Week02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create variables and do things with them!
            Console.WriteLine("Hello World");
            string myName = "Quincy";
            int myAge = 13;
            string favColor = "light gray";
            string myHobby = "reading";
            bool isOldEnoughToDrive = false;
            double myHeight = 5.16;
            char firstInitial = 'q';

            Console.WriteLine("My name is " + myName);
            Console.WriteLine("My age is {0}", + myAge);
            Console.WriteLine("My favorite color is " + favColor);
            Console.WriteLine("My favorite hobby is " + myHobby);
            Console.WriteLine("My height is " + myHeight + " feet tall.");
            Console.WriteLine("My first initial is " + firstInitial);
            Console.WriteLine("I am old enough to drive. " + isOldEnoughToDrive);
        }
    }
}
