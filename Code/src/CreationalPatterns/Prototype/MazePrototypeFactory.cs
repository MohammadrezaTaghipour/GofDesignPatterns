using System;

namespace Prototype
{
    public class MazePrototypeFactory : MazeFactory
    {
        private readonly Maze _prototypeMaze;
        private readonly Room _prototypeRoom;
        private readonly Wall _prototypeWall;
        private readonly Door _prototypeDoor;

        public MazePrototypeFactory(Maze m, Wall w, Room r, Door d)
        {
            _prototypeMaze = m;
            _prototypeWall = w;
            _prototypeRoom = r;
            _prototypeDoor = d;
        }

        public override Wall CreateWall()
        {
            var wall = _prototypeWall.Clone();
            return wall;
        }

        public override Door CreateDoor(Room r1, Room r2)
        {
            var door = _prototypeDoor.Clone();
            door.Initialize(r1, r2);
            return door;
        }

        public override Room CreateRoom(int n)
        {
            var room = _prototypeRoom.Clone();
            room.Initialize(n);
            return room;
        }
    }
}
