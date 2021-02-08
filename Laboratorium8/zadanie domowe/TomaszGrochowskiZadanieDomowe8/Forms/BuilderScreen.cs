using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TomaszGrochowskiZadanieDomowe8.Forms
{
    /// <summary>
    /// Window for builders screen
    /// </summary>
    public partial class BuilderScreen : Form
    {
        /// <summary>
        /// Observer object
        /// </summary>
        Observer observer;

        /// <summary>
        /// Variable containing id used for unsubscribing to observer
        /// </summary>
        int token = 0;

        /// <summary>
        /// Current building phase
        /// </summary>
        int buildingPhase = 0;

        /// <summary>
        /// Car to be built
        /// </summary>
        Car car;

        /// <summary>
        /// Array of subsequent car's attributes
        /// </summary>
        string[] carAttributes = new string[4] { "","","",""}; 

        public BuilderScreen(Observer observer)
        {
            this.observer = observer;
            InitializeComponent();

            //Registering to observer
            token = observer.Register((Notification notification) => { OnNotify(notification); });

            //Setting a default theme to White Mode
            this.BackColor = Color.FromArgb(225, 225, 225);
        }

        /// <summary>
        /// Method called by observer's updates
        /// </summary>
        /// <param name="notification"></param>
        private void OnNotify(Notification notification)
        {
            //Different reaction for different notification data
            switch (notification.Data)
            {
                case "Dark Mode":
                    this.BackColor = Color.FromArgb(65, 65, 65);
                    break;
                case "White Mode":
                    this.BackColor = Color.FromArgb(225, 225, 225);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Method for showing built car
        /// </summary>
        private void ShowCar()
        {
            //Getting images for car obcject
            pictureBoxCarBody.Image = car.GetBody();
            pictureBoxCarWheels.Image = car.GetWheels();
            pictureBoxCarLights.Image = car.GetLights();
            pictureBoxCarTop.Image = car.GetTop();

            //Connecting images into one
            pictureBoxCarBody.Controls.Add(pictureBoxCarWheels);
            pictureBoxCarWheels.Controls.Add(pictureBoxCarLights);
            pictureBoxCarLights.Controls.Add(pictureBoxCarTop);

            pictureBoxCarWheels.Location = new Point(0, 0);
            pictureBoxCarLights.Location = new Point(0, 0);
            pictureBoxCarTop.Location = new Point(0, 0);

            pictureBoxCarBody.Visible = true;
            pictureBoxCarWheels.Visible = true;
            pictureBoxCarLights.Visible = true;
            pictureBoxCarTop.Visible = true;

            buttonReset.Visible = true;
        }

        /// <summary>
        /// Method handling choosing first option
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxOption1_Click(object sender, EventArgs e)
        {
            //Building is split into different phases
            //Every phase saves user's choice and updates options for next phase
            if(buildingPhase == 0)
            {
                carAttributes[0] += "car-1";
                buildingPhase++;

                pictureBoxOption1.Image = Properties.Resources.green;
                pictureBoxOption2.Image = Properties.Resources.orange;
                pictureBoxOption3.Image = Properties.Resources.blue;

                labelCurrentChoice.Text = "Choose color";
            }
            else if (buildingPhase == 1)
            {
                carAttributes[0] += "-green";
                buildingPhase++;

                pictureBoxOption1.Image = Properties.Resources.wheels_1;
                pictureBoxOption2.Image = Properties.Resources.wheels_2;
                pictureBoxOption3.Image = Properties.Resources.wheels_3;

                labelCurrentChoice.Text = "Choose wheels";
            }
            else if (buildingPhase == 2)
            {
                carAttributes[1] += "wheels-1";
                buildingPhase++;

                pictureBoxOption1.Image = Properties.Resources.lights_1;
                pictureBoxOption2.Image = Properties.Resources.lights_2;
                pictureBoxOption3.Image = Properties.Resources.lights_3;

                labelCurrentChoice.Text = "Choose lights";
            }
            else if (buildingPhase == 3)
            {
                carAttributes[2] += "lights-1";
                buildingPhase++;

                pictureBoxOption1.Image = Properties.Resources.top_1;
                pictureBoxOption2.Image = Properties.Resources.top_2;
                pictureBoxOption3.Image = Properties.Resources.top_3;

                labelCurrentChoice.Text = "Choose top";
            }
            else if (buildingPhase == 4)
            {
                carAttributes[3] += "top-1";
                buildingPhase++;

                pictureBoxOption1.Visible = false;
                pictureBoxOption2.Visible = false;
                pictureBoxOption3.Visible = false;

                labelCurrentChoice.Text = "Meet your new car";

                //Building a car from chosen parts
                car = new Car.Builder().Body(carAttributes[0]).Wheels(carAttributes[1]).Lights(carAttributes[2]).Top(carAttributes[3]).Build();
                ShowCar();
            }
        }

        /// <summary>
        /// Method handling choosing second option
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxOption2_Click(object sender, EventArgs e)
        {
            //Building is split into different phases
            //Every phase saves user's choice and updates options for next phase
            if (buildingPhase == 0)
            {
                carAttributes[0] += "car-2";
                buildingPhase++;

                pictureBoxOption1.Image = Properties.Resources.green;
                pictureBoxOption2.Image = Properties.Resources.orange;
                pictureBoxOption3.Image = Properties.Resources.blue;

                labelCurrentChoice.Text = "Choose color";
            }
            else if (buildingPhase == 1)
            {
                carAttributes[0] += "-orange";
                buildingPhase++;

                pictureBoxOption1.Image = Properties.Resources.wheels_1;
                pictureBoxOption2.Image = Properties.Resources.wheels_2;
                pictureBoxOption3.Image = Properties.Resources.wheels_3;

                labelCurrentChoice.Text = "Choose wheels";
            }
            else if (buildingPhase == 2)
            {
                carAttributes[1] += "wheels-2";
                buildingPhase++;

                pictureBoxOption1.Image = Properties.Resources.lights_1;
                pictureBoxOption2.Image = Properties.Resources.lights_2;
                pictureBoxOption3.Image = Properties.Resources.lights_3;

                labelCurrentChoice.Text = "Choose lights";
            }
            else if (buildingPhase == 3)
            {
                carAttributes[2] += "lights-2";
                buildingPhase++;

                pictureBoxOption1.Image = Properties.Resources.top_1;
                pictureBoxOption2.Image = Properties.Resources.top_2;
                pictureBoxOption3.Image = Properties.Resources.top_3;

                labelCurrentChoice.Text = "Choose top";
            }
            else if (buildingPhase == 4)
            {
                carAttributes[3] += "top-2";
                buildingPhase++;

                pictureBoxOption1.Visible = false;
                pictureBoxOption2.Visible = false;
                pictureBoxOption3.Visible = false;

                labelCurrentChoice.Text = "Meet your new car";

                //Building a car from chosen parts
                car = new Car.Builder().Body(carAttributes[0]).Wheels(carAttributes[1]).Lights(carAttributes[2]).Top(carAttributes[3]).Build();
                ShowCar();
            }
        }

        /// <summary>
        /// Method handling choosing third option
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxOption3_Click(object sender, EventArgs e)
        {
            //Building is split into different phases
            //Every phase saves user's choice and updates options for next phase
            if (buildingPhase == 0)
            {
                carAttributes[0] += "car-3";
                buildingPhase++;

                pictureBoxOption1.Image = Properties.Resources.green;
                pictureBoxOption2.Image = Properties.Resources.orange;
                pictureBoxOption3.Image = Properties.Resources.blue;

                labelCurrentChoice.Text = "Choose color";
            }
            else if (buildingPhase == 1)
            {
                carAttributes[0] += "-blue";
                buildingPhase++;

                pictureBoxOption1.Image = Properties.Resources.wheels_1;
                pictureBoxOption2.Image = Properties.Resources.wheels_2;
                pictureBoxOption3.Image = Properties.Resources.wheels_3;

                labelCurrentChoice.Text = "Choose wheels";
            }
            else if (buildingPhase == 2)
            {
                carAttributes[1] += "wheels-3";
                buildingPhase++;

                pictureBoxOption1.Image = Properties.Resources.lights_1;
                pictureBoxOption2.Image = Properties.Resources.lights_2;
                pictureBoxOption3.Image = Properties.Resources.lights_3;

                labelCurrentChoice.Text = "Choose lights";
            }
            else if (buildingPhase == 3)
            {
                carAttributes[2] += "lights-3";
                buildingPhase++;

                pictureBoxOption1.Image = Properties.Resources.top_1;
                pictureBoxOption2.Image = Properties.Resources.top_2;
                pictureBoxOption3.Image = Properties.Resources.top_3;

                labelCurrentChoice.Text = "Choose top";
            }
            else if (buildingPhase == 4)
            {
                carAttributes[3] += "top-3";
                buildingPhase++;

                pictureBoxOption1.Visible = false;
                pictureBoxOption2.Visible = false;
                pictureBoxOption3.Visible = false;

                labelCurrentChoice.Text = "Meet your new car";

                //Building a car from chosen parts
                car = new Car.Builder().Body(carAttributes[0]).Wheels(carAttributes[1]).Lights(carAttributes[2]).Top(carAttributes[3]).Build();
                ShowCar();
            }
        }

        /// <summary>
        /// Restarting building process
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReset_Click(object sender, EventArgs e)
        {
            labelCurrentChoice.Text = "Choose body";
            car = null;
            buildingPhase = 0;

            for (int i = 0; i < carAttributes.Length; i++)
            {
                carAttributes[i] = "";
            }

            //Bringing up first option again
            pictureBoxOption1.Image = Properties.Resources.car_1;
            pictureBoxOption2.Image = Properties.Resources.car_2;
            pictureBoxOption3.Image = Properties.Resources.car_3;

            pictureBoxOption1.Visible = true;
            pictureBoxOption2.Visible = true;
            pictureBoxOption3.Visible = true;

            //Hiding previous car
            pictureBoxCarBody.Visible = false;
            pictureBoxCarWheels.Visible = false;
            pictureBoxCarLights.Visible = false;
            pictureBoxCarTop.Visible = false;

            buttonReset.Visible = false;
        }
    }
}
