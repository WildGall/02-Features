using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___working_with_the_constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Renderer render = new Renderer();
            Player player = new Player(3, 3);

            render.DrowPlayer(player.X, player.Y);
        }
    }

    class Player
    {
        public int X { get; private set; }

        public int Y { get; private set; }        

        public Player(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    class Renderer
    {
        public void DrowPlayer(int x, int y, char playerSymbol = '@')
        {
            Console.SetCursorPosition(x, y);
            Console.Write(playerSymbol);
        }
    }
}
