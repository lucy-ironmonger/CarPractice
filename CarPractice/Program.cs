using System;

namespace CarPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car newCar = new Car();
            Console.WriteLine($"The car colour is {newCar.Colour}");
            Console.WriteLine($"What colour would you like to repaint it?");
            var newColour = Console.ReadLine();
            newCar.Colour = newColour;
            Console.WriteLine($"You've resprayed the car {newCar.Colour} - what a badass!");
        }
    }
}
