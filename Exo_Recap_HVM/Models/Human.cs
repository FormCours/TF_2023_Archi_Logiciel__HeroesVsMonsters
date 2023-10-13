using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Recap_HVM.Models
{
    public class Human : Hero
    {
        private const int BONUS_STAMINA = 1;
        private const int BONUS_STRENGTH = 1;

        #region Props
        public override int Stamina
        {
            get { return base.Stamina + BONUS_STAMINA; }
        }
        public override int Strength
        {
            get { return base.Strength + BONUS_STRENGTH; }
        }
        #endregion

        #region Ctor
        public Human(string name) : base(name) { }
        #endregion
    }
}
