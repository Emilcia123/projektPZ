using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraWZiemniaka
{
    public class GameState
    {
        public List<Player> Players { get; set; } = new();
        public List<Potato> Potatoes { get; set; } = new();
        public int CurrentPlayerIndex { get; set; }
        public int BoardSize { get; set; }
    }


}
