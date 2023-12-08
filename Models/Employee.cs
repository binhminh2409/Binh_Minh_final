using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRapp.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Column("employee_name")]
        public string EmployeeName { get; set; }

        [Column("employee_code")]
        public string EmployeeCode { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }  // Foreign key property

        public virtual Department Department { get; set; }

    }
}