using WebApplication1.Models;
namespace WebApplication1.Services.Interfaces
{
    public interface ICustomerServices
    {

        List<string> GetCustomers();
        Customer GetCustomerById(string id);
        Customer CreateCustomer(Customer customer);

        Customer UpdateCustomer(Customer customer, string id);
        void DeleteCustomer(string id);

    }

}
