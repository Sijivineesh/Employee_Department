
using System;

using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;

using System.Linq;

using System.Web;

namespace EmployeeDepartment.Models.EmployeeModel

{

    public class Employee

    {

        public Employee()

        {

        }
        public int ID { get; set; }

        [Required]

        [StringLength(50, ErrorMessage="Only 50 characters allowed!" )]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Contact { get; set; }
        [Required]
	    public string DOB{ get; set; }
        [Required]
	    public string Gender{ get; set; }
        [Required]
        public string DepartmentID{ get; set; }
        [Required]
        public string Designation{ get; set; }
        [Required]
    	public string EmailID{ get; set; }
        [Required]
        public string Password{ get; set; }
        [Required]
        public string Status{ get; set; }
        [Required]
        public string JoinedDate{ get; set; }
        [Required]
        public string DepartmentID{ get; set; }

        
    }

}