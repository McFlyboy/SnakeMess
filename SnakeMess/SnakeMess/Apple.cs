using System;

namespace SnakeMess
{
	class Apple : Point
	{
		private Random _rng = new Random();
		private char _appearance = '$';
		public char Appearance
		{
			get
			{
				return _appearance;
			}
		}
		public Apple() : base()
		{
			
		}
		public void setRandomPosition(int xLimit = 1, int yLimit = 1)
		{
			X = _rng.Next(0, xLimit);
			Y = _rng.Next(0, yLimit);
		}
	}
}
