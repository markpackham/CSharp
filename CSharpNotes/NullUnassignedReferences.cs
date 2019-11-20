using System;

/*
 In C# a reference to no object is called either a null reference or unassigned. 
 We’ll need to apply these concepts in C# whenever we want to show that a reference is “missing”, create a reference variable without defining it, 
 or initialize an empty array.

In the first use case, we’d like to create a reference that is “missing” or empty. We set it equal to the keyword null:
Diary dy = null;

In the second case, if we create a reference variable without a value, it is unassigned:
Diary dy;
// dy is unassigned
 */

namespace LearnReferences
{
    class NullUnassignedReferences
    {
        static void Main(string[] args)
        {
            Book bk = null;
            Console.WriteLine(bk);
            // Be careful when checking for null and unassigned references. We can only compare a null reference if it is explicitly labeled null
            bool result = (bk == null);
            Console.WriteLine(result);
        }
    }
}