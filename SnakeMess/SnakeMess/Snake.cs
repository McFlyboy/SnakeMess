using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace SnakeMess
{
    
    class Snake : Point
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


        }

        //Hver gang den har spist et eple, kjør denne metoden.
        public void Grow()
        {
            //Usikker på størrelsen her.
            body.Add(new Point(10, 10));
        }

        public void Render()
        {

        }

    }
}
