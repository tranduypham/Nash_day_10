using Microsoft.EntityFrameworkCore;


namespace Day_10.Models {
    public class StudentDbContext : DbContext {
        public StudentDbContext() { }
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base (options) { }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Initial Catalog=DBName;Integrated Security=True");
        // }

        public DbSet<Student> Students { get; set; }
    }
}