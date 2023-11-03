using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWebMVC.Models
{
    [Table("Student")]
    public class Student 
    {
        [Key]
        public string StudentID { get; set; }
    }
}