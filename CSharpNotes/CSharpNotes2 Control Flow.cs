// Boolean syntax
bool variableName = true;
bool variableName = false;

/*
Comparison operators (same as most languages) include:

Equals ==: returns true if the value to the left is equal to the value to the right.
Inequality operator !=: returns true if the two values are not equal.
Less than <: returns true if the value to the left is less than the value to the right.
Greater than >: returns true if the value to the left is more than the value to the right.
Less than or equal to <=: returns true if the value to the left is less than or equal to the value on the right.
Greater than or equal to >=: returns true if the value to the left is more than or equal to the value to the right.
*/

// Test boolean & comparison operator
using System;

namespace ComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            double timeToDinner = 4;

            double distance = 95;

            double rate = 30;

            double tripDuration = distance / rate;

            bool answer = (tripDuration <= timeToDinner);

            Console.WriteLine(answer);

        }
    }
}


// And Or Not
/*
AND &&: Both expressions are evaluated and will return True only if both expressions evaluate to True. Otherwise, it will return False.
OR ||: Both expressions are evaluated and will return True if at least one of the expressions evaluates to True. Otherwise, it will return False.
NOT !: An expression, no matter its logical value, evaluates to its opposite. What is True becomes False and what is False becomes True.
*/

using System;

namespace LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            bool beach = true;
            bool hiking = false;
            bool city = true;

            bool yourNeeds = (beach && city); // true
            bool friendNeeds = (beach || hiking); // true

            bool tripDecision = (yourNeeds && friendNeeds); // true AN true
            Console.WriteLine(tripDecision); // result true

        }
    }
}



// If Else ElseIf
using System;

namespace ElseIfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int guests = 6;

            if (guests == 6)
            {
                Console.WriteLine("Catan");
            }
            else if (guests == 3)
            {
                Console.WriteLine("Innovation");
            }
            else if (guests == 0)
            {
                Console.WriteLine("Solitaire");
            }

            else (guests == -1000) // else can only come at the end
      {
                Console.WriteLine("Something has gone wrong");
            }

        }
    }
}


// Switch
using System;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a movie genre: ");
            string genre = Console.ReadLine();

            switch (genre)
            {
                case "Drama":
                    Console.WriteLine("Citizen Kane");
                    break;

                case "Comedy":
                    Console.WriteLine("Duck Soup");
                    break;

                case "Adventure":
                    Console.WriteLine("King Kong");
                    break;

                case "Horror":
                    Console.WriteLine("Psycho");
                    break;

                case "Science Fiction":
                    Console.WriteLine("2001: A Space Odyssey");
                    break;

                default:
                    Console.WriteLine("No movie found");
                    break;
            }

        }
    }
}


// Ternary operator (time saving but looks ugly, your spend more time reading code than writing it)
using System;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            double pepperLength = 4;

            string message = (pepperLength >= 3.5) ? "ready!" : "wait a little longer";

            Console.WriteLine(message);
        }
    }
}


// IndexOf and SubString
using System;

namespace CaptureOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            string designer = "Anders Hejlsberg";

            //Reports the zero-based index of the first occurrence of a specified Unicode character or string within this instance. 
            //The method returns -1 if the character or string is not found in this instance.
            int indexOfSpace = designer.IndexOf(" ");

            string secondName = designer.Substring(indexOfSpace);

            Console.WriteLine(secondName); // Gives "Hejlsberg"
        }
    }
}


// Define a method
using System;

namespace DefineAMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            VisitPlanets(); // call the method
        }

        static void VisitPlanets()
        {
            Console.WriteLine("You visited many new planets...");
        }
    }
}


// Defined method with a parameter
using System;

namespace DefineParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            VisitPlanets(3);
            VisitPlanets(4);
            VisitPlanets(5);
        }

        // the parameter is scoped inside the method, you can't access it outside of the method here
        static void VisitPlanets(int numberOfPlanets) // parameter (like a place holder till you chuck in an arguement)
        {
            Console.WriteLine($"You visited {numberOfPlanets} new planets...");
        }
    }
}


// Optional Parameter
using System;

