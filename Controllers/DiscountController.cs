using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Northwind.Models;

namespace Northwind.Controllers
{
    public class DiscountController : Controller
    {
        private INorthwindRepository repository;
        public DiscountController(INorthwindRepository repo) => repository = repo;

        public IActionResult Index() => View(repository.Discounts.FirstOrDefault(d => d.DiscountID == 1));

    }
}