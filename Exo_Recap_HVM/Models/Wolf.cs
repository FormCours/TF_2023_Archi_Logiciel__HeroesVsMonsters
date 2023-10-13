using Exo_Recap_HVM.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Recap_HVM.Models
{
    public class Wolf : Monster, ILeather
    {
        #region Props
        public int Leather { get; init; }
        #endregion

        #region Ctor
        public Wolf() : base("Loup")
        {
            Leather = D4.Roll();
        }
        #endregion
    }
}
