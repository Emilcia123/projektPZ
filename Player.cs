using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraWZiemniaka
{
    public class Player : IPlayer
    {
        public string Name { get; set; }
        public int Wynik { get;  set; }

        public Player() { }
        public Player(string name)
        {
            Name = name;
            Wynik = 0;
        }

        public void DodajWynik(int punkty)
        {
            Wynik += punkty;
        }
    }
}
