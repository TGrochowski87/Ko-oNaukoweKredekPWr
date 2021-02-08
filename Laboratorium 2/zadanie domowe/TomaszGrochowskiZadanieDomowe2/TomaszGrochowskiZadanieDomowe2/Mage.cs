using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaszGrochowskiZadanieDomowe2
{
    public class Mage : Range
    {
        /// <summary>
        /// A constructor
        /// </summary>
        /// <param name="rand"></param>
        public Mage(Random rand) : base(rand)
        {
            FigherType = "Mage";
        }

        public override int RandomizeArmor(Random rand)
        {
            return rand.Next(5, 41);
        }

        public override int RandomizeAttackStrength(Random rand)
        {
            return rand.Next(65, 91);
        }

        public override int RandomizeHealth(Random rand)
        {
            return rand.Next(100, 241);
        }
    }
}
