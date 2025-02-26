﻿namespace EmployeeManagemnet.Models
{
    public class UserActivity
    {
        public string? CreatedbyId { get; set; }

        public DateTime? CreatedOn { get; set;}

        public string? ModifiedById { get; set; }   

        public DateTime? ModifiedOn { get;  set; }
    }
    public class ApprovalActivity : UserActivity
    {
        public string? ApprovedbyId { get; set; }

        public DateTime? ApprovedOn { get; set; }

    }
}
