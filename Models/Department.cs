using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HRapp.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [Column("department_name", TypeName = "Varchar(200)")]
        public string DepartmentName { get; set; }
        [Column("department_code")]
        public int DepartmentCode { get; set; }
        [Column("department_location", TypeName = "Varchar(200)")]
        public string DepartmentLocation { get; set; }

        [ForeignKey("DepartmentId")]
        public virtual ICollection<Employee> Employees { get; set; }

        [NotMapped] // This property will not be mapped to the database
        public int EmployeeCount
        {
            get { return Employees?.Count ?? 0; }
        }

    }
}
