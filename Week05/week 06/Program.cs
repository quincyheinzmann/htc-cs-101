using System;

namespace week_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int userInput =Convert.ToInt32(Console.ReadLine());
            printEven(userInput);
        }
         public static void printEven(int evenOrOdd)
         {
            int x = 0;
             while (x >= 100){

             if (evenOrOdd % 2 == 0){
                 Console.WriteLine("Your number is even");
             }
             else 
                {
                 Console.WriteLine("Your number is odd");
                }

            evenOrOdd++;
             }
         }
    }
}
