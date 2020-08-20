using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Abstrab Factory Pattern!");

            //var game = new MazeGame();
            //var factory = new MazeFactory();
            //var maze = game.CreateMaze(factory);

            var game = new MazeGame();
            var factory = new BombedMazeFactory();
            var maze = game.CreateMaze(factory);
            
        }
    }
}
