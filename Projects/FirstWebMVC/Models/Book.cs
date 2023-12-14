using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FirstWebMVC.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string Title { get; set; }

        // Foreign key
        public int AuthorId { get; set; }

        // Navigation property
        public Author? Author { get; set; }
    }
}