using Exo_Recap_HVM.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Recap_HVM.Models
{
    public abstract class Hero : Character, IGold, ILeather
    {
        #region Props
        public int Gold { get; private set; }
        public int Leather { get; private set; }
        #endregion

        #region Ctor
        public Hero(string name) : base(name)
        {
            Gold = 0;
            Leather = 0;
        }
        #endregion

        #region Methods
        public void RestoreHealth()
        {
            Healing(HealthMax - Health);
        }

        public void Loot(Monster monster)
        {
            if(monster is IGold)
            {
                // Cast Manuel
                Gold += ((IGold) monster).Gold;
            }

            if(monster is ILeather element)
            {
                // Cast automatique (Nouvelle syntaxe)
                Leather += element.Leather;
            }
        }
        #endregion
    }
}
