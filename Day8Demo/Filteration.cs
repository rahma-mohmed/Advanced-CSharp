namespace Day8Demo
{
	public class Filteration
	{
		public static List<Employee> FilterEmployees(List<Employee> employees, Func<Employee, bool> filter)
		{
			List<Employee> filteredEmployees = new List<Employee>();
			foreach (var emp in employees)
			{
				if (filter(emp))
				{
					filteredEmployees.Add(emp);
				}
			}
			return filteredEmployees;
		}
	}
}
