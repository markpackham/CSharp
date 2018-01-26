using System;

// A class can support multiple interfaces. 

/*
 * Abstract Class can contain implementation of methods, fields, constructors
 * An Interface only contains method and property prototypes. 
 * A class can implement multiple interfaces, but it can only inherit one abstract class.
   An Interface defines what something can do, and an Abstract Class defines what something is.
   Always prefix your interfaces with a capital "I" to make them stand out
 * */


namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Vehicle object
            Vehicle buick = new Vehicle("Buick",
                4, 160);

            // Check if Vehicle implements 
            // IDrivable
            if (buick is IDrivable)
            {
                buick.Move();
                buick.Stop();
            }
            else
            {
                Console.WriteLine("The {0} can't be driven", buick.Brand);
            }

            // We are now modeling the act of
            // picking up a remote, aiming it
            // at the TV, clicking the power
            // button and then watching as
            // the TV turns on and off

            // Pick up the TV remote
            IElectronicDevice TV = TVRemote.GetDevice();

            // Create the power button
            PowerButton powBut = new PowerButton(TV);

            // Turn the TV on and off with each 
            // press
            powBut.Execute();
            powBut.Undo();

            Console.ReadLine();

        }

    }

}