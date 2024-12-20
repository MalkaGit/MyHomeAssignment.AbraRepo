using LoansLib.BL.Interfaces;
using LoansLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoansLib.BL.Services
{
    public class LoanService : ILoanService
    {
        private readonly ICustomerService _customerService;
        private readonly ILoanStrategyFactory _loanStrategyFactory;

        public LoanService(ICustomerService customerService, ILoanStrategyFactory loanStrategyFactory)
        {
            _customerService = customerService;
            _loanStrategyFactory = loanStrategyFactory;
        }

        public async Task<CalcLoanResponse> CalcLoanAsync(CalcLoanRequest calcLoanRequest)
        {
            if (calcLoanRequest.LoanPeriodInMonths < 12)
                throw new ArgumentException("Period must be greater than 11");

            Customer? customer = await _customerService.GetCutomerAsync(calcLoanRequest.ClientId);
            if (customer == null)
                throw new ArgumentException("Cutomer does not exit");

            ILoanStrategy strategy = _loanStrategyFactory.GetLoanStrategy(customer.BirthDate);
            CalcLoanResponse calcLoanResponse = strategy.CalcLoan(calcLoanRequest);

            return calcLoanResponse;
        }
    }
}
