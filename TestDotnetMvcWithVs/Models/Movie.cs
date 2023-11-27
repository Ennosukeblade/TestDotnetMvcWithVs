#pragma warning disable CS8618 
// Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System.ComponentModel.DataAnnotations;

namespace TestDotnetMvcWithVs.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Author { get; set; }
 
        public DateTime CreatedAt { get; set;} = DateTime.Now;
        
        public DateTime LastUpdatedAt { get; set;} = DateTime.Now;
    }
}
