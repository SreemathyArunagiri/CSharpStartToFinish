using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStarttoFinish._8_Generic_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Topics Covered...
             * Generic Collections
             * List<T>
             * Stack<T>, Queue<T>,Dictionary<TKey, TValue>
             * Generic Structs
             * Delegates and Generic Delegates
             */

            List<ArithOperation> animalList = new List<ArithOperation>();

            List<int> numList = new List<int>();

            numList.Add(24);

            // Add Animals
            animalList.Add(new ArithOperation() { Name = "Doug" });
            animalList.Add(new ArithOperation() { Name = "Paul" });
            animalList.Add(new ArithOperation() { Name = "Sally" });

            // Insert in index 1
            animalList.Insert(1, new ArithOperation() { Name = "Steve" });

            // Remove index 1
            animalList.RemoveAt(1);

            // Get number of Animals
            Console.WriteLine("Num of Animals : {0}",
                animalList.Count());

            // Cycle through Animals
            foreach (ArithOperation a in animalList)
            {
                Console.WriteLine(a.Name);

            }


            int x = 5, y = 4;
            ArithOperation.GetSum<int>(ref x, ref y);

            // It works for strings as well
            string strX = "5", strY = "4";
            ArithOperation.GetSum(ref strX, ref strY);

            // Use the generic struct
            Rectangle<int> rec1 = new Rectangle<int>(20, 50);
            Console.WriteLine(rec1.GetArea());

            Rectangle<string> rec2 = new Rectangle<string>("20", "50");
            Console.WriteLine(rec2.GetArea());


            // Create delegate instances and assign methods
            Arithmetic add = Add;
            Arithmetic sub = Subtract;
            Arithmetic addSub = add + sub;

            // Invoke the delegate
            Console.WriteLine($"Add {6} & {10} :"); add(6, 10);
            Console.WriteLine($"Sub {10} & {6}"); sub(10, 6);
            Console.WriteLine($"Add & Subtract {10} & {4}"); addSub(10, 4);


            Arithmetic<double> multi = Multiply<double>;
            Arithmetic<int> multiInt = Multiply<int>;
            Console.WriteLine($"Multiply 10.85 & 4.69 = {multi(10.85, 4.69)}");
            Console.WriteLine($"Multiply 10 & 4 = {multiInt(10, 4)}");
            Console.ReadLine();

        }

        // You can also create generic structs
        // and classes
        public struct Rectangle<T>
        {
            // Generic fields
            private T width;
            private T length;

            // Generic properties
            public T Width { get; set; }
            public T Length { get; set; }

            // Generic constructor
            public Rectangle(T w, T l)
            {
                this.width = w;
                this.length = l;
            }

            public string GetArea()
            {
                double dblWidth = Convert.ToDouble(Width);
                double dblLength = Convert.ToDouble(Length);
                return string.Format($"{Width} * {Length} = {dblWidth * dblLength}");
            }
        }

        // Declare a delegate 
        public delegate void Arithmetic(double num1, double num2);

        //  Define methods that match the delegate signature
        public static void Add(double num1, double num2)
        {
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        }
        public static void Subtract(double num1, double num2)
        {
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        }

        #region Generic Delegate
        delegate T Arithmetic<T>(T num1, T num2);

        static T Multiply<T>(T num1, T num2) where T : notnull
        {
        return (dynamic)num1 * num2;
        }
        
        #endregion
    }
}
