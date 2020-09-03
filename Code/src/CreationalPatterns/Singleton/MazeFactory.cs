using System;

namespace Singleton
{
    public class MazeFactory
    {
        private static MazeFactory _instance;
        private MazeFactory()
        { }

        public static MazeFactory Instance()
        {
            if (_instance == null)
                _instance = new MazeFactory();
            return _instance;
        }

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
