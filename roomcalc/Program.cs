using System;

namespace roomcalc
{
    class Program
    {
        static void Main(string[] args)
        {
           string proceed = "y";
           while(proceed == "y")
            {
                Console.Write("What is the length of the room in ft? ");
                float length = float.Parse(Console.ReadLine());
                Console.Write("What is the width of the room in ft? ");
                float width = float.Parse(Console.ReadLine());
                Console.Write("What is the height of the room in ft? ");
                float height = float.Parse(Console.ReadLine());

                float perimeter = (length * 2) + (width * 2);
                float area = (length * width);
                float volume = (length * width * height);

                Console.WriteLine($"Perimeter: {perimeter} ft. \n Area: {area} sq.ft. \n Volume: {volume} cu.ft.");
                Console.WriteLine("Would you like to measure another room? (y/n)");
                proceed = Console.ReadLine();
            }
        }
    }
}
