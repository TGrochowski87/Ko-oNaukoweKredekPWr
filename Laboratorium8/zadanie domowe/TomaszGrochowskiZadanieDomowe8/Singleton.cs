using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaszGrochowskiZadanieDomowe8
{
    /// <summary>
    /// A singleton class
    /// </summary>
    public class Singleton
    {
        /// <summary>
        /// Instance of singleton class
        /// </summary>
        static Singleton instance = new Singleton();

        //Owl images
        Bitmap bitmapAwake = new Bitmap(Properties.Resources.awake);
        Bitmap bitmapAsleep = new Bitmap(Properties.Resources.asleep);

        string name = "Singleton";

        private Singleton()
        {

        }

        public string Name { get => name; }
        public Bitmap BitmapAwake { get => bitmapAwake; set => bitmapAwake = value; }
        public Bitmap BitmapAsleep { get => bitmapAsleep; set => bitmapAsleep = value; }

        /// <summary>
        /// Getter for instance
        /// </summary>
        /// <returns></returns>
        public static Singleton GetInstance()
        {
            return instance;
        }
    }
}
