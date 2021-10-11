using System;

namespace krtg
{
    class Program
    {
        static void Main(string[] args)
        {
            var tuple = GetValues();
            Console.WriteLine(tuple.Item1); // 1
            Console.WriteLine(tuple.Item2); // 3
            Console.WriteLine(tuple.Item3);
            Console.WriteLine(tuple.Item4);

            Console.Read();
        }
        private static (int, int, string, string) GetValues()
        {
            var result = (1, 3, "Привет", ":)");
            return result;
        }
    }
}
