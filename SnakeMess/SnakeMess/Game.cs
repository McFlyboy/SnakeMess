using System;
using System.Diagnostics;

namespace SnakeMess
{
	class Game
	{
		private const string title = "Høyskolen Kristiania - SNAKE";
		private bool running;
		private bool shouldClose;
		private bool paused;

		private GameConsole console;
        private InputHandler inputHandler;
		private Stopwatch timer;
		private Random random;

		private Board board;
		private Snake snake;
		private Apple apple;
		public Game()
		{
			running = false;
			shouldClose = false;
			paused = false;
		}
		public void Start()
		{
			if (running)
			{
				return;
			}
			running = true;
			console = GameConsole.Instance;
			console.Title = title;
			inputHandler = InputHandler.Instance;
			timer = new Stopwatch();
			random = new Random();
			board = new Board(console.Width, console.Height);
			snake = new Snake();
			apple = new Apple();
			PlaceApple();
			timer.Start();
			Run();
		}
		private void Run()
		{
			while (!shouldClose)
			{
                Update();
			}
			Stop();
		}
		private void Update()
		{
			if (inputHandler.HasNewKey())
			{
				if (inputHandler.Escape)
				{
					shouldClose = true;
					return;
				}
				else if (inputHandler.Space)
				{
					paused = !paused;
				}
				if (!paused)
				{
					if (inputHandler.Up && snake.CurrentDirection != Snake.Direction.DOWN)
					{
						snake.CurrentDirection = Snake.Direction.UP;
					}
					else if (inputHandler.Down && snake.CurrentDirection != Snake.Direction.UP)
					{
						snake.CurrentDirection = Snake.Direction.DOWN;
					}
					else if (inputHandler.Left && snake.CurrentDirection != Snake.Direction.RIGHT)
					{
						snake.CurrentDirection = Snake.Direction.LEFT;
					}
					else if (inputHandler.Right && snake.CurrentDirection != Snake.Direction.LEFT)
					{
						snake.CurrentDirection = Snake.Direction.RIGHT;
					}
				}
			}
			if (paused)
			{
				return;
			}
			if (timer.ElapsedMilliseconds < 100)
			{
				return;
			}
			timer.Restart();
			Point nextHead = snake.GetNextHead();
			if (!board.IsPointInside(nextHead) || snake.IsNextHeadOverlappingBodypart())
			{
				shouldClose = true;
				return;
			}
			console.SetSnakeDrawColor();
			console.Draw(snake.HeadAppearance, nextHead);
			console.Draw(snake.BodyAppearance, snake.Head);
			if (nextHead.X == apple.X && nextHead.Y == apple.Y)
			{
				snake.Move(nextHead, true);
				PlaceApple();
			}
			else
			{
				Point tail = snake.Move(nextHead, false);
				console.Draw(' ', tail);
			}
		}
		private void Stop()
		{
			if (!running)
			{
				return;
			}
			running = false;
		}
		private void PlaceApple()
		{
			if (snake.Body.Count >= board.Width * board.Height)
			{
				shouldClose = true;
				return;
			}
			while (true)
			{
				int x = random.Next(board.Width);
				int y = random.Next(board.Height);
				bool availableSpace = true;
				foreach (Point snakePart in snake.Body)
				{
					if (x == snakePart.X && y == snakePart.Y)
					{
						availableSpace = false;
						break;
					}
				}
				if (availableSpace)
				{
					console.Draw(' ', apple);
					apple.X = x;
					apple.Y = y;
					console.SetAppleDrawColor();
					console.Draw(apple.Appearance, apple);
					break;
				}
			}
		}
		public static void Main(string[] args)
		{
			new Game().Start();
		}
	}
}
