using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models
{
    public class Expense
    {
        [Key]
        public int ExpenseId { get; set; }

        [Required]
        public string ExpenseTitle { get; set; } = string.Empty;

        [Required]
        public double ExpenseAmount { get; set; }

        public string ExpenseDescription { get; set; } = string.Empty;

        public int CategoryId { get; set; }

        public Category? Category { get; set; }

        public DateTime Date { get; set; } = DateTime.Today;
    }
}
