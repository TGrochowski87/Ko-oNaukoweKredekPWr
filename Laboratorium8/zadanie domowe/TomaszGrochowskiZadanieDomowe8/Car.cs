using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaszGrochowskiZadanieDomowe8
{
    /// <summary>
    /// Class Car containing its builder
    /// </summary>
    public class Car
    {
        //Attributes
        private string body;
        private string wheels;
        private string lights;
        private string top;

        //Getters that return bitmaps from resources found by their string identificators
        public Bitmap GetBody()
        {
            Bitmap bodyBitmap = new Bitmap((Image)Properties.Resources.ResourceManager.GetObject(body));
            return bodyBitmap;
        }
        public Bitmap GetWheels()
        {
            Bitmap wheelsBitmap = new Bitmap((Image)Properties.Resources.ResourceManager.GetObject(wheels));
            return wheelsBitmap;
        }
        public Bitmap GetLights()
        {
            Bitmap lightsBitmap = new Bitmap((Image)Properties.Resources.ResourceManager.GetObject(lights));
            return lightsBitmap;
        }
        public Bitmap GetTop()
        {
            Bitmap topBitmap = new Bitmap((Image)Properties.Resources.ResourceManager.GetObject(top));
            return topBitmap;
        }

        /// <summary>
        /// Builder for ckass Car
        /// </summary>
        public class Builder
        {
            //Attributes
            private string body;
            private string wheels;
            private string lights;
            private string top;

            //Builder's setters
            public Builder Body(string image)
            {
                this.body = image;
                return this;
            }
            public Builder Wheels(string image)
            {
                this.wheels = image;
                return this;
            }
            public Builder Lights(string image)
            {
                this.lights = image;
                return this;
            }
            public Builder Top(string image)
            {
                this.top = image;
                return this;
            }

            /// <summary>
            /// Build method creating and returning Car object
            /// </summary>
            /// <returns></returns>
            public Car Build()
            {
                Car car = new Car();
                car.body = this.body;
                car.wheels = this.wheels;
                car.lights = this.lights;
                car.top = this.top;
                return car;
            }
        }
    }
}
