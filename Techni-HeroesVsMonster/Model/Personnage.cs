using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techni_HeroesVsMonster.Model
{
    
    public class Personnage
    {
        
       
        private int _Hp = 0;

        public int Str {  get; set; }
        public int Hp
        {
            get { return _Hp; }
            set { _Hp = value; }
        }
        
        public int End { get; set; }
        public int Intel { get; set; }
        public string Nom { get; set; }
        public string Skin { get; set; }

       


        
        private bool Combat(Personnage Hero ,Personnage Monster)
        {
            int choix = 0;
            Boolean Mort=false;
            Console.WriteLine($"{Monster.Nom} veux te goumer");



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
                        Strike(Hero, Monster);

                        break;
                    case 2:
                        Skill();
                        break;
                    case 3:
                        Console.WriteLine("vous prenez la fuite");
                        return Mort;
                        break;

                }

                Tank(Hero, Monster);

                if (Hero.Hp <= 0 || Monster.Hp <= 0)
                {
                    Mort=true;
                }
            }
            return Mort;
            
        }

        public virtual void Tank(Personnage hero, Personnage monster)
        {
            hero.Hp -= monster.Str;
        }

        public void Strike(Personnage hero,Personnage monster)
        {
            monster.Hp -= hero.Str;
        }

        public abstract void Skill();
       
    }
}
