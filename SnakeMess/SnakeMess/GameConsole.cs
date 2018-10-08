using System;

namespace SnakeMess
{
	class GameConsole
	{
		public int Width { get { return Console.WindowWidth; } }
		public int Height { get { return Console.WindowHeight; } }
		public string Title { set { Console.Title = value; } }
		private static GameConsole _instance;
		public static GameConsole Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new GameConsole();
				}
				return _instance;
			}
		}
		private GameConsole()
		{
			Console.CursorVisible = false;
		}
		public void SetAppleDrawColor()
		{
			Console.ForegroundColor = ConsoleColor.Green;
		}
		public void SetSnakeDrawColor()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
		}
	}
}
