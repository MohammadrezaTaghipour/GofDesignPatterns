using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Builder Pattern!");

            //var game = new MazeGame();
            //var builder = new MazeBuilder();
            //var maze = game.CreateMaze(builder);

            var game = new MazeGame();
            var builder = new StandardMazeBuilder();
            var maze = game.CreateMaze(builder);
        }
    }
}
