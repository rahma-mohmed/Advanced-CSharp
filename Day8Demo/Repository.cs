namespace Day8Demo
{
	public class Repository
	{
		//public static List<Employee> GetEmployees()
		//{
		//	return new List<Employee>();
		//}

		public static List<Employee> GetEmployees { get; set; }
			= new List<Employee>() // static constructor call only once
		{
			new Employee(1, "John Doe", "IT", 1, 25),
			new Employee(2, "Jane Doe", "HR", 2, 30),
			new Employee(3, "Sam Smith", "IT", 1, 35),
			new Employee(4, "Tom Brown", "HR", 2, 40),
			new Employee(5, "Sara White", "IT", 1, 45),
			new Employee(6, "Mike Green", "HR", 2, 50),
			new Employee(7, "Mary Black", "IT", 1, 55),
			new Employee(8, "Paula Blue", "HR", 2, 60),
			new Employee(9, "Jim Grey", "IT", 1, 65),
			new Employee(10, "Tim Pink", "HR", 2, 70)
		};
	}
}
