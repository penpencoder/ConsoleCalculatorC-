using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Console Calculator!");
            Console.WriteLine("-----------------------------------\n");

            Console.WriteLine("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-----------------------------------\n");
            Console.WriteLine("Choose an Operator from the list: ");

            Console.WriteLine("\t a = Add");
            Console.WriteLine("\t s = Subract");
            Console.WriteLine("\t m = Multiply");
            Console.WriteLine("\t d = Divide");

            var operation = Console.ReadLine();

            switch (operation) {

                case "a":
                    Console.WriteLine("The answer is "+ (num1+num2));
                    break;
                case "s":
                    Console.WriteLine("The answer is " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine("The answer is " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine("The answer is " + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("Choose an operator!");
                    break;
            }



        }
    }
}
