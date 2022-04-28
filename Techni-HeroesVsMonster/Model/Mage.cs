using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techni_HeroesVsMonster.Model;

namespace Techni_HeroesVsMonster
{
    public class Mage : Personnage
    {
        private int _Mana;
        public int Mana { get; set; }
        public Mage(int Intel)
    {
        Mana = Intel*2;
    }

        public override Skill(Mage hero, Personnage monster)
        {
            int dégât = 0;
            dégât = hero.Intel * 2;

            if (hero.Mana >= 6)
            {
                Console.WriteLine($"{hero.Name} brandit son bâton et envoie une boule de feu. Il inflige {dégât} dégâts.");
                monster.Hp -= dégât;
                hero.Mana -= 6;
            }
            else
            {
                Console.WriteLine("Vous n'avez plus assez de mana pour lancer un sort.");
            }
        }
}
