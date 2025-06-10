using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraWZiemniaka
{
    public interface IBotPlayer
    {
        Potato WybierzRuch(GameBoard board, Player bot);
    }

}
