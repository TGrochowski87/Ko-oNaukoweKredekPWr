
namespace TomaszGrochowskiZadanieDomowe4.Forms
{
    partial class MainWindow
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
            this.dataGridViewShowData = new System.Windows.Forms.DataGridView();
            this.buttonAnimals = new System.Windows.Forms.Button();
            this.buttonMushrooms = new System.Windows.Forms.Button();
            this.buttonKeepers = new System.Windows.Forms.Button();
            this.buttonRegions = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.pictureBoxView = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewShowData
            // 
            this.dataGridViewShowData.AllowUserToAddRows = false;
            this.dataGridViewShowData.AllowUserToDeleteRows = false;
            this.dataGridViewShowData.AllowUserToResizeColumns = false;
            this.dataGridViewShowData.AllowUserToResizeRows = false;
            this.dataGridViewShowData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewShowData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowData.Location = new System.Drawing.Point(58, 98);
            this.dataGridViewShowData.MultiSelect = false;
            this.dataGridViewShowData.Name = "dataGridViewShowData";
            this.dataGridViewShowData.ReadOnly = true;
            this.dataGridViewShowData.RowHeadersWidth = 51;
            this.dataGridViewShowData.RowTemplate.Height = 24;
            this.dataGridViewShowData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewShowData.Size = new System.Drawing.Size(619, 245);
            this.dataGridViewShowData.TabIndex = 0;
            // 
            // buttonAnimals
            // 
            this.buttonAnimals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnimals.Location = new System.Drawing.Point(58, 369);
            this.buttonAnimals.Name = "buttonAnimals";
            this.buttonAnimals.Size = new System.Drawing.Size(136, 60);
            this.buttonAnimals.TabIndex = 1;
            this.buttonAnimals.Text = "Animals";
            this.buttonAnimals.UseVisualStyleBackColor = true;
            this.buttonAnimals.Visible = false;
            this.buttonAnimals.Click += new System.EventHandler(this.buttonAnimals_Click);
            // 
            // buttonMushrooms
            // 
            this.buttonMushrooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMushrooms.Location = new System.Drawing.Point(221, 369);
            this.buttonMushrooms.Name = "buttonMushrooms";
            this.buttonMushrooms.Size = new System.Drawing.Size(136, 60);
            this.buttonMushrooms.TabIndex = 2;
            this.buttonMushrooms.Text = "Mushrooms";
            this.buttonMushrooms.UseVisualStyleBackColor = true;
            this.buttonMushrooms.Visible = false;
            this.buttonMushrooms.Click += new System.EventHandler(this.buttonMushrooms_Click);
            // 
            // buttonKeepers
            // 
            this.buttonKeepers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeepers.Location = new System.Drawing.Point(382, 369);
            this.buttonKeepers.Name = "buttonKeepers";
            this.buttonKeepers.Size = new System.Drawing.Size(136, 60);
            this.buttonKeepers.TabIndex = 3;
            this.buttonKeepers.Text = "Keepers";
            this.buttonKeepers.UseVisualStyleBackColor = true;
            this.buttonKeepers.Visible = false;
            this.buttonKeepers.Click += new System.EventHandler(this.buttonKeepers_Click);
            // 
            // buttonRegions
            // 
            this.buttonRegions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegions.Location = new System.Drawing.Point(541, 369);
            this.buttonRegions.Name = "buttonRegions";
            this.buttonRegions.Size = new System.Drawing.Size(136, 60);
            this.buttonRegions.TabIndex = 4;
            this.buttonRegions.Text = "Regions";
            this.buttonRegions.UseVisualStyleBackColor = true;
            this.buttonRegions.Visible = false;
            this.buttonRegions.Click += new System.EventHandler(this.buttonRegions_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(118, 115);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(505, 32);
            this.labelWelcome.TabIndex = 5;
            this.labelWelcome.Text = "Welcome to Mauterian Forest Info App!";
            this.labelWelcome.Visible = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(504, 369);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(173, 60);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Remove keeper";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(283, 369);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(173, 60);
            this.buttonEdit.TabIndex = 7;
            this.buttonEdit.Text = "Edit keeper";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Visible = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(58, 369);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(173, 60);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "New keeper";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Visible = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // pictureBoxView
            // 
            this.pictureBoxView.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxView.Location = new System.Drawing.Point(322, 12);
            this.pictureBoxView.Name = "pictureBoxView";
            this.pictureBoxView.Size = new System.Drawing.Size(100, 88);
            this.pictureBoxView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxView.TabIndex = 9;
            this.pictureBoxView.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::TomaszGrochowskiZadanieDomowe4.Properties.Resources.forest_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(743, 538);
            this.Controls.Add(this.pictureBoxView);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.buttonRegions);
            this.Controls.Add(this.buttonKeepers);
            this.Controls.Add(this.buttonMushrooms);
            this.Controls.Add(this.buttonAnimals);
            this.Controls.Add(this.dataGridViewShowData);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mauterian Forest";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewShowData;
        private System.Windows.Forms.Button buttonAnimals;
        private System.Windows.Forms.Button buttonMushrooms;
        private System.Windows.Forms.Button buttonKeepers;
        private System.Windows.Forms.Button buttonRegions;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.PictureBox pictureBoxView;
    }
}