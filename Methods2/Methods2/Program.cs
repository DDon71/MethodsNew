using System;

namespace Methods2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            // Name: Nicholas
            // Favorite Colour: Red
            // Favorite Animal: Great White Shark
            // Favorite Artist: Youngboy

            Console.WriteLine("Hello - What is your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName}. - What is your favorite colour?");
            var colour = Console.ReadLine();

            Console.WriteLine($"{colour} is an awesome colour! What is your first animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"Oh I don't like that one! Now what is your favorite musical artist");
            var Artist = Console.ReadLine();

            Console.WriteLine($"So let me get this right, you're name is {userName} you like {colour}, you're favorite animal is a {animal} and you listen to {Artist}?");
        }
    }
}

