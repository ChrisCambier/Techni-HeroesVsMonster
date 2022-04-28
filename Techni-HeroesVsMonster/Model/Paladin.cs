using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techni_HeroesVsMonster.Model;

namespace Techni_HeroesVsMonster
{
    public class Paladin
    {
        public override Skill(Personnage hero, Personnage monster)
        {
            int dégât = 0,
                soin  = 0;

            dégât = hero.Str * 0.6;
            soin = (hero.Str * 0.6)/2;
            Console.WriteLine($"{hero.Name} voit son épée se gorger de puissance divine. Il inflige {dégât} dégâts et récupère {soin} points de vie.");
            monster.Hp -= hero.Str * 0.6;
            if (hero.Hp + soin >= hero._Hp)
                hero.Hp = hero._Hp;
            else
                hero.Hp += soin;
            
        }
        public override Tank(Personnage hero, Personnage monster)
        {
            int dégât = 0;
            dégât = monster.Str - 5;
            if (dégât > 0)
            {
                Console.WriteLine($"La lourde armure du Paladin le protège. {hero.Name} subit {dégât} dommage(s).");
                hero.Hp -= dégât;
            }
            else
            Console.WriteLine($"La lourde armure du Paladin le protège efficacement. {hero.Name} ne subit aucun dégât !");
        }
    }
}
