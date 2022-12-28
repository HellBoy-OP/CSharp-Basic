// snippet to take two inputs and print the sum of it
using System;

namespace UserInput {
    class Program {
        public static void userinput() {
            int a, b;
            Console.Write("Enter the value of 'a': ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of 'b': ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($">> {a} + {b} = {a+b}");
        }
    }
}
