using LoansLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoansLib.Data.Interfaces
{
    public interface ICustomerRepository
    {
        Task<Customer?> GetCutomerAsync(int id);
    }
}
