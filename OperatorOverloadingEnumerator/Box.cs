using System;

namespace OperatorOverloadingEnumerator
{
    class Box
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Breadth { get; set; }

        //First constructor
        public Box()
            //These are the defaults for its measurements
        : this(1, 1, 1) { }

        //Second constructor
        public Box(double l,
            double w,
            double b)
        {
            Length = l;
            Width = w;
            Breadth = b;
        }

        /*
         * Use the operator keyword to overload a built-in operator or 
         * to provide a user-defined conversion in a class or struct declaration. 
         * */
        public static Box operator +(Box box1, Box box2)
        {
            Box newBox = new Box()
            {
                Length = box1.Length + box2.Length,
                Width = box1.Width + box2.Width,
                Breadth = box1.Breadth + box2.Breadth
            };
            return newBox;
        }

        // Through operator overloading you can
        // allow users to interact with your
        // custom objects in interesting ways
        // You can overload +, -, *, /, %, !,
        // ==, !=, >, <, >=, <=, ++ and --
        public static Box operator -(Box box1, Box box2)
        {
            Box newBox = new Box()
            {
                Length = box1.Length - box2.Length,
                Width = box1.Width - box2.Width,
                Breadth = box1.Breadth - box2.Breadth
            };
            return newBox;
        }

        public static bool operator ==(Box box1, Box box2)
        {
            if ((box1.Length == box2.Length) &&
                (box1.Width == box2.Width) &&
                (box1.Breadth == box2.Breadth))
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Box box1, Box box2)
        {
            if ((box1.Length != box2.Length) ||
                (box1.Width != box2.Width) ||
                (box1.Breadth != box2.Breadth))
            {
                return true;
            }
            return false;
        }

        // You define how your object is converted
        // into a string by overridding the default ToString function
        public override string ToString()
        {
            return String.Format("Box with Height : {0} Width : {1} and Breadth : {2}",
                Length, Width, Breadth);
        }

        // You can convert from a Box into an
        // int like this even though this
        // wouldn't make sense
        // The explicit keyword declares a user-defined type conversion operator that must be invoked with a cast.
        /*
         * EXPLICIT VS IMPLICIT - use Implicit if you don't need to worry about error handling, the data thrown in is safe.
         * explicit conversion operators MUST be invoked by means of a cast!!!!!!
         * In general, implicit conversion operators should never throw exceptions and never lose information so that they 
         * can be used safely without the programmer's awareness. 
         * If a conversion operator cannot meet those criteria, it should be marked explicit.
         * */
        public static explicit operator int(Box b)
        {
            return (int)(b.Length + b.Width + b.Breadth) / 3;
        }

        // Convert from an int to a Box
        /*
         * The implicit keyword is used to declare an implicit user-defined type conversion operator. 
         * Use it to enable implicit conversions between a user-defined type and another type, 
         * if the conversion is guaranteed not to cause a loss of data. 
         * */
        public static implicit operator Box(int i)
        {
            // Return a box with the lengths all
            // set to the int passed
            return new Box(i, i, i);
        }

    }
}