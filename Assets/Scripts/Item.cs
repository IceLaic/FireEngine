using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public abstract class Item
    {
        public string Name;

        public int StartingUses;
        public int CurrentUses;

        public StatBlockModifier GetHolderModifier(StatBlockModifier previousModifier) {
            return previousModifier;
        }

        public abstract bool IsUsable(Character user);

        public abstract void UseItem(Character user);
        
    }
}
