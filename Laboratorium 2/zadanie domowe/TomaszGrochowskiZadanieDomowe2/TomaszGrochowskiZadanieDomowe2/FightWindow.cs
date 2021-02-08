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
    public partial class FightWindow : Form
    {
        /// <summary>
        /// An object of class Random
        /// </summary>
        private Random rand;
        /// <summary>
        /// List of fighters in the first team
        /// </summary>
        private List<Fighter> team1;
        /// <summary>
        /// List of fighters in the second team
        /// </summary>
        private List<Fighter> team2;
        /// <summary>
        /// A variable showing which team attacks at the moment
        /// </summary>
        private int nextTeam = 0;

        //Getters and setters
        internal List<Fighter> Team1 { get => team1; set => team1 = value; }
        internal List<Fighter> Team2 { get => team2; set => team2 = value; }
        public Random Rand { get => rand; set => rand = value; }

        /// <summary>
        /// This window is initialized with two lists of fighters and an object of class Random
        /// </summary>
        /// <param name="first">First Team</param>
        /// <param name="second">Second team</param>
        /// <param name="rand">A variable for randomizing, being a constructor parameter to keep previously set seed</param>
        public FightWindow(List<Fighter> first, List<Fighter> second, Random rand)
        {
            InitializeComponent();
            Team1 = first;
            Team2 = second;
            Rand = rand;
            //Randomizing which team attacks first
            nextTeam = rand.Next(0, 2);
            //Assigning DataSources to DataGridViews
            dataGridViewFirstTeam.DataSource = team1;
            dataGridViewSecondTeam.DataSource = team2;
        }

        /// <summary>
        /// If the window is closed before a fight concludes, the application exits
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FightWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(team1.Count > 0 && team2.Count > 0)
                Application.Exit();
        }

        /// <summary>
        /// Functionality run with every timer's tick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            //If the first team is wiped out, the fight ends and the second team wins
            if(team1.Count == 0)
            {
                //Reseting timer interval if the player changed it
                timer.Interval = 5000;
                timer.Stop();
                if (MessageBox.Show(this, "Team 2 Won!") == DialogResult.OK)
                    this.Close();
                return;
            }
            //If the second team is wiped out, the fight ends and the first team wins
            if (team2.Count == 0)
            {
                //Reseting timer interval if the player changed it
                timer.Interval = 5000;
                timer.Stop();
                if (MessageBox.Show(this, "Team 1 Won!") == DialogResult.OK)
                    this.Close();
                return;
            }

            //Checking which team attacks now
            if(nextTeam == 0)
            {
                //Randomizing which fighter attacks
                Fighter attackingFighter = team1[rand.Next(0, team1.Count)];
                Fighter defendingFighter = null;

                //A front line attacker has to fight enemy front line first
                if(attackingFighter is Melee)
                {
                    //Checking if the enemy team has anyone on front line
                    for (int i = 0; i < team2.Count; i++)
                    {
                        //If so, then the first melee defender is attacked
                        if(team2[i] is Melee)
                        {
                            defendingFighter = team2[i];
                            break;
                        }
                    }
                    //If not, then a melee attacker can attack anyone
                    if(defendingFighter == null)
                        defendingFighter = team2[rand.Next(0, team2.Count)];
                }
                //A back line attacker can attack anyone
                else
                {
                    defendingFighter = team2[rand.Next(0, team2.Count)];
                }

                //Calculating damage done to defender
                int damageDone = attackingFighter.AttackEnemy(defendingFighter);
                //Displaying changes to defender's health
                dataGridViewSecondTeam.Refresh();

                //Showing attack info on textbox
                richTextBoxAttackInfo.Text = attackingFighter.Name + " from Team 1 attacked " + defendingFighter.Name + " dealing " + damageDone + " damage!";
                //Second team attacks next
                nextTeam = 1;
            }
            else
            {
                //Randomizing which fighter attacks
                Fighter attackingFighter = team2[rand.Next(0, team2.Count)];
                Fighter defendingFighter = null;

                //A front line attacker has to fight enemy front line first
                if (attackingFighter is Melee)
                {
                    //Checking if the enemy team has anyone on front line
                    for (int i = 0; i < team1.Count; i++)
                    {
                        //If so, then the first melee defender is attacked
                        if (team1[i] is Melee)
                        {
                            defendingFighter = team1[i];
                            break;
                        }
                    }
                    //If not, then a melee attacker can attack anyone
                    if (defendingFighter == null)
                        defendingFighter = team1[rand.Next(0, team1.Count)];
                }
                //A back line attacker can attack anyone
                else
                {
                    defendingFighter = team1[rand.Next(0, team1.Count)];
                }

                //Calculating damage done to defender
                int damageDone = attackingFighter.AttackEnemy(defendingFighter);
                //Displaying changes to defender's health
                dataGridViewFirstTeam.Refresh();

                //Showing attack info on textbox
                richTextBoxAttackInfo.Text = attackingFighter.Name + " from Team 2 attacked " + defendingFighter.Name + " dealing " + damageDone + " damage!";
                //First team attacks next
                nextTeam = 0;
            }

            //Clearing dead fighters from lists 
            foreach (Fighter f in team1)
            {
                //A fighter is dead when his health drops below 1
                if (f.Health < 1)
                {
                    //Removing from list
                    team1.Remove(f);

                    //Refreshing DataGridView
                    dataGridViewFirstTeam.DataSource = null;
                    dataGridViewFirstTeam.DataSource = team1;
                    break;
                }
            }
            //Clearing dead fighters from lists 
            foreach (Fighter f in team2)
            {
                //A fighter is dead when his health drops below 1
                if (f.Health < 1)
                {
                    //Removing from list
                    team2.Remove(f);

                    //Refreshing DataGridView
                    dataGridViewSecondTeam.DataSource = null;
                    dataGridViewSecondTeam.DataSource = team2;
                    break;
                }
            }

            //Refreshing DataGridViews
            dataGridViewFirstTeam.Refresh();
            dataGridViewSecondTeam.Refresh();
        }
        
        /// <summary>
        /// A button for starting a fight
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        /// <summary>
        /// A button for speeding up fight by decreasing a value of timer's interval
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSkipFight_Click(object sender, EventArgs e)
        {
            timer.Interval = 100;
        }
    }
}
