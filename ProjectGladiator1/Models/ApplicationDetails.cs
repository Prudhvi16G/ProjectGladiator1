using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProjectGladiator1.Models
{
    public partial class ApplicationDetails
    {
        public ApplicationDetails()
        {
            AccountDetails = new HashSet<AccountDetails>();
        }

        public int LoanId { get; set; }
        public int? ApplicationId { get; set; }
        public string Status { get; set; }
        public DateTime? ApprovalDate { get; set; }

        public virtual LoanDetails Application { get; set; }
        public virtual ICollection<AccountDetails> AccountDetails { get; set; }
    }
}
