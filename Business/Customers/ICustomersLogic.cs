using HBWebApi.Entities.Models.DTO;

namespace HBWebApi.Domain.Customers
{
    public interface ICustomersLogic
    {
        CustomerByProductDto GetCustomer(int customerId);
    }
}