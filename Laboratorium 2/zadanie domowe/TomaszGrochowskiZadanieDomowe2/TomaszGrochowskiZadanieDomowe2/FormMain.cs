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
    public partial class FormMain : Form
    {
        /// <summary>
        /// Window for fight simulation
        /// </summary>
        FightWindow fightWindow;
        /// <summary>
        /// Dialog window for changing name of a fighter
        /// </summary>
        RenameDialog renameDialog;
        /// <summary>
        /// Object of class Random used throughout the entire application
        /// </summary>
        Random rand = new Random();

        /// <summary>
        /// List of first randomized team for betting
        /// </summary>
        List<Fighter> randomTeam1 = new List<Fighter>();
        /// <summary>
        /// List of second randomized team for betting
        /// </summary>
        List<Fighter> randomTeam2 = new List<Fighter>();
        /// <summary>
        /// List of fighters hired by the player
        /// </summary>
        List<Fighter> playerTeam = new List<Fighter>();
        /// <summary>
        /// List of randomized team to fight against the player's team
        /// </summary>
        List<Fighter> enemyTeam = new List<Fighter>();
        /// <summary>
        /// List of fighters available for hiring
        /// </summary>
        List<Fighter> availableFighters = new List<Fighter>();

        /// <summary>
        /// A variable saving what team has the player betted on
        /// </summary>
        int bet = 0;

        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// A button for rerolling both teams on the arena
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNewArena_Click(object sender, EventArgs e)
        {
            //If the arena is already filled, rerolling costs 3 gold coins
            if(randomTeam1.Count == 0)
                //Adjusting cost info
                labelRerollCost.Text = "3";
            if(randomTeam1.Count == 4)
                textBoxGold.Text = (Int32.Parse(textBoxGold.Text) - 3).ToString();

            //Making sure there is no data left in fighter lists
            if (randomTeam1 != null)
                randomTeam1.Clear();
            if(randomTeam2 != null)
                randomTeam2.Clear();

            //Randomizing fighters for both random teams
            for (int i = 0; i < 4; i++)
            {
                switch (rand.Next(0, 3))
                {
                    case 0:
                        randomTeam1.Add(new Melee(rand));
                        break;
                    case 1:
                        randomTeam1.Add(new Mage(rand));
                        break;
                    case 2:
                        randomTeam1.Add(new Range(rand));
                        break;
                    default:
                        break;
                }
                switch (rand.Next(0, 3))
                {
                    case 0:
                        randomTeam2.Add(new Melee(rand));
                        break;
                    case 1:
                        randomTeam2.Add(new Mage(rand));
                        break;
                    case 2:
                        randomTeam2.Add(new Range(rand));
                        break;
                    default:
                        break;
                }
            }

            //Refreshing DataGridViews
            dataGridViewFirstTeam.DataSource = null;
            dataGridViewSecondTeam.DataSource = null;
            dataGridViewFirstTeam.DataSource = randomTeam1;
            dataGridViewSecondTeam.DataSource = randomTeam2;
        }

        /// <summary>
        /// A button for changing main window view between arena and team creator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChangeScreen_Click(object sender, EventArgs e)
        {
            //Arena functionality turns invisible when changing to creator view
            dataGridViewFirstTeam.Visible = !dataGridViewFirstTeam.Visible;
            dataGridViewSecondTeam.Visible = !dataGridViewSecondTeam.Visible;
            labelTeamOne.Visible = !labelTeamOne.Visible;
            labelTeamTwo.Visible = !labelTeamTwo.Visible;
            buttonBet1.Visible = !buttonBet1.Visible;
            buttonBet2.Visible = !buttonBet2.Visible;
            buttonNewArena.Visible = !buttonNewArena.Visible;
            labelBetCost1.Visible = !labelBetCost1.Visible;
            labelBetCost2.Visible = !labelBetCost2.Visible;
            labelRerollCost.Visible = !labelRerollCost.Visible;
            pictureBoxRerollCost.Visible = !pictureBoxRerollCost.Visible;
            pictureBoxBetCost1.Visible = !pictureBoxBetCost1.Visible;
            pictureBoxBetCost2.Visible = !pictureBoxBetCost2.Visible;

            //Creator functionality turns invisible when changing to arena view
            dataGridViewToHire.Visible = !dataGridViewToHire.Visible;
            dataGridViewOwnTeam.Visible = !dataGridViewOwnTeam.Visible;
            labelToHire.Visible = !labelToHire.Visible;
            labelOwnTeam.Visible = !labelOwnTeam.Visible;
            buttonHire.Visible = !buttonHire.Visible;
            buttonDismiss.Visible = !buttonDismiss.Visible;
            buttonFire.Visible = !buttonFire.Visible;
            buttonEdit.Visible = !buttonEdit.Visible;
            labelDismissCost.Visible = !labelDismissCost.Visible;
            labelHireCost.Visible = !labelHireCost.Visible;
            pictureBoxHireCost.Visible = !pictureBoxHireCost.Visible;
            pictureBoxDismissCost.Visible = !pictureBoxDismissCost.Visible;

            //Adjusting this button's text
            if (buttonChangeScreen.Text == "Go to creator")
                buttonChangeScreen.Text = "Go to arena";
            else
                buttonChangeScreen.Text = "Go to creator";

            //Refreshing DataGridViews
            dataGridViewToHire.DataSource = null;
            dataGridViewOwnTeam.DataSource = null;
            if(playerTeam.Count != 0)
                dataGridViewOwnTeam.DataSource = playerTeam;
            if(availableFighters.Count != 0)
                dataGridViewToHire.DataSource = availableFighters;
        }

        /// <summary>
        /// A button for starting the arena battle sequence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartFight_Click(object sender, EventArgs e)
        {
            //If the player is in the arena view
            if(buttonChangeScreen.Text == "Go to creator")
            {
                //New fighter available for hire arrives with every betted arena fight. There can be no more than 6 available fighters
                if(availableFighters.Count < 6)
                {
                    switch (rand.Next(0, 3))
                    {
                        case 0:
                            availableFighters.Add(new Melee(rand));
                            break;
                        case 1:
                            availableFighters.Add(new Mage(rand));
                            break;
                        case 2:
                            availableFighters.Add(new Range(rand));
                            break;
                        default:
                            //Console.WriteLine("lol");
                            break;
                    }
                    //Refreshing DataGridView
                    dataGridViewToHire.DataSource = null;
                    dataGridViewToHire.DataSource = availableFighters;
                }

                //An arena must be filled before a fight
                if(randomTeam1.Count < 4)
                {
                    MessageBox.Show(this, "There are no gladiators on the arena!");
                }
                //A bet must be placed before a fight
                else if(bet == 0)
                {
                    MessageBox.Show(this, "You have to place your bet!");
                }
                else
                {
                    //Hiding main window
                    this.Hide();
                    //Paying gold for the bet
                    textBoxGold.Text = (Int32.Parse(textBoxGold.Text) - 10).ToString();
                    //Initializing and showing an arena fight window
                    fightWindow = new FightWindow(randomTeam1, randomTeam2, rand);
                    fightWindow.ShowDialog();

                    //Gaining 20 gold coins if the player won their bet
                    if(randomTeam1.Count == 0)
                    {
                        if(bet == 2)
                            textBoxGold.Text = (Int32.Parse(textBoxGold.Text) + 20).ToString();
                    }
                    else if(randomTeam2.Count == 0)
                    {
                        if(bet == 1)
                            textBoxGold.Text = (Int32.Parse(textBoxGold.Text) + 20).ToString();
                    }

                    //Clearing DataGridViews data
                    dataGridViewFirstTeam.DataSource = null;
                    dataGridViewSecondTeam.DataSource = null;
                    //Reseting bet status
                    bet = 0;
                    //Reseting cost of filling the arena
                    labelRerollCost.Text = "0";
                    //Bringing back the main window
                    this.Show();
                }
            }
            //If the player is in the creator view
            else
            {
                //A player must have 4 fighters hired to start a fight
                if (playerTeam.Count < 4)
                {
                    MessageBox.Show(this, "You need 4 gladiators!");
                }
                else
                {
                    //Making sure there is no data left in the list of enemy fighters
                    if (enemyTeam != null)
                        enemyTeam.Clear();

                    //Randomizing enemy team
                    for (int i = 0; i < 4; i++)
                    {
                        switch (rand.Next(0, 3))
                        {
                            case 0:
                                enemyTeam.Add(new Melee(rand));
                                break;
                            case 1:
                                enemyTeam.Add(new Mage(rand));
                                break;
                            case 2:
                                enemyTeam.Add(new Range(rand));
                                break;
                            default:
                                break;
                        }
                    }

                    //Hiding main window
                    this.Hide();
                    //Initializing and showing an arena fight window
                    fightWindow = new FightWindow(playerTeam, enemyTeam, rand);
                    fightWindow.ShowDialog();

                    //Gaining 200 gold coins if a battle
                    if (enemyTeam.Count == 0)
                    {
                        textBoxGold.Text = (Int32.Parse(textBoxGold.Text) + 200).ToString();
                    }
                    //Bringing back the main window
                    this.Show();

                    //Refreshing DataGridView
                    dataGridViewOwnTeam.DataSource = null;
                    dataGridViewOwnTeam.DataSource = playerTeam;
                }
            }
        }

        /// <summary>
        /// A button for placing a bet on first team
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBet1_Click(object sender, EventArgs e)
        {
            bet = 1;
        }

        /// <summary>
        /// A button for placing a bet on second team
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBet2_Click(object sender, EventArgs e)
        {
            bet = 2;
        }

        /// <summary>
        /// A button for dismissing a fighter, who is available for hire (selected in dataGridViewToHire)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDismiss_Click(object sender, EventArgs e)
        {
            //A fighter has to be selected in DataGridView
            if(dataGridViewToHire.SelectedRows.Count == 0)
                MessageBox.Show(this, "Choose who you want to dismiss!");
            else
            {
                //Dismissing costs 5 gold coins
                textBoxGold.Text = (Int32.Parse(textBoxGold.Text) - 5).ToString();
                //Removing chosen fighter from DataSource
                availableFighters.RemoveAt(dataGridViewToHire.CurrentRow.Index);
                //Refreshing DataGridView
                dataGridViewToHire.DataSource = null;
                dataGridViewToHire.DataSource = availableFighters;
            }
        }

        /// <summary>
        /// A button for hiring a fighter, who is available for hire (selected in dataGridViewToHire)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHire_Click(object sender, EventArgs e)
        {
            //A fighter has to be selected in DataGridView
            if (dataGridViewToHire.SelectedRows.Count == 0)
                MessageBox.Show(this, "Choose who you want to hire!");
            //There can be no more than 4 fighters in player's team
            else if(playerTeam.Count < 4)
            {
                //Hiring costs 5 gold coins
                textBoxGold.Text = (Int32.Parse(textBoxGold.Text) - 20).ToString();
                //Adding chosen fighter to player's team
                playerTeam.Add(availableFighters[dataGridViewToHire.CurrentRow.Index]);
                //Removing chosen fighter from the list of available fighters
                availableFighters.RemoveAt(dataGridViewToHire.CurrentRow.Index);
                //Refreshing DataGridViews
                dataGridViewOwnTeam.DataSource = null;
                dataGridViewToHire.DataSource = null;
                dataGridViewOwnTeam.DataSource = playerTeam;
                dataGridViewToHire.DataSource = availableFighters;

            }
            else
            {
                MessageBox.Show(this, "Your team is already full!");
            }
        }

        /// <summary>
        /// A button for editing  a fighter's name (selected in dataGridViewOwnTeam)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //A fighter has to be selected in DataGridView
            if (dataGridViewOwnTeam.SelectedRows.Count == 0)
                MessageBox.Show(this, "Choose who you want to edit!");
            else
            {
                //Initializing and showing a rename window
                renameDialog = new RenameDialog((Fighter)dataGridViewOwnTeam.CurrentRow.DataBoundItem);
                renameDialog.ShowDialog();
                //Refreshing DataGridView
                dataGridViewOwnTeam.DataSource = null;
                dataGridViewOwnTeam.DataSource = playerTeam;
            }
        }

        /// <summary>
        /// A button for firing a fighter from player's team (selected in dataGridViewOwnTeam)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFire_Click(object sender, EventArgs e)
        {
            //A fighter has to be selected in DataGridView
            if (dataGridViewOwnTeam.SelectedRows.Count == 0)
                MessageBox.Show(this, "Choose who you want to fire!");
            else
            {
                //Removing chosen fighter from the player's team
                playerTeam.RemoveAt(dataGridViewOwnTeam.CurrentRow.Index);
                //Refreshing DataGridView
                dataGridViewOwnTeam.DataSource = null;
                dataGridViewOwnTeam.DataSource = playerTeam;
            }
        }

        /// <summary>
        /// Checking win/lose condition
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxGold_TextChanged(object sender, EventArgs e)
        {
            //The game is lost when a player goes bancrupt (has less than 1 gold coin)
            if(Int32.Parse(textBoxGold.Text) <= 0)
            {
                //Disabling application windows
                this.Enabled = false;
                fightWindow.Enabled = false;
                //Closing the message box exits the application
                if (MessageBox.Show(this, "You have gone bancrupt! Try again.") == DialogResult.OK)
                    Application.Exit();
            }
            //The game is won when a player goes rich (has at least 2000 gold coins)
            else if (Int32.Parse(textBoxGold.Text) >= 2000)
            {
                //Disabling application windows
                this.Enabled = false;
                fightWindow.Enabled = false;
                //Closing the message box exits the application
                if (MessageBox.Show(this, "You have become rich and widely known as an Arena and Hazard Mastermind. Everyone knew about Your forture. " +
                    "Because of that, one day You've fallen a victim of armed robbery and became lethally woundead. You died a rich man, so congratulations!") == DialogResult.OK)
                    Application.Exit();
            }
        }
    }
}
