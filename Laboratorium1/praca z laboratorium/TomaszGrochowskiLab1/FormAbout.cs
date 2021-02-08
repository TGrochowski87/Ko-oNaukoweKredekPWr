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
    public partial class FormAbout : Form
    {
        //String showing in new window
        public string myName = "";
        public FormAbout()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loading  my name on the screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAbout_Load(object sender, EventArgs e)
        {
            labelName.Text = myName;
        }
    }
}
