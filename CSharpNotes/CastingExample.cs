using System;

/*
Upcasting is creating a superclass or interface reference from a subclass reference
Downcasting is creating a subclass reference from a superclass or interface reference.
Upcasting can be done implicitly, while downcasting cannot
*/

namespace LearnReferences
{
    class CastingExample
    {
        static void Main(string[] args)
        {
            Dissertation diss = new Dissertation();
            Diary dy = new Diary();

            Book bdiss = diss;
            Book bdy = dy;
        }
    }
}
