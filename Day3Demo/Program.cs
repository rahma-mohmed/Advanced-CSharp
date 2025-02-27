namespace Day3Demo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// thread method take no parameter or only one parameter of object type
			//var thread1 = new Thread(new ThreadStart(ProcessBatch1));
			//thread1.Priority = ThreadPriority.Highest;

			//var thread2 = new Thread(ProcessBatch2);
			//thread2.Priority = ThreadPriority.Lowest;

			//Concurancy
			//thread1.Start();
			//thread2.Start();

			//thread1.IsBackground = true;
			//thread2.IsBackground = true;

			#region Thread Pool 
			//reuse old ideal threads
			var cts = new CancellationTokenSource();
			ThreadPool.QueueUserWorkItem(ProcessBatch1, cts.Token); //background
			ThreadPool.QueueUserWorkItem(ProcessBatch2, cts.Token); //background

			Console.ReadKey(); //foreground wait to execute it

			//Thread.Sleep(900);
			//cts.Cancel();
			#endregion
		}

		private static object _lock = new object();

		private static void ProcessBatch1(object? state)
		{
			var cancellationToken = (CancellationToken)state;

			if (cancellationToken.IsCancellationRequested)
			{
				Console.WriteLine("Cancellation requested");
				return;
			}
			// lock used to 
			lock (_lock)
			{
				for (int i = 0; i <= 1000; i++)
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine(i);
					Console.ForegroundColor = ConsoleColor.White;
				}
			}
		}

		private static void ProcessBatch2(object? state)
		{
			// the lock statement is used to ensure that a block of code runs to completion without being interrupted by other threads
			lock (_lock)
			{
				for (int i = 1001; i <= 2000; i++)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine(i);
					Console.ForegroundColor = ConsoleColor.White;
				}
			}
		}
	}
}
