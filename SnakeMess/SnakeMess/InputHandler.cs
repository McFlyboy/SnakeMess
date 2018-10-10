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

        public void readKey()
        {
            input = Console.ReadKey(true);    
        }

        public bool RightKey()
        {
            return input.Key == ConsoleKey.RightArrow;
        }

        public bool LeftKey()
        {
            return input.Key == ConsoleKey.LeftArrow;
        }

        public bool UpKey()
        {
            return input.Key == ConsoleKey.UpArrow;
        }

        public bool DownKey()
        {
            return input.Key == ConsoleKey.DownArrow;
        }


        public bool EscapeKey()
        {
            return input.Key == ConsoleKey.Escape;
        }
    }
}
