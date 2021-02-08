
namespace TomaszGrochowskiLab1
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
            this.components = new System.ComponentModel.Container();
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonColor2 = new System.Windows.Forms.Button();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.counterButtonColor = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.textBoxCount2 = new System.Windows.Forms.TextBox();
            this.buttonTimer = new System.Windows.Forms.Button();
            this.timerCounter = new System.Windows.Forms.Timer(this.components);
            this.buttonNewWindow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(12, 12);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(83, 44);
            this.buttonColor.TabIndex = 0;
            this.buttonColor.Text = "Zmień kolor";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonColor2
            // 
            this.buttonColor2.Location = new System.Drawing.Point(12, 62);
            this.buttonColor2.Name = "buttonColor2";
            this.buttonColor2.Size = new System.Drawing.Size(83, 43);
            this.buttonColor2.TabIndex = 1;
            this.buttonColor2.Text = "Zmień kolor 2";
            this.buttonColor2.UseVisualStyleBackColor = true;
            this.buttonColor2.Click += new System.EventHandler(this.buttonColor2_Click);
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(137, 25);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(100, 20);
            this.textBoxCount.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(258, 20);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 28);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // counterButtonColor
            // 
            this.counterButtonColor.Location = new System.Drawing.Point(378, 14);
            this.counterButtonColor.Name = "counterButtonColor";
            this.counterButtonColor.Size = new System.Drawing.Size(115, 34);
            this.counterButtonColor.TabIndex = 4;
            this.counterButtonColor.Text = "ZmienianyKolor";
            this.counterButtonColor.UseVisualStyleBackColor = true;
            this.counterButtonColor.Click += new System.EventHandler(this.counterButtonColor_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Location = new System.Drawing.Point(258, 68);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(100, 30);
            this.buttonMultiply.TabIndex = 5;
            this.buttonMultiply.Text = "Pomnóż";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // textBoxCount2
            // 
            this.textBoxCount2.Location = new System.Drawing.Point(137, 74);
            this.textBoxCount2.Name = "textBoxCount2";
            this.textBoxCount2.Size = new System.Drawing.Size(100, 20);
            this.textBoxCount2.TabIndex = 6;
            // 
            // buttonTimer
            // 
            this.buttonTimer.Location = new System.Drawing.Point(12, 157);
            this.buttonTimer.Name = "buttonTimer";
            this.buttonTimer.Size = new System.Drawing.Size(83, 43);
            this.buttonTimer.TabIndex = 7;
            this.buttonTimer.Text = "Start";
            this.buttonTimer.UseVisualStyleBackColor = true;
            this.buttonTimer.Click += new System.EventHandler(this.buttonTimer_Click);
            // 
            // timerCounter
            // 
            this.timerCounter.Interval = 1000;
            this.timerCounter.Tick += new System.EventHandler(this.timerCounter_Tick);
            // 
            // buttonNewWindow
            // 
            this.buttonNewWindow.Location = new System.Drawing.Point(12, 253);
            this.buttonNewWindow.Name = "buttonNewWindow";
            this.buttonNewWindow.Size = new System.Drawing.Size(83, 46);
            this.buttonNewWindow.TabIndex = 8;
            this.buttonNewWindow.Text = "Nowe Okno";
            this.buttonNewWindow.UseVisualStyleBackColor = true;
            this.buttonNewWindow.Click += new System.EventHandler(this.buttonNewWindow_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 332);
            this.Controls.Add(this.buttonNewWindow);
            this.Controls.Add(this.buttonTimer);
            this.Controls.Add(this.textBoxCount2);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.counterButtonColor);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.buttonColor2);
            this.Controls.Add(this.buttonColor);
            this.Name = "FormMain";
            this.Text = "Program laboratorium 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Button buttonColor2;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button counterButtonColor;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.TextBox textBoxCount2;
        private System.Windows.Forms.Button buttonTimer;
        private System.Windows.Forms.Timer timerCounter;
        private System.Windows.Forms.Button buttonNewWindow;
    }
}

