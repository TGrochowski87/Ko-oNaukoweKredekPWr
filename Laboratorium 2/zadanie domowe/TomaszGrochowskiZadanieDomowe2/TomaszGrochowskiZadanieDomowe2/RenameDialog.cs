using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TomaszGrochowskiZadanieDomowe2
{
    public partial class RenameDialog : Form
    {
        /// <summary>
        /// A fighter who's name is being edited
        /// </summary>
        Fighter fighterToEdit;

        /// <summary>
        /// This window is initialized with a fighter object
        /// </summary>
        /// <param name="fighter">A fighter who's attribute will be edited</param>
        public RenameDialog(Fighter fighter)
        {
            this.fighterToEdit = fighter;
            InitializeComponent();
        }

        /// <summary>
        /// Filling the textbox with fighter's name on window load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RenameDialog_Load(object sender, EventArgs e)
        {
            textBoxName.Text = fighterToEdit.Name;
        }

        /// <summary>
        /// A button for canceling the editting process and closing this window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// A button for saving fighter's new name and closing this window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            fighterToEdit.Name = textBoxName.Text;
            this.Close();
        }
    }
}
