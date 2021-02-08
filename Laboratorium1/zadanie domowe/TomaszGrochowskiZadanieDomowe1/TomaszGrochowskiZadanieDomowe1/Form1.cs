using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TomaszGrochowskiZadanieDomowe1
{
    public partial class titleWindow : Form
    {
        //A main game window
        GameWindow gameWindow;

        public titleWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Starting the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            //Switching windows
            this.Hide();
            gameWindow = new GameWindow();
            gameWindow.Show();
        }
    }
}
