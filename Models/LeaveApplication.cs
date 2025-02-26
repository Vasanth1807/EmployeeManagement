using NuGet.Protocol.Core.Types;

namespace EmployeeManagemnet.Models
{
    public class LeaveApplication : ApprovalActivity
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }

        public int NoOfDays { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int DurationId { get; set; }

        public SystemCodeDetail Duration { get; set; }

        public int LeaveTypeId { get; set; }

        public LeaveType LeaveType { get; set; }

        public String? Attachments { get; set; }

        public String Description { get; set; }

        public int StatusId { get; set; }
        public SystemCodeDetail Status { get; set; }
    }
}
