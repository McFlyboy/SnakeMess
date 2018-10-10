
namespace SnakeMess
{
	class Game
	{
		private const string title = "Høyskolen Kristiania - SNAKE";
		private bool running;
		private bool shouldClose;

		private GameConsole console;
        private InputHandler inputHandler;

        private int newDirection;
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
            inputHandler = InputHandler.Instance;
			console.Title = title;
			//Startup-code here...
			Run();
		}
		private void Run()
		{
			while (!shouldClose)
			{
                if (inputHandler.EscapeKey())
                {
                    shouldClose = true;
                    break;
                }
                else if (inputHandler.UpKey())
                {
                    //newHead.Y -1
                    newDirection = 1;
                }
                else if (inputHandler.DownKey())
                {
                    //newHead.Y +1
                    newDirection = 2;
                }
                else if (inputHandler.LeftKey())
                {
                    //newHead.X -1
                    newDirection = 3;
                }
                else if (inputHandler.RightKey())
                {
                    //newHead.X +1
                    newDirection = 4;
                }
                else
                {
                    //Prompt user for action?
                }

                Update();
				Render();
			}
			Stop();
		}
		private void Update()
		{
            //Code that updates the game...

            //snake.Move(newDirection);
            
		}
		private void Render()
		{
			//Code that displays the snake and the apple...
            
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
