using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services.Interfaces;

namespace WebApplication1.Controllers

{ 
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        readonly ICustomerServices _customerService;

        public CustomerController(ICustomerServices customerService)
        {
            _customerService = customerService;
        }



        // Create - POST: api/customers
        [HttpPost]
        public IActionResult Create([FromBody] Customer customer)
        {
            var createdCustomer = _customerService.CreateCustomer(customer);
            return Ok(createdCustomer);
        }




        // Read all - GET: api/customers
        [HttpGet]
        public IActionResult Get()
        {

            return Ok();
        }

        // Read by ID - GET: api/customers/{id}
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var customer = _customerService.GetCustomerById(id);
            return Ok(customer);
        }




        // Update - PUT: api/customers/{id}
        [HttpPut("{id}")]
        public IActionResult Update([FromBody] Customer customer, string id)
        {
            var updatedCustomer = _customerService.UpdateCustomer(customer, id);
            return Ok(updatedCustomer);
        }



        // Delete - DELETE: api/customers/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            _customerService.DeleteCustomer(id);
            return NoContent();
        }
    }
}

