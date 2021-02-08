using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TomaszGrochowskiLab2
{
    public partial class FormMain : Form
    {
        //Test Car object
        Car car;
        //Test Chopper object
        Chopper chopper;

        //A list of cars
        List<Car> cars = new List<Car>();

        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Create new object of class Car
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNew_Click(object sender, EventArgs e)
        {
            //Creating new testing objects
            car = new Car();
            chopper = new Chopper();

            //Filling text boxes with car's attributes
            RefreshTextBoxes();
        }

        /// <summary>
        /// Refreshing text boxes
        /// </summary>
        private void RefreshTextBoxes()
        {
            textBoxName.Text = car.name;
            textBoxSpeed.Text = car.speed.ToString();
            textBoxFuel.Text = car.fuel.ToString();
            textBoxColor.Text = car.color;
            textBoxOwner.Text = car.owner;
            textBoxHeight.Text = chopper.height.ToString();
            textBoxSeats.Text = chopper.seatAmount.ToString();
        }

        /// <summary>
        /// Starting a car
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGo_Click(object sender, EventArgs e)
        {
            //Moving a car
            try
            {
                car.Go();
            }
            catch
            {
                Console.WriteLine("Create a car first!");
            }
            RefreshTextBoxes();
        }

        /// <summary>
        /// Refillig the car
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRefill_Click(object sender, EventArgs e)
        {
            //Refiil the car
            car.Refill();
            RefreshTextBoxes();
        }

        /// <summary>
        /// Getting chopper up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGoUp_Click(object sender, EventArgs e)
        {
            //Go up
            chopper.GoUp();
            RefreshTextBoxes();
        }

        /// <summary>
        /// Getting chopper down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGoDown_Click(object sender, EventArgs e)
        {
            //Go down
            chopper.GoDown();
            RefreshTextBoxes();
        }

        /// <summary>
        /// Running military functions of car
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMilitary_Click(object sender, EventArgs e)
        {
            //Setting background color
            BackColor = car.PaintMilitary();
            //Shooting with a chosen power
            car.Shoot(10); 
            RefreshTextBoxes();
        }

        /// <summary>
        /// Running amphibia functions for car
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAmphibia_Click(object sender, EventArgs e)
        {
            //Setting background color
            BackColor = chopper.PaintOcean();
            //Landing on water
            chopper.LandOnWater();
            RefreshTextBoxes();
        }

        /// <summary>
        /// Creating a list of cars
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonList_Click(object sender, EventArgs e)
        {
            cars.Add(new Car("Ferrari", 300, 40));
            cars.Add(new Car("Maluch", 140, 60));
            cars.Add(new Car("BMW", 220, 70));
            cars.Add(new Car("Golf V", 160, 55));

            dataGridViewVehicles.DataSource = cars;
        }

        /// <summary>
        /// Searching for a car on the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFind_Click(object sender, EventArgs e)
        {
            //Looking for a car with name given in text box
            Car carFound = cars.Where(x => x.Name == textBoxName.Text).FirstOrDefault();

            //Setting parameters of found car
            textBoxSpeed.Text = carFound.Speed.ToString();
            textBoxFuel.Text = carFound.Fuel.ToString();
        }
    }
}
