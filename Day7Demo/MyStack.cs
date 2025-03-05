namespace Day7Demo
{
	public class MyStack<T> //where T : new() // T must have a default constructor (parameterless constructor), struct (value type)
	{
		T[] arr;
		int size;
		int top;

		public MyStack(int size)
		{
			this.size = size;
			arr = new T[size];
			top = -1;
		}

		public void Push(T item)
		{
			if (top == size - 1)
			{
				Console.WriteLine("Stack is full");
				return;
			}
			arr[++top] = item;
		}

		public T Pop()
		{
			if (top == -1)
			{
				Console.WriteLine("Stack is empty");
				return default(T);
			}
			return arr[top--];
		}

		public T GetTop()
		{
			if (top == -1)
			{
				Console.WriteLine("Stack is empty");
				return default(T);
			}
			return arr[top];
		}

		public int GetCount()
		{
			return top + 1;
		}
	}
}
