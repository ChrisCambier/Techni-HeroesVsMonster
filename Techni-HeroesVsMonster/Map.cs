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
            Biome[,] position = new Biome[30, 30];
            Random rnd = new Random();

            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    position[i, j] = (Biome)rnd.Next(0, 5);
                    Console.WriteLine(position[i, j]); // Pas sûr que ça affiche un tableau xD
                }
            }
        }
        public void Display()
        {
            throw new NotImplementedException();
        }
        

    }
    enum Biome
    {
        Grass,
        Tree,
        Water,
        Ennemy,
        Tresor
    }
}
