using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public abstract class Weapon : Wieldable
    {
        public int Might;
        public int Accuracy;
        public int CriticalRate;
        public int Weight;

        public bool MightUsesMagic;
        public bool DefenderUsesResistance;

        public abstract int GetDamageMultiplier(Character defender);

        public abstract int GetTriangleAdvantage(Character defender);

        public StatBlockModifier GetWielderModifier(StatBlockModifier previousModifier)
        {
            return previousModifier;
        }

        public StatBlockModifier GetDefenderModifier(StatBlockModifier previousModifier)
        {
            return previousModifier;
        }

        public bool ConsecutiveAttacks;
    }
}
