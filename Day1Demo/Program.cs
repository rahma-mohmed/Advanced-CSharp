namespace Day1Demo
{
	internal class Program
	{
		// Enum must be declared outside the Main method
		enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

		#region struct: value type, used to create complex data types
		struct Point
		{
			public int x;
			public int y;
			public Point(int x, int y)
			{
				this.x = x;
				this.y = y;
			}
		}
		#endregion

		static void Main(string[] args)
		{
			#region enum: value type, to represent a group of named constants
			Days today = Days.Mon;

			Days d1, d0;
			d0 = 0;
			d1 = (Days)1;

			//string Day = Console.ReadLine();
			//Days EnumDay = (Days)Enum.Parse(typeof(Days), Day);
			#endregion

			#region Class
			Student student; // reference from std, 0 byte
			student = new Student();
			//1. allocate member variable in heap
			//2. garbage collector overhead to manage memory
			//3. intialize - call constructor
			//4. make reference to the object
			#endregion

			#region Object
			object o1 = new object();
			o1 = new Student();
			//Console.WriteLine(o1.GetType().Name);
			#endregion

			#region Dynamic
			// dynamic keyword make clr identify variable
			dynamic x = 22;
			#endregion
		}
	}
}
