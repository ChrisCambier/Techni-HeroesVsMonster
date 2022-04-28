using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techni_HeroesVsMonster
{
    internal class Map
    {
        public List<IMonstres> Monstres { get; set; }
        public IHero Hero { get; set; }
        public ConsoleUI UI { get; set; }
        public Object[,] Positions { get; set; }

        public Map(int rows, int cols, IHero hero)
        {
            Monstres = new List<IMonstres>();
            Hero = hero;
            UI = new ConsoleUI();
            Positions = new Object[rows, cols];
        }
        public void Randomize()
        {
            throw new NotImplementedException();
        }
        public void Display()
        {
            throw new NotImplementedException();
        }
        

    }
}
