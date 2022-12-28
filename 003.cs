// snippet to find the number is odd or even
using System;

namespace If_Else {
    class Program {
        public static void ifelse() {
            Console.Write("Enter a Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0) {
                Console.WriteLine($"The number {num} is Even!");
            }
            else {
                Console.WriteLine($"The number {num} is Odd!");
            }
        }
    }
}