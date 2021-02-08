
namespace TomaszGrochowskiLab2
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
            this.buttonNew = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.textBoxFuel = new System.Windows.Forms.TextBox();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.textBoxOwner = new System.Windows.Forms.TextBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.buttonRefill = new System.Windows.Forms.Button();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.labelCar = new System.Windows.Forms.Label();
            this.labelChopper = new System.Windows.Forms.Label();
            this.textBoxSeats = new System.Windows.Forms.TextBox();
            this.buttonGoDown = new System.Windows.Forms.Button();
            this.buttonGoUp = new System.Windows.Forms.Button();
            this.buttonMilitary = new System.Windows.Forms.Button();
            this.buttonAmphibia = new System.Windows.Forms.Button();
            this.buttonList = new System.Windows.Forms.Button();
            this.dataGridViewVehicles = new System.Windows.Forms.DataGridView();
            this.buttonFind = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicles)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(27, 21);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(98, 44);
            this.buttonNew.TabIndex = 0;
            this.buttonNew.Text = "Nowy obiekt";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(25, 71);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(98, 20);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.Text = "Nazwa";
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(25, 97);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(98, 20);
            this.textBoxSpeed.TabIndex = 2;
            this.textBoxSpeed.Text = "160";
            // 
            // textBoxFuel
            // 
            this.textBoxFuel.Location = new System.Drawing.Point(25, 123);
            this.textBoxFuel.Name = "textBoxFuel";
            this.textBoxFuel.Size = new System.Drawing.Size(98, 20);
            this.textBoxFuel.TabIndex = 3;
            this.textBoxFuel.Text = "30";
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(25, 183);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(98, 20);
            this.textBoxColor.TabIndex = 4;
            this.textBoxColor.Text = "Czerwony";
            // 
            // textBoxOwner
            // 
            this.textBoxOwner.Location = new System.Drawing.Point(25, 209);
            this.textBoxOwner.Name = "textBoxOwner";
            this.textBoxOwner.Size = new System.Drawing.Size(98, 20);
            this.textBoxOwner.TabIndex = 5;
            this.textBoxOwner.Text = "Paweł";
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(27, 235);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(98, 44);
            this.buttonGo.TabIndex = 6;
            this.buttonGo.Text = "Jedź";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // buttonRefill
            // 
            this.buttonRefill.Location = new System.Drawing.Point(27, 285);
            this.buttonRefill.Name = "buttonRefill";
            this.buttonRefill.Size = new System.Drawing.Size(98, 44);
            this.buttonRefill.TabIndex = 7;
            this.buttonRefill.Text = "Dolej paliwa";
            this.buttonRefill.UseVisualStyleBackColor = true;
            this.buttonRefill.Click += new System.EventHandler(this.buttonRefill_Click);
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(129, 183);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxHeight.TabIndex = 8;
            this.textBoxHeight.Text = "10";
            // 
            // labelCar
            // 
            this.labelCar.AutoSize = true;
            this.labelCar.Location = new System.Drawing.Point(41, 167);
            this.labelCar.Name = "labelCar";
            this.labelCar.Size = new System.Drawing.Size(58, 13);
            this.labelCar.TabIndex = 9;
            this.labelCar.Text = "Samochód";
            // 
            // labelChopper
            // 
            this.labelChopper.AutoSize = true;
            this.labelChopper.Location = new System.Drawing.Point(152, 167);
            this.labelChopper.Name = "labelChopper";
            this.labelChopper.Size = new System.Drawing.Size(55, 13);
            this.labelChopper.TabIndex = 10;
            this.labelChopper.Text = "Helikopter";
            // 
            // textBoxSeats
            // 
            this.textBoxSeats.Location = new System.Drawing.Point(129, 209);
            this.textBoxSeats.Name = "textBoxSeats";
            this.textBoxSeats.Size = new System.Drawing.Size(100, 20);
            this.textBoxSeats.TabIndex = 11;
            this.textBoxSeats.Text = "4";
            // 
            // buttonGoDown
            // 
            this.buttonGoDown.Location = new System.Drawing.Point(129, 285);
            this.buttonGoDown.Name = "buttonGoDown";
            this.buttonGoDown.Size = new System.Drawing.Size(98, 44);
            this.buttonGoDown.TabIndex = 13;
            this.buttonGoDown.Text = "Leć niżej";
            this.buttonGoDown.UseVisualStyleBackColor = true;
            this.buttonGoDown.Click += new System.EventHandler(this.buttonGoDown_Click);
            // 
            // buttonGoUp
            // 
            this.buttonGoUp.Location = new System.Drawing.Point(129, 235);
            this.buttonGoUp.Name = "buttonGoUp";
            this.buttonGoUp.Size = new System.Drawing.Size(98, 44);
            this.buttonGoUp.TabIndex = 12;
            this.buttonGoUp.Text = "Leć wyżej";
            this.buttonGoUp.UseVisualStyleBackColor = true;
            this.buttonGoUp.Click += new System.EventHandler(this.buttonGoUp_Click);
            // 
            // buttonMilitary
            // 
            this.buttonMilitary.Location = new System.Drawing.Point(129, 21);
            this.buttonMilitary.Name = "buttonMilitary";
            this.buttonMilitary.Size = new System.Drawing.Size(98, 44);
            this.buttonMilitary.TabIndex = 14;
            this.buttonMilitary.Text = "Wojskowy";
            this.buttonMilitary.UseVisualStyleBackColor = true;
            this.buttonMilitary.Click += new System.EventHandler(this.buttonMilitary_Click);
            // 
            // buttonAmphibia
            // 
            this.buttonAmphibia.Location = new System.Drawing.Point(235, 183);
            this.buttonAmphibia.Name = "buttonAmphibia";
            this.buttonAmphibia.Size = new System.Drawing.Size(98, 44);
            this.buttonAmphibia.TabIndex = 15;
            this.buttonAmphibia.Text = "Amfibia";
            this.buttonAmphibia.UseVisualStyleBackColor = true;
            this.buttonAmphibia.Click += new System.EventHandler(this.buttonAmphibia_Click);
            // 
            // buttonList
            // 
            this.buttonList.Location = new System.Drawing.Point(233, 21);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(98, 44);
            this.buttonList.TabIndex = 16;
            this.buttonList.Text = "Nowa Lista";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // dataGridViewVehicles
            // 
            this.dataGridViewVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVehicles.Location = new System.Drawing.Point(337, 12);
            this.dataGridViewVehicles.Name = "dataGridViewVehicles";
            this.dataGridViewVehicles.Size = new System.Drawing.Size(451, 150);
            this.dataGridViewVehicles.TabIndex = 17;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(233, 71);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(98, 44);
            this.buttonFind.TabIndex = 18;
            this.buttonFind.Text = "Znajdź";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.dataGridViewVehicles);
            this.Controls.Add(this.buttonList);
            this.Controls.Add(this.buttonAmphibia);
            this.Controls.Add(this.buttonMilitary);
            this.Controls.Add(this.buttonGoDown);
            this.Controls.Add(this.buttonGoUp);
            this.Controls.Add(this.textBoxSeats);
            this.Controls.Add(this.labelChopper);
            this.Controls.Add(this.labelCar);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.buttonRefill);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.textBoxOwner);
            this.Controls.Add(this.textBoxColor);
            this.Controls.Add(this.textBoxFuel);
            this.Controls.Add(this.textBoxSpeed);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonNew);
            this.Name = "FormMain";
            this.Text = "Laboratorium 2 - Obiektowaość";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.TextBox textBoxFuel;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.TextBox textBoxOwner;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Button buttonRefill;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label labelCar;
        private System.Windows.Forms.Label labelChopper;
        private System.Windows.Forms.TextBox textBoxSeats;
        private System.Windows.Forms.Button buttonGoDown;
        private System.Windows.Forms.Button buttonGoUp;
        private System.Windows.Forms.Button buttonMilitary;
        private System.Windows.Forms.Button buttonAmphibia;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.DataGridView dataGridViewVehicles;
        private System.Windows.Forms.Button buttonFind;
    }
}

