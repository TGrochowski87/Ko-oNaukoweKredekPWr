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
    public partial class GameWindow : Form
    {
        //Time since last villager arrived
        int newVillagerTimer = 0;
        //Time untill next event
        int timeUntilNextEvent = 15;
        //Time before announced event happens
        int eventTimer = -1;
        //A variable saving which event has been randomized
        int drawnEvent = 0;
        //Set true if a player has done a recon
        bool reconDone = false;
        //Set true if the next event should be the ending one
        bool endGame = false;

        //Amounts of resources needed to build certain building
        string[] hunterHutCost = { "10", "0", "0", "1" };
        string[] lumberMillCost = { "10", "0", "0", "1" };
        string[] stoneFactoryCost = { "20", "0", "0", "1" };
        string[] ironMineCost = { "20", "30", "0", "1" };
        string[] houseCost = { "20", "0", "0", "0" };
        string[] barracksCost = { "20", "40", "20", "0" };
        string[] wallCost = { "20", "60", "20", "0" };
        string[] towerCost = { "20", "40", "20", "2" };
        string[] palisadeCost = { "80", "0", "0", "0" };

        //Event info shown to player if a recon has been done
        string[] events = { "New villagers will come ",
            "Wolfs will attack ",
            "The drought will cause stockpile fires ",
            "A large barbarian army will arrive " };

        //Possible outcomes of events shown to player if a recon has been done
        string[] eventOutcome = { "Get 3 villagers or  dismiss them.",
            "Have palisade or let up to 2 warriors die or let  up to 3 villagers die.",
            "Hire 2 villagers as water bearers or lose up to 35 lumber.",
            "Have at least 20 warriors and all military buildings at maximum level or lose the game" };

        /// <summary>
        /// Check if requirements are met to build chosen building
        /// </summary>
        /// <param name="selectedIndex">Which building has been chosen.</param>
        /// <returns>Are requirements met.</returns>
        private bool CheckIfRequirementsMet(int selectedIndex)
        {
            //Temporary variable just to shorten rest of the code
            var selectedItem = listViewBuildChooser.Items[selectedIndex];
            //Array of owned resources
            int[] ownedResources = { Int32.Parse(textBoxLumberAmount.Text), Int32.Parse(textBoxStoneAmount.Text), Int32.Parse(textBoxIronAmount.Text), Int32.Parse(textBoxVillagers.Text) };
            //Array of required resources
            int[] requiredResources = { Int32.Parse(selectedItem.SubItems[1].Text), Int32.Parse(selectedItem.SubItems[2].Text), Int32.Parse(selectedItem.SubItems[3].Text), Int32.Parse(selectedItem.SubItems[4].Text) };

            //Checking if every requirement is met
            for(int i = 0; i < ownedResources.Length; i++)
            {
                if (ownedResources[i] < requiredResources[i])
                    return false;
            }

            //If so, then use them
            for(int i = 0; i < ownedResources.Length; i++)
            {
                ownedResources[i] -= requiredResources[i];
            }

            //Saving new amounts of resources
            textBoxLumberAmount.Text = ownedResources[0].ToString();
            textBoxStoneAmount.Text = ownedResources[1].ToString();
            textBoxIronAmount.Text = ownedResources[2].ToString();
            textBoxVillagers.Text = ownedResources[3].ToString();

            return true;
        }

        /// <summary>
        /// Randomize which event will occur
        /// </summary>
        /// <returns>Random value from 0 to 2</returns>
        private int RandomizeEvent()
        {
            //Temporary instance of class Random
            var rand = new Random();

            return (rand.Next(3));
        }

        public GameWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Timer starts instantly after new window is created
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameWindow_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            //If the village runs out of food, the game is lost
            if(Int32.Parse(textBoxFoodAmount.Text) < 0)
            {
                //Stopping game's functionality
                timer.Stop();
                listViewBuildChooser.Enabled = false;
                buttonBuildUtilities.Enabled = false;
                buttonBuildMilitaries.Enabled = false;
                buttonRecruitWarriors.Enabled = false;
                buttonRecon.Enabled = false;
                //Showing adequate message
                MessageBox.Show("You lost!");
                return;
            }
            //Incrementing amount of days
            textBoxDays.Text = (Int32.Parse(textBoxDays.Text) + 1).ToString();

            //Updating resources' status
            textBoxFoodAmount.Text = (Int32.Parse(textBoxFoodAmount.Text) + 4*Int32.Parse(textBoxHunterHutAmount.Text)).ToString();
            textBoxFoodAmount.Text = (Int32.Parse(textBoxFoodAmount.Text) - Int32.Parse(textBoxVillagers.Text) - Int32.Parse(textBoxArmyAmount.Text) - Int32.Parse(textBoxWorkingVillagers.Text)).ToString();
            textBoxLumberAmount.Text = (Int32.Parse(textBoxLumberAmount.Text) + 2*Int32.Parse(textBoxLumberMillAmount.Text)).ToString();
            textBoxStoneAmount.Text = (Int32.Parse(textBoxStoneAmount.Text) + 2*Int32.Parse(textBoxStoneFactoryAmount.Text)).ToString();
            textBoxIronAmount.Text = (Int32.Parse(textBoxIronAmount.Text) + 2*Int32.Parse(textBoxIronMineAmount.Text)).ToString();

            //New villagers can arrive every three days and only if there is space in houses
            newVillagerTimer++;
            if(newVillagerTimer >= 3 && ((Int32.Parse(textBoxVillagers.Text) + Int32.Parse(textBoxWorkingVillagers.Text)) < Int32.Parse(textBoxMaxPopulation.Text)))
            {
                textBoxVillagers.Text = (Int32.Parse(textBoxVillagers.Text) + 1).ToString();
                //Reseting villager timer
                newVillagerTimer = 0;
            }

            //After 170 days and endgame event can begin
            if(Int32.Parse(textBoxDays.Text) > 170)
            {
                endGame = true;
            }

            //Decrementing time until next event
            timeUntilNextEvent--;

            //Initiating new event
            if(timeUntilNextEvent == 0)
            {
                //Endgame event gives more time for final preparations
                if(endGame)
                {
                    eventTimer = 30;
                    drawnEvent = 3;
                }
                else
                {
                    eventTimer = 10;
                    drawnEvent = RandomizeEvent();
                }
            }
            //Counting until an event happens
            else if(timeUntilNextEvent < 0)
            {
                //Decrementing timer
                eventTimer--;
                listBoxEventInfo.Items.Clear();

                //Showing an adequate information in EventInfo list
                if(drawnEvent == 3)
                {
                    string eventInfo = events[3] + eventTimer + " days!";
                    listBoxEventInfo.Items.Add(eventInfo);
                    listBoxEventInfo.Items.Add(eventOutcome[3]);
                }
                else if(!reconDone)
                {
                    string eventInfo = "Something will happen in " + eventTimer + " days!";
                    listBoxEventInfo.Items.Add(eventInfo);
                }
                //Specific information is granted only after a recon was done
                else
                {
                    string eventInfo = events[drawnEvent] + eventTimer + " days!";
                    listBoxEventInfo.Items.Add(eventInfo);
                    listBoxEventInfo.Items.Add(eventOutcome[drawnEvent]);
                }
            }

            //When timer hits 0 the event happens
            if(eventTimer == 0)
            {
                //If it is the final event the game ends
                if(drawnEvent == 3)
                {
                    //Stopping game's functionality
                    timer.Stop();
                    listViewBuildChooser.Enabled = false;
                    buttonBuildUtilities.Enabled = false;
                    buttonBuildMilitaries.Enabled = false;
                    buttonRecruitWarriors.Enabled = false;
                    buttonRecon.Enabled = false;

                    //Check if a player has fulfilled the requirements
                    if (Int32.Parse(textBoxWallLevel.Text) == 3 && Int32.Parse(textBoxTowerAmount.Text) == 4 && Int32.Parse(textBoxPalisadeLevel.Text) == 2 && Int32.Parse(textBoxArmyAmount.Text) > 20)
                    {
                        MessageBox.Show("You won!");
                    }
                    else
                    {
                        MessageBox.Show("You lost!");
                    }
                }
                //If it is not the final event a player will decide the outcome
                else
                {
                    //Wolves can be stopped by having a full palisade
                    if(drawnEvent == 1 && Int32.Parse(textBoxPalisadeLevel.Text) == 2)
                    {
                        //Reseting event-associated variables
                        listBoxEventInfo.Items.Clear();
                        timeUntilNextEvent = 15;
                        reconDone = false;
                        eventTimer = -1;
                        return;
                    }

                    //Showing an adequate message and filling buttons with adequate texts
                    switch(drawnEvent)
                    {
                        case 0:
                            listBoxEventInfo.Items.Add("Three new settlers arrived to your village.");

                            buttonEventOutcome1.Text = "Accept them";
                            buttonEventOutcome2.Text = "Reject them";
                            break;
                        case 1:
                            listBoxEventInfo.Items.Add("Wolfs are attacking your village.");

                            buttonEventOutcome1.Text = "Lose warriors";
                            buttonEventOutcome2.Text = "Lose villagers";
                            break;
                        case 2:
                            listBoxEventInfo.Items.Add("A drought has causes your stockpiles to stand ablaze.");

                            buttonEventOutcome1.Text = "Hire water bearers";
                            buttonEventOutcome2.Text = "Lose lumber";
                            break;
                    }

                    //Showing event buttons and stopping other functionality
                    timer.Stop();

                    buttonBuildUtilities.Enabled = false;
                    buttonBuildMilitaries.Enabled = false;
                    buttonRecruitWarriors.Enabled = false;
                    buttonRecon.Enabled = false;

                    buttonEventOutcome1.Visible = true;
                    buttonEventOutcome2.Visible = true;
                }
            }
        }

        /// <summary>
        /// Doing a recon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRecon_Click(object sender, EventArgs e)
        {
            //Recon can only be done once per event and it needs one warrior to do it
            if(!reconDone && Int32.Parse(textBoxArmyAmount.Text) > 0)
            {
                //Save info that a recon has been done
                reconDone = true;
                //Use required resource
                textBoxArmyAmount.Text = (Int32.Parse(textBoxArmyAmount.Text) - 1).ToString();
            }
        }

        /// <summary>
        /// Recruiting new warriors
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRecruitWarriors_Click(object sender, EventArgs e)
        {
            //Recruitment is only available when barracks have already been built
            if(Int32.Parse(textBoxBarracksAmount.Text) == 1)
            {
                //Checking if requirements are met
                if(Int32.Parse(textBoxIronAmount.Text) > 15 && Int32.Parse(textBoxVillagers.Text) > 0)
                {
                    //Using required resources and adding new warrior
                    textBoxIronAmount.Text = (Int32.Parse(textBoxIronAmount.Text) - 15).ToString();
                    textBoxVillagers.Text = (Int32.Parse(textBoxVillagers.Text) - 1).ToString();
                    textBoxArmyAmount.Text = (Int32.Parse(textBoxArmyAmount.Text) + 1).ToString();
                }
            }
        }

        /// <summary>
        /// Filling BuildChooser list with possible utility options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuildUtilities_Click(object sender, EventArgs e)
        {
            //Reseting contents
            listViewBuildChooser.BeginUpdate();
            listViewBuildChooser.Items.Clear();

            //Add if the amount of owned buildings is smaller than maximum
            if (Int32.Parse(textBoxHunterHutAmount.Text) < 15)
                listViewBuildChooser.Items.Add("Hunter's Hut").SubItems.AddRange(hunterHutCost);

            if (Int32.Parse(textBoxLumberMillAmount.Text) < 10)
                listViewBuildChooser.Items.Add("Lumber Mill").SubItems.AddRange(lumberMillCost);

            if (Int32.Parse(textBoxStoneFactoryAmount.Text) < 10)
                listViewBuildChooser.Items.Add("Stone Factory").SubItems.AddRange(stoneFactoryCost);

            if (Int32.Parse(textBoxIronMineAmount.Text) < 10)
                listViewBuildChooser.Items.Add("Iron Mine").SubItems.AddRange(ironMineCost);

            if (Int32.Parse(textBoxHouseAmount.Text) < 15)
                listViewBuildChooser.Items.Add("House").SubItems.AddRange(houseCost);

            listViewBuildChooser.EndUpdate();
        }

        /// <summary>
        /// Filling BuildChooser list with possible military options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuildMilitaries_Click(object sender, EventArgs e)
        {
            //Reseting contents
            listViewBuildChooser.BeginUpdate();
            listViewBuildChooser.Items.Clear();

            //Add if the amount of owned buildings is smaller than maximum
            if (Int32.Parse(textBoxBarracksAmount.Text) < 1)
                listViewBuildChooser.Items.Add("Barracks").SubItems.AddRange(barracksCost);

            if (Int32.Parse(textBoxWallLevel.Text) < 3)
                listViewBuildChooser.Items.Add("Walls").SubItems.AddRange(wallCost);

            if (Int32.Parse(textBoxTowerAmount.Text) < 4)
                listViewBuildChooser.Items.Add("Tower").SubItems.AddRange(towerCost);

            if (Int32.Parse(textBoxPalisadeLevel.Text) < 2)
                listViewBuildChooser.Items.Add("Palisade").SubItems.AddRange(palisadeCost);

            listViewBuildChooser.EndUpdate();
        }

        /// <summary>
        /// Building what a player has chosen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewBuildChooser_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Ignore unselecting the previous list item
            if (listViewBuildChooser.SelectedIndices.Count == 0)
                return;

            //Temporary variable just to shorten rest of the code
            int selectedIndex = listViewBuildChooser.SelectedIndices[0];

            //If a player has not enough resources, clear the list and return
            if(!CheckIfRequirementsMet(listViewBuildChooser.SelectedIndices[0]))
            {
                listViewBuildChooser.Items.Clear();
                return;
            }

            //Check which building has been chosen and increment its amount
            //If it is a resource producing facility, increment the mount of working villagers as well
            if (listViewBuildChooser.Items[selectedIndex].Text == "Hunter's Hut")
            {
                textBoxHunterHutAmount.Text = (Int32.Parse(textBoxHunterHutAmount.Text) + 1).ToString();
                textBoxWorkingVillagers.Text = (Int32.Parse(textBoxWorkingVillagers.Text) + 1).ToString();
            }
            if (listViewBuildChooser.Items[selectedIndex].Text == "Lumber Mill")
            {
                textBoxLumberMillAmount.Text = (Int32.Parse(textBoxLumberMillAmount.Text) + 1).ToString();
                textBoxWorkingVillagers.Text = (Int32.Parse(textBoxWorkingVillagers.Text) + 1).ToString();
            }
            if (listViewBuildChooser.Items[selectedIndex].Text == "Stone Factory")
            {
                textBoxStoneFactoryAmount.Text = (Int32.Parse(textBoxStoneFactoryAmount.Text) + 1).ToString();
                textBoxWorkingVillagers.Text = (Int32.Parse(textBoxWorkingVillagers.Text) + 1).ToString();
            }
            if (listViewBuildChooser.Items[selectedIndex].Text == "Iron Mine")
            {
                textBoxIronMineAmount.Text = (Int32.Parse(textBoxIronMineAmount.Text) + 1).ToString();
                textBoxWorkingVillagers.Text = (Int32.Parse(textBoxWorkingVillagers.Text) + 1).ToString();
            }
            if (listViewBuildChooser.Items[selectedIndex].Text == "House")
            {
                textBoxHouseAmount.Text = (Int32.Parse(textBoxHouseAmount.Text) + 1).ToString();
                //One house is a home for up to 5 villagers
                textBoxMaxPopulation.Text = (Int32.Parse(textBoxHouseAmount.Text) * 5).ToString();
            }
            if (listViewBuildChooser.Items[selectedIndex].Text == "Barracks")
            {
                textBoxBarracksAmount.Text = (Int32.Parse(textBoxBarracksAmount.Text) + 1).ToString();
            }
            if (listViewBuildChooser.Items[selectedIndex].Text == "Walls")
            {
                textBoxWallLevel.Text = (Int32.Parse(textBoxWallLevel.Text) + 1).ToString();
            }
            if (listViewBuildChooser.Items[selectedIndex].Text == "Tower")
            {
                textBoxTowerAmount.Text = (Int32.Parse(textBoxTowerAmount.Text) + 1).ToString();
            }
            if (listViewBuildChooser.Items[selectedIndex].Text == "Palisade")
            {
                textBoxPalisadeLevel.Text = (Int32.Parse(textBoxPalisadeLevel.Text) + 1).ToString();
            }
            //Clearing BuildChooser list
            listViewBuildChooser.Items.Clear();
        }

        /// <summary>
        /// Exit the application if this window has been closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Make resizing columns of BuildChooser impossible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewBuildChooser_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listViewBuildChooser.Columns[e.ColumnIndex].Width;
        }

        /// <summary>
        /// The functionality of first event outcome button changes depending on the event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEventOutcome1_Click(object sender, EventArgs e)
        {
            //Checking which event has been randomized
            switch (drawnEvent)
            {
                case 0:
                    //Getting 3 new villagers
                    textBoxVillagers.Text = (Int32.Parse(textBoxVillagers.Text) + 3).ToString();
                    break;
                case 1:
                    //If a player has chosen to lose warriors, they will be lost, but if there were no warriors, the villagers would die instead
                    if(Int32.Parse(textBoxArmyAmount.Text) > 0)
                    {
                        //Losing 2 warriors
                        textBoxArmyAmount.Text = (Int32.Parse(textBoxArmyAmount.Text) - 2).ToString();
                        if (Int32.Parse(textBoxArmyAmount.Text) < 0)
                            textBoxArmyAmount.Text = "0";
                    }
                    else
                    {
                        //Losing 3 villagers
                        textBoxVillagers.Text = (Int32.Parse(textBoxVillagers.Text) - 3).ToString();
                        if (Int32.Parse(textBoxVillagers.Text) < 0)
                            textBoxVillagers.Text = "0";
                    }
                    break;
                case 2:
                    //If the player has chosen to hire water bearers, 2 villagers will be lost, but if there were not enough villagers, lumber would be lost instead
                    if(Int32.Parse(textBoxVillagers.Text) >= 2)
                        //Losing villagers
                        textBoxVillagers.Text = (Int32.Parse(textBoxVillagers.Text) - 2).ToString();
                    else
                    {
                        //Losing lumber
                        textBoxLumberAmount.Text = (Int32.Parse(textBoxLumberAmount.Text) - 35).ToString();
                        if (Int32.Parse(textBoxLumberAmount.Text) < 0)
                            textBoxLumberAmount.Text = "0";
                    }
                    break;
            }

            //Reseting event timers
            timeUntilNextEvent = 15;
            eventTimer = -1;
            //Clearing event info
            listBoxEventInfo.Items.Clear();
            //Reseting recon status
            reconDone = false;
            //Hiding event outcome buttons
            buttonEventOutcome1.Visible = false;
            buttonEventOutcome2.Visible = false;

            //Unfreezing the game
            buttonBuildUtilities.Enabled = true;
            buttonBuildMilitaries.Enabled = true;
            buttonRecruitWarriors.Enabled = true;
            buttonRecon.Enabled = true;
            timer.Start();
        }

        /// <summary>
        /// The functionality of second event outcome button changes depending on the event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEventOutcome2_Click(object sender, EventArgs e)
        {
            //Checking which event has been randomized
            switch (drawnEvent)
            {
                case 0:
                    //If villagers have been rejected, nothing will happen
                    break;
                case 1:
                    //If a player has chosen to lose villagers, they will be lost, but if there were no villagers, the warriors would die instead
                    if (Int32.Parse(textBoxVillagers.Text) > 0)
                    {
                        textBoxVillagers.Text = (Int32.Parse(textBoxVillagers.Text) - 3).ToString();
                        if (Int32.Parse(textBoxVillagers.Text) < 0)
                            textBoxVillagers.Text = "0";
                    }
                    else
                    {
                        textBoxArmyAmount.Text = (Int32.Parse(textBoxArmyAmount.Text) - 2).ToString();
                        if (Int32.Parse(textBoxArmyAmount.Text) < 0)
                            textBoxArmyAmount.Text = "0";
                    }
                    break;
                case 2:
                    //If the player has chosen to hire water bearers, 2 villagers will be lost, but if there were not enough villagers, lumber would be lost instead
                    textBoxLumberAmount.Text = (Int32.Parse(textBoxLumberAmount.Text) - 35).ToString();
                    if (Int32.Parse(textBoxLumberAmount.Text) < 0)
                        textBoxLumberAmount.Text = "0";
                    break;
            }
            //Reseting event timers
            timeUntilNextEvent = 15;
            eventTimer = -1;
            //Clearing event info
            listBoxEventInfo.Items.Clear();
            //Reseting recon status
            reconDone = false;
            //Hiding event outcome buttons
            buttonEventOutcome1.Visible = false;
            buttonEventOutcome2.Visible = false;

            //Unfreezing the game
            buttonBuildUtilities.Enabled = true;
            buttonBuildMilitaries.Enabled = true;
            buttonRecruitWarriors.Enabled = true;
            buttonRecon.Enabled = true;
            timer.Start();
        }
    }
}
