// snippets of all the loops in c#
using System;

namespace Loop{
    class Program {
        public static void while_loop() {
            // sum of all even numbers till n using while loop
            int i = 0, result=0;
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            while (i <= n) {
                if (i % 2 == 0) {
                    result = result + i;
                }
                i++;
            }
            Console.WriteLine($"Sum of all even numbers from 1 to {n} is: {result}");
        }

        public static void do_while_loop() {
            // sum of all odd numbers till n using do while loop
            int i = 0, result = 0;
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            do {
                if (i % 2 != 0) {
                    result = result + i;
                }
                i++;
            } while (i <= n);
            Console.WriteLine($"Sum of all odd numbers from 1 to {n} is: {result}");
        }

        public static void for_loop() {
            // find all the factors of input number
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Factors of {n}: ");
            for (int i = 1; i <= n; i++) {
                if (n % i == 0) {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}