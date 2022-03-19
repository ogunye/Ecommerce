using Core.Entities;
using Core.Repository.Query.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository.Query
{
    public interface ICustomerQueryRepository : IQueryRepository<Customer>
    {
        //Custom operation which is not generic
        Task<IReadOnlyList<Customer>> GetAllAsync();
        Task<Customer> GetByIdAsync(int id);
        Task<Customer> GetByNameAsync(string name);
    }
}
