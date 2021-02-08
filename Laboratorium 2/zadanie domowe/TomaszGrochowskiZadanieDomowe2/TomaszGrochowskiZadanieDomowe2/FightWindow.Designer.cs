namespace TomaszGrochowskiZadanieDomowe2
{
    partial class FightWindow
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewSecondTeam = new System.Windows.Forms.DataGridView();
            this.dataGridViewFirstTeam = new System.Windows.Forms.DataGridView();
            this.richTextBoxAttackInfo = new System.Windows.Forms.RichTextBox();
            this.buttonSkipFight = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.buttonStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSecondTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFirstTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSecondTeam
            // 
            this.dataGridViewSecondTeam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewSecondTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSecondTeam.Location = new System.Drawing.Point(86, 271);
            this.dataGridViewSecondTeam.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewSecondTeam.Name = "dataGridViewSecondTeam";
            this.dataGridViewSecondTeam.ReadOnly = true;
            this.dataGridViewSecondTeam.RowHeadersWidth = 30;
            this.dataGridViewSecondTeam.RowTemplate.Height = 24;
            this.dataGridViewSecondTeam.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewSecondTeam.Size = new System.Drawing.Size(531, 117);
            this.dataGridViewSecondTeam.TabIndex = 4;
            // 
            // dataGridViewFirstTeam
            // 
            this.dataGridViewFirstTeam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewFirstTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFirstTeam.Location = new System.Drawing.Point(86, 11);
            this.dataGridViewFirstTeam.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewFirstTeam.Name = "dataGridViewFirstTeam";
            this.dataGridViewFirstTeam.ReadOnly = true;
            this.dataGridViewFirstTeam.RowHeadersWidth = 30;
            this.dataGridViewFirstTeam.RowTemplate.Height = 24;
            this.dataGridViewFirstTeam.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewFirstTeam.Size = new System.Drawing.Size(531, 117);
            this.dataGridViewFirstTeam.TabIndex = 3;
            // 
            // richTextBoxAttackInfo
            // 
            this.richTextBoxAttackInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxAttackInfo.Location = new System.Drawing.Point(152, 132);
            this.richTextBoxAttackInfo.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxAttackInfo.Name = "richTextBoxAttackInfo";
            this.richTextBoxAttackInfo.Size = new System.Drawing.Size(396, 135);
            this.richTextBoxAttackInfo.TabIndex = 5;
            this.richTextBoxAttackInfo.Text = "";
            // 
            // buttonSkipFight
            // 
            this.buttonSkipFight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSkipFight.Location = new System.Drawing.Point(578, 172);
            this.buttonSkipFight.Name = "buttonSkipFight";
            this.buttonSkipFight.Size = new System.Drawing.Size(95, 49);
            this.buttonSkipFight.TabIndex = 6;
            this.buttonSkipFight.Text = "Skip";
            this.buttonSkipFight.UseVisualStyleBackColor = true;
            this.buttonSkipFight.Click += new System.EventHandler(this.buttonSkipFight_Click);
            // 
            // timer
            // 
            this.timer.Interval = 5000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(25, 172);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(95, 49);
            this.buttonStart.TabIndex = 7;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // FightWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 399);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonSkipFight);
            this.Controls.Add(this.richTextBoxAttackInfo);
            this.Controls.Add(this.dataGridViewSecondTeam);
            this.Controls.Add(this.dataGridViewFirstTeam);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FightWindow";
            this.ShowIcon = false;
            this.Text = "Arena Simulator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FightWindow_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSecondTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFirstTeam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSecondTeam;
        private System.Windows.Forms.DataGridView dataGridViewFirstTeam;
        private System.Windows.Forms.RichTextBox richTextBoxAttackInfo;
        private System.Windows.Forms.Button buttonSkipFight;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button buttonStart;
    }
}