namespace LoansAPI.Dto
{
    public class LoanResponseDto
    {
        public LoanResponseDto() { }
        public LoanResponseDto(double totalReturnedAmount, double basicIntrest, double effectivePrimeIntrest, double extraMonthIntrest)
        {
            TotalReturnedAmount = totalReturnedAmount;
            BasicIntrest = basicIntrest;
            EffectivePrimeIntrest = effectivePrimeIntrest;
            ExtraMonthIntrest = extraMonthIntrest;
        }

        public double TotalReturnedAmount { get; set; }
        public double BasicIntrest { get; set; }
        public double EffectivePrimeIntrest { get; set; }
        public double ExtraMonthIntrest { get; set; }
    }
}
