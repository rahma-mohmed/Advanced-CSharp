namespace Day2Demo.Extention_Methods
{
	public static class NumberExtentions
	{
		public static bool IsBetween(this int number, int lower, int upper)
		{
			return number >= lower && number <= upper;
		}
	}
}
