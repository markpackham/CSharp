using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Globilization allows culture specific formatting
using System.Globalization;

namespace LoopingArraysStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] favNums = new int[3];
            favNums[0] = 23;

            Console.WriteLine("favNum 0 : {0}", favNums[0]);

            string[] customer = { "Bob", "Sally", "Sue" };

            var employees = new[] { "Mike", "Paul", "Rick" };

            object[] randomArray = { "Paul", 45, 1.234 };

            Console.WriteLine("randomArray 0 : {0}", randomArray[2].GetType());

            Console.WriteLine("Array Size : {0}", randomArray.Length);

            for (int i = 0; i < randomArray.Length; i++)
            {
                Console.WriteLine("Array Size {0} : Value : {1}", i, randomArray[i]);
            }

            string[,] custNames = new string[2, 2] { { "Bob", "Smith" }, { "Sally", "Marks" } };

            Console.WriteLine("MD Value : {0}", custNames.GetValue(1, 1));

            for (int i = 0; i < custNames.GetLength(0); i++)
            {
                for (int j = 0; j < custNames.GetLength(1); j++)
                {
                    Console.Write("{0}", custNames[i, j]);
                }
                Console.WriteLine();
            }

            int[] randNums = { 1, 4, 9, 2 };

            randNums.SetValue(9000, 2);

            Console.WriteLine("1 at Index : {0}", Array.IndexOf(randNums, 1));

            Array.Reverse(randNums);

            Array.Sort(randNums);

            printArray(randNums, "ForEach");

            int[] srcArray = { 1, 2, 3 };
            int[] destArray = new int[2];
            int startInd = 0;
            int length = 2;

            Array.Copy(srcArray, startInd, destArray, startInd, length);

            printArray(destArray, "Copy");

            Array anotherArray = Array.CreateInstance(typeof(int), 10);

            srcArray.CopyTo(anotherArray, 5);

            foreach (int m in anotherArray)
            {
                Console.WriteLine("CopyTo : {0}, ", m);
            }

            int[] numArray = {1,11,22};

            //Array.FindAll would return an array of all the matches
            Console.WriteLine("> 10 : {0}", Array.Find(numArray, greaterThanTen));

            StringBuilder sb = new StringBuilder("Random Text");

            //Default is 16 characters
            StringBuilder sb2 = new StringBuilder("More stuff that is important", 256);

            Console.WriteLine("Capacity: {0}", sb.Capacity);
            Console.WriteLine("Length: {0}", sb.Length);

            sb2.AppendLine("\nMore important text");

            CultureInfo enUS = CultureInfo.CreateSpecificCulture("en-US");
            string bestCust = "Bob Smith";
            sb2.AppendFormat(enUS, "Best Customer :  {0}", bestCust);

            Console.WriteLine(sb2.ToString());

            sb2.Replace("text", "characters");
            Console.WriteLine(sb2.ToString());

            sb2.Clear();

            sb2.Append("Random Text");

            Console.WriteLine(sb.Equals(sb2));

            sb2.Insert(11, " that's great ");

            Console.WriteLine(sb2.ToString());

            //Remove next 7 characters after index 11
            sb2.Remove(11, 7);

            Console.WriteLine(sb2.ToString());

            long num1 = 1234;
            int num2 = (int)num1;

            Console.WriteLine("Orig : {0} Cast : {1}",num1.GetType(),num2.GetType());

            Console.ReadLine();
        }

        static void printArray(int[] intArray, string mess)
        {
            foreach (int k in intArray)
            {
                Console.WriteLine("{0} : {1}", mess, k);
            }
        }

        private static bool greaterThanTen(int val)
        {
            return val > 10;
        }
    }
}