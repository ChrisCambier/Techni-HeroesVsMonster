using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techni_HeroesVsMonster.Model
{
        public enum Items
        {
            Gold, Potion, Cuir
        }
    public class Inventaire
    {

        private Dictionary<Items,int> _Items = new Dictionary<Items,int>();
        private Personnage _Owner;

        public Inventaire(Personnage owner)
        {
            _Owner = owner;
        }


        public int this[Items type]
        {
            get => _Items.ContainsKey(type) ? _Items[type] : 0;

            private set => _Items[type] = value;

        }

        public Inventaire Add(Items item, int qtt = 0)
        {
            if (_Items.ContainsKey(item))
            {
                this[item] += qtt;
            }
            else
            {
                _Items.Add(item, qtt);
            }

            return this;
        }

        public Inventaire UseItem(Items item, int qtt = 1)
        {
            if (!_Items.ContainsKey(item)) return this;

            switch (item)
            {
                case Items.Gold:
                    break;
                case Items.Potion:
                    if (Items.Potion < 0) 
                    _Owner.Hp += 5;
                    break;
                case Items.Cuir:
                    break;
                default:
                    break;
            }

            _Items[item] -= qtt;

            return this;
        }
    }
}
