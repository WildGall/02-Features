using System;

namespace _01___working_with_the_constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(3,3);
            Renderer render = new Renderer();           

            render.DrawPlayer(player.PositionX, player.PositionY);
        }
    }

    class Player
    {
        public int PositionX { get; private set; }
        public int PositionY { get; private set; }        

        public Player(int positionX, int positionY)
        {
            PositionX = positionX;
            PositionY = positionY;
        }
    }

    class Renderer
    {
        public Renderer() { }

        public void DrawPlayer(int playerPositionX, int playerPositionY, char playerSymbol = '@')
        {
            Console.SetCursorPosition(playerPositionX, playerPositionY);
            Console.Write(playerSymbol);
        }
    }
}
