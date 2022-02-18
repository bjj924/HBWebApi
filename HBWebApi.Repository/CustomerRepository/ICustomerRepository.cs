using HBWebApi.Entities.Models.DTO;

namespace HBWebApi.Repository.CustomerRepository
{
    public interface ICustomerRepository
    {
        CustomerByProductDto Get(int productId);
    }
}
