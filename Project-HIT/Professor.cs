using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Project_HIT
{
	public class Professor : Employee
	{
		List<string> courses;
		List<Student> myStudents;
		public Professor(List<string> courses, List<Student> students)
		{
			this.Courses = courses;
			this.MyStudents = students;
			
		}

        public List<string> Courses { get => courses; set => courses = value; }
        public List<Student> MyStudents { get => myStudents; set => myStudents = value; }
    }
}
