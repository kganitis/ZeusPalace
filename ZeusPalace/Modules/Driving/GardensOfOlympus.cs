﻿using System;
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
    public partial class GardensOfOlympusForm : EmbeddedForm
    {
         private Dictionary<Label, string> initialLabelTexts = new Dictionary<Label, string>();
        private Dictionary<Label, string> changedLabelTexts = new Dictionary<Label, string>();
        
        public GardensOfOlympusForm()
        {
            InitializeComponent();
            initializeLabelTexts();
            this.KeyPreview = true;

        }

        private void GardensOfOlympusForm_Load(object sender, EventArgs e) {
            richTextBox1.Visible = false;
        }

        private void initializeLabelTexts()
        {
            initialLabelTexts.Add(labelOpenDoor, labelOpenDoor.Text);
            initialLabelTexts.Add(labelOpenHalfDoor, labelOpenHalfDoor.Text);
            initialLabelTexts.Add(labelCloseDoor, labelCloseDoor.Text);
            initialLabelTexts.Add(labelExtendLadder, labelExtendLadder.Text);
            initialLabelTexts.Add(labelRetractedLadder, labelRetractedLadder.Text);
        }
        //Αλλάζω χρώμα και κείμενο στο label που έχει επιλεγεί
        private void changeLabelTexts(Label label)
        {
            ResetAllLabels();
            if (label == labelOpenDoor)
            {
                label.BackColor = Color.Yellow;
                label.ForeColor = Color.Black;
                label.Text = "Πόρτα Ανοιχτή";
            }

            else if (label == labelOpenHalfDoor)
            {
                label.BackColor = Color.Yellow;
                label.ForeColor = Color.Black;
                label.Text = "Πόρτα Μισάνοιχτη";
            }

            else if (label == labelCloseDoor)
            {
                label.BackColor = Color.Yellow;
                label.ForeColor = Color.Black;
                label.Text = "Πόρτα κλειστή";
            }

            else if (label == labelExtendLadder)
            {
                label.BackColor = Color.Yellow;
                label.ForeColor = Color.Black;
                label.Text = "Σκάλα Ανοιχτή";
            }

            else if (label == labelRetractedLadder)
            {
                label.BackColor = Color.Yellow;
                label.ForeColor = Color.Black;
                label.Text = "Σκάλα Κλειστή";
            }
        }
        //Φέρνει τα labels χειρισμού του Αλόγου στην αρχική τους μορφή
        private void ResetAllLabels()
        {
            foreach (var label in initialLabelTexts.Keys)
            {
                label.BackColor = Color.Black;
                label.ForeColor = Color.White;
                label.Text = initialLabelTexts[label];
            }
        }
        private void activateLadderLabels()
        {
            labelExtendLadder.Enabled = true;
            labelRetractedLadder.Enabled = true;
        }
        private void disableLadderLabels()
        {
            labelExtendLadder.Enabled = false;
            labelRetractedLadder.Enabled = false;
        }

        private void GardensOfOlympusForm_KeyDown_1(object sender, KeyEventArgs e)
        {
            int newX = drivingHorsePictureBox.Location.X;
            int newY = drivingHorsePictureBox.Location.Y;
            string choice = "";

            switch (e.KeyCode)
            {
                case Keys.Right:
                    newX += 20;
                    choice = "R";
                    break;
                case Keys.Left:
                    newX -= 20;
                    choice = "L";
                    break;
                case Keys.Up:
                    newY -= 20;
                    choice = "U";
                    break;
                case Keys.Down:
                    newY += 20;
                    choice = "D";
                    break;

            }
            bool collisionDetected = CheckCollisionWithObstacles(newX, newY, choice);

            if (!collisionDetected)
            {
                drivingHorsePictureBox.Location = new Point(newX, newY);
            }
        }

        //Method for driving with Mouse
        private void MoveHorse(string direction)
        {
            int newX = drivingHorsePictureBox.Location.X;
            int newY = drivingHorsePictureBox.Location.Y;
            string choice = "";

            switch (direction)
            {
                case ("Right"):
                    newX += 30;
                    choice = "R";
                    break;
                case ("Left"):
                    newX -= 30;
                    choice = "L";
                    break;
                case ("Down"):
                    newY += 30;
                    choice = "D";
                    break;
                case ("Up"):
                    newY -= 30;
                    choice = "U";
                    break;
            }
            bool collisionDetected = CheckCollisionWithObstacles(newX, newY, choice);

            if (!collisionDetected)
            {
                drivingHorsePictureBox.Location = new Point(newX, newY);
            }
        }
        //Method for driving with keyboard

        //Method for avoiding Obstacles
        private bool CheckCollisionWithObstacles(int x, int y, string c)
        {
            if ((x >= 104 && x <= 900) && (y >= 130 && y <= 275) || (x <= 106 && y >=174 && y <= 230))
            {
                switch (c)
                {
                    case "R":
                        drivingHorsePictureBox.Image = Properties.Resources.horse_right;
                        return false;
                    case "L":
                        //  drivingHorsePictureBox.ImageLocation = "C:/Users/PX/source/repos/ZeusPalace/ZeusPalace/Pictures/horse_left2.png";
                        drivingHorsePictureBox.Image = Properties.Resources.horse_left2;
                        if (x <= 50)
                        {
                            DrivingForm drivingForm = new DrivingForm();
                            drivingForm.ShowDialog();
                            this.Close();
                            return true;
                        }
                        return false;
                    case "U":
                        return false;
                    case "D":
                        return false;
                }
                
            }
            return true;
        }

        private void pictureBoxUp_Click_1(object sender, EventArgs e)
        {
            MoveHorse("Up");
        }

        private void pictureBoxDown_Click(object sender, EventArgs e)
        {
            MoveHorse("Down");
        }

        private void pictureBoxLeft_Click(object sender, EventArgs e)
        {
            MoveHorse("Left");
        }

        private void pictureBoxRight_Click(object sender, EventArgs e)
        {
            MoveHorse("Right");
        }

        //Χειρισμός Σκάλας και Πόρτας με πάτημα των labels
        private void labelOpenDoor_Click_1(object sender, EventArgs e)
        {
            changeLabelTexts(labelOpenDoor);
            activateLadderLabels();
        }

        private void labelOpenHalfDoor_Click_1(object sender, EventArgs e)
        {
            changeLabelTexts(labelOpenHalfDoor);
            disableLadderLabels();
        }

        private void labelCloseDoor_Click_1(object sender, EventArgs e)
        {
            changeLabelTexts(labelCloseDoor);
            disableLadderLabels();
        }

        private void labelExtendLadder_Click_1(object sender, EventArgs e)
        {
            changeLabelTexts(labelExtendLadder);
        }

        private void labelRetractedLadder_Click_1(object sender, EventArgs e)
        {
            changeLabelTexts(labelRetractedLadder);
        }
   
        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {

            int mouseX = e.X;
            int mouseY = e.Y;
            string coordinates = $"X: {mouseX}, Y: {mouseY}";
            // richTextBox1.Text = coordinates + "\n";
            richTextBox1.AppendText(coordinates + "\n");
        }

      
    }
}
