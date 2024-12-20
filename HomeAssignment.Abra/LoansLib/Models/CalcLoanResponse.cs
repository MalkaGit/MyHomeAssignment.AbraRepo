using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoansLib.Models
{
    public class CalcLoanResponse
    {
        public CalcLoanResponse(double totalReturnedAmount, double basicIntrest, double effectivePrimeIntrest, double extraMonthIntrest)
        {
            TotalReturnedAmount = totalReturnedAmount;
            BasicIntrest = basicIntrest;
            EffectivePrimeIntrest = effectivePrimeIntrest;
            ExtraMonthIntrest = extraMonthIntrest;
        }

        public double TotalReturnedAmount { get; private set; }
        public double BasicIntrest { get; private set; }
        public double EffectivePrimeIntrest { get; private set; }
        public double ExtraMonthIntrest { get; private set; }
    }
}