namespace OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            VisitPlanets(3);
            VisitPlanets(4);
            VisitPlanets(5);
            VisitPlanets();
        }

        // If no one bothers to pass an argument we have a default to fall back on
        static void VisitPlanets(int numberOfPlanets = 100)
        {
            Console.WriteLine($"You visited {numberOfPlanets} new planets...");
        }
    }
}


// Naming the argument you want to specifically set
using System;

namespace NamedArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            //When calling a method, pass arguments by position/order they come in or by name. If using names, use the colon (:) syntax
            VisitPlanets();
            VisitPlanets(numberOfPlanets: 2);
            // Only set number of planets & name so gForce & adjective stay as they are
            VisitPlanets(numberOfPlanets: 2, name: "Farfel");

        }

        static void VisitPlanets(
          string adjective = "brave",
          string name = "Cosmonaut",
          int numberOfPlanets = 0,
          double gForce = 4.2)
        {
            Console.WriteLine($"Welcome back, {adjective} {name}.");
            Console.WriteLine($"You visited {numberOfPlanets} new planets...");
            Console.WriteLine($"...while experiencing a g-force of {gForce} g!");
        }
    }
}


// Method Overloading (same method reacts differently depending on arguments like Java's Polymorphism)
using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            NamePets("Laika", "Albert");
            NamePets("Mango", "Puddy", "Bucket");
            NamePets();
        }

        static void NamePets(string pet1, string pet2)
        {
            Console.WriteLine($"Your pets {pet1} and {pet2} will be joining your voyage across space!");
        }

        static void NamePets(string pet1, string pet2, string pet3)
        {
            Console.WriteLine($"Your pets {pet1}, {pet2}, and {pet3} will be joining your voyage across space!");
        }

        static void NamePets()
        {
            Console.WriteLine("Aw, you have no spacefaring pets :(");
        }
    }
}

// A method signature is a method’s name and parameter types in order.

// Return statement example
using System;

namespace Return
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DecoratePlanet("Jupiter"));
        }

        static string DecoratePlanet(string planet)
        {
            return $"*..*..* Welcome to {planet} *..*..*";
        }
    }
}


/*
The method definition must contain the type of the return value: if a method returns an integer, 
its return type must be int; if it returns text, it must be string, and so on. If the method returns nothing, use void.

If a method returns a type different from its stated return type, it will throw an error. 
*/

// This error means you must state a return type before the method name
// error CS1520: Method must have a return type

// This error means that your method doesn’t return a value, when it should:
// error CS0161: [MethodName]: not all code paths return a value

// In some cases, this error means that your method returns a string when it should be an int 
// (this one can be caused by a lot of things outside of methods):
// error CS0029: Cannot implicitly convert type 'string' to 'int'



// Out
// A method can only return one value, but sometimes you need to output two pieces of information & "out" can be used
using System;

namespace OutParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            string ageAsString = "102";
            string nameAsString = "Granny";
            int ageAsInt;
            bool outcome;
            outcome = Int32.TryParse(ageAsString, out ageAsInt);
            Console.WriteLine(outcome); // True
            Console.WriteLine(ageAsInt); // 102

            int nameAsInt;
            bool outcome2;
            outcome2 = Int32.TryParse(nameAsString, out nameAsInt);
            Console.WriteLine(outcome2); // False
            Console.WriteLine(nameAsInt); // 0
        }
    }
}


// Another "out" example
using System;

namespace UsingOut
{
    class Program
    {
        static void Main(string[] args)
        {
            string statement = "GARRRR";
            string murmur = Whisper(statement, out bool marker);
            Console.WriteLine(murmur); // garrrr
        }

        static string Whisper(string phrase, out bool wasWhisperCalled)
        {
            wasWhisperCalled = true;
            return phrase.ToLower();
        }
    }
}


// This error means that the out parameter needs to be assigned a value within the method:
// error CS0177: The out parameter 'success' must be assigned to before control leaves the current method

// This error means you called a method that expects an ‘out’ parameter but you didn’t use the out keyword when calling it:
// error CS1620: Argument 2 must be passed with the 'out' keyword

// Every method has a return type, designated in its method signature. That type must match the type of the value actually returned.
// If a method returns no type, its return type is void