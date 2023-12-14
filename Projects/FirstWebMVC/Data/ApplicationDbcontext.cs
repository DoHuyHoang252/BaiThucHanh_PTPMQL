using FirstWebMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstWebMVC.Data
{
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
        {}
        public DbSet<Person> Person {get; set;}
        public DbSet<Employee> Employee {get; set;}
        public DbSet<Author> Author { get; set; } = default!;
        public DbSet<Book> Book { get; set; } = default!;
        public DbSet<HeThongPhanPhoi> HeThongPhanPhoi { get; set; } = default!;
        public DbSet<DaiLy> DaiLy { get; set; } = default!;
    }
}