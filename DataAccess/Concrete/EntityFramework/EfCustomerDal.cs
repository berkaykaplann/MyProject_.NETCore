using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, DatabaseContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var result = from customer in context.Customers
                             join order in context.Orders
                             on customer.CustomerId equals order.CustomerId
                             select new CustomerDetailDto
                             {
                                 CustomerId = customer.CustomerId,
                                 CustomerName=customer.ContactName,
                                 OrderDate = order.OrderDate,
                                 ShipCity = order.ShipCity

                             };
                return result.ToList();
            }
        }
    }
}
