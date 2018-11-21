using System;

namespace csharp {
    public static class Fizzbuzz {
        public static string Of(int number) {
            if (number > 100) {
                throw new ArgumentException("Number must be within 1 to 100");
            }
            if (number % 3 == 0) return "Fizz";
            return "1";
        }
    }
}