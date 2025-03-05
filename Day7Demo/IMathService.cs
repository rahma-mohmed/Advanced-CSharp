using System.Numerics;

namespace Day7Demo
{
	public interface IMathService<T> where T : INumber<T>
	{
		T Add(T a, T b);
		T Subtract(T a, T b);
		T Multiply(T a, T b);
		T Divide(T a, T b);
	}

	//in - input parameter, out - output parameter
	public interface IMyInterface<in T, out U>
	{
		U Add(T a, T b);
		U Subtract(T a, T b);
	}

	class MathService1 : IMathService<int>
	{
		public int Add(int a, int b)
		{
			return a + b;
		}
		public int Subtract(int a, int b)
		{
			return a - b;
		}
		public int Multiply(int a, int b)
		{
			return a * b;
		}
		public int Divide(int a, int b)
		{
			return a / b;
		}
	}

	class MathService2<T> : IMathService<T> where T : INumber<T>
	{
		public T Add(T a, T b)
		{
			return a + b;
		}
		public T Subtract(T a, T b)
		{
			return a - b;
		}
		public T Multiply(T a, T b)
		{
			return a * b;
		}
		public T Divide(T a, T b)
		{
			return a / b;
		}
	}
}
