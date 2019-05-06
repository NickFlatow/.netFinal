using System;
using System.ComponentModel.DataAnnotations;

namespace Northwind.Models
{
    public class Discount
    {
        public int DiscountID { get; set; }
        public int Code { get; set; }
        [Range(typeof(DateTime), "5/01/2019", "06/08/2019")]
        public DateTime StartTime { get; set; }
        [Range(typeof(DateTime), "5/01/2019", "06/08/2019")]
        public DateTime EndTime { get; set; }
        public int ProductID { get; set; }
        public decimal DiscountPercent { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Product Product { get; set; }
    }
}

