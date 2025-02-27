namespace Day4Demo
{
	internal class Program
	{
		static async Task Main(string[] args)
		{
			var cts = new CancellationTokenSource();
			Console.WriteLine("Main thread Id: " + Environment.CurrentManagedThreadId);
			//Task.Run(() => ProcessBatch1(cts.Token));
			//await ProcessBatch1(cts.Token);
			//ProcessBatch2(cts.Token);

			//Continuation task
			var task1 = ProcessBatch1(cts.Token);
			var task2 = await task1.ContinueWith(async t => await ProcessBatch2(cts.Token));

			await task2;

			//var task2 = ProcessBatch2(cts.Token);

			//await Task.WhenAll(task1, task2);
			//await Task.WhenAny(task1, task2);

			Console.WriteLine("Please enter your name: ");
			var name = Console.ReadLine();
			Console.WriteLine($"Welcome {name} !");
			Console.ReadKey();
		}

		private static object _lock = new object();

		private static async Task ProcessBatch1(CancellationToken cancellationToken)
		{
			Console.WriteLine("Batch1  thread Id: " + Environment.CurrentManagedThreadId);
			//await Task.Delay(500);
			Console.WriteLine("Batch1 step2 thread Id: " + Environment.CurrentManagedThreadId);

			for (int i = 0; i <= 100; i++)
			{
				if (cancellationToken.IsCancellationRequested)
				{
					Console.WriteLine("Cancellation requested");
					return;
				}
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
