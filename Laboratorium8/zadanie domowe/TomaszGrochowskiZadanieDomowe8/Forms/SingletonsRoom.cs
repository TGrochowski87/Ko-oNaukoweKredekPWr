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
    /// Window for Singleton's Room
    /// </summary>
    public partial class SingletonsRoom : Form
    {
        /// <summary>
        /// Observer object
        /// </summary>
        Observer observer;

        /// <summary>
        /// Variable containing id used for unsubscribing to observer
        /// </summary>
        int token;

        public SingletonsRoom(Observer observer)
        {
            this.observer = observer;
            InitializeComponent();

            //Registering to observer
            token = observer.Register((Notification notification) => { OnNotify(notification); });

            //Setting a default theme to White Mode
            this.BackColor = Color.FromArgb(225, 225, 225);

            //Showing initial image of owl Singleton
            pictureBoxOwl.Image = Singleton.GetInstance().BitmapAwake;
            labelName.Text = "Owl " + Singleton.GetInstance().Name;
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
                    pictureBoxOwl.Image = Singleton.GetInstance().BitmapAsleep;
                    break;
                case "White Mode":
                    this.BackColor = Color.FromArgb(225, 225, 225);
                    pictureBoxOwl.Image = Singleton.GetInstance().BitmapAwake;
                    break;
                default:
                    break;
            }
        }
    }
}
