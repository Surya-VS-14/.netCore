using System.ComponentModel.DataAnnotations;

namespace RestApiDemo.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(1, double.MaxValue)]
        public double Price { get; set; }
    }
}
