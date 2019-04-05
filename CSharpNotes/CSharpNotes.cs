//Getting Input
using System;

namespace GettingInput
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("How old are you?");
      string input = Console.ReadLine();
      Console.WriteLine($"You are {input} years old!");
    }
  }
}

//Run via "dotnet run" - Runs source code without any explicit compile or launch commands.

/*
C# is used to make interactive websites, mobile apps, video games, augmented and virtual reality (AR and VR), back-end services, and desktop applications
.NET generally refers to the family of programs and commands that let you make applications with C#
C# and .NET jobs are out there! Build video games with Unity, build websites with ASP.NET…The skills you learn on Codecademy can open new doors
The command Console.WriteLine() prints text to the console
The command Console.ReadLine() captures user input in the console
 */

 /*
 The functions do the following:

capitalize: will turn lowercase characters into uppercase characters
square: will square a number
evaluate: will determine if an input is true or false
The data types include:

int (4637): whole integer number
string (kangaroo): a piece of text
bool (true): represents the logical idea of true or false

int - whole numbers, like: 1, -56, 948
double - decimal numbers, like: 239.43909, -660.01
char - single characters, like: “a”, “&”, “£”
string - string of characters, like: “dog”, “hello world”
bool - boolean values, like: true or false
  */

//data types
using System;

namespace Form
{
  class Program
  {
    static void Main(string[] args)
    {
      // Create Variables
string name = "Shadow";
string breed = "Golden Retriever";
int age = 5;
double weight = 65.22;
bool spayed = true;      
      // Print variables to the console
Console.WriteLine(name);
Console.WriteLine(breed);
Console.WriteLine(age);
Console.WriteLine(weight);
Console.WriteLine(spayed);
    }
  }
}

//Conversion
/*
implicit conversion: happens automatically if no data will be lost in the conversion. 
That’s why it’s possible to convert an int (which can hold less data) to a double (which can hold more), 
but not the other way around.
explicit conversion: requires a cast operator to convert a data type into another one. 
So if we do want to convert a double to an int, we could use the operator (int).
*/

//Convert String to Int
using System;

namespace FavoriteNumber
{
  class Program
  {
    static void Main(string[] args)
    {
      // Ask user for fave number
      Console.Write("Enter your favorite number!: ");

      // Turn that answer into an int
      //int(Console.ReadLine()) wouldn't work since a String can't be explicitly converted to an Int
int faveNumber = Convert.ToInt32(Console.ReadLine());


    }
  }
}



//Numbers
using System;

namespace Numbers
{
  class Program
  {
    static void Main(string[] args)
    {
      // Number of pizza shops
      int pizzaShops = 4332;

      // Number of employees
      int totalEmployees = 86928;

      // Revenue
      double revenue = 390819.28;

      // Log the values to the console:
      Console.WriteLine(pizzaShops);
      Console.WriteLine(totalEmployees);
      Console.WriteLine(revenue);
    }
  }
}


//Arithamtic Operators
using System;

namespace PlanetCalculations
{
  class Program
  {
    static void Main(string[] args)
    {  
      // Your Age
      int userAge = 30;

      // Length of years on Jupiter (in Earth years)
      double jupiterYears = 11.86;

      // Age on Jupiter
      double jupiterAge = userAge/jupiterYears;

      // Time to Jupiter
      double journeyToJupiter = 6.142466;

      // New Age on Earth
      double newEarthAge = userAge + journeyToJupiter;

      // New Age on Jupiter
      double newJupiterAge = newEarthAge/jupiterYears;

      // Log calculations to console
      Console.WriteLine(jupiterAge);
      Console.WriteLine(newEarthAge);
      Console.WriteLine(newJupiterAge);
    }
  }
}


//++ += -- -=
using System;

namespace MakingProgress
{
  class Program
  {
    static void Main(string[] args)
    {
      // declare steps variable
      int steps = 0;

      // Two steps forward 
      steps += 2;

      // One step back 
      steps--;

      // Print result to the console
      Console.WriteLine(steps);
    }
  }
}


//Modulous %
using System;

namespace ClassTeams
{
  class Program
  {
    static void Main(string[] args)
    {
      // Number of students
      int students = 18;

      // Number of students in a group
      int groupSize = 3;

      // Does groupSize go evenly into students?
      Console.WriteLine(students % groupSize);

    }
  }
}


//Math methods
/*
Math.Abs()—will find the absolute value of a number. Example: Math.Abs(-5) returns 5.
Math.Sqrt()—will find the square root of a number. Example: Math.Sqrt(16) returns 4.
Math.Floor()—will round the given double or decimal down to the nearest whole number. Example: Math.Floor(8.65) returns 8.
Math.Min()—returns the smaller of two numbers. Example: Math.Min(39, 12) returns 12.
Math.Pow()
Math.Max()
Math.Ceiling()
*/
using System;

namespace LowestNumber
{
  class Program
  {
    static void Main(string[] args)
    {
      // Create variables 
      int numberOne = 12932;
      int numberTwo = -2828472;

      // Use built-in methods and save to variable 
      double numberOneSqrt = Math.Floor(Math.Sqrt(numberOne));

      // Use built-in methods and save to variable 
      double numberTwoSqrt = Math.Floor(Math.Sqrt(Math.Abs(numberTwo)));

      // Print the lowest number
      Console.WriteLine(Math.Min(numberTwoSqrt, numberOneSqrt));
    }
  }
}

