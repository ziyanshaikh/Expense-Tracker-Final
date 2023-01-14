using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [System.ComponentModel.DataAnnotations.Required]

        public string CategoryName { get; set; } = string.Empty;
    
        public double CategoryAmount { get; set; }
    }
}
