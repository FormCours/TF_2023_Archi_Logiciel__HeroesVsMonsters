using Exo_Recap_HVM.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Recap_HVM.Models
{
    public class Orc : Monster, IGold
    {
        private const int BONUS_STRENGTH = 1;

        #region Props
        public int Gold { get; init; }

        public override int Strength
        {
            get { return base.Strength + BONUS_STRENGTH; }
        }
        #endregion

        #region Ctor
        public Orc() : base("Orque")
        {
            Gold = D6.Roll();
        }
        #endregion
    }
}