using System;

namespace DocumentationHunt
{
  class Program
  {
    static void Main(string[] args)
    {

      double numberOne = 6.5;
      double numberTwo = 4;

      // Raise numberOne to the numberTwo power
      Console.WriteLine(Math.Pow(numberOne, numberTwo));

      // Round numberOne up
      Console.WriteLine(Math.Ceiling(numberOne));

      // Find the larger number between numberOne and numberTwo
      Console.WriteLine(Math.Max(numberOne, numberTwo));

    }
  }
}


/*
Outputting a lot of text
 */
 using System;

namespace MadTeaParty
{
  class Program
  {
    static void Main(string[] args)
    {
      string drink = "wine";
      string madTeaParty = $"\"Have some {drink},\" the March Hare said in an encouraging tone. \nAlice looked all round the table, but there was nothing on it but tea.\n\"I don't see any {drink},\" she remarked.\n\"There isn't any,\" said the March Hare.";

      int storyLength = madTeaParty.Length;
      string toFind = "March Hare";

      string findLowerCase = toFind.ToLower(); 
      int findMarchHare = madTeaParty.IndexOf(toFind);

      Console.WriteLine(madTeaParty.Substring(findMarchHare));
      Console.WriteLine($"This scene is {storyLength} long.\n");
      Console.WriteLine($"The term we're looking for is {toFind} and is located at index {findMarchHare}.");

    }
  }
}


//Escape characters
using System;

namespace PrideAndPrejudice
{
  class Program
  {
    static void Main(string[] args)
    {
      // First string variable
      string firstSentence = "It is a truth universally acknowledged, that a single man in possession of a good fortune, must be in want of a wife.";
      // Second string variable
      string firstSpeech = "\"My dear Mr. Bennet,\" said his lady to him one day, \"have you heard that Netherfield Park is let at last?\"";

      // Print variable and newline
      Console.WriteLine(firstSentence);
      Console.WriteLine("\n");
      Console.WriteLine(firstSpeech);
    }
  }
}


//String Concatenation via +
using System;

namespace StoryTime
{
  class Program
  {
    static void Main(string[] args)
    {
      // Declare the variables
      string beginning = "Once upon a time";
      string middle = "the kid climbed a tree";
      string end = "Everyone lived happily ever after";

      // Concatenate the string and the variables
      string story = beginning + ", " + middle + ". " + end + ".";

      // Print the story to the console 
      Console.WriteLine(story);
    }
  }
}


//String interpolation essentially C#'s answer to JavaScript's ` ` Template literals
/*
String interpolation was introduced in C# 6 and it enables us to insert our variable values and
 expressions in the middle of a string,
 without having to worry about spaces and punctuation.
 */
using System;

namespace StoryTime
{
  class Program
  {
    static void Main(string[] args)
    {
      // Declare the variables
      string beginning = "Once upon a time,";
      string middle = "The kid climbed a tree";
      string end = "Everyone lived happily ever after.";

      // Interpolate the string and the variables
      string story = $"{beginning} it was a beautiful day. {middle} and the birds flew through the sky. {end}";

      // Print the story to the console 
      Console.WriteLine(story);
    }
  }
}

//Length & IndexOf (find specific character or substring)
using System;

namespace PasswordCheck
{
  class Program
  {
    static void Main(string[] args)
    {
      // Create password
      string password = "a92301j2add";

      // Get password length
      int passwordLength = password.Length;

      // Check if password uses symbol
      int passwordCheck = password.IndexOf("!");

      // Print results
      Console.WriteLine($"The user password is {password}. It's length is {passwordLength} and it receives a {passwordCheck} check.");

    }
  }
}

//.Substring()
using System;

namespace NameGrab
{
  class Program
  {
    static void Main(string[] args)
    {
      // User Name
      string name = "Farhad Hesam Abbasi";

      // Get first letter
      int charPosition = name.IndexOf("F");
      char firstLetter = name[charPosition];

      // Get last name
      charPosition = name.IndexOf("Abbasi");
      string lastName = name.Substring(charPosition);

      // Print results
      Console.WriteLine($"{firstLetter}. {lastName}");

    }
  }
}

//.ToUpper() .ToLower()
using System;

namespace MovieScript
{
  class Program
  {
    static void Main(string[] args)
    {
      // Script line
      string script = "Close on a portrait of the HANDSOME PRINCE -- as the BEAST'S giant paw slashes it.";

      // Get camera directions
      int charPosition = script.IndexOf("Close");
      int length = "Close on".Length;
      string cameraDirections = script.Substring(charPosition, length);

      // Get scene description
      charPosition = script.IndexOf("a portrait");
      string sceneDescription = script.Substring(charPosition);

      // Make camera directions uppercase
      cameraDirections = cameraDirections.ToUpper();

      // Make scene description lowercase
      sceneDescription = sceneDescription.ToLower();

      // Print results
      Console.WriteLine($"{cameraDirections} {sceneDescription}");
    }
  }
}


/*
Use the addition symbol (+) to concatenate strings.
Interpolate strings for easier string construction.
Find information about a string using .Length and .IndexOf().
Grab characters and parts of strings using bracket notation and .Substring().
Use built-in methods such as .ToUpper() and .ToLower() to manipulate strings.
 */