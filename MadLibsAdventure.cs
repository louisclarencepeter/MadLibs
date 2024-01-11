using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program is Mad Libs, Mad Libs are short stories with blanks for the player to fill in that represent different parts of speech. The end result is a really hilarious and strange story.
            Author: Louis
            */

            // Let the user know that the program is starting:
            Console.WriteLine("Welcome to the whimsical world of Mad Libs!");

            // Give the Mad Lib a title:
            string title = "The Unexpected Adventure of Louis";
            Console.WriteLine($"Title: {title}\n");

            // Define user input and variables:
            Console.Write("Imagine an adjective as colorful as a rainbow: ");
            string adj1 = Console.ReadLine();
            Console.Write("Think of another adjective, as mysterious as the night: ");
            string adj2 = Console.ReadLine();
            Console.Write("Now, one more adjective, as zesty as a lemon: ");
            string adj3 = Console.ReadLine();
            Console.Write("Envision a verb that makes you feel like dancing: ");
            string verb = Console.ReadLine();
            Console.Write("Dream up a noun, something fantastical: ");
            string noun1 = Console.ReadLine();
            Console.Write("Conjure another noun, something utterly bizarre: ");
            string noun2 = Console.ReadLine();

            Console.Write("Name an animal you'd like to be friends with: ");
            string animal = Console.ReadLine();
            Console.Write("What's a food that makes you go 'yum'? ");
            string food = Console.ReadLine();
            Console.Write("Pick a fruit from a magical orchard: ");
            string fruit = Console.ReadLine();
            Console.Write("Choose a superhero you'd have tea with: ");
            string superhero = Console.ReadLine();
            Console.Write("Select a country from a storybook map: ");
            string country = Console.ReadLine();
            Console.Write("What dessert do you dream about? ");
            string dessert = Console.ReadLine();
            Console.Write("Imagine a year in the future, any year: ");
            string year = Console.ReadLine();


        }
    }
}