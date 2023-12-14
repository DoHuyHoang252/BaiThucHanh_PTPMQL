using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FirstWebMVC.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }

        // Navigation property
        public ICollection<Book>? Books { get; set; }
    }
}