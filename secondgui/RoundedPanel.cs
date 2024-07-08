using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace registration_login_system
{
    public class RoundedPanel : Panel
    {
        private int _borderRadius = 30; // Change this value to adjust the roundness

        public int BorderRadius
        {
            get { return _borderRadius; }
            set
            {
                _borderRadius = value;
                this.Invalidate(); // Redraw the panel when the property changes
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Create a path for the rounded edges
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, _borderRadius, _borderRadius, 180, 90);
                path.AddArc(this.Width - _borderRadius, 0, _borderRadius, _borderRadius, 270, 90);
                path.AddArc(this.Width - _borderRadius, this.Height - _borderRadius, _borderRadius, _borderRadius, 0, 90);
                path.AddArc(0, this.Height - _borderRadius, _borderRadius, _borderRadius, 90, 90);
                path.CloseFigure();

                this.Region = new Region(path);

                // Optionally, draw a border
                using (Pen pen = new Pen(Color.Black, 2))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }
    }
}
