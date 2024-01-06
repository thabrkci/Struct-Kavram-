using System;

namespace Structconcept
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using the Class
            Rectangle rectangle = new Rectangle();
            rectangle.ShortSide = 3;
            rectangle.LongSide = 4;
            Console.WriteLine("Class Area Calculation : {0}", rectangle.CalculateArea());

            // Using the Struct
            RectangleStruct rectangleStruct; // No need to use 'new' keyword for initialization in a struct
            rectangleStruct.ShortSide = 5;
            rectangleStruct.LongSide = 6;
            Console.WriteLine("Struct Area Calculation: {0}", rectangleStruct.CalculateArea());

            // Alternatively, you can use a struct constructor for a cleaner initialization
            RectangleStruct rectangleStructWithConstructor = new RectangleStruct(3, 4);
            Console.WriteLine("Struct Area with Constructor: {0}", rectangleStructWithConstructor.CalculateArea());
        }
    }

    // Class representing a rectangle
    class Rectangle
    {
        public int ShortSide;
        public int LongSide;

        // Method to calculate the area of the rectangle
        public long CalculateArea()
        {
            return this.ShortSide * this.LongSide;
        }
    }

    // Struct representing a rectangle
    struct RectangleStruct
    {
        public int ShortSide;
        public int LongSide;

        // Constructor for initializing the struct with values
        public RectangleStruct(int shortSide, int longSide)
        {
            ShortSide = shortSide;
            LongSide = longSide;
        }

        // Method to calculate the area of the rectangle
        public long CalculateArea()
        {
            return this.ShortSide * this.LongSide;
        }
    }
}
