using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public abstract class Staff : Wieldable
    {
        public abstract bool CanUseOnSelf();
        public abstract bool CanUseOnAllies();
        public abstract bool CanUseOnEnemies();
        public abstract bool CanUseOnEnvironment();
    }
}
