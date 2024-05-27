using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class LINQMethods
    {
        public static void main()
        {
            List<string> jmena_list = ["Lukas", "Karel", "Tomas", "Martin", "Radim", "Sofian", "Jakub"];

            Console.WriteLine(String.Join(", ", jmena_list));

            int[] numbers = [13, 32335, -18, 0, 23, 233, 0, -12, 1235, -16000, 128933484];

            // WHERE - filtr
            var kladna = numbers.Where(number => number > 0);

            // ORDER BY
            var ordered = numbers.OrderBy(number => number);

            // TAKE, SKIP
            var first5 = numbers.Take(5);
            var skip5 = numbers.Skip(5);

            // MAX, MIN, SUM, AVG - agregacni
            var sum = numbers.Sum(number => number);
            var max = numbers.Max(number => number);

            Console.WriteLine($"sum: {sum}");
            Console.WriteLine($"max: {max}");

            //SELECT - transformace
            var positives = numbers.Select(number => Math.Abs(number));
            Console.WriteLine($"positives {String.Join(", ", positives)}");

            //ALL, ANY
            bool all_positive = numbers.All(x => x > 0);
            bool atleastone_positive = numbers.Any(x => x > 0);


            foreach (int number in kladna)
            {
                Console.WriteLine(number);
            }

        }
        public static void ukol()
        {
            int[] numbers = { 11, 2, 13, 97542, 44, -5, 6, 127, -99, 0, 256, 0, 12, 11 };

            // 1.  kolik obsahuje pole kladných čísel
            // 2.  kolik obsahuje pole záporných čísel
            // 3.  sumu kladných hodnot
            // 4.  největší absolutní hodnotu
            // 5.  všechna kladná sudá čísla
            // 6.  seřaďte pole od nejmenších po největší hodnoty,
            // 7.   přeskočte první 3 prvky a sečtěte zbytek hodnot

            Console.WriteLine($"numbers: {String.Join(", ", numbers)}");

            var positives = numbers.Where(number => number > 0);
            Console.WriteLine($"positives: {String.Join(", ", positives)}");
            
            var negatives = numbers.Where(number => number < 0);
            Console.WriteLine($"negatives: {String.Join(", ", negatives)}");

            var sum_positives = numbers.Where(number => number > 0).Sum(number => number);
            Console.WriteLine($"sum_positives: {String.Join(", ", sum_positives)}");

            var max_absolute = numbers.Select(number => Math.Abs(number)).Max(number => number);
            Console.WriteLine($"max_absolute: {String.Join(", ", max_absolute)}");

            var positive_even = positives.Where(number => number % 2 == 0);
            Console.WriteLine($"positive_even: {String.Join(", ", positive_even)}");

            var ordered = numbers.OrderBy(number => number);
            Console.WriteLine($"ordered: {String.Join(", ", ordered)}");

            var sum_skipped = numbers.Skip(3).Sum(number => number);
            Console.WriteLine($"sum_skipped: {String.Join(", ", sum_skipped)}");


            //pocet pismen
            var fruits = new[] { "aPPLE", "BlUeBeRrY", "cHeRry", "RaspbeRry" };
            var letter_count = fruits.Select(f => f.Length).Sum();
            Console.WriteLine($"dohromady pismen: {letter_count}");

            //lowercase
            var fruits_lower = fruits.Select(f => f.ToLower());
            Console.WriteLine($"fruits_lower: {String.Join(", ", fruits_lower)}");

            //anonymni typ
            //upper+lower
            var fruits_combo = fruits.Select(x => new { Uppercase = x.ToUpper(), Lowercase = x.ToLower() });
            Console.WriteLine($"fruits_combo: {String.Join(", ", fruits_combo)}");

            var sweet_cats = fruits.Select(fruit => new Animal(fruit, Species.CAT));



            var numbers2 = new[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var strings = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            // vypište čísla v poli numbers jako slova

            var num_strings = numbers2.Select(n => strings[n]);
            Console.WriteLine($"num_strings: {String.Join(", ", num_strings)}");


        }

    }
}
