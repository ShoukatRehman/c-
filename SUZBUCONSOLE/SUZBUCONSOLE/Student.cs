using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUZBUCONSOLE
{
	public class Student
	{
		public int ID{ get; set; }
		public string Name { get; set; }
		public string Mobile { get; set; }
		public void ShowDetails(Student student)
		{
			Console.WriteLine("ID of the student is{0} and Name of the student is {1}\n Mobile Number is {2}", student.ID, student.Name, student.Mobile);
		}
	}
}
