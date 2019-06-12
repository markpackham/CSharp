using System;
namespace Tutlane
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine("Variable Value Before Calling the Method: {0}", x); // shows 10
            // ref used here
            Multiplication(ref x); // shows 100 for value in method
            Console.WriteLine("Variable Value After Calling the Method: {0}", x);  // shows 100 (had we not passed by reference it would have been unchanged at 10)
            Console.WriteLine("Press Enter Key to Exit..");
            Console.ReadLine();
        }
        //ref used here
        public static void Multiplication(ref int a)
        {
            a *= a;
            Console.WriteLine("Variable Value Inside the Method: {0}", a);
        }
    }
}