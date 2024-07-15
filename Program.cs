namespace Valdecanas_FinalProject
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var movies = new List<string>
            {
                "Finding Nemo",
                "My Girl",
                "Enola Holmes",
                "Juno",
                "Little Women",
                "Forrest Gump",
                "Conjuring 2",
                "Encanto",
                "Coco",
                "Moana",
                "Seven Sundays"
            };

            var watchedMovies = new List<string>();

            ChooseMovies(movies, watchedMovies);
            Menu.Options(movies, watchedMovies);
        }

        public static void ChooseMovies(List<string> movies, List<string> watchedMovies)
        {
            while (watchedMovies.Count < 11)
            {
                Console.WriteLine("What movies have you watched? (press 0 to skip)");
                
                DisplayMovies(movies);

                string input = Console.ReadLine();               
                if (input == "0")
                {
                    Console.WriteLine("Skipping to menu . . .");
                    break;
                }

                int movieIndex = int.Parse(input);
                var selectedMovie = movies[movieIndex - 1];
                watchedMovies.Add(selectedMovie);
                movies.RemoveAt(movieIndex - 1);
                Console.WriteLine("");
            }
        }
        public static void DisplayMovies(List<string> movies)
        {
            for (int i = 0; i < movies.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {movies[i]}");
            }
        }
    }
}