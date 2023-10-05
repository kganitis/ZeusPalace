using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZeusPalace.Modules.Driving
{
    public partial class GardensOfOlympusPanel : CampingAreaPanel
    {
        public GardensOfOlympusPanel()
        {
            InitializeComponent();
            MovementAreas.Add(panelMovementArea1);
            MovementAreas.Add(panelMovementArea2);
            MovementAreas.Add(panelMovementArea3);
            MovementAreas.Add(panelMovementArea4);
            MovementAreas.Add(panelMovementArea5);
            MovementAreas.Add(panelMovementArea6);
        }

        public override bool IsInNewFormArea(int x, int y)
        {
            return x <= panelMovementArea6.Location.X;
        }
    }
}
