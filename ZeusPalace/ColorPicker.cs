using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeusPalace
{
    internal static class ColorPicker
    {
        public static Color Charcoal => Color.FromArgb(51, 51, 51);
        public static Color AntiqueWhite => Color.FromArgb(224, 221, 213);
        public static Color AegeanBlue => Color.FromArgb(40, 61, 112);
        public static Color Vermilion => Color.FromArgb(255, 102, 102);
        public static Color TurquoiseGreen => Color.FromArgb(0, 188, 139);
        public static Color ControlGray => Color.FromArgb(201, 198, 191);

        public static Color[] TemperatureColor = new Color[]
        {
            Color.FromArgb(51, 255, 255),    // Sky Blue
            Color.FromArgb(51, 255, 153),    // Light Blue
            Color.FromArgb(51, 255, 51),    // Cyan
            Color.FromArgb(153, 255, 51),  // Light Green
            Color.FromArgb(255, 255, 51),  // Pale Yellow
            Color.FromArgb(255, 153, 51),  // Light Orange
            Color.FromArgb(255, 51, 51)     // Strong Red
        };

        public static Color GetShade(Color baseColor, int percent)
        {
            float scale = 1f - (percent / 100f);

            int red = (int)(baseColor.R * scale);
            int green = (int)(baseColor.G * scale);
            int blue = (int)(baseColor.B * scale);

            return Color.FromArgb(baseColor.A, red, green, blue);
        }

        public static Color GetTint(Color baseColor, int percent)
        {
            float scale = 1f + (percent / 100f);

            int red = Math.Min((int)(baseColor.R * scale), 255);
            int green = Math.Min((int)(baseColor.G * scale), 255);
            int blue = Math.Min((int)(baseColor.B * scale), 255);
            return Color.FromArgb(baseColor.A, red, green, blue);
        }
    }
}
