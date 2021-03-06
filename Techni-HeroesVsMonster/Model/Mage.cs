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
            Mana = Intel * 2;
        }

        public override void Skill(Personnage monster)
        {
            int dégât = 0;
            dégât = this.Intel * 2;

            if (this.Mana >= 6)
            {
                Console.WriteLine($"{this.Name} brandit son bâton et envoie une boule de feu. Il inflige {dégât} dégâts.");
                monster.Hp -= dégât;
                hero.Mana -= 6;
            }
            else
            {
                Console.WriteLine("Vous n'avez plus assez de mana pour lancer un sort.");
            }
        }
    }
}
