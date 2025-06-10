using System;
using System.Threading;

namespace GraWZiemniaka
{
    public class BotPlayer : Player
    {
        private readonly GameBoard _board;
        private readonly IBotPlayer _strategia;

        public BotPlayer(string name, GameBoard board, IBotPlayer strategia) : base(name)
        {
            _board = board;
            _strategia = strategia;
        }

        public void WykonajRuch()
        {
            
            Thread.Sleep(500);

            var ruch = _strategia.WybierzRuch(_board, this);
            if (ruch != null)
            {
                _board.OznaczenieZiemniaka(ruch.X, ruch.Y, ruch.Z, this);
                Console.WriteLine($"{Name} zaznaczył ziemniaka ({ruch.X}, {ruch.Y}, {ruch.Z})");
            }
            else
            {
                Console.WriteLine($"{Name} nie ma dostępnych ruchów.");
            }
        }
    }
}
