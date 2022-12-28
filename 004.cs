// Calculator menu console app using switch case in c#
using System;

namespace Switch {
    class Program {
        public static void switchcase() {
            Console.WriteLine(
                "----  Calculator Menu  ----\n"
                + "1. Addition\n"
                + "2. Subtraction\n"
                + "3. Multiplication\n"
                + "4. Division"
            );
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter two numbers to perform this operation: ");
            int num1 = Convert.ToInt32(Console.ReadLine());            
            int num2 = Convert.ToInt32(Console.ReadLine());
            switch (choice) {
                case 1:
                    Console.WriteLine($">> {num1} + {num2} = {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($">> {num1} - {num2} = {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($">> {num1} * {num2} = {num1 * num2}");
                    break;
                case 4:
                    Console.WriteLine($">> {num1} / {num2} = {num1 / num2}");
                    break;
                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }
        }
    }
}