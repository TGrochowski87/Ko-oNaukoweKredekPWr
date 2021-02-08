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
    /// Window for settings
    /// </summary>
    public partial class Settings : Form
    {
        /// <summary>
        /// Observer object
        /// </summary>
        Observer observer;

        /// <summary>
        /// Variable containing id used for unsubscribing to observer
        /// </summary>
        int token = 0;

        public Settings(Observer observer)
        {
            this.observer = observer;
            InitializeComponent();
            comboBoxTheme.SelectedIndex = 1;

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
            switch (notification.Data)
            {
                //Different reaction for different notification data
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
        /// Sending message to registered listeners of theme has been changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxTheme_SelectedValueChanged(object sender, EventArgs e)
        {
            Notification notification = new Notification();
            notification.Data = comboBoxTheme.SelectedItem.ToString();
            observer.Notify(notification);
        }
    }
}
