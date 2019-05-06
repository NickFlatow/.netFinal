using System.Linq;

namespace Northwind.Models
{
    public interface INorthwindRepository
    {
        IQueryable<Category> Categories { get; }
        IQueryable<Product> Products { get; }
        IQueryable<Discount> Discounts { get; }
        IQueryable<Customer> Customers { get; }
        IQueryable<Employee> Employees { get; }


        void AddCustomer(Customer customer);
        void EditCustomer(Customer customer);
        void AddDiscount(Discount discount);
        void EditDiscount(Discount discount);
        void AddEmployee(Employee employee);
        void EditEmployee(Employee employee);
    }
}
