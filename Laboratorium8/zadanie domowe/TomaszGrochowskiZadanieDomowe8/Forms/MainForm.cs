using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TomaszGrochowskiZadanieDomowe8.Forms;


namespace TomaszGrochowskiZadanieDomowe8
{
    /// <summary>
    /// Window for main menu
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Observer object
        /// </summary>
        Observer observer = new Observer();

        /// <summary>
        /// Instance of settings windw
        /// </summary>
        Settings settings;

        /// <summary>
        /// Instance of loading screen window
        /// </summary>
        LoadingScreen loadingScreen;

        /// <summary>
        /// Instance of singletons room window
        /// </summary>
        SingletonsRoom singletonsRoom;

        /// <summary>
        /// Instance of builders screen window
        /// </summary>
        BuilderScreen builderScreen;
        
        /// <summary>
        /// Variable containing id used for unsubscribing to observer
        /// </summary>
        int token = 0;

        public MainForm()
        {
            InitializeComponent();

            //Passing observer reference to other windows
            settings = new Settings(observer);
            loadingScreen = new LoadingScreen(observer);
            singletonsRoom = new SingletonsRoom(observer);
            builderScreen = new BuilderScreen(observer);

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
                case "loaded":
                    this.buttonBuild.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Showing settings window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings.ShowDialog();
        }

        /// <summary>
        /// Showing loading screen window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            loadingScreen.ShowDialog();
        }

        /// <summary>
        /// Showing singletons room window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonIntroduction_Click(object sender, EventArgs e)
        {
            singletonsRoom.ShowDialog();
        }

        /// <summary>
        /// Showing builder screen window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            builderScreen.ShowDialog();
        }

        /// <summary>
        /// Button for exiting application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
