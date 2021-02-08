using System;
using System.Data;
using System.Collections.Generic;
using TomaszGrochowskiZadanieDomowe3.Repositories;
using System.Windows.Forms;

namespace TomaszGrochowskiZadanieDomowe3.Forms
{
    /// <summary>
    /// Main window
    /// </summary>
    public partial class MainWindow : Form
    {
        //Windows for setting keeper's data
        KeeperDataWindow keeperDataWindow;

        //Object of repository where animal data is stored in
        AnimalsRepository animalsRepository = new AnimalsRepository();

        //Object of repository where keeper data is stored in
        KeepersRepository keepersRepository = new KeepersRepository();

        //Object of repository where mushroom data is stored in
        MushroomsRepository mushroomsRepository = new MushroomsRepository();

        //Object of repository where region data is stored in
        RegionsRepository regionsRepository = new RegionsRepository();

        //A boolean variable saving are admin privileges granted or not
        bool admin = false;
        public MainWindow(bool admin)
        {
            Admin = admin;
            InitializeComponent();
        }

        public bool Admin { get => admin; set => admin = value; }

        /// <summary>
        /// Loading different view for admin or guest user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_Load(object sender, EventArgs e)
        {
            if (admin)
            {
                this.Text += " - Admin";

                //Showing admin buttons
                buttonAdd.Visible = true;
                buttonEdit.Visible = true;
                buttonDelete.Visible = true;

                //Filling DataGridView with employee data
                DataTable keepers = keepersRepository.GetKeepers();
                dataGridViewShowData.DataSource = keepers;
                //Hiding column with Ids
                dataGridViewShowData.Columns[0].Visible = false;
            }
            else
            {
                this.Text += " - Guest";

                //Showing welcome text
                labelWelcome.Visible = true;

                //Showing admin buttons
                buttonAnimals.Visible = true;
                buttonKeepers.Visible = true;
                buttonMushrooms.Visible = true;
                buttonRegions.Visible = true;
            }
        }

        /// <summary>
        /// Closing this window shuts the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Guest button to show animals
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAnimals_Click(object sender, EventArgs e)
        {
            //Loading animal icon from resources
            pictureBoxView.Image = Properties.Resources.Animal;
            labelWelcome.Visible = false;

            //Filling DataGridView with adequate data
            DataTable animals = animalsRepository.GetAnimals();
            dataGridViewShowData.DataSource = null;
            dataGridViewShowData.DataSource = animals;
        }

        /// <summary>
        /// Guest button to show mushrooms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMushrooms_Click(object sender, EventArgs e)
        {
            //Loading mushroom icon from resources
            pictureBoxView.Image = Properties.Resources.Mushroom;
            labelWelcome.Visible = false;

            //Filling DataGridView with adequate data
            DataTable mushrooms = mushroomsRepository.GetMushrooms();
            dataGridViewShowData.DataSource = null;
            dataGridViewShowData.DataSource = mushrooms;
        }

        /// <summary>
        /// Guest button to show keepers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonKeepers_Click(object sender, EventArgs e)
        {
            //Loading keeper icon from resources
            pictureBoxView.Image = Properties.Resources.Keeper;
            labelWelcome.Visible = false;

            //Filling DataGridView with adequate data
            DataTable keepers = keepersRepository.GetKeepers();
            dataGridViewShowData.DataSource = null;
            dataGridViewShowData.DataSource = keepers;

            //Hiding column with Ids
            dataGridViewShowData.Columns[0].Visible = false;
        }

        /// <summary>
        /// Guest button to show regions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRegions_Click(object sender, EventArgs e)
        {
            //Loading region icon from resources
            pictureBoxView.Image = Properties.Resources.Region;
            labelWelcome.Visible = false;

            //Filling DataGridView with adequate data
            DataTable regions = regionsRepository.GetRegions();
            dataGridViewShowData.DataSource = null;
            dataGridViewShowData.DataSource = regions;
        }

        /// <summary>
        /// Admin button to add new keeper
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Showing window for filling new keeper's data
            keeperDataWindow = new KeeperDataWindow();
            keeperDataWindow.ShowDialog();

            //Refreshing DataGridView
            dataGridViewShowData.DataSource = null;
            dataGridViewShowData.DataSource = keepersRepository.GetKeepers();
            dataGridViewShowData.Columns[0].Visible = false;
            dataGridViewShowData.ClearSelection();
        }

        /// <summary>
        /// Admin button to edit an existing keeper's data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //User must choose whose data to edit
            if (dataGridViewShowData.SelectedRows.Count == 0)
            {
                if (MessageBox.Show(this, "No data was selected!") == DialogResult.OK)
                    return;
            }

            //Showing window filled with editable keeper's data
            keeperDataWindow = new KeeperDataWindow((int)dataGridViewShowData.CurrentRow.Cells[0].Value);
            keeperDataWindow.ShowDialog();

            //Refreshing DataGridView
            dataGridViewShowData.DataSource = null;
            dataGridViewShowData.DataSource = keepersRepository.GetKeepers();
            dataGridViewShowData.Columns[0].Visible = false;
            dataGridViewShowData.ClearSelection();
        }

        /// <summary>
        /// Admin button to detele selected keeper's data from data base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //User must choose whose data to edit
            if (dataGridViewShowData.SelectedRows.Count == 0)
            {
                if (MessageBox.Show(this, "No data was selected!") == DialogResult.OK)
                    return;
            }

            //Deleteing selected keeper from data base
            keepersRepository.DeleteKeeper((int)dataGridViewShowData.CurrentRow.Cells[0].Value);

            //Refreshing DataGridView
            dataGridViewShowData.DataSource = null;
            dataGridViewShowData.DataSource = keepersRepository.GetKeepers();
            dataGridViewShowData.Columns[0].Visible = false;
            dataGridViewShowData.ClearSelection();
        }
    }
}
