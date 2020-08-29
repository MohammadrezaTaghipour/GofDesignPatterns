namespace Prototype
{
    public class RoomWithABomb : Room
    {
        public RoomWithABomb(int n) : base(n)
        {

        }

        public RoomWithABomb()
        {

        }

        public override Room Clone()
        {
            return new RoomWithABomb();
        }
    }
}
