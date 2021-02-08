using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaszGrochowskiLab2
{
    interface IMilitary
    {
        /// <summary>
        /// Shooting
        /// </summary>
        /// <param name="power"></param>
        void Shoot(int power);

        /// <summary>
        /// Painting a vehicle to a military color
        /// </summary>
        /// <returns></returns>
        System.Drawing.Color PaintMilitary();
    }
}
