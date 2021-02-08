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
    /// Window for loading screen
    /// </summary>
    public partial class LoadingScreen : Form
    {
        /// <summary>
        /// Observer object
        /// </summary>
        Observer observer;

        /// <summary>
        /// Variable containing id used for unsubscribing to observer
        /// </summary>
        int token = 0;

        public LoadingScreen(Observer observer)
        {
            this.observer = observer;
            InitializeComponent();
            //Registering to observer
            token = observer.Register((Notification notification) => { OnNotifty(notification); });

            //Setting a default theme to White Mode
            this.BackColor = Color.FromArgb(225, 225, 225);
        }

        /// <summary>
        /// Method called by observer's updates
        /// </summary>
        /// <param name="notification"></param>
        private void OnNotifty(Notification notification)
        {
            //Different reaction for different notification data
            switch (notification.Data)
            {
                case "Dark Mode":
                    this.BackColor = Color.FromArgb(65, 65, 65);
                    progressBar.Brush.Color = Color.FromArgb(80, 80, 80);
                    break;
                case "White Mode":
                    this.BackColor = Color.FromArgb(225, 225, 225);
                    progressBar.Brush.Color = Color.FromArgb(230, 230, 230);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Loading the progress bar by clicking this button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            //Progress bar cannot be loaded entirely in White Mode
            if (progressBar.Value > 25 && this.BackColor == Color.FromArgb(225, 225, 225))
                return;

            //Loading progress bar
            progressBar.Increment(2);

            //Showing tips for user to change theme
            if(this.BackColor == Color.FromArgb(225, 225, 225))
            {
                if (progressBar.Value > 8)
                    labelTip.Text = "Is this even loading?";
                if(progressBar.Value > 20)
                    labelTip.Text = "Maybe try changing color?";
            }

            //Sending message to unlock BUILD button in menu if the progress bar has been filled
            if(progressBar.Value >= 100)
            {
                Notification notification = new Notification();
                notification.Data = "loaded";
                observer.Notify(notification);
            }
        }
    }
}
