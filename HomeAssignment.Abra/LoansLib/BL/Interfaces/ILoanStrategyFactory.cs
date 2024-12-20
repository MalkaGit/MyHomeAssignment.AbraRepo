using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoansLib.BL.Interfaces
{
    public interface ILoanStrategyFactory
    {
        ILoanStrategy GetLoanStrategy(DateTime birthDate);
    }
}
