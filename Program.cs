using MovieStoreApp.Models;

namespace MovieStoreApp
{
    internal class Program
    {
        static List<Movie> movies = new List<Movie>(4);
        static void Main(string[] args)
        {
            DisplayMenu();
        }

        static void DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine("Welcome to MovieStore App");
                Console.WriteLine("What operation would you like to perform? \n" +
                    "1. Add new Movie \n" +
                    "2. Display All Movie \n" +
                    "3. Find Movie by Id \n" +
                    "4. Remove Movie by Name \n" +
                    "5. Clear All Movie \n" +
                    "6. Exit \n");

                Console.WriteLine("Enter your Choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                DoTask(choice);
            }
        }

        static void DoTask(int choice)
        {
            switch (choice)
            {
                case 1:
                    if(movies.Count >4)
                        Console.WriteLine("List is full");
                    else
                        AddMovie();
                    break;
                case 2:
                    if(movies.Count ==0)
                        Console.WriteLine("The List is empty");
                    else
                        movies.ForEach(movie => Console.WriteLine(movie));
                    break;
                case 3:
                    Movie findMovie = FindMovieById();
                    if (findMovie != null)
                        Console.WriteLine(findMovie);
                    else
                        Console.WriteLine("Account not found");
                    break;
                case 4:
                    RemoveMovie();
                    break;
                case 5:
                    if(movies.Count ==0)
                        Console.WriteLine("Movie list is already empty. Nothing to clear");
                    else
                        movies.Clear();
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break ;



            }
        }

        static void AddMovie()
        {
            Console.WriteLine("Enter Movie Details");
            Console.WriteLine("Enter Movie Id");
            int movieId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Movie Name");
            string movieName = Console.ReadLine();
            Console.WriteLine("Enter Year of Release");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Genre");
            string genre = Console.ReadLine();

            movies.Add(Movie.CreateNewMovie(movieId, movieName, year, genre));
        }

        static Movie FindMovieById()
        {
            Movie findMovie = null;
            Console.WriteLine("Enter Movie Id");
            int id = Convert.ToInt32(Console.ReadLine());
            findMovie = movies.Where(item => item.Id == id).FirstOrDefault();
            return findMovie;

        }
        static void RemoveMovie()
        {
            Movie findMovie = null;
            Console.WriteLine("Enter Movie Name");
            string name = Console.ReadLine();
            findMovie = movies.Where(item => item.Name == name).FirstOrDefault();
            if (findMovie == null)
                Console.WriteLine("Account not found");
            else
            {
                movies.Remove(findMovie);
                Console.WriteLine("Movie deleted successfully");
            }
        }
    }
}
