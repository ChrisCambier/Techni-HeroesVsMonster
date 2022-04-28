using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techni_HeroesVsMonster.Model;

namespace Techni_HeroesVsMonster
{
    public class Barbare : Personnage
    {
        public override void Skill(Personnage monster)
        {
            int dégât = 0,
                retour = 0;

            dégât = hero.Str * 2.5;
            retour = hero.Str * 0.3;
            Console.WriteLine($"{hero.Name} gonfle les muscles et frappe comme un enragé. Il inflige {dégât} dégâts et se blesse de {retour} points de vie.");
            monster.Hp -= dégât;
            hero.Hp -= retour;

        }
    }
}
