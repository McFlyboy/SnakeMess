
namespace SnakeMess
{
	class Board
	{
		public int Width { get; set; }
		public int Height { get; set; }
		public Board(int width, int height)
		{
			if (width < 1)
			{
				width = 1;
			}
			if (height < 1)
			{
				height = 1;
			}
			Width = width;
			Height = height;
		}
		public bool IsPointInside(Point point)
		{
			if (point.X < 0 || point.X >= Width)
			{
				return false;
			}
			else if (point.Y < 0 || point.Y >= Height)
			{
				return false;
			}
			return true;
		}
	}
}
