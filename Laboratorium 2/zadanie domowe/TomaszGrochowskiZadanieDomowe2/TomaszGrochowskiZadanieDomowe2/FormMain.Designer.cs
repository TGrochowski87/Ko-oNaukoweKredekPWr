namespace TomaszGrochowskiZadanieDomowe2
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonNewArena = new System.Windows.Forms.Button();
            this.dataGridViewFirstTeam = new System.Windows.Forms.DataGridView();
            this.dataGridViewSecondTeam = new System.Windows.Forms.DataGridView();
            this.buttonChangeScreen = new System.Windows.Forms.Button();
            this.buttonBet1 = new System.Windows.Forms.Button();
            this.buttonBet2 = new System.Windows.Forms.Button();
            this.textBoxGold = new System.Windows.Forms.TextBox();
            this.labelTeamOne = new System.Windows.Forms.Label();
            this.labelTeamTwo = new System.Windows.Forms.Label();
            this.dataGridViewOwnTeam = new System.Windows.Forms.DataGridView();
            this.dataGridViewToHire = new System.Windows.Forms.DataGridView();
            this.labelOwnTeam = new System.Windows.Forms.Label();
            this.labelToHire = new System.Windows.Forms.Label();
            this.buttonHire = new System.Windows.Forms.Button();
            this.buttonFire = new System.Windows.Forms.Button();
            this.buttonStartFight = new System.Windows.Forms.Button();
            this.buttonDismiss = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.pictureBoxOwnMoney = new System.Windows.Forms.PictureBox();
            this.pictureBoxRerollCost = new System.Windows.Forms.PictureBox();
            this.labelRerollCost = new System.Windows.Forms.Label();
            this.labelBetCost2 = new System.Windows.Forms.Label();
            this.pictureBoxBetCost2 = new System.Windows.Forms.PictureBox();
            this.labelBetCost1 = new System.Windows.Forms.Label();
            this.pictureBoxBetCost1 = new System.Windows.Forms.PictureBox();
            this.labelDismissCost = new System.Windows.Forms.Label();
            this.pictureBoxDismissCost = new System.Windows.Forms.PictureBox();
            this.labelHireCost = new System.Windows.Forms.Label();
            this.pictureBoxHireCost = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFirstTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSecondTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOwnTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToHire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOwnMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRerollCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBetCost2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBetCost1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDismissCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHireCost)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNewArena
            // 
            this.buttonNewArena.Location = new System.Drawing.Point(485, 330);
            this.buttonNewArena.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNewArena.Name = "buttonNewArena";
            this.buttonNewArena.Size = new System.Drawing.Size(106, 44);
            this.buttonNewArena.TabIndex = 0;
            this.buttonNewArena.Text = "New Arena";
            this.buttonNewArena.UseVisualStyleBackColor = true;
            this.buttonNewArena.Click += new System.EventHandler(this.buttonNewArena_Click);
            // 
            // dataGridViewFirstTeam
            // 
            this.dataGridViewFirstTeam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewFirstTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFirstTeam.Location = new System.Drawing.Point(9, 89);
            this.dataGridViewFirstTeam.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewFirstTeam.MultiSelect = false;
            this.dataGridViewFirstTeam.Name = "dataGridViewFirstTeam";
            this.dataGridViewFirstTeam.ReadOnly = true;
            this.dataGridViewFirstTeam.RowHeadersWidth = 30;
            this.dataGridViewFirstTeam.RowTemplate.Height = 24;
            this.dataGridViewFirstTeam.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewFirstTeam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFirstTeam.Size = new System.Drawing.Size(514, 236);
            this.dataGridViewFirstTeam.TabIndex = 1;
            // 
            // dataGridViewSecondTeam
            // 
            this.dataGridViewSecondTeam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewSecondTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSecondTeam.Location = new System.Drawing.Point(549, 89);
            this.dataGridViewSecondTeam.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewSecondTeam.MultiSelect = false;
            this.dataGridViewSecondTeam.Name = "dataGridViewSecondTeam";
            this.dataGridViewSecondTeam.ReadOnly = true;
            this.dataGridViewSecondTeam.RowHeadersWidth = 30;
            this.dataGridViewSecondTeam.RowTemplate.Height = 24;
            this.dataGridViewSecondTeam.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewSecondTeam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSecondTeam.Size = new System.Drawing.Size(514, 236);
            this.dataGridViewSecondTeam.TabIndex = 2;
            // 
            // buttonChangeScreen
            // 
            this.buttonChangeScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeScreen.Location = new System.Drawing.Point(9, 10);
            this.buttonChangeScreen.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChangeScreen.Name = "buttonChangeScreen";
            this.buttonChangeScreen.Size = new System.Drawing.Size(109, 54);
            this.buttonChangeScreen.TabIndex = 3;
            this.buttonChangeScreen.Text = "Go to creator";
            this.buttonChangeScreen.UseVisualStyleBackColor = true;
            this.buttonChangeScreen.Click += new System.EventHandler(this.buttonChangeScreen_Click);
            // 
            // buttonBet1
            // 
            this.buttonBet1.Location = new System.Drawing.Point(214, 330);
            this.buttonBet1.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBet1.Name = "buttonBet1";
            this.buttonBet1.Size = new System.Drawing.Size(77, 37);
            this.buttonBet1.TabIndex = 4;
            this.buttonBet1.Text = "Bet";
            this.buttonBet1.UseVisualStyleBackColor = true;
            this.buttonBet1.Click += new System.EventHandler(this.buttonBet1_Click);
            // 
            // buttonBet2
            // 
            this.buttonBet2.Location = new System.Drawing.Point(787, 330);
            this.buttonBet2.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBet2.Name = "buttonBet2";
            this.buttonBet2.Size = new System.Drawing.Size(77, 37);
            this.buttonBet2.TabIndex = 5;
            this.buttonBet2.Text = "Bet";
            this.buttonBet2.UseVisualStyleBackColor = true;
            this.buttonBet2.Click += new System.EventHandler(this.buttonBet2_Click);
            // 
            // textBoxGold
            // 
            this.textBoxGold.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxGold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGold.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxGold.Location = new System.Drawing.Point(962, 15);
            this.textBoxGold.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxGold.Name = "textBoxGold";
            this.textBoxGold.ReadOnly = true;
            this.textBoxGold.Size = new System.Drawing.Size(95, 26);
            this.textBoxGold.TabIndex = 6;
            this.textBoxGold.Text = "100";
            this.textBoxGold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxGold.TextChanged += new System.EventHandler(this.textBoxGold_TextChanged);
            // 
            // labelTeamOne
            // 
            this.labelTeamOne.AutoSize = true;
            this.labelTeamOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeamOne.Location = new System.Drawing.Point(211, 60);
            this.labelTeamOne.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTeamOne.Name = "labelTeamOne";
            this.labelTeamOne.Size = new System.Drawing.Size(83, 20);
            this.labelTeamOne.TabIndex = 8;
            this.labelTeamOne.Text = "Team One";
            // 
            // labelTeamTwo
            // 
            this.labelTeamTwo.AutoSize = true;
            this.labelTeamTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeamTwo.Location = new System.Drawing.Point(783, 60);
            this.labelTeamTwo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTeamTwo.Name = "labelTeamTwo";
            this.labelTeamTwo.Size = new System.Drawing.Size(82, 20);
            this.labelTeamTwo.TabIndex = 9;
            this.labelTeamTwo.Text = "Team Two";
            // 
            // dataGridViewOwnTeam
            // 
            this.dataGridViewOwnTeam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewOwnTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOwnTeam.Location = new System.Drawing.Point(549, 90);
            this.dataGridViewOwnTeam.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewOwnTeam.MultiSelect = false;
            this.dataGridViewOwnTeam.Name = "dataGridViewOwnTeam";
            this.dataGridViewOwnTeam.ReadOnly = true;
            this.dataGridViewOwnTeam.RowHeadersWidth = 30;
            this.dataGridViewOwnTeam.RowTemplate.Height = 24;
            this.dataGridViewOwnTeam.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewOwnTeam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOwnTeam.Size = new System.Drawing.Size(514, 236);
            this.dataGridViewOwnTeam.TabIndex = 11;
            this.dataGridViewOwnTeam.Visible = false;
            // 
            // dataGridViewToHire
            // 
            this.dataGridViewToHire.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewToHire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewToHire.Location = new System.Drawing.Point(9, 90);
            this.dataGridViewToHire.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewToHire.MultiSelect = false;
            this.dataGridViewToHire.Name = "dataGridViewToHire";
            this.dataGridViewToHire.ReadOnly = true;
            this.dataGridViewToHire.RowHeadersWidth = 30;
            this.dataGridViewToHire.RowTemplate.Height = 24;
            this.dataGridViewToHire.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewToHire.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewToHire.Size = new System.Drawing.Size(514, 236);
            this.dataGridViewToHire.TabIndex = 10;
            this.dataGridViewToHire.Visible = false;
            // 
            // labelOwnTeam
            // 
            this.labelOwnTeam.AutoSize = true;
            this.labelOwnTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOwnTeam.Location = new System.Drawing.Point(767, 60);
            this.labelOwnTeam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOwnTeam.Name = "labelOwnTeam";
            this.labelOwnTeam.Size = new System.Drawing.Size(116, 20);
            this.labelOwnTeam.TabIndex = 13;
            this.labelOwnTeam.Text = "Your gladiators";
            this.labelOwnTeam.Visible = false;
            // 
            // labelToHire
            // 
            this.labelToHire.AutoSize = true;
            this.labelToHire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToHire.Location = new System.Drawing.Point(186, 60);
            this.labelToHire.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelToHire.Name = "labelToHire";
            this.labelToHire.Size = new System.Drawing.Size(145, 20);
            this.labelToHire.TabIndex = 12;
            this.labelToHire.Text = "Available gladiators";
            this.labelToHire.Visible = false;
            // 
            // buttonHire
            // 
            this.buttonHire.Location = new System.Drawing.Point(254, 329);
            this.buttonHire.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHire.Name = "buttonHire";
            this.buttonHire.Size = new System.Drawing.Size(77, 37);
            this.buttonHire.TabIndex = 14;
            this.buttonHire.Text = "Hire";
            this.buttonHire.UseVisualStyleBackColor = true;
            this.buttonHire.Visible = false;
            this.buttonHire.Click += new System.EventHandler(this.buttonHire_Click);
            // 
            // buttonFire
            // 
            this.buttonFire.Location = new System.Drawing.Point(734, 330);
            this.buttonFire.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFire.Name = "buttonFire";
            this.buttonFire.Size = new System.Drawing.Size(77, 37);
            this.buttonFire.TabIndex = 15;
            this.buttonFire.Text = "Fire";
            this.buttonFire.UseVisualStyleBackColor = true;
            this.buttonFire.Visible = false;
            this.buttonFire.Click += new System.EventHandler(this.buttonFire_Click);
            // 
            // buttonStartFight
            // 
            this.buttonStartFight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartFight.Location = new System.Drawing.Point(485, 378);
            this.buttonStartFight.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStartFight.Name = "buttonStartFight";
            this.buttonStartFight.Size = new System.Drawing.Size(106, 44);
            this.buttonStartFight.TabIndex = 16;
            this.buttonStartFight.Text = "Fight!";
            this.buttonStartFight.UseVisualStyleBackColor = true;
            this.buttonStartFight.Click += new System.EventHandler(this.buttonStartFight_Click);
            // 
            // buttonDismiss
            // 
            this.buttonDismiss.Location = new System.Drawing.Point(173, 329);
            this.buttonDismiss.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDismiss.Name = "buttonDismiss";
            this.buttonDismiss.Size = new System.Drawing.Size(77, 37);
            this.buttonDismiss.TabIndex = 17;
            this.buttonDismiss.Text = "Dismiss";
            this.buttonDismiss.UseVisualStyleBackColor = true;
            this.buttonDismiss.Visible = false;
            this.buttonDismiss.Click += new System.EventHandler(this.buttonDismiss_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(815, 330);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(77, 37);
            this.buttonEdit.TabIndex = 18;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Visible = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // pictureBoxOwnMoney
            // 
            this.pictureBoxOwnMoney.Image = global::TomaszGrochowskiZadanieDomowe2.Properties.Resources.Coins;
            this.pictureBoxOwnMoney.Location = new System.Drawing.Point(927, 11);
            this.pictureBoxOwnMoney.Name = "pictureBoxOwnMoney";
            this.pictureBoxOwnMoney.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxOwnMoney.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOwnMoney.TabIndex = 19;
            this.pictureBoxOwnMoney.TabStop = false;
            // 
            // pictureBoxRerollCost
            // 
            this.pictureBoxRerollCost.Image = global::TomaszGrochowskiZadanieDomowe2.Properties.Resources.Coins;
            this.pictureBoxRerollCost.Location = new System.Drawing.Point(609, 336);
            this.pictureBoxRerollCost.Name = "pictureBoxRerollCost";
            this.pictureBoxRerollCost.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxRerollCost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRerollCost.TabIndex = 20;
            this.pictureBoxRerollCost.TabStop = false;
            // 
            // labelRerollCost
            // 
            this.labelRerollCost.AutoSize = true;
            this.labelRerollCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRerollCost.Location = new System.Drawing.Point(594, 341);
            this.labelRerollCost.Name = "labelRerollCost";
            this.labelRerollCost.Size = new System.Drawing.Size(18, 20);
            this.labelRerollCost.TabIndex = 21;
            this.labelRerollCost.Text = "0";
            // 
            // labelBetCost2
            // 
            this.labelBetCost2.AutoSize = true;
            this.labelBetCost2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBetCost2.Location = new System.Drawing.Point(865, 341);
            this.labelBetCost2.Name = "labelBetCost2";
            this.labelBetCost2.Size = new System.Drawing.Size(27, 20);
            this.labelBetCost2.TabIndex = 23;
            this.labelBetCost2.Text = "10";
            // 
            // pictureBoxBetCost2
            // 
            this.pictureBoxBetCost2.Image = global::TomaszGrochowskiZadanieDomowe2.Properties.Resources.Coins;
            this.pictureBoxBetCost2.Location = new System.Drawing.Point(889, 337);
            this.pictureBoxBetCost2.Name = "pictureBoxBetCost2";
            this.pictureBoxBetCost2.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxBetCost2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBetCost2.TabIndex = 22;
            this.pictureBoxBetCost2.TabStop = false;
            // 
            // labelBetCost1
            // 
            this.labelBetCost1.AutoSize = true;
            this.labelBetCost1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBetCost1.Location = new System.Drawing.Point(292, 341);
            this.labelBetCost1.Name = "labelBetCost1";
            this.labelBetCost1.Size = new System.Drawing.Size(27, 20);
            this.labelBetCost1.TabIndex = 25;
            this.labelBetCost1.Text = "10";
            // 
            // pictureBoxBetCost1
            // 
            this.pictureBoxBetCost1.Image = global::TomaszGrochowskiZadanieDomowe2.Properties.Resources.Coins;
            this.pictureBoxBetCost1.Location = new System.Drawing.Point(316, 336);
            this.pictureBoxBetCost1.Name = "pictureBoxBetCost1";
            this.pictureBoxBetCost1.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxBetCost1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBetCost1.TabIndex = 24;
            this.pictureBoxBetCost1.TabStop = false;
            // 
            // labelDismissCost
            // 
            this.labelDismissCost.AutoSize = true;
            this.labelDismissCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDismissCost.Location = new System.Drawing.Point(186, 375);
            this.labelDismissCost.Name = "labelDismissCost";
            this.labelDismissCost.Size = new System.Drawing.Size(18, 20);
            this.labelDismissCost.TabIndex = 27;
            this.labelDismissCost.Text = "5";
            this.labelDismissCost.Visible = false;
            // 
            // pictureBoxDismissCost
            // 
            this.pictureBoxDismissCost.Image = global::TomaszGrochowskiZadanieDomowe2.Properties.Resources.Coins;
            this.pictureBoxDismissCost.Location = new System.Drawing.Point(203, 371);
            this.pictureBoxDismissCost.Name = "pictureBoxDismissCost";
            this.pictureBoxDismissCost.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxDismissCost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDismissCost.TabIndex = 26;
            this.pictureBoxDismissCost.TabStop = false;
            this.pictureBoxDismissCost.Visible = false;
            // 
            // labelHireCost
            // 
            this.labelHireCost.AutoSize = true;
            this.labelHireCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHireCost.Location = new System.Drawing.Point(265, 375);
            this.labelHireCost.Name = "labelHireCost";
            this.labelHireCost.Size = new System.Drawing.Size(27, 20);
            this.labelHireCost.TabIndex = 29;
            this.labelHireCost.Text = "20";
            this.labelHireCost.Visible = false;
            // 
            // pictureBoxHireCost
            // 
            this.pictureBoxHireCost.Image = global::TomaszGrochowskiZadanieDomowe2.Properties.Resources.Coins;
            this.pictureBoxHireCost.Location = new System.Drawing.Point(289, 371);
            this.pictureBoxHireCost.Name = "pictureBoxHireCost";
            this.pictureBoxHireCost.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxHireCost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHireCost.TabIndex = 28;
            this.pictureBoxHireCost.TabStop = false;
            this.pictureBoxHireCost.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1072, 459);
            this.Controls.Add(this.labelHireCost);
            this.Controls.Add(this.pictureBoxHireCost);
            this.Controls.Add(this.labelDismissCost);
            this.Controls.Add(this.pictureBoxDismissCost);
            this.Controls.Add(this.labelBetCost1);
            this.Controls.Add(this.pictureBoxBetCost1);
            this.Controls.Add(this.labelBetCost2);
            this.Controls.Add(this.pictureBoxBetCost2);
            this.Controls.Add(this.labelRerollCost);
            this.Controls.Add(this.pictureBoxRerollCost);
            this.Controls.Add(this.pictureBoxOwnMoney);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDismiss);
            this.Controls.Add(this.buttonStartFight);
            this.Controls.Add(this.buttonFire);
            this.Controls.Add(this.buttonHire);
            this.Controls.Add(this.labelOwnTeam);
            this.Controls.Add(this.labelToHire);
            this.Controls.Add(this.dataGridViewOwnTeam);
            this.Controls.Add(this.dataGridViewToHire);
            this.Controls.Add(this.labelTeamTwo);
            this.Controls.Add(this.labelTeamOne);
            this.Controls.Add(this.textBoxGold);
            this.Controls.Add(this.buttonBet2);
            this.Controls.Add(this.buttonBet1);
            this.Controls.Add(this.buttonChangeScreen);
            this.Controls.Add(this.dataGridViewSecondTeam);
            this.Controls.Add(this.dataGridViewFirstTeam);
            this.Controls.Add(this.buttonNewArena);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.Text = "Arena Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFirstTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSecondTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOwnTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToHire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOwnMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRerollCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBetCost2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBetCost1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDismissCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHireCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNewArena;
        private System.Windows.Forms.DataGridView dataGridViewFirstTeam;
        private System.Windows.Forms.DataGridView dataGridViewSecondTeam;
        private System.Windows.Forms.Button buttonChangeScreen;
        private System.Windows.Forms.Button buttonBet1;
        private System.Windows.Forms.Button buttonBet2;
        private System.Windows.Forms.TextBox textBoxGold;
        private System.Windows.Forms.Label labelTeamOne;
        private System.Windows.Forms.Label labelTeamTwo;
        private System.Windows.Forms.DataGridView dataGridViewOwnTeam;
        private System.Windows.Forms.DataGridView dataGridViewToHire;
        private System.Windows.Forms.Label labelOwnTeam;
        private System.Windows.Forms.Label labelToHire;
        private System.Windows.Forms.Button buttonHire;
        private System.Windows.Forms.Button buttonFire;
        private System.Windows.Forms.Button buttonStartFight;
        private System.Windows.Forms.Button buttonDismiss;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.PictureBox pictureBoxOwnMoney;
        private System.Windows.Forms.PictureBox pictureBoxRerollCost;
        private System.Windows.Forms.Label labelRerollCost;
        private System.Windows.Forms.Label labelBetCost2;
        private System.Windows.Forms.PictureBox pictureBoxBetCost2;
        private System.Windows.Forms.Label labelBetCost1;
        private System.Windows.Forms.PictureBox pictureBoxBetCost1;
        private System.Windows.Forms.Label labelDismissCost;
        private System.Windows.Forms.PictureBox pictureBoxDismissCost;
        private System.Windows.Forms.Label labelHireCost;
        private System.Windows.Forms.PictureBox pictureBoxHireCost;
    }
}