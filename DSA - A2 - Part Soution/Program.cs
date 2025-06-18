using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Task_2___Random_Number_Generation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SplitMix64 rng = new SplitMix64();
            List<ulong> numbers = new List<ulong>();

            Console.WriteLine("Generating 100 random numbers between 1 and 1000...");
            for (int i = 0; i < 100; i++)
            {
                ulong value = rng.Next(1, 1000);
                numbers.Add(value);
                Console.Write(value + " ");
            }

            Console.WriteLine("\n\nChecking if all values are within range 1–1000: " +
                (numbers.TrueForAll(n => n >= 1 && n <= 1000) ? "✅ Passed" : "❌ Failed"));

            Console.WriteLine("Checking if list is sorted ascending: " +
                (IsSortedAscending(numbers) ? "❌ Sorted" : "✅ Not Sorted"));

            Console.WriteLine("Checking if list is sorted descending: " +
                (IsSortedDescending(numbers) ? "❌ Sorted" : "✅ Not Sorted"));

            Console.WriteLine("\nNow generating timing data for empirical analysis...\n");
            RunBenchmark(1_000);
            RunBenchmark(10_000);
            RunBenchmark(100_000);
            RunBenchmark(1_000_000);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static void RunBenchmark(int count)
        {
            SplitMix64 rng = new SplitMix64();
            Stopwatch sw = new Stopwatch();
            sw.Start();

            for (int i = 0; i < count; i++)
            {
                rng.Next(1, 1000);
            }

            sw.Stop();
            Console.WriteLine($"Time to generate {count:N0} numbers: {sw.ElapsedMilliseconds} ms");
        }

        static bool IsSortedAscending(List<ulong> list)
        {
            for (int i = 1; i < list.Count; i++)
                if (list[i] < list[i - 1]) return false;
            return true;
        }

        static bool IsSortedDescending(List<ulong> list)
        {
            for (int i = 1; i < list.Count; i++)
                if (list[i] > list[i - 1]) return false;
            return true;
        }
    }
}
