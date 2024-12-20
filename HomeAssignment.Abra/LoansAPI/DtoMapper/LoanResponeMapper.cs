using LoansAPI.Dto;
using LoansLib.Models;

namespace LoansAPI.DtoMapper
{
    public static class LoanResponeMapper
    {
        public static LoanResponseDto FromModel(this CalcLoanResponse model)
        {
            var result = new LoanResponseDto(model.TotalReturnedAmount, model.BasicIntrest, model.EffectivePrimeIntrest, model.ExtraMonthIntrest);
            return result;
        }
    }
}
