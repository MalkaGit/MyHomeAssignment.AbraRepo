using LoansLib.BL.Interfaces;
using LoansLib.BL.Services.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoansLib.BL.Services
{
    public class LoanStrategyFactory : ILoanStrategyFactory
    {
        private static readonly JuniorLoanStrategy juniorLoanStrategy = new JuniorLoanStrategy();   //TDOO: consider Dependency injection
        private static readonly MidLoanStrategy midLoanStrategy = new MidLoanStrategy();            //TDOO: consider Dependency injection
        private static readonly SeniorLoanStrategy seniorLoanStrategy = new SeniorLoanStrategy();   //TDOO: consider Dependency injection

        public ILoanStrategy GetLoanStrategy(DateTime birthDate)
        {
            var age = DateTime.Today.Year - birthDate.Year; //TODO: refine according to months

            if (age <= 20)
                return juniorLoanStrategy;

            if (age > 20 && age <= 35)
                return midLoanStrategy;

            if (age > 35)
                return seniorLoanStrategy;

            throw new ApplicationException("age range not covered ");
        }
    }
}
