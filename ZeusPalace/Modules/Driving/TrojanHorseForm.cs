using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ZeusPalace.Properties;

namespace ZeusPalace.Modules.Driving
{
    public partial class TrojanHorseForm : ZeusPalace.Modules.EmbeddedForm
    {
        // Movement fields
        private const int trojanHorseSpeed = 10;
        private bool rightKeyPressed, leftKeyPressed, upKeyPressed, downKeyPressed = false;
        private char currentDirection = 'R';

        // Door and ladder fields
        private Dictionary<Label, string> initialLabelTexts = new Dictionary<Label, string>();
        private Dictionary<Label, string> selectedLabelTexts = new Dictionary<Label, string>();
        private Label selectedDoorLabel;
        private Label selectedLadderLabel;

        private CampingAreaPanel currentCampingAreaPanel;
        private GardensOfOlympusPanel gardensOfOlympusPanel = new GardensOfOlympusPanel();
        private MainForm mainForm;
        
        public TrojanHorseForm()
        {
            InitializeComponent();
        }

        public TrojanHorseForm(MainForm mainForm) : this()
        {
            // the key events are sent to the main form to handle
            this.mainForm = mainForm;
            mainForm.KeyUp += ZeusTempleCourtyardForm_KeyUp;
            mainForm.KeyDown += ZeusTempleCourtyardForm_KeyDown;

            currentCampingAreaPanel = zeusTempleCourtyardPanel;
        }

        private void ZeusTempleCourtyardForm_Load(object sender, EventArgs e)
        {
            // Door and ladder fields initialization
            initialLabelTexts.Add(labelOpenDoor, labelOpenDoor.Text);
            initialLabelTexts.Add(labelHalfOpenDoor, labelHalfOpenDoor.Text);
            initialLabelTexts.Add(labelHalfClosedDoor, labelHalfClosedDoor.Text);
            initialLabelTexts.Add(labelClosedDoor, labelClosedDoor.Text);
            initialLabelTexts.Add(labelExtendLadder, labelExtendLadder.Text);
            initialLabelTexts.Add(labelRetractLadder, labelRetractLadder.Text);

            selectedLabelTexts.Add(labelOpenDoor, "Πόρτες ανοιχτές");
            selectedLabelTexts.Add(labelHalfOpenDoor, "Πόρτες μισοανοιχτές");
            selectedLabelTexts.Add(labelHalfClosedDoor, "Πόρτες μισόκλειστες");
            selectedLabelTexts.Add(labelClosedDoor, "Πόρτες κλειστές");
            selectedLabelTexts.Add(labelExtendLadder, "Σκάλα κατεβασμένη");
            selectedLabelTexts.Add(labelRetractLadder, "Σκάλα ανεβασμένη");

            selectedDoorLabel = labelClosedDoor;
            HighlightLabel(selectedDoorLabel);
            selectedLadderLabel = labelRetractLadder;
            HighlightLabel(selectedLadderLabel);
        }

        #region Movement methods

