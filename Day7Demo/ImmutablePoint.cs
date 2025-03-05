namespace Day7Demo
{
	public class ImmutablePoint
	{
		//init keyword is used to set the value of the property only once
		public int x { get; init; }
		public int y { get; init; }

		public ImmutablePoint(int _x, int _y)
		{
			x = _x;
			y = _y;
		}

		public ImmutablePoint() : this(0, 0)
		{

		}
	}
}
