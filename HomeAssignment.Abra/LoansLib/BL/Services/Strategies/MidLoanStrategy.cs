﻿using LoansLib.BL.Interfaces;
using LoansLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoansLib.BL.Services.Strategies
{
    public class MidLoanStrategy : ILoanStrategy
    {
        private readonly double _primeIntrest = 1;          //TODO: from config - dependency injection 
        private readonly double _extraMonthIntrest = 0.15;  //TODO: from config - dependency injection 


        public CalcLoanResponse CalcLoan(CalcLoanRequest calcLoanRequest)
        {

            double basicIntrest = 0;
            double effectivePrimeIntrest = 0;

            if (calcLoanRequest.RequestedAmount <= 5000)
            {
                basicIntrest = 2;
                effectivePrimeIntrest = 0;
            }

            if (calcLoanRequest.RequestedAmount > 5000 && calcLoanRequest.RequestedAmount <= 30000)
            {
                basicIntrest = 1.5;
                effectivePrimeIntrest = _primeIntrest;
            }

            if (calcLoanRequest.RequestedAmount > 30000)
            {
                basicIntrest = 1;
                effectivePrimeIntrest = _primeIntrest;
            }

            double extraMonthIntrest = calcLoanRequest.LoanPeriodInMonths <= 12 ? 0 : (calcLoanRequest.LoanPeriodInMonths - 12) * _extraMonthIntrest;
            double totalIntrest = basicIntrest + extraMonthIntrest + effectivePrimeIntrest;
            double totalReturnedAmount = calcLoanRequest.RequestedAmount + totalIntrest * calcLoanRequest.RequestedAmount / 100;

            CalcLoanResponse calcLoanResponse = new CalcLoanResponse(totalReturnedAmount, basicIntrest, effectivePrimeIntrest, extraMonthIntrest);
            return calcLoanResponse;
        }
    }
}
