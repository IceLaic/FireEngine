using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public abstract class Class
    {
        public MovementType ClassMovement;
        public Class PreviousClass;
        public List<Class> PromotionOptions;

        public abstract int GetDamageMultiplier(Character defender);
    }
}
