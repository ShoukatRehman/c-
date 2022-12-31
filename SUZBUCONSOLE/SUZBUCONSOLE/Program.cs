using System;
using System.Collections.Generic;

namespace SUZBUCONSOLE
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Car car=new Car();
			car.Company = "Audi";
			car.Model = "2020";
			car.Name = "A8";
			car.color = "Full Black";
			car.Doors = 4;
			car.NumberofSeats= 5;

			Console.WriteLine("The Name of the Car is {0}{1}\nThe Color of Car is {2}",car.Company,car.Name,car.color);
			Console.WriteLine("Let's drive the Car");
			Console.WriteLine(car.IncreaseSpeed());
			Console.WriteLine(car.IncreaseSpeed());
			car.Brake();
			Console.WriteLine(car.IncreaseSpeed());

			 
			


			Console.ReadLine();

		}
	}
}
