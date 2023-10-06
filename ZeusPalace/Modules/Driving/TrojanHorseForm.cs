using System;
using System.Collections.Concurrent;
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
        private bool upKeyPressed, downKeyPressed = false;
        private readonly Movement currentMovement = new Movement();

        class Movement
        {
            private readonly string[] directions = new string[] { "up", "right", "down", "left" };
            private int directionIndex = 1; // right
            private string Direction => directions[directionIndex];
            public int FacingDirection => Direction == "down" || Direction == "right" ? 1 : -1;

            public char Axis => Direction == "up" || Direction == "down" ? 'Y' : 'X';

            private int flipHorizontalIndex = 0;
            public bool FlipHorizontal {
                get
                {
                    if (Math.Abs(flipHorizontalIndex) == 2)
                    {
                        flipHorizontalIndex = 0;
                        return true;
                    }
                    return false;
                }
            }

            public void Rotate(string rotation)
            {
                if (rotation == "right")
                {
                    directionIndex = (directionIndex + 1) % directions.Length;
                    flipHorizontalIndex++;

                }
                else if (rotation == "left")
                {
                    directionIndex = (directionIndex - 1 + directions.Length) % directions.Length;
                    flipHorizontalIndex--;
                }
                Debug.WriteLine(Direction);
            }
        }

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
            mainForm.KeyUp += TrojanHorseForm_KeyUp;
            mainForm.KeyDown += TrojanHorseForm_KeyDown;

            currentCampingAreaPanel = zeusTempleCourtyardPanel;
        }

        private void TrojanHorseForm_Load(object sender, EventArgs e)
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
                TrojanHorseForm_KeyDown(this, new KeyEventArgs(Keys.W));
            }
            else if (sender == pictureBoxDown)
            {
                TrojanHorseForm_KeyDown(this, new KeyEventArgs(Keys.S));
            }
            else if (sender == pictureBoxLeft)
            {
                TrojanHorseForm_KeyDown(this, new KeyEventArgs(Keys.A));
            }
            else if (sender == pictureBoxRight)
            {
                TrojanHorseForm_KeyDown(this, new KeyEventArgs(Keys.D));
            }
        }

        private void pictureBoxDirection_MouseUp(object sender, MouseEventArgs e)
        {
            if (sender == pictureBoxUp)
            {
                TrojanHorseForm_KeyUp(this, new KeyEventArgs(Keys.W));
            }
            else if (sender == pictureBoxDown)
            {
                TrojanHorseForm_KeyUp(this, new KeyEventArgs(Keys.S));
            }
            else if (sender == pictureBoxLeft)
            {
                TrojanHorseForm_KeyUp(this, new KeyEventArgs(Keys.A));
            }
            else if (sender == pictureBoxRight)
            {
                TrojanHorseForm_KeyUp(this, new KeyEventArgs(Keys.D));
            }
        }

        private void TrojanHorseForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (mainForm.CurrentForm == this && selectedDoorLabel.Equals(labelClosedDoor))
            {
                // set the appropriate key flag when a key is pressed
                if (e.KeyData == Keys.W || e.KeyData == Keys.Up)
                {
                    upKeyPressed = true;
                    StartTimer();
                }
                else if (e.KeyData == Keys.S || e.KeyData == Keys.Down)
                {
                    downKeyPressed = true;
                    StartTimer();
                }

                // start the timer if it's not already running
                void StartTimer()
                {
                    if (!timerMovement.Enabled)
                    {
                        timerMovement.Start();
                    }
                }
            }
        }

        private void TrojanHorseForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (mainForm.CurrentForm == this && selectedDoorLabel.Equals(labelClosedDoor))
            {
                // left and right keys just rotate the trojan horse
                if (e.KeyData == Keys.A || e.KeyData == Keys.Left)
                {
                    RotateTrojanHorse("left");
                    return;
                }
                else if (e.KeyData == Keys.D || e.KeyData == Keys.Right)
                {
                    RotateTrojanHorse("right");
                    return;
                }

                // unset the appropriate key flag when a key is released
                if (e.KeyData == Keys.W || e.KeyData == Keys.Up)
                {
                    upKeyPressed = false;
                }
                else if (e.KeyData == Keys.S || e.KeyData == Keys.Down)
                {
                    downKeyPressed = false;
                }

                // stop the timer if all keys are released
                if (!upKeyPressed && !downKeyPressed)
                {
                    timerMovement.Stop();
                }
            }
        }

        private void RotateTrojanHorse(string rotation)
        {
            currentMovement.Rotate(rotation);
            currentCampingAreaPanel.RotateTrojanHorse(rotation, currentMovement.FlipHorizontal);
        }

        private void timerMovement_Tick(object sender, EventArgs e)
        {
            // Store the current position as the potential new position
            int newTrojanHorseX = currentCampingAreaPanel.TrojanHorseX;
            int newTrojanHorseY = currentCampingAreaPanel.TrojanHorseY;

            // Move in opposite (negative speed) if forwards is false
            int currentSpeed = trojanHorseSpeed;
            if (downKeyPressed) currentSpeed *= -1;

            // Update the potential new position based on movement axis
            int distance = currentMovement.FacingDirection * currentSpeed;
            if (currentMovement.Axis == 'X')
            {
                newTrojanHorseX += distance;
            }
            else if (currentMovement.Axis == 'Y')
            {
                newTrojanHorseY += distance;
            }

            // Update the horse's position if it's within bounds
            currentCampingAreaPanel.TrojanHorseLocation = new Point(newTrojanHorseX, newTrojanHorseY);

            // Check if the new position is in new form area
            if (currentCampingAreaPanel.IsInNewFormArea(newTrojanHorseX, newTrojanHorseY))
            {
                // Swap the area panels
                Controls.Remove(currentCampingAreaPanel);
                if (currentCampingAreaPanel == zeusTempleCourtyardPanel)
                {
                    gardensOfOlympusPanel.TrojanHorseImage = currentCampingAreaPanel.TrojanHorseImage;
                    currentCampingAreaPanel = gardensOfOlympusPanel;
                }
                else
                {
                    zeusTempleCourtyardPanel.TrojanHorseImage = currentCampingAreaPanel.TrojanHorseImage;
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
