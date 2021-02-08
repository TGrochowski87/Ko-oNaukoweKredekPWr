using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaszGrochowskiZadanieDomowe2
{
    public abstract class Fighter
    {
        /// <summary>
        /// Fighter's name
        /// </summary>
        private string name;
        /// <summary>
        /// Fighter's health points
        /// </summary>
        private int health;
        /// <summary>
        /// Fighter's attack power
        /// </summary>
        private int attack;
        /// <summary>
        /// Fighter's armor value
        /// </summary>
        private int armor;
        /// <summary>
        /// Fighter's attack type
        /// </summary>
        private string attackType;
        /// <summary>
        /// Fighter's armor type
        /// </summary>
        private string armorType;
        /// <summary>
        /// Fighter's type
        /// </summary>
        private string fighterType;

        //Getters and setters
        public string Name { get => name; set => name = value; }
        public int Health { get => health; set => health = value; }
        public int Attack { get => attack; set => attack = value; }
        public int Armor { get => armor; set => armor = value; }
        public string AttackType { get => attackType; set => attackType = value; }
        public string ArmorType { get => armorType; set => armorType = value; }
        public string FigherType { get => fighterType; set => fighterType = value; }

        /// <summary>
        /// A method responsible for randomizing health points
        /// </summary>
        /// <param name="rand"></param>
        /// <returns></returns>
        public abstract int RandomizeHealth(Random rand);
        /// <summary>
        /// A method responsible for randomizing attack power
        /// </summary>
        /// <param name="rand"></param>
        /// <returns></returns>
        public abstract int RandomizeAttackStrength(Random rand);
        /// <summary>
        /// A method responsible for randomizing armor value
        /// </summary>
        /// <param name="rand"></param>
        /// <returns></returns>
        public abstract int RandomizeArmor(Random rand);
        /// <summary>
        /// A method responsible for enemy attacking functionality
        /// </summary>
        /// <param name="fighter"></param>
        /// <returns></returns>
        public abstract int AttackEnemy(Fighter fighter);

        /// <summary>
        /// A method responsible for randomizing attack type
        /// </summary>
        /// <param name="rand"></param>
        /// <returns></returns>
        public string RandomizeAttackType(Random rand)
        {
            int choice = rand.Next(0, 5);

            switch (choice)
            {
                case 0:
                    return "Steel";
                case 1:
                    return "Fire";
                case 2:
                    return "Water";
                case 3:
                    return "Demonic";
                case 4:
                    return "Spiritual";
                default:
                    return "";
            }
        }

        /// <summary>
        /// A method responsible for randomizing armor type
        /// </summary>
        /// <param name="rand"></param>
        /// <returns></returns>
        public string RandomizeArmorType(Random rand)
        {
            int choice = rand.Next(0, 5);

            switch (choice)
            {
                case 0:
                    return "Steel";
                case 1:
                    return "Dark";
                case 2:
                    return "Molten";
                case 3:
                    return "Ice";
                case 4:
                    return "Soul";
                default:
                    return "";
            }
        }

        /// <summary>
        /// A method responsible for randomizing name
        /// </summary>
        /// <param name="rand"></param>
        /// <returns></returns>
        public string RandomizeName(Random rand)
        {
            int choice = rand.Next(0, 18);

            switch (choice)
            {
                case 0:
                    return "Fred";
                case 1:
                    return "Arnold";
                case 2:
                    return "Philip";
                case 3:
                    return "Mark";
                case 4:
                    return "Greg";
                case 5:
                    return "Martin";
                case 6:
                    return "Valdo";
                case 7:
                    return "Sigfried";
                case 8:
                    return "Morris";
                case 9:
                    return "Artur";
                case 10:
                    return "Michael";
                case 11:
                    return "Wilma";
                case 12:
                    return "Martha";
                case 13:
                    return "Anna";
                case 14:
                    return "Danny";
                case 15:
                    return "Olgierd";
                case 16:
                    return "Lucy";
                case 17:
                    return "Iris";
                default:
                    return "";
            }
        }

        /// <summary>
        /// A method returning an adequate damage multiplier based on attack type/armor type counters
        /// </summary>
        /// <param name="attack"></param>
        /// <param name="armor"></param>
        /// <returns></returns>
        public float CounterMultiplier(string attack, string armor)
        {
            switch (attack)
            {
                case "Steel":
                    {
                        return 1;
                    }
                case "Spiritual":
                    {
                        if (armor == "Dark")
                            return 1.5f;
                        else if (armor == "Molten")
                            return 1.25f;
                        else if (armor == "Steel")
                            return 1.0f;
                        else if (armor == "Ice")
                            return 0.75f;
                        else if (armor == "Soul")
                            return 0.5f;
                    }
                    break;
                case "Demonic":
                    {
                        if (armor == "Soul")
                            return 1.5f;
                        else if (armor == "Ice")
                            return 1.25f;
                        else if (armor == "Steel")
                            return 1.0f;
                        else if (armor == "Molten")
                            return 0.75f;
                        else if (armor == "Dark")
                            return 0.5f;
                    }
                    break;
                case "Fire":
                    {
                        if (armor == "Ice")
                            return 1.5f;
                        else if (armor == "Soul")
                            return 1.25f;
                        else if (armor == "Steel")
                            return 1.0f;
                        else if (armor == "Dark")
                            return 0.75f;
                        else if (armor == "Molten")
                            return 0.5f;
                    }
                    break;
                case "Water":
                    {
                        if (armor == "Molten")
                            return 1.5f;
                        else if (armor == "Dark")
                            return 1.25f;
                        else if (armor == "Steel")
                            return 1.0f;
                        else if (armor == "Soul")
                            return 0.75f;
                        else if (armor == "Ice")
                            return 0.5f;
                    }
                    break;
                default:
                    return 0;
            }
            return 0;
        }
    }
}
