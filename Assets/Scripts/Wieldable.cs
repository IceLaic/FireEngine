using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public abstract class Wieldable : Item
    {
        public abstract int MinimumRange(Character wielder);
        public abstract int MaximumRange(Character wielder);

        public WeaponType Type;
        public int RankRequired;

        public abstract bool IsWieldable(Character user);

        public override bool IsUsable(Character user)
        {
            return false;
        }
    }
}
