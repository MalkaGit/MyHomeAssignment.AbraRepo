using LoansAPI.Dto;
using LoansLib.Models;

namespace LoansAPI.DtoMapper
{
    public static class LoanRequestMapper
    {
        public static CalcLoanRequest ToModel(this LoanRequestDto dto)
        {
            var result = new CalcLoanRequest(dto.ClientId, dto.RequestedAmount, dto.LoanPeriodInMonths);
            return result;
        }
    }
}
