using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Recap_HVM.Models
{
    public abstract class Monster : Character
    {
        protected Monster(string name) : base(name) { }
    }
}
