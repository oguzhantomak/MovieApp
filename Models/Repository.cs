using System.Collections.Generic;
using System.Linq;

namespace MovieApp.Models
{
    public static class Repository //Örnek oluşturulamayan, uygulamaya özel tek bir Repository Class'ı
    {
        private static List<Movie> _movies = null;

        static Repository()
        {
            _movies = new List<Movie>()
            {
                new Movie(){Id=1, Name="The Lord of the Rings: The Return of the King",Description="Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.",ImageUrl="1.jpg"},
                new Movie(){Id=2, Name="The Lord of the Rings: The Fellowship of the Ring",Description="A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.",ImageUrl="2.jpg"},
                new Movie(){Id=3, Name="The Lord of the Rings: The Two Towers",Description="While Frodo and Sam edge closer to Mordor with the help of the shifty Gollum, the divided fellowship makes a stand against Sauron's new ally, Saruman, and his hordes of Isengard.",ImageUrl="3.jpg"},
                new Movie(){Id=4, Name="Interstellar",Description="A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.",ImageUrl="4.jpg"},
                new Movie(){Id=5, Name="The Prestige",Description="After a tragic accident, two stage magicians engage in a battle to create the ultimate illusion while sacrificing everything they have to outwit each other.",ImageUrl="5.jpg"},
                new Movie(){Id=6, Name="Avengers: Endgame",Description="After the devastating events of Avengers: Infinity War (2018), the universe is in ruins. With the help of remaining allies, the Avengers assemble once more in order to reverse Thanos' actions and restore balance to the universe.",ImageUrl="6.jpg"},
                new Movie(){Id=7, Name="Avengers: Infinity War",Description="The Avengers and their allies must be willing to sacrifice all in an attempt to defeat the powerful Thanos before his blitz of devastation and ruin puts an end to the universe.",ImageUrl="7.jpg"},
            };
        }

        public static List<Movie> Movies
        {
            get
            {
                return _movies;
            }
        }

        public static void AddMovie(Movie entity)
        {
            _movies.Add(entity);
        }
        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(i => i.Id == id);
        }
    }
}