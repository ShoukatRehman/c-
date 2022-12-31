using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUZBUCONSOLE
{
	public class Car
	{
		private int speed=0;

		public string Model { get; set; }
		public string Company { get; set; }
		public string color { get; set; }
		public string Name { get; set; }
		public string Gear { get; set; }
		public int NumberofSeats { get; set; }
		public int  Doors { get; set; }

		public int IncreaseSpeed()
		{
			speed++;
			return speed;
		}
		public int DecreaseSpeed()
		{
			speed--;
			return speed;
		}
		public void Brake()
		{
			speed = 0;
			Console.Write("Car Stopped");
		}
	}
}
