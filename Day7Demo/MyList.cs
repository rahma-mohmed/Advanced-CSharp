namespace Day7Demo
{
	public class MyList : List<int>
	{
		public void Add(int item)
		{
			//Keep Normal Behavior 
			base.Add(item); //base keyword is used to access the base class members
			Console.WriteLine("Item Added");
		}
	}
}
