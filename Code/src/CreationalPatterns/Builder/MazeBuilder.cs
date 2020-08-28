using System;

namespace Builder
{
    public abstract class MazeBuilder
    {
        protected MazeBuilder()
        { }

        public virtual void BuildMaze()
        { }

        public virtual void BuildRoom(int n)
        { }

        public virtual void BuildDoor(int roomFrom, int roomTo)
        { }

        public virtual Maze GetMaze()
        { return default; }
    }
}
