using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab11v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine("\n There are 10 movies in this list");

            var movieList = new List<MovieReturn>();
            movieList.Add(new MovieReturn("Friday the 13", "Horror"));
            movieList.Add(new MovieReturn("Event Horizon", "Horror"));
            movieList.Add(new MovieReturn("Lion King", "Animated"));
            movieList.Add(new MovieReturn("Dumbo", "Animated"));
            movieList.Add(new MovieReturn("Up", "Animated"));
            movieList.Add(new MovieReturn("The Shawshank Redemption", "Drama"));
            movieList.Add(new MovieReturn("The Pursuit of Happyness ", "Drama"));
            movieList.Add(new MovieReturn("The Matrix", "Scifi"));
            movieList.Add(new MovieReturn("Star Trek II: Wrath of Khan", "Scifi"));
            movieList.Add(new MovieReturn("Aliens", "Scifi "));

            string goAgain;
            while (true)
            {
                Console.Write("What catergory are you interested in? (Animated, Drama, Horror, Scifi): ");
                var userInput = Console.ReadLine();
             
                foreach (var m in movieList)
                {
                    if (m.Category.Equals(userInput, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine(m.Title);
                    }
                
                 }

                //if (!MovieReturn.Equals(userInput, StringComparison.OrdinalIgnoreCase)) //<- Can't get this working correctly.  Not utilizing it at this time. 
                //{
                //    Console.WriteLine("Invalid Selection");
                //}

                Console.Write("Would you like to go again? (y/n): ");
                goAgain = Console.ReadLine().ToLower();

                if (goAgain != "y")
                {
                    break;
                }

            }
            Console.WriteLine("Have a good day");
        }
    }
}
