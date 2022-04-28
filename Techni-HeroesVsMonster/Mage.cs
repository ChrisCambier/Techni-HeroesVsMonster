using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public virtual Fireball(Mage.Intel, Mage.Mana)
        {

        }
}
