using Core.Entities;
using Core.Repository.Command.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository.Command
{
    public interface ICustomerCommandRespository : ICommandRepository<Customer>
    {
    }
}