        private void pictureBoxDirection_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender == pictureBoxUp)
            {
                ZeusTempleCourtyardForm_KeyDown(this, new KeyEventArgs(Keys.W));
            }
            else if (sender == pictureBoxDown)
            {
                ZeusTempleCourtyardForm_KeyDown(this, new KeyEventArgs(Keys.S));
            }
            else if (sender == pictureBoxLeft)
            {
                ZeusTempleCourtyardForm_KeyDown(this, new KeyEventArgs(Keys.A));
            }
            else if (sender == pictureBoxRight)
            {
                ZeusTempleCourtyardForm_KeyDown(this, new KeyEventArgs(Keys.D));
            }
        }

        private void pictureBoxDirection_MouseUp(object sender, MouseEventArgs e)
        {
            if (sender == pictureBoxUp)
            {
                ZeusTempleCourtyardForm_KeyUp(this, new KeyEventArgs(Keys.W));
            }
            else if (sender == pictureBoxDown)
            {
                ZeusTempleCourtyardForm_KeyUp(this, new KeyEventArgs(Keys.S));
            }
            else if (sender == pictureBoxLeft)
            {
                ZeusTempleCourtyardForm_KeyUp(this, new KeyEventArgs(Keys.A));
            }
            else if (sender == pictureBoxRight)
            {
                ZeusTempleCourtyardForm_KeyUp(this, new KeyEventArgs(Keys.D));
            }
        }

        private void ZeusTempleCourtyardForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (mainForm.CurrentForm == this && selectedDoorLabel.Equals(labelClosedDoor))
            {
                // set the appropriate key flag when a key is pressed
                if (e.KeyData == Keys.A || e.KeyData == Keys.Left)
                {
                    leftKeyPressed = true;
                    currentDirection = 'L';
                    //pictureBoxTrojanHorse.Image = Resources.horse_left;
                }
                else if (e.KeyData == Keys.D || e.KeyData == Keys.Right)
                {
                    rightKeyPressed = true;
                    currentDirection = 'R';
                    //pictureBoxTrojanHorse.Image = Resources.horse_right;
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

        private void ZeusTempleCourtyardForm_KeyUp(object sender, KeyEventArgs e)
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

        private void timerMovement_Tick(object sender, EventArgs e)
        {
            // Store the current position as the potential new position
            int newTrojanHorseX = currentCampingAreaPanel.TrojanHorseX;
            int newTrojanHorseY = currentCampingAreaPanel.TrojanHorseY;

            // Update the potential new position based on the key that was pressed
            if (leftKeyPressed)
            {
                newTrojanHorseX -= trojanHorseSpeed;
            }
            else if (rightKeyPressed)
            {
                newTrojanHorseX += trojanHorseSpeed;
            }
            else if (upKeyPressed)
            {
                newTrojanHorseY -= trojanHorseSpeed;
            }
            else if (downKeyPressed)
            {
                newTrojanHorseY += trojanHorseSpeed;
            }

            // Update the horse's position if it's within bounds
            currentCampingAreaPanel.TrojanHorseLocation = new Point(newTrojanHorseX, newTrojanHorseY);

            // Check if the new position is in new form area
            if (currentCampingAreaPanel.IsInNewFormArea(newTrojanHorseX, newTrojanHorseY))
            {
                Controls.Remove(currentCampingAreaPanel);
                if (currentCampingAreaPanel == zeusTempleCourtyardPanel)
                {
                    currentCampingAreaPanel = gardensOfOlympusPanel;
                }
                else
                {
                    currentCampingAreaPanel = zeusTempleCourtyardPanel;
                }
                Controls.Add(currentCampingAreaPanel);
            }
        }

        #endregion

        #region Door and ladder methods

        private void labelDoor_Click(object sender, EventArgs e)
        {
            ResetLabel(selectedDoorLabel);
            selectedDoorLabel = (Label)sender;
            HighlightLabel(selectedDoorLabel);

            ToggleHalfDoorLabel(selectedDoorLabel);

            // Enable or disable ladder labels
            if (selectedDoorLabel.Equals(labelOpenDoor))
            {
                labelExtendLadder.Enabled = labelRetractLadder.Enabled = true;
                HighlightLabel(labelRetractLadder);
            }
            else
            {
                labelLadder_Click(labelRetractLadder, e); // retract ladder by force if doors not open
                labelExtendLadder.Enabled = labelRetractLadder.Enabled = false;
            }
        }

        private void labelLadder_Click(object sender, EventArgs e)
        {
            ResetLabel(selectedLadderLabel);
            selectedLadderLabel = (Label)sender;
            HighlightLabel(selectedLadderLabel);
        }

        private void HighlightLabel(Label label)
        {
            label.BackColor = Color.Honeydew;
            label.Text = selectedLabelTexts[label];
            label.Enabled = false;
        }

        private void ResetLabel(Label label)
        {
            if (label != null)
            {
                label.BackColor = Color.Transparent;
                label.Text = initialLabelTexts[label];
                label.Enabled = true;
            }
        }

        // Handle half-open or half-closed door label, depending on current door state
        private void ToggleHalfDoorLabel(Label selectedDoorLabel)
        {
            if (selectedDoorLabel.Equals(labelOpenDoor))
            {
                labelHalfOpenDoor.Visible = false;
                labelHalfClosedDoor.Visible = true;
            }
            else if (selectedDoorLabel.Equals(labelClosedDoor))
            {
                labelHalfOpenDoor.Visible = true;
                labelHalfClosedDoor.Visible = false;
            }
        }

        #endregion
    }
}
