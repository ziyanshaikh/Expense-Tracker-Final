using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models
{
    public class TotalExpense
    {
        [Key]
        public int TotalExpenseId { get; set; }

        [Required]
        public double TotalExpenseLimit { get; set; }
    }
}
