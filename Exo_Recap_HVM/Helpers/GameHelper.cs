using Exo_Recap_HVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Recap_HVM.Helpers
{
    public static class GameHelper
    {
        public static int GenerateStats()
        {
            Dice d6 = new Dice(6);
            List<int> results = new List<int>();

            // Lancer de dés
            for (int i = 0; i < 4; i++)
            {
                // Lancer d'un D6
                int res = d6.Roll();

                // Ajout du resultat dans la liste
                results.Add(res);
            }

            // Trouver le pire resultat
            int indexWorstResult = 0;
            for (int i = 1; i < results.Count; i++)
            {
                // Comparaison de resultat avec le pire enregistré
                if (results[i] < results[indexWorstResult])
                {
                    // Si vrai -> Le resultat devient le pire
                    indexWorstResult = i;
                }
            }

            // Retirer le pire resultat
            results.RemoveAt(indexWorstResult);

            // Faire la somme des dés restant
            int stats = 0;
            foreach (int res in results)
            {
                stats += res;
            }

            return stats;
        }

        public static int GetModifier(int stat)
        {
            // Méthode alternative, sans "if"
            int modifierMax = 2;
            int modifier = (stat / 5) - 1;

            return Math.Min(modifier, modifierMax);

            // NB: L'énoncé est fait pour faire pousser a faire un if/switch/ternaire ;)
        }
    }
}
