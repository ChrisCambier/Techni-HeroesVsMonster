using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techni_HeroesVsMonster.Model;

namespace Techni_HeroesVsMonster
{
    public class Paladin : Personnage
    {
        public override void Skill(Personnage monster)
        {
            int dégât = 0,
                soin  = 0;

            dégât = this.Str * 0.6;
            soin = (this.Str * 0.6)/2;
            Console.WriteLine($"{this.Name} voit son épée se gorger de puissance divine. Il inflige {dégât} dégâts et récupère {soin} points de vie.");
            monster.Hp -= this.Str * 0.6;
            if (this.Hp + soin >= this._Hp)
                this.Hp = this._Hp;
            else
                this.Hp += soin;
            
        }
        public override void Tank( Personnage monster)
        {
            int dégât = 0;
            dégât = monster.Str - 5;
            if (dégât > 0)
            {
                Console.WriteLine($"La lourde armure du Paladin le protège. {this.Name} subit {dégât} dommage(s).");
                this.Hp -= dégât;
            }
            else
            Console.WriteLine($"La lourde armure du Paladin le protège efficacement. {this.Name} ne subit aucun dégât !");
        }
    }
}
