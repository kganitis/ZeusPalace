using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ZeusPalace.Modules.Driving
{
  
    public partial class DrivingForm : EmbeddedForm
    {

        private Dictionary<Label, string> initialLabelTexts = new Dictionary<Label, string>();
        private Dictionary<Label, string> changedLabelTexts = new Dictionary<Label, string>();
        GardensOfOlympusForm go = new GardensOfOlympusForm();

        public DrivingForm()
        {
            InitializeComponent();
            initializeLabelTexts();
        }
        //Προσθέτω στο Dictionary το κάθε label με το αντίστοιχο Text
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
        private void DrivingForm_KeyDown(object sender, KeyEventArgs e)
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
        //Method for avoiding Obstacles
        private bool CheckCollisionWithObstacles(int x, int y, string c)
        {
            if ((x >= 251 && x <= 807) && (y >= 140 && y <= 305) || (x >= 630 && x <= 710) && (y >= 50 && y <= 147))
            {
                switch (c) 
                {
                    case "R":
                        drivingHorsePictureBox.Image = Properties.Resources.horse_right;
                        return false;
                    case "L":
                       //  drivingHorsePictureBox.ImageLocation = "C:/Users/PX/source/repos/ZeusPalace/ZeusPalace/Pictures/horse_left2.png";
                         drivingHorsePictureBox.Image = Properties.Resources.horse_left2;
                        return false;
                    case"U":
                        return false;
                    case "D":
                        return false;
                }
            }                       
            return true;
        }


        private void DrivingForm_Load(object sender, EventArgs e)
        {

            drivingHorsePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBoxRight_Click(object sender, EventArgs e)
        {
            MoveHorse("Right");
        }

        private void pictureBoxLeft_Click_1(object sender, EventArgs e)
        {
            MoveHorse("Left");
        }

        private void pictureBoxDown_Click(object sender, EventArgs e)
        {
            MoveHorse("Down");
        }

        private void pictureBoxUp_Click(object sender, EventArgs e)
        {
            MoveHorse("Up");
        }
        //Χειρισμός Σκάλας και Πόρτας με πάτημα των labels
        private void labelOpenDoor_Click(object sender, EventArgs e)
        {
            changeLabelTexts(labelOpenDoor);
            activateLadderLabels();
        }
        private void labelOpenHalfDoor_Click(object sender, EventArgs e)
        {
            changeLabelTexts(labelOpenHalfDoor);
            disableLadderLabels();
        }

        private void labelCloseDoor_Click(object sender, EventArgs e)
        {
            changeLabelTexts(labelCloseDoor);
            disableLadderLabels();
        }

        private void labelExtendLadder_Click(object sender, EventArgs e)
        {
            changeLabelTexts(labelExtendLadder);

        }

        private void labelRetractedLadder_Click(object sender, EventArgs e)
        {
            changeLabelTexts(labelRetractedLadder);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
