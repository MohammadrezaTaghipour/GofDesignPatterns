using System;

namespace Builder
{
    public class StandardMazeBuilder : MazeBuilder
    {
        private Maze _currentMaze;

        public StandardMazeBuilder()
        { }

        public override void BuildMaze()
        {
            _currentMaze = new Maze();
        }

        public override void BuildRoom(int n)
        {
            if (_currentMaze.RoomNumber(n) == null)
            {
                var room = new Room(n);
                _currentMaze.AddRoom(room);
                room.SetSide(Direction.North, new Wall());
                room.SetSide(Direction.South, new Wall());
                room.SetSide(Direction.East, new Wall());
                room.SetSide(Direction.West, new Wall());
            }
        }

        public override void BuildDoor(int roomFrom, int roomTo)
        {
            var r1 = _currentMaze.RoomNumber(roomFrom);
            var r2 = _currentMaze.RoomNumber(roomTo);
            var d = new Door(r1, r2);
            r1.SetSide(CommonWall(r1, r2), d);
            r2.SetSide(CommonWall(r2, r1), d);
        }

        public override Maze GetMaze()
        {
            return _currentMaze;
        }

        private Direction CommonWall(Room r1, Room r2)
        {
            var eastSide = r1.GetSide(Direction.East);
            var westSide = r2.GetSide(Direction.West);

            if (eastSide is Wall && westSide is Wall)
                return Direction.East;
            else
                return Direction.West;
        }
    }
}
