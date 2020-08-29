
namespace Prototype
{
    public class Door : MapSite
    {
        private Room _room1;
        private Room _room2;

        public Door()
        {

        }

        public Door(Room room1, Room room2)
        {
            _room1 = room1;
            _room2 = room2;
        }

        public Door(Door d)
        {
            _room1 = d._room1;
            _room2 = d._room2;
        }

        public Room OtherSideFrom(Room r)
        {
            return _room1 == r ? _room2 : _room1;
        }

        public void Initialize(Room r1, Room r2)
        {
            _room1 = r1;
            _room2 = r2;
        }

        public Door Clone()
        {
            return new Door(this);
        }
    }
}
