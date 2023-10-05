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

        public virtual bool IsInNewFormArea(int x, int y)
        {
            return false;
        }
    }
}
