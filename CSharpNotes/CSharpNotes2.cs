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
      
      double tripDuration = distance/rate;
      
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

      string message = (pepperLength >= 3.5)  ? "ready!" : "wait a little longer";

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