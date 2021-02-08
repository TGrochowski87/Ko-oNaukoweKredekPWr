using System;
using System.Collections.Generic;
using TomaszGrochowskiZadanieDomowe3.Repositories;
using System.Windows.Forms;

namespace TomaszGrochowskiZadanieDomowe3.Forms
{
    /// <summary>
    /// Window for editing or adding new keeper data
    /// </summary>
    public partial class KeeperDataWindow : Form
    {
        //Object of repository where keeper data is stored in
        KeepersRepository keepersRepository = new KeepersRepository();

        //List of currently edited keeper data
        List<string> keeperData = new List<string>();

        //Id of currently edited keeper
        int keeperId;

        public List<string> KeeperData { get => keeperData; set => keeperData = value; }
        public int KeeperId { get => keeperId; set => keeperId = value; }

        /// <summary>
        /// Constructor for add view
        /// </summary>
        public KeeperDataWindow()
        {
            InitializeComponent();
            buttonConfirm.Visible = true;
        }

        /// <summary>
        /// Constructor for edit view
        /// </summary>
        /// <param name="id"></param>
        public KeeperDataWindow(int id)
        {
            //Saving keeper's Id
            KeeperId = id;

            //Filling list with keeper's data
            KeeperData = keepersRepository.GetKeeper(KeeperId);
            InitializeComponent();
            buttonEdit.Visible = true;
        }

        /// <summary>
        /// Filling the text boxes with keeper's data if an edit view has been opened
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeeperDataWindow_Load(object sender, EventArgs e)
        {
            if(keeperData.Count > 0)
            {
                textBoxFirstName.Text = KeeperData[0];
                textBoxLastName.Text = KeeperData[1];
                textBoxContact.Text = KeeperData[2];
                textBoxLodgeID.Text = KeeperData[3];
            }
        }

        /// <summary>
        /// Button to confirm new keeper's data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            //All text boxes must be filled
            if(textBoxFirstName.Text == "" || textBoxLastName.Text == "" || textBoxContact.Text == "" || textBoxLodgeID.Text == "")
            {
                if (MessageBox.Show(this, "All text boxes must be filled!") == DialogResult.OK)
                    return;
            }

            //Checking if lodge id and contect number are numbers
            int lodgeId = -1;
            try
            {
                lodgeId = int.Parse(textBoxLodgeID.Text);
            }
            catch (Exception)
            {
                if (MessageBox.Show(this, "Lodge ID must be a number!") == DialogResult.OK)
                    return;
            }

            try
            {
                int numberTest = int.Parse(textBoxContact.Text);
            }
            catch (Exception)
            {
                if (MessageBox.Show(this, "Contact must be a number!") == DialogResult.OK)
                    return;
            }

            //Adding new keeper
            keepersRepository.AddKeeper(textBoxFirstName.Text, textBoxLastName.Text, textBoxContact.Text, lodgeId);

            this.Close();
        }

        /// <summary>
        /// Button to confirm edited data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //All text boxes must be filled
            if (textBoxFirstName.Text == "" || textBoxLastName.Text == "" || textBoxContact.Text == "" || textBoxLodgeID.Text == "")
            {
                if (MessageBox.Show(this, "All text boxes must be filled!") == DialogResult.OK)
                    return;
            }

            //Checking if lodge id and contect number are numbers
            int lodgeId = -1;
            try
            {
                lodgeId = int.Parse(textBoxLodgeID.Text);
            }
            catch (Exception)
            {
                if (MessageBox.Show(this, "Lodge ID must be a number!") == DialogResult.OK)
                    return;
            }

            try
            {
                int numberTest = int.Parse(textBoxContact.Text);
            }
            catch (Exception)
            {
                if (MessageBox.Show(this, "Contact must be a number!") == DialogResult.OK)
                    return;
            }

            //Updating keepr data
            keepersRepository.EditKeeper(KeeperId, textBoxFirstName.Text, textBoxLastName.Text, textBoxContact.Text, lodgeId);

            this.Close();
        }
    }
}
