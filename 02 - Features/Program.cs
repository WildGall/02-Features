using System;

namespace _01___working_with_the_constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Renderer render = new Renderer();           

            render.DrawPlayer();
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
        Player player = new Player(3, 3);

        public Renderer() { }

        public void DrawPlayer(char playerSymbol = '@')
        {
            Console.SetCursorPosition(player.PlayerPositionX, player.PlayerPositionY);
            Console.Write(playerSymbol);
        }
    }
}
