using Microsoft.EntityFrameworkCore;
using ExpenseTracker.Models;

namespace ExpenseTracker.Models
{
    public class AppDbContext : DbContext
    {
       

        //internal readonly object Expense;

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        

        public DbSet<Category> Categories { get; set; }

        public DbSet<Expense> Expenses { get; set; }

        public DbSet<ExpenseTracker.Models.TotalExpense> TotalExpense { get; set; }

        

        //protected override object OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=.;Database=ExpenseTrackerDB;IntegratedSecurity=True;");
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
