using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public class CombatStats
    {
        public Character Attacker;
        public int AttackerHp;
        public bool AttackerConsecutiveAttacks;
        public Weapon AttackerWeapon;
        public int AttackerMight;
        public int AttackerDefense;
        public int AttackerSpeed;
        public int AttackerHitRate;
        public int AttackerCritRate;

        public Character Defender;
        public int DefenderHp;
        public bool DefenderConsecutiveAttacks;
        public Weapon DefenderWeapon;
        public int DefenderMight;
        public int DefenderDefense;
        public int DefenderSpeed;
        public int DefenderHitRate;
        public int DefenderCritRate;

        public void ResolveAttack()
        {

            //Attacker

            //If consecutive, attacker again

            //Defender

            //If consecutive, defender again

            //If doubling, attacker again

            //If doubling, defender again
        }
    }
}
