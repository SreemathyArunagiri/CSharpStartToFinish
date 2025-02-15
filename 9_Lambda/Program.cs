using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStarttoFinish.Lambda
{
    class Program
    {
        static void Main(string[] args) 
        { 
            // Initializing a list of numbers
            List<int> numList = new List<int> { 1, 9, 2, 6, 3, 8, 5, 7, 4, 10 };

            // Filtering: Get even numbers
            var evenList = numList.Where(a => a % 2 == 0).ToList();
            Console.WriteLine($"Even numbers: {string.Join(", ", evenList)}");

            //Sorting: Order by ascending
            var sortedList = numList.OrderBy(a => a).ToList();
            Console.WriteLine($"Sorted (Ascending): {string.Join(", ", sortedList)}");

            //Sorting: Order by descending
            var descSortedList = numList. (a => a).ToList();
            Console.WriteLine($"Sorted (Descending): {string.Join(", ", descSortedList)}");

            // Transformation: Multiply each number by 2 (Projection)
            var multipliedList = numList.Select(a => a * 2).ToList();
            Console.WriteLine($"Multiplied by 2: {string.Join(", ", multipliedList)}");

            //Find First Even Number
            var firstEven = numList.FirstOrDefault(a => a % 2 == 0);
            Console.WriteLine($"First Even Number: {firstEven}");

            //Find Last Odd Number
            var lastOdd = numList.LastOrDefault(a => a % 2 != 0);
            Console.WriteLine($"Last Odd Number: {lastOdd}");

            //Aggregation: Sum of all numbers
            var sum = numList.Sum();
            Console.WriteLine($"Sum of all numbers: {sum}");

            //Aggregation: Find Maximum
            var max = numList.Max();
            Console.WriteLine($"Maximum number: {max}");

            //Aggregation: Find Minimum
            var min = numList.Min();
            Console.WriteLine($"Minimum number: {min}");

            //Aggregation: Find Average
            var avg = numList.Average();
            Console.WriteLine($"Average of numbers: {avg}");

            //Checking Condition: Are all numbers positive?
            var allPositive = numList.All(a => a > 0);
            Console.WriteLine($"Are all numbers positive? {allPositive}");

            //Checking Condition: Any number greater than 5?
            var anyGreaterThanFive = numList.Any(a => a > 5);
            Console.WriteLine($"Is any number greater than 5? {anyGreaterThanFive}");

            //Take First 3 Numbers
            var firstThree = numList.Take(3).ToList();
            Console.WriteLine($"First 3 numbers: {string.Join(", ", firstThree)}");

            //Skip First 3 Numbers
            var skipThree = numList.Skip(3).ToList();
            Console.WriteLine($"After skipping first 3 numbers: {string.Join(", ", skipThree)}");

            //Distinct Numbers (Removing Duplicates)
            List<int> duplicateList = new List<int> { 1, 2, 2, 3, 3, 4, 4, 5 };
            var distinctList = duplicateList.Distinct().ToList();
            Console.WriteLine($"Distinct numbers: {string.Join(", ", distinctList)}");

            //Grouping: Group numbers by even and odd
            var groupedNumbers = numList.GroupBy(a => a % 2 == 0 ? "Even" : "Odd");
            Console.WriteLine("Grouped Numbers:");
            foreach (var group in groupedNumbers)
            {
                Console.WriteLine($"{group.Key}: {string.Join(", ", group)}");
            }

            //Find first number greater than 5
            var findval = numList.Find(a => a> 5);
            Console.WriteLine($"Find first number greater than 5: {findval}");

            //Find all numbers greater than 5
            var findAllVal = numList.FindAll(a => a > 5);
            Console.WriteLine($"Find all numbers greater than 5: {string.Join(", ", findAllVal)}");

            //Find index of first number greater than 5
            var index = numList.FindIndex(a => a > 5);
            Console.WriteLine($"Index of first number greater than 5: {index}");

            //Reverse the list
            var reversedList = numList.AsEnumerable().Reverse().ToList();
            Console.WriteLine($"Reversed list: {string.Join(", ", reversedList)}");

            //Find the name starting with 'S'
            var nameList = new List<string> { "John", "Steve", "Bill", "Sree" };
            var sname = nameList.FindAll(a => a.StartsWith("S"));
            Console.WriteLine($"Names starting with 'S': {string.Join(", ", sname)}");
        }
    }
}
