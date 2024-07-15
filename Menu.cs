using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valdecanas_FinalProject
{
    public static class Menu
    {
        public static void Options(List<string> movies, List<string> watchedMovies)
        {
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("1. Get movie recommendations");
                Console.WriteLine("2. View watched-movies");
                Console.WriteLine("3. Exit");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        GetRecommendations();
                        break;
                    case "2":
                        ViewWatchedMovies(watchedMovies);
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        public static void GetRecommendations()
        {
            var recommendedMovies = new List<string>
            {
                "Minions: The Rise of Gru",
                "Oppenheimer",
                "Inside Out 2",
                "Home Alone",
                "Charlie's Angels",
                "A Dog's Purpose",
                "Cloudy with a Chance of Meatballs",
                "World War Z",
                "Men in Black",
                "The Amazing Spider-Man",
                "Rewind",
                "Casper",
                "A Man Called Otto",
                "Flipped",
                "Pitch Perfect"
            };

            int i = 0;

            while (i < recommendedMovies.Count)
            {
                Console.WriteLine($"\n~~ {recommendedMovies[i]} ~~");
                Console.WriteLine("(Press Enter to get another recommendation)");
                Console.WriteLine("(Press 0 to return to menu)");
                i++;


                string input = Console.ReadLine();
                if (input == "0")
                {
                    Console.WriteLine("Returning to menu . . .");
                    break;
                }


                if (i == recommendedMovies.Count)
                {
                    Console.WriteLine("\nSorry, no more recommendations T_T");
                    Console.ReadKey();
                    Console.ReadKey();
                    break;  
                }
            }
        }

        public static void ViewWatchedMovies(List<string> watchedMovies)
        {
            if (watchedMovies.Count == 0)
            {
                Console.WriteLine("\n(You don't have any watched-movies. Tara, movie-marathon!)");
            }
            else
            {
                Console.WriteLine("\nYour watched-movies:");
                for (int i = 0; i < watchedMovies.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {watchedMovies[i]}");
                }
            }
        }
    }
}