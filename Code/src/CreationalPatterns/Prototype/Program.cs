using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Prototype Pattern!");

            //var game = new MazeGame();
            //var factory = new MazePrototypeFactory(new Maze(), new Wall(),
            //    new Room(), new Door());
            //var maze = game.CreateMaze(factory);

            var game = new MazeGame();
            var factory = new MazePrototypeFactory(new Maze(), new BombedWall(),
                new RoomWithABomb(), new Door());
            var maze = game.CreateMaze(factory);
        }
    }
}
