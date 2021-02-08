using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaszGrochowskiZadanieDomowe2
{
    public class Melee : Fighter, IFight
    {
        /// <summary>
        /// A constructor
        /// </summary>
        /// <param name="rand"></param>
        public Melee(Random rand)
        {
            Name = RandomizeName(rand);
            Health = RandomizeHealth(rand);
            Attack = RandomizeAttackStrength(rand);
            Armor = RandomizeArmor(rand);
            AttackType = RandomizeAttackType(rand);
            ArmorType = RandomizeArmorType(rand);
            FigherType = "Melee";
        }

        public override int AttackEnemy(Fighter fighter)
        {
            return Fight(fighter);
        }

        public int Fight(Fighter enemy)
        {
            float damage = (this.Attack * (100 - enemy.Armor)) / 100;
            damage *= CounterMultiplier(this.AttackType, enemy.ArmorType);
            //Front line attackers deal a bit more damage to front line defenders...
            if (enemy is Melee)
                damage *= 1.1f;
            //... and a bit less to back line defenders
            else
                damage *= 0.9f;

            //Inflicting damage to defender
            enemy.Health -= (int)damage;
            return (int)damage;
        }

        public override int RandomizeArmor(Random rand)
        {
            return rand.Next(40, 71);
        }

        public override int RandomizeAttackStrength(Random rand)
        {
            return rand.Next(40, 71);
        }

        public override int RandomizeHealth(Random rand)
        {
            return rand.Next(200, 401);
        }
    }
}
