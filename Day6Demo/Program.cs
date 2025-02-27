using System.Numerics;

namespace Day6Demo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var list = new GenericList<int>();
			list.Add(1);
			list.Add(2);
			list.Add(3);
			list.Add(4);
			list.Remove(2);
			var count = list.count();

			Console.WriteLine(Add(2, 4));
			Console.WriteLine(Add(2.5, 4.5));
		}

		public static T Add<T>(T a, T b) where T : INumber<T>
		{
			return a + b;
		}

		public class GenericList<T>
		{
			private readonly List<T> list = new();

			public void Add(T item)
			{
				list.Add(item);
			}

			public void Remove(T item)
			{
				list.Remove(item);
			}

			public int count()
			{
				return list.Count;
			}
		}
	}
}
