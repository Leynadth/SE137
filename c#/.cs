using System;

namespace Week1_Sample1
{
    class Program
    {
        static void Main(string[] args)
        {
            string strFirst, strOperand, strNum1, strNum2;
            int intNum1 = 0, intNum2 = 0, intResult = 0;
            double dblResult;

            Console.WriteLine("Hello There!");

            Console.Write("Please enter your first name: ");
            strFirst = Console.ReadLine();

            Console.WriteLine("Hello " + strFirst + "! Let's do some math!");

            Console.Write("Please enter the first number: ");
            strNum1 = Console.ReadLine();

            Console.Write("Please enter the math operation (PLUS, MINUS, MULTIPLY, DIVIDE): ");
            strOperand = Console.ReadLine().ToUpper(); // Convert operand to uppercase

            Console.Write("Please enter the second number: ");
            strNum2 = Console.ReadLine();

            intNum1 = int.Parse(strNum1);
            intNum2 = int.Parse(strNum2); // Convert strNum2 to an integer

            switch (strOperand)
            {
                case "PLUS":
                    intResult = intNum1 + intNum2;
                    dblResult = intResult; // Convert intResult to double
                    break;
                case "MINUS":
                    intResult = intNum1 - intNum2;
                    dblResult = intResult; // Convert intResult to double
                    break;
                case "MULTIPLY":
                    intResult = intNum1 * intNum2;
                    dblResult = intResult; // Convert intResult to double
                    break;
                case "DIVIDE":
                    dblResult = (double)intNum1 / intNum2; // Convert intNum1 to double
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    Environment.Exit(1); // Exit the program for an invalid operation
                    break;
            }

            Console.WriteLine($"\nThe result of {intNum1} {strOperand} {intNum2} equals: {dblResult}");

            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }
    }
}
