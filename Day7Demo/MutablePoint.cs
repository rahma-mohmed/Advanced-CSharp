namespace Day7Demo
{
	public class MutablePoint
	{
		public int x { get; set; }
		public int y { get; set; }

		public MutablePoint(int _x, int _y)
		{
			x = _x;
			y = _y;
		}

		public MutablePoint() : this(0, 0)
		{

		}
	}
}
