using Microsoft.EntityFrameworkCore;
using VerifyEmailAndForgotPasswordTutorial.Models;

namespace VerifyEmailAndForgotPasswordTutorial.Data
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options ): base( options )
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder
                .UseSqlServer("Data Source=desktop-fpdjkd9;Initial Catalog=VerificationEmail;Integrated Security=True");
        }

        public DbSet<User> Users { get; set; }
    }
}
