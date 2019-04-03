using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public class Character
    {
        public string Name;
        public Class CurrentClass;

        public int CurrentHP;

        public StatBlockDto BaseStats;

        public List<Tuple<WeaponType, int>> WeaponRanks;
        
        public List<Item> Inventory;

        public Weapon GetEquippedWeapon()
        {
            foreach (Item item in Inventory)
            {
                if (item is Weapon)
                {
                    Weapon weapon = item as Weapon;
                    if (weapon.IsWieldable(this))
                    {
                        return item as Weapon;
                    }
                }
            }
            return null;
        }

        public StatBlockModifier GetCumulativeStatBlockModifier()
        {
            StatBlockModifier modifier = new StatBlockModifier();

            modifier = GetEquippedWeapon().GetWielderModifier(modifier);
            
            foreach (Item item in Inventory)
            {
                modifier = item.GetHolderModifier(modifier);
            }

            return modifier;
        }

        public StatBlockDto GetEffectiveStatBlock()
        {
            StatBlockModifier modifier = GetCumulativeStatBlockModifier();

            StatBlockDto effectiveStats = BaseStats.AddModifier(modifier);
            effectiveStats.Speed -= GetEquippedWeapon().Weight;

            return effectiveStats;
        }

        public int GetDamageMultiplier(Character opponent)
        {
            int multiplier = 1;

            StatBlockModifier opponentModifier = opponent.GetCumulativeStatBlockModifier();

            Weapon attackingWeapon = GetEquippedWeapon();

            int weaponMultiplier = attackingWeapon.GetDamageMultiplier(opponent);
            int classMultiplier = CurrentClass.GetDamageMultiplier(opponent);

            if (weaponMultiplier > classMultiplier)
            {
                multiplier = weaponMultiplier;
            } else
            {
                multiplier = classMultiplier;
            }

            if (multiplier > 1 && opponentModifier.NegateEffectiveDamage)
            {
                multiplier = 1;
            }

            return multiplier;
        }

        public CombatStats GetCombatForecast(Character opponent)
        {
            Weapon attackingWeapon = GetEquippedWeapon();
            Weapon defendingWeapon = opponent.GetEquippedWeapon();
            
            StatBlockDto unitStats = GetEffectiveStatBlock();
            StatBlockDto opponentStats = opponent.GetEffectiveStatBlock();

            int attackerMultiplier = GetDamageMultiplier(opponent);
            int defenderMultiplier = opponent.GetDamageMultiplier(this);

            int attackerMight = 0;
            int defenderMight = 0;
            int attackerDefense = 0;
            int defenderDefense = 0;

            if (attackingWeapon.MightUsesMagic)
            {
                attackerMight = unitStats.Magic;
                defenderDefense = unitStats.Resistance;
            } else
            {
                attackerMight = unitStats.Strength;
                defenderDefense = unitStats.Defense;
            }

            if (defendingWeapon.MightUsesMagic)
            {
                defenderMight = unitStats.Magic;
                attackerDefense = unitStats.Resistance;
            }
            else
            {
                defenderMight = unitStats.Strength;
                attackerDefense = unitStats.Defense;
            }

            attackerMight *= attackerMultiplier;
            defenderMight *= defenderMultiplier;

            return null;
        }
    }
}
