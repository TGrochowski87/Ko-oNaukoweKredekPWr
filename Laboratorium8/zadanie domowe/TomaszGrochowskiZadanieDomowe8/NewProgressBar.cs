using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TomaszGrochowskiZadanieDomowe8
{
    /// <summary>
    /// Custom progress bar made so it could change colors
    /// </summary>
    public class NewProgressBar : ProgressBar
    {
        //Custom fill color
        SolidBrush brush = new SolidBrush(Color.FromArgb(230, 230, 230));

        public NewProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        public SolidBrush Brush { get => brush; set => brush = value; }

        /// <summary>
        /// Method for custom filling progress bar
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rec = e.ClipRectangle;

            rec.Width = (int)(rec.Width * ((double)Value / Maximum)) - 4;
            if (ProgressBarRenderer.IsSupported)
                ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle);
            rec.Height = rec.Height - 4;

            e.Graphics.FillRectangle(Brush, 2, 2, rec.Width, rec.Height);
        }
    }
}
