namespace Day8Demo
{
	public class Employee
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Department { get; set; }
		public int Age { get; set; }
		public int DeptId { get; set; }
		public Employee(int id, string name, string department, int deptid, int age)
		{
			Id = id;
			Name = name;
			Department = department;
			DeptId = deptid;
			Age = age;
		}
		public Employee()
		{
			Id = 0;
			Name = "";
			Department = "";
			DeptId = 0;
			Age = 0;
		}

		public override string ToString()
		{
			return $"{Id} - {Name} - {Department} - {DeptId} - {Age}";
		}

		public Employee GetEmployeeById()
		{
			return new Employee(1, "John Doe", "IT", 1, 25);
		}
	}
}
