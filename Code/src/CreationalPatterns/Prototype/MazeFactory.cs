using System;

namespace Prototype
{
    public class MazeFactory
    {
        public virtual Maze CreateMaze()
        {
            return new Maze();
        }

        public virtual Wall CreateWall()
        {
            return new Wall();
        }

        public virtual Room CreateRoom(int n)
        {
            return new Room(n);
        }

        public virtual Door CreateDoor(Room r1, Room r2)
        {
            return new Door(r1, r2);
        }
    }
}
