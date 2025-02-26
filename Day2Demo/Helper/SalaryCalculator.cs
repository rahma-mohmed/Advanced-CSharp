using Day2Demo.Entities;

namespace Day2Demo.Helper
{
	public class SalaryCalculator
	{
		public delegate bool CalculateSalaryDelegate(Employee e);

		public event EmployeeSalaryCalculatedEventHandler EmployeeSalaryCalculated;

		public delegate void EmployeeSalaryCalculatedEventHandler(Employee e, double salary);

		public void CalculateSalary(List<Employee> employees, CalculateSalaryDelegate predicate)
		{
			foreach (Employee e in employees)
			{
				if (predicate(e))
				{
					double salary = e.BasicSalary + e.Bouns;
					//Console.WriteLine($"Employee {e.Name} salary {salary} is calculated");
					EmployeeSalaryCalculated?.Invoke(e, salary);
				}
			}
		}
	}
}
