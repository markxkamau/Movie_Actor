using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Genre { get; set; }
        public int Age { get; set; }
        [Display(Name = "Years Experience")]
        public string? YearsExperience { get; set; }
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public int MovieId { get; set; }
        [ForeignKey("MovieId")]
        [Display(Name = "Movie Id")]
        public Movie? movie { get; set; }
    }
}