using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStarttoFinish._5_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            // We can store our shapes in
            // a Shape array as long as it 
            // contains subclasses of Shape
            Shape[] shapes = {new Circle(5),
            new Rectangle(4,5)};
            
            foreach (Shape s in shapes)
            {
                // Call the overidden method
                s.GetInfo();

                Console.WriteLine("{0} Area : {1:f2}",
                s.Name, s.Area());

                Circle testCirc = s as Circle;
                if (testCirc == null)
                {
                    Console.WriteLine("This isn't a Circle");
                }
                                
                if (s is Circle)
                {
                    Console.WriteLine("This isn't a Rectangle");
                }


                Console.WriteLine();
            }

            // You can store any class as a base
            // class and call the subclass methods
            // even if they don't exist in the base
            // class by casting
            object circ1 = new Circle(4);

            Circle circ2 = (Circle)circ1;
            Console.WriteLine("The {0} Area is {1:f2}",
                circ2.Name, circ2.Area());


            Console.ReadLine();

        }
    }
}
