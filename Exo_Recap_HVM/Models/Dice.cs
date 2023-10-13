using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Recap_HVM.Models
{
    public sealed class Dice // Classe scelée -> Heritage interdit
    {
        #region Field
        private int _Minimum;
        private int _Maximum;
        private Random _Rng;
        #endregion

        #region Props
        public int Minimum { get { return _Minimum; } }
        public int Maximum { get { return _Maximum; } }
        #endregion

        #region Ctor
        public Dice(int maximum, int minimum = 1)
        {
            _Maximum = maximum;
            _Minimum = minimum;
            _Rng = new Random();
        }
        #endregion

        #region Methods
        public int Roll()
        {
            return _Rng.Next(Minimum, Maximum + 1);
        }
        #endregion
    }
}
