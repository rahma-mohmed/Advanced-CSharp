using Day5Demo.Entities;

namespace Day5Demo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var employee = new Employee();
			employee.AddPayItem("Basic", 1000);
			employee.AddPayItem("HRA", 500);
			employee.AddPayItem("TA", 200);
			employee.AddPayItem("DA", 300);

			foreach (var payItem in employee)
			{
				Console.WriteLine($"{payItem.Name} : {payItem.Amount}");
			}

			for (int i = 0; i < employee.Count(); i++)
			{
				Console.WriteLine($"{employee[i].Name} : {employee[i].Amount}");
			}
		}
	}
}
