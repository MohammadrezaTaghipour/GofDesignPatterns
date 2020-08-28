using System.Collections.Generic;

namespace FactoryMethod
{
    public class Maze
    {
        private readonly List<Room> _rooms;
        public Maze()
        {
            _rooms = new List<Room>();
        }

        public void AddRoom(Room r)
        {
            _rooms.Add(r);
        }
    }
}
