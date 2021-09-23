using System.ComponentModel.DataAnnotations;

namespace Myproject.Models
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }

        public string ImageUrl { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Description { get; set; }

        public string Author { get; set; }

        public int Positive { get; set; }

        public int Negative { get; set; }

    }
}