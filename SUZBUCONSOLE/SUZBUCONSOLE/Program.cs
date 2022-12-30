using System;
using System.Collections.Generic;

namespace SUZBUCONSOLE
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Student> student = new List<Student>();
			student.Add(new Student { ID = 123,Mobile="9324897",Name="Shoukat"});
			student.Add(new Student { ID = 1233, Mobile = "932487", Name = "Rehman" });

			foreach (var item in student)
			{
				Console.WriteLine("The ID {0} Name is {1} Phone Number is {2}",item.ID,item.Name,item.Mobile);
			}


			Console.ReadLine();

		}
	}
}
