#pragma warning disable CS8618 
using System.ComponentModel.DataAnnotations;

namespace TestDotnetMvcWithVs.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        
        public DateTime LastUpdatedAt { get; set; } = DateTime.Now;

        
    }
}
