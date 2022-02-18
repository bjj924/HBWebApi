using HBWebApi.Domain.Customers;
using HBWebApi.Entities.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace HBWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomersLogic _customersLogic;
        
        public CustomersController(ICustomersLogic customersLogic)
        {
            _customersLogic = customersLogic;
        }

        [Route("GetCustomerByProduct")]
        [HttpPost]
        public CustomerByProductDto GetCustomerByProduct([FromQuery] int producId)
        {
            var customerByProduct = _customersLogic.GetCustomer(producId);

            return customerByProduct;
        }
    }
}
