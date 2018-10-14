using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeMess
{
    class InputHandler
    {
        private static InputHandler _instance;
        private ConsoleKeyInfo input;

        public static InputHandler Instance
        {
            get
            {
                if (_instance == null) {
                    _instance = new InputHandler();
                }
                return _instance;
            }
        }
		public bool Right { get { return input.Key == ConsoleKey.RightArrow; } }
		public bool Left { get { return input.Key == ConsoleKey.LeftArrow; } }
		public bool Up { get { return input.Key == ConsoleKey.UpArrow; } }
		public bool Down { get { return input.Key == ConsoleKey.DownArrow; } }
		public bool Space { get { return input.Key == ConsoleKey.Spacebar; } }
		public bool Escape { get { return input.Key == ConsoleKey.Escape; } }
		public bool HasNewKey()
		{
			bool available = Console.KeyAvailable;
			if (available)
			{
				input = Console.ReadKey(true);
			}
			return available;
		}
	}
}
