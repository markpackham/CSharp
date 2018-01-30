using System;

namespace OOP
{
    class Program
    {

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

            // If you assign one Rectangle to another
            // you are setting the values and not
            // creating a reference
            rect2 = rect1;
            rect1.length = 33;

            Console.WriteLine("rect2.length : {0}",
                rect2.length);

            // ----- OBJECT ORIENTED PROGRAMMING -----
            // A class models real world objects by
            // defining their attributes (fields) and
            // capabilities (methods)
            // Then unlike with structs you can 
            // inherit from a class and create more
            // specific subclass types

            // Add a class Project -> Add Class

            // Create an Animal object
            // You could also assign values like
            // fox.name = "Red"
            Animal fox = new Animal()
            {
                name = "Red",
                sound = "Raaaw"
            };

            // Call the static method
            Console.WriteLine("Number of Animals {0}",
                Animal.GetNumAnimals());

            // You can also create static utility
            // classes Project -> Add Class
            Console.WriteLine("Area of Rectangle : {0}",
                ShapeMath.GetArea("rectangle", 5, 6));


            // ----- NULLABLE TYPES -----
            // Data types by default cannot have a
            // value of null. Often null is needed
            // when you are working with databases
            // and you can create a null type by 
            // adding a ? to the definition
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
        //Structs are value types and Classes are reference types.
        //value types always contains a value whilst reference types can contain a null-reference, meaning that they don't refer to anything at all at the moment
		/*
		As a rule of thumb, the majority of types in a framework should be classes. There are, however, some situations in which the characteristics of a value type make it more appropriate to use structs.

		✓ CONSIDER defining a struct instead of a class if instances of the type are small and commonly short-lived or are commonly embedded in other objects.

		X AVOID defining a struct unless the type has all of the following characteristics:

    It logically represents a single value, similar to primitive types (int, double, etc.).

    It has an instance size under 16 bytes.

    It is immutable (unchanging over time or unable to be changed).

    It will not have to be boxed frequently.

		**/

        struct Rectangle
        {
            public double length;
            public double width;

            // You can create a constructor method
            // that will set the values for fields
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

