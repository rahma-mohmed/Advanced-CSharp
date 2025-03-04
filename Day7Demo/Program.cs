namespace Day7Demo
{
	internal class Program
	{
		struct Point
		{
			public int x, y;
			public Point(int p1, int p2)
			{
				x = p1;
				y = p2;
			}
		}

		struct Rectangle
		{
			public Point topLeft, bottomRight;
			public Rectangle(Point p1, Point p2)
			{
				topLeft = p1;
				bottomRight = p2;
			}
			public void Print()
			{
				Console.WriteLine("Top Left: {0}, {1}, Bottom Right: {2}, {3}", topLeft.x, topLeft.y, bottomRight.x, bottomRight.y);
			}
		}
		static void Main(string[] args)
		{
			#region Boxing and Unboxing
			//Boxing is the process of converting a value type to the object (reference type)
			///move value from stack to heap (safe casting).
			int i = 123;
			object o = i;

			//Unboxing (unsafe casting: cast must be done explicity)
			int j = (int)o;
			#endregion

			#region Nullable Types
			//Nullable types are used to represent value type variables that can be assigned null.
			int? num1 = null;
			bool? boolval = null;

			//Nullable VT has additional properties
			//if (num1.HasValue)
			//{
			//	Console.WriteLine("num1 has value {0}", num1.Value);
			//}
			//else
			//{
			//	Console.WriteLine("num1 has no value");
			//}

			//Console.WriteLine(num1 ?? 2); //if num1 is null, return 2

			//int num2 = null;
			#endregion

			#region Null propagation operator
			//Null propagition operator is used to avoid null reference exceptions.
			string str = default;
			Console.WriteLine(str?.Length); //if str is null, return null instead of throwing exception
			#endregion

			#region Parameterize Constructor
			//Student s1 = new Student();
			//Student s2 = new Student("Rahma Mohmed", 20, "456 Main St");
			//Console.WriteLine(s1);
			//Console.WriteLine(s2);
			#endregion

			#region static class
			//Static class can only have static members
			//Static class is sealed and cannot be inherited
			//Static class cannot have instance constructor has only static constructor
			//Console.WriteLine(Draft.Add(2, 4));
			#endregion

			#region Access Modifiers
			//protected internal: Access is limited to the current assembly or types derived from the containing class (or both).
			//internal: Access is limited to the current assembly.
			//protected: Access is limited to the containing class or types derived from the containing class.

			Student s = new Student();
			s.Name = "John Doe";
			//s.Age = 18; //Error: Age is protected
			s.Address = "123 Main St";
			#endregion

			#region struct
			//Struct is a value type 
			//Structs can implement interfaces but they cannot inherit from another struct.
			#endregion
		}
	}
}
