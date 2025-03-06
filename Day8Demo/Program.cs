namespace Day8Demo
{
	internal class Program
	{
		public delegate void Print<T>(T value);

		public delegate U MyGenericDelegate1<in T, out U>(T value);

		public delegate U MyGenericDelegate2<in T, out U>(T x, T y);

		public delegate string GetEmployeeByAge(Employee employee);

		static void Main(string[] args)
		{
			#region Repository Pattern
			List<Employee> employees = Repository.GetEmployees;
			//foreach (var emp in employees)
			//{
			//	Console.WriteLine(emp);
			//}
			#endregion

			#region Reflection
			//Reflection is the ability of inspecting an assembly's metadata at runtime.
			//It is used to find all types in an assembly and/or dynamically invoke methods in an assembly.
			//Implementation:
			//1. Load the assembly
			//2. Get the type
			//3. Get the method
			//4. Invoke the method
			//Assembly assembly = Assembly.LoadFrom("Day8Demo.dll");
			//Type type = assembly.GetType("Day8Demo.Employee");
			//object obj = Activator.CreateInstance(type);
			//MethodInfo method = type.GetMethod("GetEmployeeById");
			//method.Invoke(obj, null);
			#endregion

			#region Filteration
			List<Employee> filteredEmployees = Filteration.FilterEmployees(employees, emp => emp.Id > 8);

			//foreach (var emp in filteredEmployees)
			//{
			//	Console.WriteLine(emp);
			//}

			#endregion

			#region Delegates (Pointer to function)
			//Delegates are reference types that hold the reference to a method.
			//Implementation:
			//1. Define the delegate
			//2. Create the delegate object
			//3. Invoke the delegate

			Func<int, int, int> add1 = (a, b) => a + b;
			Console.WriteLine(add1(10, 20));

			Action<int, int> add2 = (a, b) => Console.WriteLine(a + b);
			add2(10, 20);

			Predicate<int> isEven = num => num % 2 == 0;
			Console.WriteLine(isEven(10));

			//Custom delegate
			Employee emp = new Employee();
			Employee emp2 = new Employee(1, "Rahma", "IT", 1, 22);

			Func<Employee> getEmployee = emp.GetEmployeeById;
			Console.WriteLine(getEmployee.Invoke());

			Print<Employee> print = Trial.Write;
			print(emp2);
			#endregion

			GetEmployeeByAge getEmployeeByAge = emp => emp.Age <= 25 ? "young employee" : "old employee";
			Console.WriteLine(getEmployeeByAge(emp2));

			//predicate take one generic params and return bool
			//action take one or more generic params from 0 to 16 and return void 
			//func take one or more generic params from 0 to 16 and return one generic param
		}
	}
}
