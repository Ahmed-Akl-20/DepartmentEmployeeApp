using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DepartmentEmployeeApp.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Department Name")]
        public string Name { get; set; }

        public List<Employee>? Employees { get; set; }
    }
}
