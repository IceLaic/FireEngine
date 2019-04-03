using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public static class TerrainTypeUtils
    {
        public static int GetMovementCost(MovementType type, TerrainType terrain)
        {
            return 1;
        }

        public static int GetDefense(TerrainType terrain)
        {
            if (terrain == TerrainType.Forest)
            {
                return 1;
            }
            //else if (terrain == TerrainType.)
            return 0;
        }

        public static int GetAvoid(TerrainType terrain)
        {
            return 0;
        }
    }
}
