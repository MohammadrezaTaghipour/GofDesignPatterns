using System;

namespace FactoryMethod
{
    public class MazeGame
    {
        public virtual Maze CreateMaze()
        {
            var maze = MakeMaze();

            var r1 = MakeRoom(1);
            var r2 = MakeRoom(2);
            var theDoor = MakeDoor(r1, r2);

            maze.AddRoom(r1);
            maze.AddRoom(r2);

            r1.SetSide(Direction.North, MakeWall());
            r1.SetSide(Direction.East, theDoor);
            r1.SetSide(Direction.South, MakeWall());
            r1.SetSide(Direction.West, MakeWall());

            r2.SetSide(Direction.North, MakeWall());
            r2.SetSide(Direction.East, MakeWall());
            r2.SetSide(Direction.South, MakeWall());
            r2.SetSide(Direction.West, theDoor);

            return maze;
        }

        protected virtual Maze MakeMaze()
        {
            return new Maze();
        }

        protected virtual Room MakeRoom(int n)
        {
            return new Room(n);
        }

        protected virtual Wall MakeWall()
        {
            return new Wall();
        }

        protected virtual Door MakeDoor(Room r1, Room r2)
        {
            return new Door(r1, r2);
        }
    }
}
