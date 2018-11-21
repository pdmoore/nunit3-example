using System;

namespace csharp {
    public static class Fizzbuzz {
        public static string Convert(int number) {
            if (number > 100) {
                throw new ArgumentException("bar");
            }
            if (number % 3 == 0) return "Fizz";
            return "1";
        }
    }
}