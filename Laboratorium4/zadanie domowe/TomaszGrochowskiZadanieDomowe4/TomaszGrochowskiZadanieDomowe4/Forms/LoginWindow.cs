using System;
using System.Windows.Forms;
using TomaszGrochowskiZadanieDomowe4.Repositories;
using TomaszGrochowskiZadanieDomowe4.Forms;

namespace TomaszGrochowskiZadanieDomowe4
{
    /// <summary>
    /// Login window
    /// </summary>
    public partial class LoginWindow : Form
    {
        //Object of repository where user data is stored in
        UsersRepository usersRepository = new UsersRepository();
        //Main application window
        MainWindow mainWindow;
        public LoginWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button to attempt to log in with given data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConfirmLogin_Click(object sender, EventArgs e)
        {
            //Checking if given data matches the login data for admin account
            bool admin = usersRepository.Login(textBoxLogin.Text, textBoxPassword.Text);

            //If login and password are correct, admin privileges are granted and management view is shown
            if (admin)
            {
                mainWindow = new MainWindow(admin);
                //Hiding login window
                this.Hide();
                mainWindow.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        /// <summary>
        /// Button to log in as a guest
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGuestLogin_Click(object sender, EventArgs e)
        {
            //Opening new window with guest view
            mainWindow = new MainWindow(false);
            //Hiding login window
            this.Hide();
            mainWindow.Show();
        }
    }
}
