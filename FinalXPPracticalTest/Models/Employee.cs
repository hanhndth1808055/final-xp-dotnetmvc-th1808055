using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalXPPracticalTest.Models
{
    public class Employee
    {
        [Required]
        [DisplayName("Employee ID")]
        public string EmployeeID { get; set; }
        [Required]
        [DisplayName("Employee Name")]
        public string EmployeeName { get; set; }
        [Required]
        public string Department { get; set; }
        [Required] 
        public int Salary { get; set; }
    }
}