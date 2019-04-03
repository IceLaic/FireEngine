using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public interface ICombatModifier
    {
        void PreCombat(ref Unit attacker, ref Unit defender);
        void PostCombat(ref Unit attacker, ref Unit defender);
    }
}
