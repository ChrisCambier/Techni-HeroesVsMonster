using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techni_HeroesVsMonster
{
    public class Tresor : ILoot
    {
        public int NbreGold { get; set; }
        public int NbrePotion { get; set; }
        public int NbrePeau { get; set; }
        protected Tresor(int nbreGold, int nbrePotion, int nombrePeau)
        {
            this.NbreGold = nbreGold;
            this.NbrePotion = nbrePotion;
            this.NbrePeau = nbrePotion;
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
