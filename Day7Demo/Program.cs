using System.Collections;
using System.Text;

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

			#region Clone Object from array
			int[] arr = { 1, 2, 3, 4, 5 };
			int[] arr2 = (int[])arr.Clone();
			//Console.WriteLine(arr.GetHashCode());
			//Console.WriteLine(arr2.GetHashCode());
			#endregion

			#region Clone Object from class
			Student student01 = new Student { Name = "Rahma", Address = "Damietta" };
			Student student02 = (Student)student01.Clone();
			//Console.WriteLine(student01.GetHashCode());
			//Console.WriteLine(student02.GetHashCode());
			#endregion

			#region Compare Objects
			Student[] students = new Student[] {
				 new Student { Name = "Rahma", Address = "Damietta" },
				 new Student { Name = "Ali", Address = "Cairo" },
				 new Student { Name = "Hassan", Address = "Damietta" },
			};
			Array.Sort(students);
			//foreach (var student in students)
			//{
			//	Console.WriteLine(student);
			//}
			#endregion

			#region String
			//String is a reference type
			//String is immutable
			string str1 = "Hello";
			//Console.WriteLine(str1.GetHashCode());
			string str2 = "Hello";
			str1 += " World";
			//Console.WriteLine(str1.GetHashCode());
			//Console.WriteLine(str1 == str2); //True
			//Console.WriteLine(str1.Equals(str2)); //True
			#endregion

			#region StringBuilder
			//StringBuilder is mutable
			//StringBuilder is faster than string
			StringBuilder sb = new StringBuilder("Hello");
			sb.Append(" World");
			//Console.WriteLine(sb);
			#endregion

			#region Generic
			//Generic class is a class that can work with any data type

			MyStack<int> stack = new MyStack<int>(3);
			stack.Push(1);
			stack.Push(2);
			stack.Push(3);
			//Console.WriteLine(stack.Pop());

			MyStack<string> stack2 = new MyStack<string>(3);
			stack2.Push("Hello");
			stack2.Push("World");
			stack2.Push("C#");

			//Console.WriteLine(stack2.Pop());
			#endregion

			#region Array
			//Array is a collection of similar data types has a fixed size
			#endregion

			#region non-generic collection (ArrayList) [carry data of object type]
			//ArrayList is a non-generic collection
			//ArrayList can store multiple data types
			//ArrayList is slower than generic collections
			ArrayList list = new ArrayList();
			list.Add(1);
			list.Add("Hello");
			list.Add(3.14);
			//foreach (var item in list)
			//{
			//	Console.WriteLine(item);
			//}

			#endregion

			#region generic collection (List<T>) [carry data of specific type]
			//List<T> is a generic collection
			//List<T> can store a single data type
			//List<T> is faster than non-generic collections
			List<int> list2 = new List<int>(2);
			list2.Add(1); //2
			list2.Add(2); //2
			list2.Add(3); //4
			list2.Add(4); //4
			list2.Add(5); //8
						  //list2.Remove(5);
						  //list2.RemoveAt(2);
						  //list2.RemoveRange(1, 2);
			list2.TrimExcess();
			Console.WriteLine(list2.Capacity);
			#endregion

			#region Dictionary
			//Dictionary<TKey, TValue> is a generic collection
			//Dictionary<TKey, TValue> is a collection of key-value pairs
			//Dictionary<TKey, TValue> is faster than non-generic collections
			Dictionary<int, string> dict = new Dictionary<int, string>();
			dict.Add(1, "One");
			dict.Add(2, "Two");
			dict.Add(3, "Three");

			//foreach (var item in dict)
			//{
			//	Console.WriteLine(item.Key + " - " + item.Value);
			//}
			#endregion
		}
	}
}

