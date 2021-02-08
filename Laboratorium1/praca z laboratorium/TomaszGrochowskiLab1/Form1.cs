using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TomaszGrochowskiLab1
{
    public partial class FormMain : Form
    {
        //Counter variable
        public int counter = 0;
        //New window variable
        FormAbout formAbout;

        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This button changes color of colorButton2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonColor_Click(object sender, EventArgs e)
        {
            //Switching between blue and violet
            if (buttonColor2.BackColor != Color.Blue)
                buttonColor2.BackColor = Color.Blue;
            else if (buttonColor2.BackColor != Color.Violet)
                buttonColor2.BackColor = Color.Violet;
        }

        /// <summary>
        /// This button changes color of colorButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonColor2_Click(object sender, EventArgs e)
        {
            //Switching between green and red
            if (buttonColor.BackColor != Color.Green)
                buttonColor.BackColor = Color.Green;
            else if (buttonColor.BackColor != Color.Red)
                buttonColor.BackColor = Color.Red;
        }

        /// <summary>
        /// Adding a value to textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Parsing from String to Int
            counter = counter + Int32.Parse(textBoxCount.Text);

            //Back to 0
            if (counter > 150)
                counter = 0;

            //Parsing from Int to String
            textBoxCount.Text = counter.ToString();
        }

        /// <summary>
        /// Button changing it's color basing on value in textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void counterButtonColor_Click(object sender, EventArgs e)
        {
            //Change button color
            counterButtonColor.BackColor = Color.FromArgb(counter, counter + 50, counter + 70);
        }

        /// <summary>
        /// Textbox showing multiplicity of values in 2 textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            //Show new value of textbox2
            textBoxCount2.Text = (Int32.Parse(textBoxCount2.Text) * Int32.Parse(textBoxCount.Text)).ToString();
        }

        /// <summary>
        /// Button starting timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTimer_Click(object sender, EventArgs e)
        {
            timerCounter.Start();
        }

        /// <summary>
        /// Incrementing counter at every tick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCounter_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("tick");
            //Incrementing variable "counter"
            counter++;
            //Saving value
            textBoxCount.Text = counter.ToString();

            //Changing start button position
            if (counter % 2 == 1)
                buttonTimer.Location = new Point(buttonTimer.Location.X + 2, buttonTimer.Location.Y);
        }

        /// <summary>
        /// Button showing "About" window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNewWindow_Click(object sender, EventArgs e)
        {
            //Creating new window
            formAbout = new FormAbout();
            //Filling its attributes
            formAbout.myName = "Tomasz Grochowski";
            //Showing new window
            formAbout.Show();
        }
    }
}
