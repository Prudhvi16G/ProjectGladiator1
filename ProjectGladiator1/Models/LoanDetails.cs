using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProjectGladiator1.Models
{
    public partial class LoanDetails
    {
        public LoanDetails()
        {
            ApplicationDetails = new HashSet<ApplicationDetails>();
        }

        public int ApplicationId { get; set; }
        public string Username { get; set; }
        public int? MaxLoanAmountGrantable { get; set; }
        public decimal? InterestRate { get; set; }
        public int? Tenure { get; set; }
        public int? LoantAmount { get; set; }
        public DateTime? LoanStartDate { get; set; }

        public virtual PersonalDetails UsernameNavigation { get; set; }
        public virtual ICollection<ApplicationDetails> ApplicationDetails { get; set; }
    }
}
