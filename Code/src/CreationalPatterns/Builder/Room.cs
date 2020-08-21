namespace Builder
{
    public class Room : MapSite
    {
        private readonly int _roomNumber;
        private readonly MapSite[] _sides;
        public Room(int number)
        {
            _roomNumber = number;
            _sides = new MapSite[4];
        }

        public int RoomNumber => _roomNumber;

        public MapSite GetSide(Direction direction)
        {
            return _sides[(int)direction];
        }

        public void SetSide(Direction direction, MapSite mapSite)
        {
            _sides[(int)direction] = mapSite;
        }
    }
}
