using LoansLib.BL.Interfaces;
using LoansLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoansLib.BL.Services.Strategies
{
    public class JuniorLoanStrategy : ILoanStrategy
    {
        private readonly double _primeIntrest = 1;          //TODO: from config ith ddependency injection 
        private readonly double _extraMonthIntrest = 0.15;  //TODO: from config ith ddependency injection 

        public CalcLoanResponse CalcLoan(CalcLoanRequest calcLoanRequest)
        {
            double basicIntrest = 2;
            double effectivePrimeIntrest = _primeIntrest;
            double extraMonthIntrest = calcLoanRequest.LoanPeriodInMonths <= 12 ? 0 : (calcLoanRequest.LoanPeriodInMonths - 12) * _extraMonthIntrest;

            double totalIntrest = basicIntrest + effectivePrimeIntrest + extraMonthIntrest;
            double totalReturnedAmount = calcLoanRequest.RequestedAmount + totalIntrest * calcLoanRequest.RequestedAmount / 100;


            CalcLoanResponse calcLoanResponse = new CalcLoanResponse(totalReturnedAmount, basicIntrest, effectivePrimeIntrest, extraMonthIntrest);
            return calcLoanResponse;
        }



    }
}
