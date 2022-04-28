using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techni_HeroesVsMonster.Model;

namespace Techni_HeroesVsMonster
{
    internal class Map
    {
        public List<Monster> Monsters { get; set; }
        public IHero Hero { get; set; }
        public int Rows { get; set; }
        public int Cols { get; set; }
        public Tuple<int, int> HeroPos { get; set; }
        public Object[,] Positions { get; set; }
        public List<ConsoleKey> ValidKeys = new List<ConsoleKey> { ConsoleKey.DownArrow, ConsoleKey.UpArrow, ConsoleKey.LeftArrow, ConsoleKey.RightArrow, ConsoleKey.P };


        public Map(int rows, int cols, IHero hero)
        {
            Monsters = new List<Monster>();
            Hero = hero;
            Positions = new Object[rows, cols];
            Rows = rows;
            Cols = cols;
        }

        public void Randomize()
        {
            throw new NotImplementedException();
        }
        public void Display()
        {
            throw new NotImplementedException();
        }

        public ConsoleKey UserInput()
        {
            ConsoleKeyInfo userInput = Console.ReadKey();
            do
            {
                userInput = Console.ReadKey();
            } while (ValidKeys.Exists(x => x == userInput.Key));
            return userInput.Key;

        }

        public void HandleInput(ConsoleKey userInput)
        {
            
            switch (userInput)
            {
                case ConsoleKey.DownArrow:
                    MoveHero(HeroPos.Item1 - 1, HeroPos.Item2);
                    break;
                case ConsoleKey.UpArrow:
                    MoveHero(HeroPos.Item1 + 1, HeroPos.Item2);
                    break;
                case ConsoleKey.RightArrow:
                    MoveHero(HeroPos.Item1, HeroPos.Item2 + 1);
                    break;
                case ConsoleKey.LeftArrow:
                    MoveHero(HeroPos.Item1, HeroPos.Item2 - 1);
                    break;
                case ConsoleKey.P:
                    Hero.Healing();
                    break;
            }
        }

        private void MoveHero(int x, int y)
        {
            Monster m;
            if (IsValidPos(x, y))
            {
                if (IsEmpty(x, y))
                {
                    Tuple<int, int> pos = new Tuple<int, int>(x, y);
                    HeroPos = pos;
                }
                m = OccupiedBy(x, y);
                if (m is not null)
                {
                    Hero.Combat(m);
                }
            }
            

        }

        private bool IsValidPos(int x, int y)
        {
            bool isValid = false;
            if (x >= 0 && y >= 0 && x < Rows && y < Cols)
            {
                isValid = true;
            }
            return isValid;
        }

        private bool IsEmpty(int x, int y)
        {
            bool isValid = false;
            if (Positions[x, y] is null)
            {
                isValid = true;
            }
            return isValid;
        }

        private Monster OccupiedBy(int x, int y)
        {
            Monster monster;
            if (Positions[x, y] is Monster);
            {
                monster = (Monster)Positions[x, y];
            }
            return monster;
        }


    }
}
