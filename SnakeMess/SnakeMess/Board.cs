

namespace SnakeMess
{
	class Board
	{
		private int _width, _height;
		public int Width
		{
			get
			{
				return _width;
			}
			set
			{
				_width = value;
			}
		}
		public Board(int width = 1, int height = 1)
		{
			_width = width;
			_height = height;
		}

	}
}
