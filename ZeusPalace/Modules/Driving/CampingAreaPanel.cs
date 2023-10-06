using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Image = System.Drawing.Image;

namespace ZeusPalace.Modules.Driving
{
    public partial class CampingAreaPanel : UserControl
    {
        public int TrojanHorseX => pictureBoxTrojanHorse.Location.X;
        public int TrojanHorseY => pictureBoxTrojanHorse.Location.Y;
        public Point TrojanHorseLocation
        {
            get => pictureBoxTrojanHorse.Location;
            set
            {
                if (IsWithinBounds(value.X, value.Y))
                {
                    pictureBoxTrojanHorse.Location = value;
                }
            }
        }

        public List<Panel> MovementAreas = new List<Panel>();

        public Image TrojanHorseImage
        {
            get => pictureBoxTrojanHorse.Image;
            set => pictureBoxTrojanHorse.Image = value;
        }

        public CampingAreaPanel()
        {
            InitializeComponent();
        }

        // Check if the entire area of the pictureBoxTrojanHorse is within the area of any panel
        private bool IsWithinBounds(int x, int y)
        {
            foreach (Panel area in MovementAreas)
            {
                if (x >= area.Left && x + pictureBoxTrojanHorse.Width <= area.Right &&
                    y >= area.Top && y + pictureBoxTrojanHorse.Height <= area.Bottom)
                {
                    return true; // The pictureBoxTrojanHorse is entirely within this panel's area.
                }
            }

            return false; // The pictureBoxTrojanHorse is not within any panel's area.
        }

        public void RotateTrojanHorse(string direction, bool flipHorizontal = false)
        {
            Image image = pictureBoxTrojanHorse.Image;

            // Create a new Bitmap for the rotated image
            Bitmap rotatedImage = new Bitmap(image.Width, image.Height);

            // Create a Graphics object to perform the rotation
            using (Graphics graphics = Graphics.FromImage(rotatedImage))
            {
                // Apply the rotation transformation
                float rotationAngle;
                graphics.TranslateTransform(image.Width / 2, image.Height / 2);
                if (direction == "left")
                {
                    rotationAngle = -90.0f;
                }
                else if (direction == "right")
                {
                    rotationAngle = 90.0f;
                }
                else
                {
                    rotationAngle = 0;
                }
                graphics.RotateTransform(rotationAngle);
                graphics.TranslateTransform(-image.Width / 2, -image.Height / 2);

                if (flipHorizontal)
                {
                    // Apply horizontal flip transformation
                    graphics.ScaleTransform(-1, 1);
                    graphics.TranslateTransform(-image.Width, 0);
                }

                // Draw the original image onto the rotated image
                graphics.DrawImage(image, Point.Empty);

                pictureBoxTrojanHorse.Image = rotatedImage;
            }
        }

        public virtual bool IsInNewFormArea(int x, int y)
        {
            return false;
        }
    }
}
