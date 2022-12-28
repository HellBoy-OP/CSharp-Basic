// snippets of break & continue statements
using System;

namespace Break {
    class Program {
        public static void breaks() {
            // take input until 0 is passed
            while (true) {
                Console.Write("Enter a number: ");
                int i = Convert.ToInt32(Console.ReadLine());
                if (i == 0) {
                    break;
                }
            }
        }
    }
}

namespace Continue {
    class Program {
        public static void continues() {
            // sum of all odd numbers using continue statement
            int sum=0;
            Console.Write("Enter a num: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n; i++) {
                if (i % 2 == 0) {
                    continue;
                }
                sum = sum + i;
            }
            Console.Write(sum);
        }
    }
}