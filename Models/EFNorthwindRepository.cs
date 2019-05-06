using System.Linq;

namespace Northwind.Models
{
    public class EFNorthwindRepository : INorthwindRepository
    {
        // the repository class depends on the NorthwindContext service
        // which was registered at application startup
        private NorthwindContext context;
        public EFNorthwindRepository(NorthwindContext ctx)
        {
            context = ctx;
        }
        // create IQueryable for Categories & Products
        public IQueryable<Category> Categories => context.Categories;
        public IQueryable<Product> Products => context.Products;
        public IQueryable<Discount> Discounts => context.Discounts;
        public IQueryable<Customer> Customers => context.Customers;
        public IQueryable<Employee> Employees => context.Employees;

        public void AddCustomer(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
        }

        public void EditCustomer(Customer customer)
        {
            var customerToUpdate = context.Customers.FirstOrDefault(c => c.CustomerID == customer.CustomerID);
            customerToUpdate.Address = customer.Address;
            customerToUpdate.City = customer.City;
            customerToUpdate.Region = customer.Region;
            customerToUpdate.PostalCode = customer.PostalCode;
            customerToUpdate.Country = customer.Country;
            customerToUpdate.Phone = customer.Phone;
            customerToUpdate.Fax = customer.Fax;
            context.SaveChanges();
        }
        public void AddDiscount(Discount discount)
        {
            context.Discounts.Add(discount);
            context.SaveChanges();
        }


        public void EditDiscount(Discount discount)
        {
            var discountToUpdate = context.Discounts.FirstOrDefault(d => d.DiscountID == discount.DiscountID);
            discountToUpdate.StartTime = discount.StartTime;
            discountToUpdate.EndTime = discount.EndTime;
            discountToUpdate.DiscountPercent = discount.DiscountPercent;
            discountToUpdate.Title = discount.Title;
            discountToUpdate.Description = discount.Description;
            context.SaveChanges();
        }
        public void DeleteDiscount(Discount discount)
        {
            context.Remove(discount);
            context.SaveChanges();
        }

        public void AddEmployee(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
        }

        public void EditEmployee(Employee employee)
        {
            var employeeToUpdate = context.Employees.FirstOrDefault(c => c.EmployeeID == employee.EmployeeID);
            employeeToUpdate.Title = employee.Title;
            employeeToUpdate.TitleOfCourtesy = employee.TitleOfCourtesy;
            employeeToUpdate.BirthDate = employee.BirthDate;
            employeeToUpdate.HireDate = employee.HireDate;
            employeeToUpdate.Address = employee.Address;
            employeeToUpdate.City = employee.City;
            employeeToUpdate.Region = employee.Region;
            employeeToUpdate.PostalCode = employee.PostalCode;
            employeeToUpdate.Country = employee.Country;
            employeeToUpdate.HomePhone = employee.HomePhone;
            employeeToUpdate.Extension = employee.Extension;
            context.SaveChanges();
        }
    }
}
