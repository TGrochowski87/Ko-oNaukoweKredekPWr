using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaszGrochowskiLab2
{
    abstract class Vehicle
    {
        /// <summary>
        /// Car name
        /// </summary>
        public string name = "Golf V";
        /// <summary>
        /// Car's max speed
        /// </summary>
        public int speed = 220;
        /// <summary>
        /// Car's max fuel capacity
        /// </summary>
        public int fuel = 5;

        /// <summary>
        /// Moving the car
        /// </summary>
        public void Go()
        {
            try
            {
                //Speed up and lose fuel
                if (fuel > 0)
                {
                    speed++;
                    fuel--;
                }
            }
            catch
            {

            }
        }
    }
}
