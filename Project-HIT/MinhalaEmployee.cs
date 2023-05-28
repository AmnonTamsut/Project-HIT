using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_HIT
{
	public class MinhalaEmployee : Employee
	{
		SchoolMain school;
		public MinhalaEmployee(int salary, int workerId, SchoolMain school)
		{
			this.salary = salary;
			this.workerId = workerId;
		}


		MinhalaEmployee GetMinhala() {
			return this;
		}


		public void getAllStudentsForCourse(string course)
		{


		}
	}
}
