using System;

namespace _01___working_with_the_constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(3,3);
            Renderer render = new Renderer();           

            render.DrawPlayer(player.PlayerPositionX, player.PlayerPositionY);
        }
    }

    class Player
    {
        public int PlayerPositionX { get; private set; }
        public int PlayerPositionY { get; private set; }        

        public Player(int x, int y)
        {
            PlayerPositionX = x;
            PlayerPositionY = y;
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
