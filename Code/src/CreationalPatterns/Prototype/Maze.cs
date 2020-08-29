using System.Collections.Generic;

namespace Prototype
{
    public class Maze
    {
        private readonly List<Room> _rooms;
        public Maze()
        {
            _rooms = new List<Room>();
        }
        public Maze(Maze m)
        {
            _rooms = m._rooms;
        }

        public void AddRoom(Room r)
        {
            _rooms.Add(r);
        }

        public Maze Clone()
        {
            return new Maze(this);
        }
    }
}
