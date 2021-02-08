using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaszGrochowskiLab2
{
    class Car : Vehicle, IMilitary
    {
        /// <summary>
        /// Car's color
        /// </summary>
        public string color = "Green";
        /// <summary>
        /// Car's owner name
        /// </summary>
        public string owner = "Waldek";

        /// <summary>
        /// Parameters
        /// </summary>
        public string Name { get { return /*"Marka samochodu: " + */name; } set { name = value; } }
        public int Speed { get { return speed; } set { speed = value; } }
        public int Fuel { get { return fuel; } set { fuel = value; } }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Car()
        {

        }

        /// <summary>
        /// A parametric constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="speed"></param>
        /// <param name="fuel"></param>
        public Car(string name, int speed, int fuel)
        {
            Name = name;
            Speed = speed;
            Fuel = fuel;
        }

        /// <summary>
        /// Setting a background color to military
        /// </summary>
        /// <returns></returns>
        public Color PaintMilitary()
        {
            return System.Drawing.Color.DarkKhaki;
        }

        /// <summary>
        /// Refill the car
        /// </summary>
        public void Refill()
        {
            //Add fuel
            fuel += 30;
        }

        /// <summary>
        /// Shooting
        /// </summary>
        /// <param name="power"></param>
        public void Shoot(int power)
        {
            fuel -= power;
        }
    }
}
