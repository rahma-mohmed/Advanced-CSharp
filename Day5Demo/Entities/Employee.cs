using System.Collections;

namespace Day5Demo.Entities
{
	public class Employee : IEnumerable<PayItem>
	{
		public string Name { get; set; }

		private readonly List<PayItem> _payItems = new List<PayItem>();

		public void AddPayItem(string name, double value)
		{
			_payItems.Add(new PayItem { Name = name, Amount = value });
		}

		public IEnumerator<PayItem> GetEnumerator()
		{
			foreach (var payItem in _payItems)
			{
				yield return payItem;
			}

			//return _payItems.GetEnumerator();

			//return new PayItemsEnumerator(_payItems);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		//Custom Enumerator	
		private class PayItemsEnumerator : IEnumerator<PayItem>
		{
			private readonly List<PayItem> _payItems;
			private int _currentIndex = -1;

			public PayItemsEnumerator(List<PayItem> payItems)
			{
				_payItems = payItems;
			}

			public PayItem Current => _payItems[_currentIndex];

			object IEnumerator.Current => Current;

			public void Dispose()
			{

			}

			public bool MoveNext()
			{
				_currentIndex++;
				if (_currentIndex < _payItems.Count)
				{
					return true;
				}
				else
				{
					return false;
				}
			}

			public void Reset()
			{
				throw new NotImplementedException();
			}
		}
	}
}
