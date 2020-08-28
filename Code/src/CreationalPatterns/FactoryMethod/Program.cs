using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Facotry Method Pattern!");

            //var game = new MazeGame();
            //var maze = game.CreateMaze();

            var game = new BombedMazeGame();
            var maze = game.CreateMaze();
        }
    }
}
