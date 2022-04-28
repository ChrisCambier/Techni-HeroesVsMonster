using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techni_HeroesVsMonster
{
    public class Dice
    {
        static int Throw(int Max)
        { 
            Random aleatoire = new Random();
            int resultat = aleatoire.Next(1,Max+1); // Génère un entier compris entre 1 et Max

            return resultat;
        }
    }
}
