using Day2Demo.Entities;
using Day2Demo.Extention_Methods;
using Day2Demo.Helper;

public class Program
{
	delegate int CalculateDelegate(int n1, int n2);

	static void Main(string[] args)
	{
		#region Extension Methods	

		int percentage = 50;
		if (percentage.IsBetween(0, 100))
		{
			Console.WriteLine("Valid percentage");
		}
		else
		{
			Console.WriteLine("Invalid percentage");
		}
		//---------------------------------------------------
		string str = "Hello World";
		Console.WriteLine(str.RemoveSpaces().Reverse());
		#endregion

		#region Recursive Function
		int Factorial(int n)
		{
			if (n <= 1)
			{
				return n;
			}
			return n * Factorial(n - 1);
		}
		Console.WriteLine(Factorial(4));

		PrintDirectoryFileSystem(@"D:\DotNet\Advanced C#\Advanced-CSharp\Day2Demo", 1);
		long size = GetDirectorySize(@"D:\DotNet\Advanced C#\Advanced-CSharp\Day2Demo");
		Console.WriteLine($"Directory size= {size / 1024} KB");

		void PrintDirectoryFileSystem(string path, int indent)
		{
			foreach (string file in Directory.GetFiles(path))
			{
				Console.WriteLine($"{new string(' ', indent)}{Path.GetFileName(file)}");
			}

			foreach (string directory in Directory.GetDirectories(path))
			{
				Console.WriteLine($"{new string(' ', indent)}{Path.GetFileName(directory)}");
				PrintDirectoryFileSystem(directory, indent + 1);
			}
		}

		static long GetDirectorySize(string dir)
		{
			long size = 0;
			foreach (var file in Directory.GetFiles(dir))
			{
				size += new FileInfo(file).Length;
			}

			foreach (var directory in Directory.GetDirectories(dir))
			{
				size += GetDirectorySize(directory);
			}

			return size;
		}
		#endregion

		#region Delegates

		// Delegate is a type that represents references to methods with a particular parameter list and return type.
		// Delegates are used to pass methods as arguments to other methods.
		int n1 = 10, n2 = 3;
		Calculate(n1, n2, Add);
		Calculate(n1, n2, Subtract);
		Calculate(n1, n2, Multiply);
		Calculate(n1, n2, Divide);
		Calculate(n1, n2, (a, b) => a % b);
		Calculate(n1, n2, delegate (int a, int b) { return a % b; });

		#region MultiCast Delegate

		// A multicast delegate is a delegate that has references to more than one function.
		CalculateDelegate dlg = Add;
		//Calculate(n1, n2, dlg);
		dlg += Subtract;
		dlg += Multiply;
		dlg += Divide;
		//dlg -= Add;
		Calculate(n1, n2, dlg);

		#endregion

		#endregion

		#region Events
		List<Employee> employees = new();
		for (var i = 0; i < 100; i++)
		{
			employees.Add(new Employee
			{
				Name = $"Employee {i}",
				BasicSalary = Random.Shared.Next(1000, 5001),
				Bouns = Random.Shared.Next(0, 1001)
			});
		}

		var salaryCalculator = new SalaryCalculator();
		salaryCalculator.EmployeeSalaryCalculated += (e, salary) =>
		{
			Console.WriteLine($"Employee {e.Name} salary {salary} is calculated");
		};
		salaryCalculator.CalculateSalary(employees, e => e.BasicSalary <= 2000);
		#endregion
	}
	static void Calculate(int n1, int n2, CalculateDelegate calculate)
	{
		Console.WriteLine(calculate(n1, n2));
	}

	static int Add(int n1, int n2)
	{
		Console.WriteLine("Add result:");
		return n1 + n2;
	}

	static int Subtract(int n1, int n2)
	{
		Console.WriteLine("Subtract result:");
		return n1 - n2;
	}

	static int Multiply(int n1, int n2)
	{
		Console.WriteLine("Multiply result:");
		return n1 * n2;
	}

	static int Divide(int n1, int n2)
	{
		Console.WriteLine("Divide result:");
		return n1 / n2;
	}
}