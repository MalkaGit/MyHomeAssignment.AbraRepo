using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoansLib.Models
{
    public class CalcLoanRequest
    {
        public CalcLoanRequest(int clientId, double requestedAmount, int loanPeriodInMonths)
        {
            ClientId = clientId;
            RequestedAmount = requestedAmount;
            LoanPeriodInMonths = loanPeriodInMonths;
        }

        public int ClientId { get; private set; }
        public double RequestedAmount { get; private set; }
        public int LoanPeriodInMonths { get; private set; }
    }
}
