using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZeusPalace.Entities.Pool;

namespace ZeusPalace.Modules.PoolControl
{
    public partial class PoolForm : EmbeddedForm
    {
        private Pool pool = new Pool();

        public PoolForm()
        {
            InitializeComponent();
        }

        public PoolForm(Pool pool) : this()
        {
            this.pool = pool;
            labelTitle.Text = pool.Type == PoolType.Private ? "Ιδιωτική πισίνα" : "Κεντρική πισίνα";
            AlignLabelToCenter(labelTitle, panelTitle);
            
        }

        private void trackBarWaterLevel_Scroll(object sender, EventArgs e)
        {
            verticalProgressBarWaterLevel.Value = trackBarWaterLevel.Value;
            labelWaterLevel.Text = trackBarWaterLevel.Value + " cm";
            pool.WaterLevel = verticalProgressBarWaterLevel.Value;
        }

        private void trackBarTemperature_Scroll(object sender, EventArgs e)
        {
            verticalProgressBarTemperature.Value = trackBarTemperature.Value;
            verticalProgressBarTemperature.ProgressBarColor = ColorPicker.TemperatureColor[verticalProgressBarTemperature.Value - 1];
            labelTemperature.Text = trackBarTemperature.Value + pool.MinTemperature - 1 + " oC";
            pool.Temperature = verticalProgressBarTemperature.Value + pool.MinTemperature - 1;
        }
    }
}
