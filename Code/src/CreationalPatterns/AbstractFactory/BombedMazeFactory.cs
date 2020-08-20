using System;

namespace AbstractFactory
{
    public class BombedMazeFactory : MazeFactory
    {
        public override Wall CreateWall()
        {
            return new BombedWall();
        }

        public override Room CreateRoom(int n)
        {
            return new RoomWithABomb(n);
        }
    }
}
