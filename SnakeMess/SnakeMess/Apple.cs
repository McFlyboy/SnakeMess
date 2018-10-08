using System;

namespace SnakeMess
{
	class Apple : Point
	{
		private Random _rng = new Random();
		public char Appearance { get; } = '$';
		public void SetRandomPosition(int xLimit = 1, int yLimit = 1)
		{
			X = _rng.Next(0, xLimit);
			Y = _rng.Next(0, yLimit);
		}
	}
}
