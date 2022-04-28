using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techni_HeroesVsMonster
{
    public interface ILoot
    {
        void TakeGold(int nbrGold);
        void TakePotion(int nbrPotion);
        void TakePeau (int nbrPeau);

        //void RecupererItem (int BonusInt , int BonusFor , int BonusEnd , int Bonus PV , int BonusMana )
    }
}
