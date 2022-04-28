using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techni_HeroesVsMonster.Model
{
    public class Personnage
    {
        private int choix = 0;
        private int _Hp = 0;

        public int Str {  get; set; }
        public int Hp { get; set; }
        public int End { get; set; }
        public int Intel { get; set; }
        public string race { get; set; }
        public string Nom { get; set; }
        public string Skin { get; set; }


        
        private void Combat(Personnage Hero ,Personnage Monster)
        {
            Console.WriteLine($"{Monstre.Nom} veux te goumer");
            Console.WriteLine("Choissir une action");
            Console.WriteLine("1.Frapper\n2.Competence\n3.Fuir");

            while(choix<1 || choix > 3)
            {
                Console.WriteLine("1.Frapper\n2.Competence\n3.Fuir");
                int.TryParse(Console.ReadLine(), out choix);
            }
            switch (choix)
            {
                case 1:
                    Strike(Hero.Str);
                    Tank(Mons)
                    break;
            }
            
            Strike(Hero, Monstre);
            
            
        }

        
    }
}
