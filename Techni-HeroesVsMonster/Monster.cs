using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techni_HeroesVsMonster
{
    public class Monster : Personnage, ILoot , IStats 
    {
        
        // public int Stats { get; set; }

        public Monster(int str ,int hp, Inventaire inventaire , int nbrePeau) // en attente de voir la gestion inventaire depuis Personnage
        {
            this.Str = str.;
            this.Hp = hp;
            this.Inventaire.Gold = nbreGold;
            this.Inventaire.Items.Potion = nbrePotion;
            this.NbrePeau = nbrePeau;

        }

            public void TakeGold(int nbrGold)
        {
            this.NbreGold -= 0;
            Hero.Gold += nbreGold;
        }

        public void TakePeau(int nbrPeau)
        {
            this.NbrePeau -= 0;
            Hero.Gold += nbreGold;
        }

        public void TakePotion(int nbrPotion)
        {
            this.NbrePotion -= nbrPotion;
            Hero.Gold += nbreGold;
        }
    }
}
