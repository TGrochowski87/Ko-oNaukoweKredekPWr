using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaszGrochowskiLab2
{
    class Chopper : Vehicle, IAmphibia
    {
        /// <summary>
        /// Chopper's height
        /// </summary>
        public int height = 10;
        /// <summary>
        /// Amount of seats in the chopper
        /// </summary>
        public int seatAmount = 2;

        /// <summary>
        /// Going up
        /// </summary>
        public void GoUp()
        {
            height++;
        }

        /// <summary>
        /// Going down
        /// </summary>
        public void GoDown()
        {
            height--;
        }

        /// <summary>
        /// Changing background color to sea green
        /// </summary>
        /// <returns></returns>
        public Color PaintOcean()
        {
            return System.Drawing.Color.SeaGreen;
        }

        /// <summary>
        /// Landing a chopper
        /// </summary>
        public void LandOnWater()
        {
            height = 0;
        }
    }
}
