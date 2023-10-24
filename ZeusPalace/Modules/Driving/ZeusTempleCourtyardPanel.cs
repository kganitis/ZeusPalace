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
