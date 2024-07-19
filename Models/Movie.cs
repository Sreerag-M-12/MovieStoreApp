using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp.Models
{
    internal class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int YearOfRelease { get; set; }

        public string Genre { get; set; }

        public Movie()
        {

        }
        public Movie(int id, string name, int yearOfRelease, string genre)
        {
            Id = id;
            Name = name;
            YearOfRelease = yearOfRelease;
            Genre = genre;
        }

        public static Movie CreateNewMovie(int id, string name, int yearOfRelease, string genre)
        {
            Movie movie = new Movie(id, name,yearOfRelease, genre);
            return movie;
        }

        public override string ToString()
        {
            Console.WriteLine($"=========Movie No {Id}===========");
            Console.WriteLine($"Movie id: {Id}");
            Console.WriteLine($"Movie Name no: {Name}");
            Console.WriteLine($"Movie Release Year : {YearOfRelease}");
            Console.WriteLine($"Movie Genre : {Genre}");
            Console.WriteLine("==================================");
            return " ";
        }

    }
}
