using System.Globalization;
using System.Text;

namespace CSharp_EndtoEnd
{
    public class Program
    {
        private static void Greetings()
        {
            Console.WriteLine("You name:");
            string name = Console.ReadLine();
            Console.WriteLine($"Hi {name} What's up !");

        }

        private static void typeCasting()
        {
            //ValueType Variables
            int a = 10;
            double c = 14.56;

            //Reference type variable
            string name = "Sreemathy";
            string age = "35";

            //Implicit Conversion- No data lost (complier handles the conversion)
            Console.WriteLine($"The double value is {a}");

            //Explicit Conversion - data lost
            Console.WriteLine($"Using Cast operator: {(int)c}");
            Console.WriteLine($"Using Convert Class: My age is {Convert.ToInt32(age)}");
            Console.WriteLine($"Using Parse()Method: {int.Parse(age)}");
            if (int.TryParse(name, out a))
            {
                Console.WriteLine($"Using TryParse() Method {name}");
            }
            string aValue = a.ToString();
            Console.WriteLine($"Using ToString() Method: {aValue}");
        }

        private static void stringFunctions()
        {
            string randString = "Hi everyone. This is a sample.";
            Console.WriteLine($"String Length = {randString.Length}");
            Console.WriteLine($"String contains everyone = {randString.Contains("everyone")}");
            Console.WriteLine($"Index of everyone = {randString.IndexOf("everyone")}");
            Console.WriteLine($"REmove String = {randString.Remove(12)}");
            Console.WriteLine($"Insert String = {randString.Insert(12, "Added new ")}");
            Console.WriteLine($"Replace string = {randString.Replace("everyone", "Sree")}");
            Console.WriteLine($"Compare 2 strings results {String.Compare(randString, "Hi everyone.This is a sample.")}");
        }

        private static void arrayFunctions()
        {
            int[] arr = new int[2];
            arr[0] = 1;
            arr[1] = 2;
            int[] arr2 = { 1, 5, 8, 2, 4, 9, 3 };
            string[] employees = { "Sam", "Peter", "Mike" };
            var clients = new[] { "Meta", "Amazon", "Walmart" };
            object[] managers = { "Maxima", 52, 5.25 };
            Console.WriteLine($"Array size is : {managers.Length}");
            foreach (var manager in managers)
            {
                Console.WriteLine(manager.ToString());
            }

            int[] sortarray = (int[])arr2.Clone();
            Array.Sort(sortarray);
            int[] reversedArr = sortarray.Reverse().ToArray(); // Stores the reversed sorted array in a new variable

            Console.WriteLine($"Sorted array = {string.Join(", ", sortarray)}");
            Console.WriteLine($"Reversed sorted array = {string.Join(", ", reversedArr)}");
        }

        private static void basicExceptions()
        {
            try
            {
                Console.WriteLine("Enter number 1: ");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number 2: ");
                int number2 = Convert.ToInt32(Console.ReadLine());
                if (number1 > 10)
                {
                    throw new Exception();
                }
                int sum = number1 + number2;
                Console.WriteLine(sum.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sree custom error handling ......... " + ex.Message);

            }
            finally
            {
                Console.WriteLine("Clean up code goes here!");
            }
        }

        static void exploreStringBuilder()
        {
            StringBuilder sb = new StringBuilder("Random Text");

            // Create a StringBuilder with a size of 256
            StringBuilder sb2 = new StringBuilder("More Stuff that is very important", 256);

            // Get max size
            Console.WriteLine("Capacity : {0}", sb2.Capacity);

            // Get length
            Console.WriteLine("Length : {0}", sb2.Length);

            // Add text to StringBuilder
            sb2.AppendLine("\nMore important text");

            // Define culture specific formating
            CultureInfo enUS = CultureInfo.CreateSpecificCulture("en-US");

            // Append a format string
            string bestCust = "Bob Smith";
            sb2.AppendFormat(enUS, "Best Customer : {0}", bestCust);

            // Output StringBuilder
            Console.WriteLine(sb2.ToString());

            // Replace a string
            sb2.Replace("text", "characters");
            Console.WriteLine(sb2.ToString());

            // Clear a string builder
            sb2.Clear();

            sb2.Append("Random Text");

            // Are objects equal
            Console.WriteLine(sb.Equals(sb2));

            // Insert at an index
            sb2.Insert(11, " that's Great");

            Console.WriteLine("Insert : {0}", sb2.ToString());

            // Remove number of characters starting at index
            sb2.Remove(11, 7);

            Console.WriteLine("Remove : {0}", sb2.ToString());
        }

        static void exploreMethodParameter(int x, int y, ref int i, out int j)
        {
            Console.WriteLine(x + y);
            x++; y++; i++;
            j = x + y;
            Console.WriteLine($"Now the value of x = {x} , y = {y} , i = {i} and j = {j} inside the Method");
        }

        public static void Main(string[] args)
        {
            #region exploreMethodParameter
            //Understanding Passing by value,Reference,Out
            int x = 5, y = 6, i = 10, j = 11;
            Console.WriteLine($"Now the value of x = {x} , y = {y} , i = {i} and j = {j} before calling the method");

            exploreMethodParameter(x, y, ref i, out j);
            Console.WriteLine($"Now the value of x = {x} , y = {y} , i = {i} and j = {j} after calling the method");
            #endregion

            //exploreStringBuilder();
            //basicExceptions();
            //arrayFunctions();
            //stringFunctions(); 
            //Greetings();
            //typeCasting();
            Console.ReadLine();
        }
    }
}