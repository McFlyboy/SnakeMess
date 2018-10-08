
namespace SnakeMess
{
	class Game
	{
		private const string title = "Høyskolen Kristiania - SNAKE";
		private bool running;
		private bool shouldClose;

		private GameConsole console;
		public Game()
		{
			running = false;
			shouldClose = false;
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
			//Startup-code here...
			Run();
		}
		private void Run()
		{
			while (!shouldClose)
			{
				Update();
				Render();
			}
			Stop();
		}
		private void Update()
		{
			//Code that updates the game...
		}
		private void Render()
		{
			//Code that displays the snake and the apple...
            //Her bør vell både apple og snake ha sin egen render metode som blir kalt på?
		}
		private void Stop()
		{
			if (!running)
			{
				return;
			}
			running = false;
			//Shutdown-code here...
		}
		public static void Main(string[] args)
		{
			new Game().Start();
		}
	}
}
