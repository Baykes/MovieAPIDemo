using System.Data;
using System.Reflection.Emit;

namespace MovieAPIDemo.Entities{
    public class Movie{
        public int Id {get; set;}

        public string Title {get; set;}

        public string Description {get; set;}

        public string Language {get; set;}

        public DateTime releaseDate {get; set;}

        public string CoverImage {get; set;}

        public DateTime CreatedDate {get; set;} = DateTime.Now;

        public DateTime? ModifiedDate {get; set;}

        public ICollection<Person> Actors {get; set;}
    }
}