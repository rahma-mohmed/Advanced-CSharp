namespace Day7Demo
{
	public class Student : ICloneable, IComparable
	{
		public string Name { get; set; }
		protected int Age { get; set; }
		internal string Address { get; set; }

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

		public object Clone()
		{
			return new Student { Name = this.Name, Age = this.Age, Address = this.Address };
		}

		public int CompareTo(object? obj)
		{
			Student student = obj as Student;
			return this.Name.CompareTo(student.Name);
		}
	}
}
