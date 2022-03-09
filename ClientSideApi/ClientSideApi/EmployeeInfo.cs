using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClientSideApi
{
	public class EmployeeInfo
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Key]

		public string EmpId { get; set; }

		public String EmpName { get; set; }

		public String Designation { get; set; }

		public String Department { get; set; }
	}
}
