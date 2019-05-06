using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Northwind.Models;

namespace Northwind.Controllers
{
    public class EmployeeController : Controller
    {
        // this controller depends on the NorthwindRepository & the UserManager
        private INorthwindRepository repository;
        private UserManager<AppUser> userManager;
        public EmployeeController(INorthwindRepository repo, UserManager<AppUser> usrMgr)
        {
            repository = repo;
            userManager = usrMgr;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async System.Threading.Tasks.Task<IActionResult> Register(EmployeeWithPassword employeeWithPassword)
        {
            if (ModelState.IsValid)
            {
                Employee employee = employeeWithPassword.Employee;
                if (repository.Employees.Any(c => c.Email == employee.Email))
                {
                    ModelState.AddModelError("", "Email must be unique");
                }
                else
                {
                    if (ModelState.IsValid)
                    {
                        AppUser user = new AppUser
                        {
                            // email and username are synced - this is by choice
                            Email = employee.Email,
                            UserName = employee.Email
                        };
                        // Add user to Identity DB
                        IdentityResult result = await userManager.CreateAsync(user, employeeWithPassword.Password);
                        if (!result.Succeeded)
                        {
                            AddErrorsFromResult(result);
                        }
                        else
                        {
                            // Assign user to employees Role
                            result = await userManager.AddToRoleAsync(user, "Employee");

                            if (!result.Succeeded)
                            {
                                // Delete User from Identity DB
                                await userManager.DeleteAsync(user);
                                AddErrorsFromResult(result);
                            }
                            else
                            {
                                // Create employee (Northwind)
                                repository.AddEmployee(employee);
                                return RedirectToAction("Index", "Home");
                            }
                        }
                    }
                }
            }
            return View();
        }

 

        private void AddErrorsFromResult(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
        }
    }
}
