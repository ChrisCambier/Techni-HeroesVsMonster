using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techni_HeroesVsMonster.Model
{
    
    public class Personnage
    {
        
       
        protected int _Hp = 0;

        public int Str {  get; set; }
        public int Hp
        {
            get { return _Hp; }
            set { _Hp = value; }
        }
        
        public int End { get; set; }
        public int Intel { get; set; }
        public string Name { get; set; }
        public string Skin { get; set; }

        public Inventaire Inventaire;

        public Personnage()
        {
            Inventaire = new Inventaire(this);
        }
///////////////////////////////////////////////////////////////////////////////proprieter 
       


        
        private bool Combat(Personnage Monster)//methode a appeler par evenement 
        {
            int choix = 0;
            Boolean Mort=false;
            Console.WriteLine($"{Monster.Name} veux te goumer");



            while (!Mort)
            {
                while (choix < 1 || choix > 3)
                    choix = 0;
                {
                    Console.WriteLine("Choissir une action");
                    Console.WriteLine("1.Frapper\n2.Competence\n3.Fuir");
                    int.TryParse(Console.ReadLine(), out choix);
                }
                
                switch (choix)
                {
                    case 1:
                        Console.WriteLine("Pattate de forain");
                        Strike( Monster);

                        break;
                    case 2:
                        Skill();
                        break;
                    case 3:
                        Console.WriteLine("vous prenez la fuite");
                        return Mort;
                        break;

                }

                Tank(this, Monster);

                if (Hp <= 0 || Monster.Hp <= 0)
                {
                    Mort=true;
                }
            }
            return Mort;
            
        }

        public virtual void Tank(Personnage monster)
        {
            this._Hp -= monster.Str;
        }

        public void Strike(Personnage target)
        {
            target.Hp -= Str;
        }

        public virtual void Skill(Personnage monster)
        {
           // methode a gere avec les differente Class
        }

        public void Healing()
        {
            Inventaire.UseItem(Items.Potion);   
            //voir Useitem
        }

    }
}
