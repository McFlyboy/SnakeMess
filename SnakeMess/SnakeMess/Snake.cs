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
		public List<Point> Body { get; set; }
		public Direction CurrentDirection { get; set; }
		public char HeadAppearance { get; }
		public char BodyAppearance { get; }
		public Point Head { get { return Body[Body.Count - 1]; } }
		public Snake()
        {
			Body = new List<Point>()
			{
				new Point(10, 10),
				new Point(10, 10),
				new Point(10, 10),
				new Point(10, 10)
			};
			CurrentDirection = Direction.DOWN;
			HeadAppearance = '@';
			BodyAppearance = '0';
		}
		public bool IsNextHeadOverlappingBodypart()
		{
			Point nextHead = GetNextHead();
			for (int i = 0; i < Body.Count - 1; i++)
			{
				if (Body[i].X == nextHead.X && Body[i].Y == nextHead.Y)
				{
					return true;
				}
			}
			return false;
		}
		public Point GetNextHead()
		{
			Point nextHead = new Point(Head);
			switch (CurrentDirection)
			{
				case Direction.UP:
					nextHead.Y--;
					break;
				case Direction.DOWN:
					nextHead.Y++;
					break;
				case Direction.LEFT:
					nextHead.X--;
					break;
				case Direction.RIGHT:
					nextHead.X++;
					break;
			}
			return nextHead;
		}
        public Point Move(Point nextHead, bool keepTail)
        {
			Body.Add(nextHead);
			Point tail = null;
			if (!keepTail)
			{
				tail = Body[0];
				Body.RemoveAt(0);
			}
			return tail;
        }
		public enum Direction
		{
			UP, LEFT, DOWN, RIGHT
		}
    }
}
