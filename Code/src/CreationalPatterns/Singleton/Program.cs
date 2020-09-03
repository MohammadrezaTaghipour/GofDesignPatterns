using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Singleton pattern!");

            var game = new MazeGame();
            var factory = MazeFactory.Instance();
            var maze = game.CreateMaze(factory);
        }
    }
}
