using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZeusPalace.Properties;

namespace ZeusPalace.Modules.Driving
{
    public partial class GardensOfOlympusForm : ZeusPalace.Modules.Driving.ZeusTempleCourtyardForm
    {
        public GardensOfOlympusForm()
        {
            InitializeComponent();
        }

        public GardensOfOlympusForm(MainForm mainForm) : this()
        {
            this.mainForm = mainForm;
            mainForm.KeyUp += GardensOfOlympusForm_KeyDown;
            mainForm.KeyDown += GardensOfOlympusForm_KeyUp;
        }

        private void GardensOfOlympusForm_Load(object sender, EventArgs e)
        {
            movementAreas = new List<Panel>
            {
                panelMovementArea2,
                panelMovementArea3,
                panelMovementArea4,
                panelMovementArea5,
                panelMovementArea6,
                panelMovementArea7
            };
        }
        
        protected override bool IsInNewFormArea(int x, int y)
        {
            return trojanHorseX == panelMovementArea6.Location.X;
        }

        private void GardensOfOlympusForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (mainForm.CurrentForm == this && selectedDoorLabel.Equals(labelClosedDoor))
            {
                // set the appropriate key flag when a key is pressed
                if (e.KeyData == Keys.A || e.KeyData == Keys.Left)
                {
                    leftKeyPressed = true;
                    currentDirection = 'L';
                    pictureBoxTrojanHorse.Image = Resources.horse_left;
                }
                else if (e.KeyData == Keys.D || e.KeyData == Keys.Right)
                {
                    rightKeyPressed = true;
                    currentDirection = 'R';
                    pictureBoxTrojanHorse.Image = Resources.horse_right;
                }
                else if (e.KeyData == Keys.W || e.KeyData == Keys.Up)
                {
                    upKeyPressed = true;
                    currentDirection = 'U';
                }
                else if (e.KeyData == Keys.S || e.KeyData == Keys.Down)
                {
                    downKeyPressed = true;
                    currentDirection = 'D';
                }

                // start the timer if it's not already running
                if (!timerMovement.Enabled)
                {
                    timerMovement.Start();
                }
            }
        }

        private void GardensOfOlympusForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (mainForm.CurrentForm == this && selectedDoorLabel.Equals(labelClosedDoor))
            {
                // unset the appropriate key flag when a key is released
                if (e.KeyData == Keys.A || e.KeyData == Keys.Left)
                {
                    leftKeyPressed = false;
                }
                else if (e.KeyData == Keys.D || e.KeyData == Keys.Right)
                {
                    rightKeyPressed = false;
                }
                else if (e.KeyData == Keys.W || e.KeyData == Keys.Up)
                {
                    upKeyPressed = false;
                }
                else if (e.KeyData == Keys.S || e.KeyData == Keys.Down)
                {
                    downKeyPressed = false;
                }

                // stop the timer if all keys are released
                if (!leftKeyPressed && !rightKeyPressed && !upKeyPressed && !downKeyPressed)
                {
                    timerMovement.Stop();
                }
            }
        }
    }
}
