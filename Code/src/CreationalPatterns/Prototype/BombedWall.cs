namespace Prototype
{
    public class BombedWall : Wall
    {
        private bool _bomb;

        public BombedWall()
        {

        }

        public BombedWall(BombedWall b)
        {
            _bomb = b._bomb;
        }

        public override Wall Clone()
        {
            return new BombedWall(this);
        }
    }
}
