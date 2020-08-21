namespace Builder
{
    public class Door : MapSite
    {
        private readonly Room _room1;
        private readonly Room _room2;
        private readonly bool _isOpen;
        public Door(Room room1, Room room2)
        {
            _room1 = room1;
            _room2 = room2;
        }

        public virtual Room OtherSideFrom(Room r)
        {
            return _room1 == r ? _room2 : _room1;
        }
    }
}
