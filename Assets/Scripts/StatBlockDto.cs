using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public class StatBlockDto
    {
        public int Strength;
        public int Magic;
        public int Defense;
        public int Resistance;
        public int Speed;
        public int Movement;

        public StatBlockDto AddModifier(StatBlockModifier modifier)
        {
            return new StatBlockDto()
            {
                Strength = Strength + modifier.StrengthModifier,
                Magic = Magic + modifier.MagicModifier,
                Defense = Defense + modifier.DefenseModifier,
                Resistance = Resistance + modifier.ResistanceModifier,
                Speed = Speed + modifier.SpeedModifier,
                Movement = Movement + modifier.MovementModifier,
            };
        }
    }
}
