using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment21_p_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           OurClass obj= new OurClass();
            // Prompt the user to input two integers
            Console.Write("Enter the first integer: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int num2 = int.Parse(Console.ReadLine());

            // Prompt the user to choose an arithmetic operation
            Console.WriteLine("Choose an arithmetic operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            Console.Write("Enter your choice (1-4): ");
            int choice = int.Parse(Console.ReadLine());

            // Perform the selected arithmetic operation using the corresponding delegate
            int result = 0;
            switch (choice)
            {
                case 1:
                    result = obj.AdditionDelegate(num1, num2);
                    break;
                case 2:
                    result = obj.SubtractionDelegate(num1, num2);
                    break;
                case 3:
                    result = obj.MultiplicationDelegate(num1, num2);
                    break;
                case 4:
                    result = obj.DivisionDelegate(num1, num2);
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }

            // Display the result
            Console.WriteLine($"Result: {result}");
            Console.ReadKey();
        }


        
    }
}

