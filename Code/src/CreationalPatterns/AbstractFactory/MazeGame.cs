using System;

namespace AbstractFactory
{
    public class MazeGame
    {
        public Maze CreateMaze(MazeFactory factory)
        {
            var aMaze = factory.CreateMaze();
            var r1 = factory.CreateRoom(1);
            var r2 = factory.CreateRoom(2);
            var aDoor = factory.CreateDoor(r1, r2);

            aMaze.AddRoom(r1);
            aMaze.AddRoom(r2);

            r1.SetSide(Direction.North, factory.CreateWall());
            r1.SetSide(Direction.East, aDoor);
            r1.SetSide(Direction.South, factory.CreateWall());
            r1.SetSide(Direction.West, factory.CreateWall());

            r2.SetSide(Direction.North, factory.CreateWall());
            r2.SetSide(Direction.East, factory.CreateWall());
            r2.SetSide(Direction.South, factory.CreateWall());
            r2.SetSide(Direction.West, aDoor);

            return aMaze;
        }
    }
}
