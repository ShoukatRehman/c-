using System;

namespace SUZBUCONSOLE
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Student abcd = new Student();
			abcd.Name = "SHOUKAT REHMAN";
			abcd.ID = 0355;
			abcd.Mobile = "032899";
			abcd.ShowDetails(abcd);

			abcd.Name = "akbar ali";
			abcd.ID = 933;
			abcd.Mobile = "ouou";
			abcd.ShowDetails(abcd);
			


			Console.ReadLine();

		}
	}
}
