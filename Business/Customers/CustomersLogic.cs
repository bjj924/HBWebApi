using HBWebApi.Entities.Models.DTO;
using HBWebApi.Repository.CustomerRepository;
using System;

namespace HBWebApi.Domain.Customers
{
    public class CustomersLogic : ICustomersLogic
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomersLogic(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public CustomerByProductDto GetCustomer(int customerId)
        {
            try
            {
                var customerByProduct = _customerRepository.Get(customerId);

                return customerByProduct;
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}
