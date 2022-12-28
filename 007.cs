// working with private functions and function calling methods
using System;

namespace Methods {
    class Program {
        // a private function that only can be accessed by this class
        static int factorial(int num) {
            // function to calculate factorial of given number
            int fact = 1;
            for (int i = 1; i <= num; i++) {
                fact = fact * i;
            }
            return fact;
        }

        public static void method() {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int fact = factorial(num);
            Console.WriteLine($"Factorial of {num} = {fact}");
        }
    }
}