using System;

namespace Builder
{
    public class MazeGame
    {
        public Maze CreateMaze(MazeBuilder builder)
        {
            builder.BuildMaze();
            builder.BuildRoom(1);
            builder.BuildRoom(2);
            builder.BuildDoor(1, 2);

            return builder.GetMaze();
        }

        public Maze CreateComplexMaze(MazeBuilder builder)
        {
            builder.BuildMaze();

            builder.BuildRoom(1);
            builder.BuildRoom(2);
            builder.BuildDoor(1, 2);
            builder.BuildRoom(3);
            builder.BuildDoor(2, 3);
            builder.BuildRoom(4);
            builder.BuildDoor(3, 4);

            return builder.GetMaze();
        }
    }
}
