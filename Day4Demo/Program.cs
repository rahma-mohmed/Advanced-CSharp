namespace Day4Demo
{
	internal class Program
	{
		static async Task Main(string[] args)
		{
			// cancellation token source
			var cts = new CancellationTokenSource();

			// main thread
			Console.WriteLine("Main thread Id: " + Environment.CurrentManagedThreadId);

			#region Task.Run
			//Task.Run(() => ProcessBatch1(cts.Token));
			#endregion



			#region Continuation task
			//var task1 = ProcessBatch1(cts.Token);
			//var task2 = await task1.ContinueWith(async t => await ProcessBatch2(cts.Token));
			//await task2;
			#endregion

			var task1 = ProcessBatch1(cts.Token);
			var task2 = ProcessBatch2(cts.Token);
			await Task.Delay(10);
			cts.Cancel();
			await Task.Delay(100);
			Console.WriteLine("Task1 status is: " + task1.Status);
			await task2;

			//await ProcessBatch1(cts.Token);
			//ProcessBatch2(cts.Token);

			//var task2 = ProcessBatch2(cts.Token);

			//await Task.WhenAll(task1, task2);
			//await Task.WhenAny(task1, task2);

			#region Foreground wait 
			Console.WriteLine("Please enter your name: ");
			var name = Console.ReadLine();
			Console.WriteLine($"Welcome {name} !");
			Console.ReadKey();
			#endregion
		}

		private static object _lock = new object();

		private static async Task ProcessBatch1(CancellationToken cancellationToken)
		{
			Console.WriteLine("Batch1  thread Id: " + Environment.CurrentManagedThreadId);
			//await Task.Delay(500);
			Console.WriteLine("Batch1 step2 thread Id: " + Environment.CurrentManagedThreadId);

			for (int i = 0; i <= 100; i++)
			{

				cancellationToken.ThrowIfCancellationRequested();

				//if (cancellationToken.IsCancellationRequested)
				//{
				//	Console.WriteLine("Cancellation requested");
				//	return;
				//}

				await Task.Delay(100);

				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine(i);
				Console.ForegroundColor = ConsoleColor.White;
			}
		}


		private static async Task ProcessBatch2(CancellationToken cancellationToken)
		{
			Console.WriteLine("Batch2 thread Id: " + Environment.CurrentManagedThreadId);
			//await Task.Delay(500);
			Console.WriteLine("Batch2 step2 thread Id: " + Environment.CurrentManagedThreadId);

			for (int i = 101; i <= 200; i++)
			{
				if (cancellationToken.IsCancellationRequested)
				{
					Console.WriteLine("Cancellation requested");
					return;
				}
				await Task.Delay(100);
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine(i);
				Console.ForegroundColor = ConsoleColor.White;
			}

		}
	}
}
