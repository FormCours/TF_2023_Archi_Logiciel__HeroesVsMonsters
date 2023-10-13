using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Recap_HVM.Models
{
    public class Dwarf : Hero
    {
        private const int BONUS_STAMINA = 2;

        #region Props
        public override int Stamina
        {
            get { return base.Stamina + BONUS_STAMINA; }
        }
        #endregion

        #region Ctor
        public Dwarf(string name) : base(name) { }
        #endregion
    }
}
