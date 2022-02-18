using HBWebApi.Entities.Models.DTO;
using HBWebApi.Repository.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBWebApi.Repository.CustomerRepository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationContext _context;
        public CustomerRepository(ApplicationContext context)
        {
            _context = context;
        }

        public CustomerByProductDto Get(int productId)
        {
            var query = _context.Customers
                           .Join(
                                _context.Orders,
                                c => c.PersonID,
                                o => o.PersonID,
                                (c, o) => new { c, o })
                           .Join(
                                _context.OrdersDetails,
                                co => co.o.OrderID,
                                od => od.OrderID,
                                (co, od) => new { co, od })
                            .Where(p => p.od.ProductID.Equals(productId))
                            .AsNoTracking()
                            .Select(p => new { Custumer = p.co.c, Orders = p.co.o, OrdersDetails = p.od });

            var queryResult = query.FirstOrDefault();

            var customerByProductDTO = new CustomerByProductDto();

            if (queryResult != null)
            {
                customerByProductDTO.FullName = queryResult?.Custumer?.FirstName + " " + queryResult?.Custumer?.LastName;
                customerByProductDTO.Age = queryResult.Custumer.Age;
                customerByProductDTO.OrderId = queryResult.Orders.OrderID;
                customerByProductDTO.DateCreated = queryResult.Orders.DateCreated.ToString();
                customerByProductDTO.MethodofPurchase = queryResult?.Orders?.MethodofPurchase;
                customerByProductDTO.ProductNumber = queryResult.OrdersDetails.ProductNumber;
                customerByProductDTO.ProductOrigin = queryResult.OrdersDetails.ProductOrigin;
            }

            return customerByProductDTO;
        }
    }
}
