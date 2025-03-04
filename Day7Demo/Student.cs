namespace Day7Demo
{
	public class Student
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public string Address { get; set; }

		public Student()
		{
			Name = "John Doe";
			Age = 18;
			Address = "123 Main St";
		}

		public Student(string _name, int _age, string _address)
		{
			Name = _name;
			Age = _age;
			Address = _address;
		}

		#region static constructor
		//Static constructor is used to initialize static data members
		//Static constructor is called only once
		//has no overload , has no return type, has no access modifier

		static int counter;

		static Student() // called once
		{
			counter = 0;
		}
		#endregion

		public override string ToString()
		{
			return $"{Name} - {Age} - {Address}";
		}
	}
}
