using LoansLib.BL.Interfaces;
using LoansLib.Data.Interfaces;
using LoansLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoansLib.BL.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Task<Customer?> GetCutomerAsync(int id)
        {
            return _customerRepository.GetCutomerAsync(id);
        }
    }
}
