// Array built in methods

// Length
int[] plantHeights = { 3, 4, 6 };
// arrayLength will be 3
int arrayLength = plantHeights.Length

//
// Sort
int[] plantHeights = { 3, 6, 4, 1 };

// plantHeights will be { 1, 3, 4, 6 }
Array.Sort(plantHeights); 
//
//
// IndexOf
int[] plantHeights = { 3, 6, 4, 1, 6, 8 };

// returns 1
Array.IndexOf(plantHeights, 6);

//
//
// Find
int[] plantHeights = { 3, 6, 4, 1, 6, 8 };

// Find the first occurence of a plant height that is greater than 5 inches
int firstHeight = Array.Find(plantHeights, height => height > 5);


using System;

namespace BuiltInMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] summerStrut;

            summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };

            int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };

            int threeRating = Array.IndexOf(ratings, 3);
            Console.WriteLine($"Song number {threeRating + 1} is rated three stars.");

            string findName = Array.Find(summerStrut, song => song.Length > 10);

            Console.WriteLine($"The first song that has more than 10 characters in the title is {findName}.");

            Array.Sort(summerStrut);
            string firstSong = summerStrut[0];
            string lastSong = summerStrut[7];
            Console.WriteLine($"The first song in the playlist is now {firstSong}.");
            Console.WriteLine($"The last song in the playlist is now {lastSong}.");

        }
    }
}
