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
    public partial class ZeusTempleCourtyardPanel : CampingAreaPanel
    {
        public ZeusTempleCourtyardPanel()
        {
            InitializeComponent();
            MovementAreas.Add(panelMovementArea1);
        }

        public override bool IsInNewFormArea(int x, int y)
        {
            return x + pictureBoxTrojanHorse.Width >= panelMovementArea1.Location.X + panelMovementArea1.Width;
        }
    }
}
