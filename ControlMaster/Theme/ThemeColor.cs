using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.ControlMaster.Theme
{
    public class ThemeColor
    {
        public static List<String> ColorList = new List<string>() { "#3B71CA", "#9FA6B2", "#14A44D", "#DC4C64", "#E4A11B", "#54B4D3", "#FBFBFB", "#332D2D" };

        public Color Primary()
        {
            Color Color = Color.FromArgb(0, 123, 255);
            return Color;
        }

        public Color Danger()
        {
            Color Color = Color.FromArgb(220, 53, 69);
            return Color;
        }

        public Color Success()
        {
            Color Color = Color.FromArgb(40, 167, 69);
            return Color;
        }

        public Color Warning()
        {
            Color Color = Color.FromArgb(255, 193, 7);
            return Color;
        }

        public Color Light()
        {
            Color Color = Color.FromArgb(240, 241, 241);
            return Color;
        }
        public Color White()
        {
            Color Color = Color.FromArgb(255, 255, 255);
            return Color;
        }

        public Color Dark()
        {
            Color Color = Color.FromArgb(0, 0, 0);
            return Color;
        }
    }
}
