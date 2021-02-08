
namespace TomaszGrochowskiZadanieDomowe8.Forms
{
    partial class SingletonsRoom
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
            this.pictureBoxOwl = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOwl)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxOwl
            // 
            this.pictureBoxOwl.Location = new System.Drawing.Point(40, 28);
            this.pictureBoxOwl.Name = "pictureBoxOwl";
            this.pictureBoxOwl.Size = new System.Drawing.Size(425, 411);
            this.pictureBoxOwl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOwl.TabIndex = 0;
            this.pictureBoxOwl.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(150, 28);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 32);
            this.labelName.TabIndex = 1;
            // 
            // SingletonsRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 409);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBoxOwl);
            this.Name = "SingletonsRoom";
            this.Text = "SingletonsRoom";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOwl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOwl;
        private System.Windows.Forms.Label labelName;
    }
}