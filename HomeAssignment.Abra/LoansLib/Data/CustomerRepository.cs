using LoansLib.Data.Interfaces;
using LoansLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoansLib.Data
{
    public class CustomerRepository : ICustomerRepository
    {
        //TODO: read from db or json file
        public Task<Customer?> GetCutomerAsync(int id)
        {
            Customer customer = null;
            if (id == 1) customer = new Customer(1, new DateTime(DateTime.Now.Year - 19, 1, 1));
            if (id == 2) customer = new Customer(1, new DateTime(DateTime.Now.Year - 30, 1, 1));
            if (id == 3) customer = new Customer(1, new DateTime(DateTime.Now.Year - 40, 1, 1));
            return Task.FromResult(customer);

        }
    }
}
