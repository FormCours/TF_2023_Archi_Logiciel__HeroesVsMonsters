using Exo_Recap_HVM.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Recap_HVM.Models
{
    public class Dragonet : Monster, IGold, ILeather
    {
        private const int BONUS_STAMINA = 1;

        #region Props
        public int Gold { get; init; }
        public int Leather { get; init; }
        public override int Stamina
        {
            get { return base.Stamina + BONUS_STAMINA; }
        }
        #endregion

        #region Ctor
        public Dragonet() : base("Dragonnet")
        {
            Gold = D6.Roll();
            Leather = D4.Roll();
        }
        #endregion
    }
}
