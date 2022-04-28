using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techni_HeroesVsMonster.Model
{
    public class Inventaire
    {
        public enum Items
        {
            Gold, Potion, Cuir
        }

        Dictionary<Items,int> items = new Dictionary<Items,int>();

        public int this[Items type]
        {
            get { return items[type]; }

            set { items[type] = value; }

        }
    }
}
