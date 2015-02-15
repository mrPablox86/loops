using System;

namespace Mazes
{
	public static class MazeTasks
	{
		/*
		* Не нужно писать код выхода из произвольного лабиринта. Напишите, решение для конкретных лабиринтов.
		* Используйте циклы. Ваш К.О.
		* Постарайтесь решить задачу с ограничение "не более одного цикла на метод".
		* Подумайте, какие вспомогательные методы помогут сделать ваше решение более лаконичным, понятным и красивым.
		*/
		public static void MoveOutFromEmptyMaze(Robot robot, int width, int height)
		{
            while(true)
            {
                for (var i = 0; i < 6; i++)
                {
                    robot.MoveTo(Direction.Down);
                }

                for(var j = 0; j < 5; j++)
                {
                    robot.MoveTo(Direction.Right);
                }

                return;
            }
		}
       
		public static void MoveOutFromSnakeMaze(Robot robot, int width, int height)
		{
            while( robot.Pos.Y != ( height-2 ) )
            {
                MoveSnakeStraightOnRIght(robot, Direction.Right, width);
                MoveSnakeDown(robot, Direction.Down);
                MoveSnakeStraightOnLeft(robot, Direction.Left, width);
                if ( robot.Pos.Y != (height - 2) )
                    MoveSnakeDown(robot, Direction.Down);
            }
		}

        public static void MoveSnakeStraightOnRIght(Robot robot, Direction dir, int width)
        {
            while ( true )
            {
                if ( robot.Pos.X != width - 2 )
                    robot.MoveTo(dir);
                else
                    break;
            }
        }

        public static void MoveSnakeStraightOnLeft( Robot robot, Direction dir, int width )
        {
            while ( true )
            {
                if ( robot.Pos.X != width-(width - 1) )
                    robot.MoveTo(dir);
                else
                    break;
            }
        }

        public static void MoveSnakeDown( Robot robot, Direction dir )
        {
            for ( var i = 0; i < 2; i++ )
                robot.MoveTo(dir);
        }

        public static void MoveOutFromPyramidMaze( Robot robot, int width, int height )
		{
            var countStep = width;
            while ( robot.Pos.Y != height - (height - 1) )
            {
                MoveSnakeStraightOnRIght(robot, Direction.Right, countStep);
                MoveSnakeUp(robot, Direction.Up);
                countStep = countStep-2;
                MoveSnakeStraightOnLeft(robot, Direction.Left, countStep);
                MoveSnakeUp(robot, Direction.Up);
                countStep = countStep-2;
            }
        }

        public static void MoveSnakeUp( Robot robot, Direction dir )
        {
            for ( var i = 0; i < 2; i++ )
                robot.MoveTo(dir);
        }
	}
}