using System;
namespace Sssaver.Models
{
    public class SavingsChallenge
    {
        public decimal Amount { get; set; }
        public DateTime ScheudledDate { get; set; }
        public DateTime ActualDate { get; set; }
        public bool IsCompleted { get; set; } = false;

        public SavingsChallenge(DateTime scheduledDate = new DateTime(), decimal amount = (decimal)0.0 )
        {
            ScheudledDate = scheduledDate;
            Amount = amount;
        }
    }
}
