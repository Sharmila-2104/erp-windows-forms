using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP.ControlMaster.Buttons
{
    class RoundedButton : Button
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Define the rounded rectangle path
            float radius = 20; // Adjust the radius as needed
            RectangleF rect = new RectangleF(0, 0, Width, Height);
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            // Set the button's region to the rounded rectangle
            Region = new Region(path);
        }
    }
}
