using System.Collections.Generic;
using System.Linq;

namespace Builder
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

        public Room RoomNumber(int n)
        {
            return _rooms.FirstOrDefault(r => r.RoomNumber == n);
        }
    }
}
