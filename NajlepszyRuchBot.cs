namespace GraWZiemniaka
{
    public class NajlepszyRuchBot : IBotPlayer
    {
        public Potato WybierzRuch(GameBoard board, Player bot)
        {
            return board.ZnajdzNajlepszyRuch();
        }
    }
}
