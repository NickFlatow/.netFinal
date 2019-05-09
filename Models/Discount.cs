using System;
using System.ComponentModel.DataAnnotations;

namespace Northwind.Models
{
    public class Discount
    {
        public int DiscountID { get; set; }
        [Required(ErrorMessage = "Code is required")]
        public int Code { get; set; }
        [Required(ErrorMessage = "Start time is required")]
        public DateTime StartTime { get; set; }
        [Required(ErrorMessage = "End Time is required")]
        public DateTime EndTime { get; set; }
        public int ProductID { get; set; }
        public decimal DiscountPercent { get; set; }
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage = "Product is required")]
        public Product Product { get; set; }
    }
}

