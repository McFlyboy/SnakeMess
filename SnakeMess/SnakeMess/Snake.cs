using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace SnakeMess
{
    
    class Snake
    {
        //Kanskje ha en instance variabel? 
    
        public List<Point> body;
        public Snake()
        {
            body = new List<Point>();
            body.Add(new Point(10, 10));
        }

        public void Move(int direction)
        {
            switch (direction)
            {
                case 1: //Move Up: newHead.Y -1;
                    break;
                case 2:
                    //Move Down: newHead.Y +1
                    break;
                case 3:
                    //Move Left: newHead.X -1
                    break;
                case 4:
                    //Move Right: newHead.X +1
                    break;
                default:
                    break;

            }
        }

        
        public void Grow()
        {
            
            //body.Add(new Point(10, 10));
        }

        public void Render()
        {

        }

    }
}
