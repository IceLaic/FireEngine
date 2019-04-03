using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public class StatBlockModifier
    {
        public int StrengthModifier;
        public int MagicModifier;
        public int DefenseModifier;
        public int ResistanceModifier;
        public int SpeedModifier;
        public int MovementModifier;

        public bool NegateEffectiveDamage;
        public bool NegateCriticals;
    }
}
