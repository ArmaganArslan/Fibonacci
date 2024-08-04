using System;
using System.Collections.Generic;

namespace Fibonacci
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Fibonacci serisinin derinliğini girin: ");
            int depth;
            if (!int.TryParse(Console.ReadLine(), out depth) || depth <= 0)
            {
                Console.WriteLine("Geçerli bir derinlik girin.");
                return;
            }

            var fibonacciSequence = FibonacciCalculator.Calculate(depth);

            double average = AverageCalculator.Calculate(fibonacciSequence);

            Console.WriteLine($"Fibonacci serisindeki sayıların ortalaması: {average}");

            Console.WriteLine("Devam etmek için herhangi bir tuşa basın...");
            Console.ReadKey();
        }
    }

    public static class FibonacciCalculator
    {
        public static List<int> Calculate(int depth)
        {
            var sequence = new List<int>();
            int a = 0, b = 1;
            for (int i = 0; i < depth; i++)
            {
                sequence.Add(a);
                int next = a + b;
                a = b;
                b = next;
            }
            return sequence;
        }
    }

    public static class AverageCalculator
    {
        public static double Calculate(List<int> numbers)
        {
            if (numbers.Count == 0)
                return 0;

            double sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum / numbers.Count;
        }
    }
}
