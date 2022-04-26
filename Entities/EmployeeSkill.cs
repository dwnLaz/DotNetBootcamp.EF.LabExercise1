using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkScheduleSolution.Entities
{
    public class EmployeeSkill
    {
        [Key]
        public int EmployeeSkillID { get; set; }

        // Foreign Key
        public int EmployeeID { get; set; }
        public Employee Employees { get; set; }
        public int SkillID { get; set; }
        public Skill Skills { get; set; }

        public int Level { get; set; }
        public int? YearsOfExperience { get; set; }
        public decimal HourlyWage { get; set; }
    }
}
