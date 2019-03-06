using System;

namespace Week05
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Console.WriteLine("What is the first number?");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the second number?");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Addition or subtraction?");
            string operation = Console.ReadLine();

            if (operation == "+") {
                Console.WriteLine(AddNumbers(firstNum, secondNum));
            }
            else if (operation == "-") {
                int difference = SubtractNumbers(firstNum, secondNum);
                Console.WriteLine(difference);
            }
            else {
                Console.WriteLine("Invalid Operation");
            }*/
            Console.WriteLine("What is the first number?");
            int firstInt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the second number?");
            int secondInt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Multiplication or division?");
            string operation2 = Console.ReadLine();

            if (operation2 == "*") {
                Console.WriteLine(MultiplyNumbers(firstInt, secondInt));
            }
            else if (operation2 == "/") {
                Console.WriteLine(DivideNumbers(firstInt, secondInt));
            }
            else {
                Console.WriteLine("Invalid Operation");
            }
        }

        public static int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int SubtractNumbers(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int MultiplyNumbers(int integer1, int integer2) 
        {
            return integer1 * integer2;
        }
        public static int DivideNumbers(int integer1, int integer2)
        {
            return integer1/integer2;
        }
    }
}
