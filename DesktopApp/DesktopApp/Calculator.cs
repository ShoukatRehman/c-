using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp
{
	public class Calculator
	{
		public int Multiply(int x, int y)
		{
			return x * y;
		}
		public int Divide(int x, int y)
		{
			return x / y;
		}
		public int Addition(int x, int y)
		{
			return x + y;
		}
		public int Subtraction(int x, int y)
		{
				return x - y;
		}
	}
}
