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
            var k = 0;
            while(k != 6)
            {
                MoveSnake(robot, Direction.Right);

                MoveSnakeDown(robot, Direction.Down);

                MoveSnake(robot, Direction.Left);

                k++;
            }
            MoveSnakeDown(robot, Direction.Down);
		}

        public static void MoveSnakeDown(Robot robot, Direction dir)
        {
            for (var j = 0; j < 2; j++)
            {
                robot.MoveTo(dir);
            }
        }

        public static void MoveSnake(Robot robot, Direction dir)
        {
             for ( var i = 0; i < 25; i++)
             {
                 robot.MoveTo(dir);
             }
        }

		public static void MoveOutFromPyramidMaze(Robot robot, int width, int height)
		{ 
		}
	}
}