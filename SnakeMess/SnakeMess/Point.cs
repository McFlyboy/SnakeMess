

namespace SnakeMess
{
	class Point
	{
		private int _x, _y;
		public int X
		{
			get
			{
				return _x;
			}
			set
			{
				_x = value;
			}
		}
		public int Y
		{
			get
			{
				return _y;
			}
			set
			{
				_y = value;
			}
		}
		public Point(int x = 0, int y = 0)
		{
			X = x;
			Y = y;
		}
		public Point(Point point)
		{
			X = point.X;
			Y = point.Y;
		}
	}
}
