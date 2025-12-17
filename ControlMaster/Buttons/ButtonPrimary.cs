using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using ERP.ControlMaster.FontFamily;


namespace ERP.ControlMaster
{
    internal class ButtonPrimary : Button
    {
        private int BorderSize = 0;
        private int BorderRadius = 40;
        private Color BorColor = Color.FromArgb(0, 123, 255);
        private Color BColor = Color.FromArgb(0, 123, 255);
        private Color FColor = Color.White;
        Fonts F=new Fonts();

        //constructor
        public ButtonPrimary()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = BorderSize;
            this.Size = new Size(100, 40);  
            this.BackColor = BColor;
            this.ForeColor = FColor;
            this.Font = F.MontserratButton();
            this.Padding=new Padding(5);
        }

        //methods
        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width-radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }

         protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode=SmoothingMode.AntiAlias;

            RectangleF RectSurface=new RectangleF(0,0,this.Width,this.Height);
            RectangleF RectBorder=new RectangleF(1,1,this.Width-0.8f,this.Height-1);

            //Round Button
            if (BorderRadius >2)
            {
                using(GraphicsPath pathSurface = GetFigurePath(RectSurface, BorderRadius))
                using(GraphicsPath pathBorder= GetFigurePath(RectBorder, BorderRadius))
                using(Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using(Pen penBorder = new Pen(BorColor, BorderSize))
                {
                    penBorder.Alignment=PenAlignment.Inset;
                    //Button Surface
                    this.Region = new Region(pathSurface);
                    //Draw Surface
                    e.Graphics.DrawPath(penSurface, pathSurface);

                    //Button Border
                    if (BorderSize >= 1)
                    {
                        //Draw Control Border
                        e.Graphics.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            //Normal Button
            else
            {
                //Draw Surface
                this.Region = new Region(RectSurface);
                //Button Border
                if (BorderSize >= 1)
                {
                    using (Pen penBorder = new Pen(BorColor, BorderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        e.Graphics.DrawRectangle(penBorder,0,0,this.Width-1,this.Height-1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackcolorChanged);
        }
        private void Container_BackcolorChanged(object sender, EventArgs e)
        {
            if(this.DesignMode)
                this.Invalidate();
        }
    }
}
