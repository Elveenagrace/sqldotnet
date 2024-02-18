 
using AWebApplication1.Repository.Interfaces;
using WebApplication1.Models;
using WebApplication1.Services.Interfaces;
namespace WebApplication1.Services
{
    public class CustomerServiceImp : ICustomerServices
    {
        private readonly ICustomerRepo _customerRepo;

        public CustomerServiceImp(ICustomerRepo customerRepo)
        {
            _customerRepo = customerRepo;
        }

        public Customer GetCustomerById(string id)
        {
            return _customerRepo.GetCustomerById(id);
        }


        public Customer CreateCustomer(Customer customer)
        {

            return _customerRepo.CreateCustomer(customer);
        }


        public Customer UpdateCustomer(Customer customer, string id)
        {

            return _customerRepo.UpdateCustomer(customer, id);
        }


        public void DeleteCustomer(string id)
        {

            _customerRepo.DeleteCustomer(id);
        }

        public List<string> GetCustomers()
        {

            throw new NotImplementedException();
        }
    }
}

