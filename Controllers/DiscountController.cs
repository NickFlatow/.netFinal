﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Northwind.Models;

namespace Northwind.Controllers
{
    public class DiscountController : Controller
    {
        private INorthwindRepository repository;
        public DiscountController(INorthwindRepository repo) => repository = repo;

        public IActionResult Edit(int id) => View(repository.Discounts.FirstOrDefault(d => d.DiscountID == id));

        public IActionResult Discounts() => View(repository.Discounts.OrderBy(d => d.DiscountID));

        public IActionResult Add()
        {
            List<Product> productList = new List<Product>();
            productList = repository.Products.OrderBy(p => p.ProductName).ToList();
            ViewBag.ListofProducts = productList;
           return View();

        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult AddDiscount(Discount discount)
        {
            repository.AddDiscount(discount);
            return RedirectToAction("Discounts");
          
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult EditDiscount(Discount discount)
        {
            // Edit customer info
            repository.EditDiscount(discount);
            return RedirectToAction("Index", "Home");
        }
        public IActionResult DeleteDiscount(int id)
        {
            repository.DeleteDiscount(repository.Discounts.FirstOrDefault(d => d.DiscountID == id));
            return RedirectToAction("Discounts");
        }

        //public IActionResult Index(int id) => View(repository.Products.Where(p => p.CategoryId == id && p.Discontinued == false).OrderBy(p => p.ProductName));
        //this is to the code
    }
}