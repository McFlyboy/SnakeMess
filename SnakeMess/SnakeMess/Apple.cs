using System;

namespace SnakeMess
{
	class Apple : Point
	{
		public char Appearance { get; }
		public Apple(int x = 0, int y = 0) : base(x, y)
		{
			Appearance = '$';
		}
	}
}
