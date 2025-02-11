using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStarttoFinish._2_
{
    internal class Program
    {
        /* Topics Covered...
         * Creating static (Animal.cs) and non-static classes(ShapMath.cs)
         * Constructors and static constructors
         * Structs
         * NULLABLE types
         */
        static void Main(string[] args)
        {
            // Create a Rectangle
            Rectangle rect1;

            // Add values to it and run the Area method
            rect1.length = 200;
            rect1.width = 50;
            Console.WriteLine("Area of rect1 : {0}",
                rect1.Area());

            // Use a constructor to create a Rectangle
            Rectangle rect2 = new Rectangle(100, 40);
                       
            rect2 = rect1;
            rect1.length = 33;

            Console.WriteLine("rect2.length : {0}",
                rect2.length);

            // ----- OBJECT ORIENTED PROGRAMMING -----
            
            Animal fox = new Animal()
            {
                name = "Red",
                sound = "Raaaw"
            };

            // Call the static method
            Console.WriteLine("# of Animals {0}",
                Animal.GetNumAnimals());

            // You can also create static utility
            // classes Project -> Add Class
            Console.WriteLine("Area of Rectangle : {0}",
                ShapMath.GetArea("rectangle", 5, 6));


            // ----- NULLABLE TYPES -----
            
            int? randNum = null;

            // Check for null
            if (randNum == null)
            {
                Console.WriteLine("randNum is null");
            }

            // Another check for null
            if (!randNum.HasValue)
            {
                Console.WriteLine("randNum is null");
            }


            Console.ReadLine();

        }

        // ----- STRUCTS -----
        // A struct is a user defined type that
        // contain multiple fields and methods

        struct Rectangle
        {
            public double length;
            public double width;

            public Rectangle(double l = 1, double w = 1)
            {
                length = l;
                width = w;
            }

            public double Area()
            {
                return length * width;
            }
        }
    }
}
