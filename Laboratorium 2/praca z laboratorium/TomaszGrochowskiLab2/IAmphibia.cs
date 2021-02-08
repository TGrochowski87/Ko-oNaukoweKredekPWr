using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaszGrochowskiLab2
{
    interface IAmphibia
    {
        /// <summary>
        /// Painting background to ocean color
        /// </summary>
        /// <returns></returns>
        System.Drawing.Color PaintOcean();

        /// <summary>
        /// Landing a chopper on water
        /// </summary>
        void LandOnWater();
    }
}
