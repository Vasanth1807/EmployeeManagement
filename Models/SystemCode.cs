using System.ComponentModel.DataAnnotations;

namespace EmployeeManagemnet.Models
{
    public class SystemCode : UserActivity
    {
        [Key]

        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
