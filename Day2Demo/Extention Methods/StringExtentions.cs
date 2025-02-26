namespace Day2Demo.Extention_Methods
{
	public static class StringExtentions
	{
		public static string RemoveSpaces(this string str)
		{
			return string.Join("", str.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
		}

		public static string Reverse(this string str)
		{
			char[] charArray = str.ToCharArray();
			Array.Reverse(charArray);
			return new string(charArray);
		}
	}
}
