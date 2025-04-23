using System.Data;
using System.Reflection.Emit;

namespace MovieAPIDemo.Entities{
    public class Person{
        public int Id {get; set;}

        public string Name {get; set;}

        public DateTime DateOfBirth {get; set;}

        public DateTime CreatedDate {get; set;} = DateTime.Now;

        public DateTime? ModifiedDate {get; set;}

        public ICollection<Movie> Movies {get; set;}
    }
}