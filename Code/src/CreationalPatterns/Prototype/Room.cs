using Prototype;

namespace Prototype
{
    public class Room : MapSite
    {
        private int _roomNumber;
        private readonly MapSite[] _sides;
        public Room()
        {
             
        }
        public Room(int number)
        {
            _roomNumber = number;
            _sides = new MapSite[4];
        }

        public MapSite GetSide(Direction direction)
        {
            return _sides[(int)direction];
        }

        public void SetSide(Direction direction, MapSite mapSite)
        {
            _sides[(int)direction] = mapSite;
        }

        public virtual Room Clone()
        {
            return new Room();
        }

        public void Initialize(int n)
        {
            _roomNumber = n;
        }
    }
}
