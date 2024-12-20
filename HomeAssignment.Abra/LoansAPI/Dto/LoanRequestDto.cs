namespace LoansAPI.Dto
{
    public class LoanRequestDto
    {
        public int ClientId { get; set; }
        public double RequestedAmount { get; set; }
        public int LoanPeriodInMonths { get; set; }
    }
}
