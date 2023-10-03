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
        private GardensOfOlympusForm gardenForm;
        private bool isMoving = false;

        public DrivingForm()
        {
            InitializeComponent();
            initializeLabelTexts();
        }
        public DrivingForm(Point newLocation)
        {
            InitializeComponent();
            initializeLabelTexts();
            drivingHorsePictureBox.Location = newLocation;
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
        private async void DrivingForm_KeyDown(object sender, KeyEventArgs e)
        {
            string direction = "";

            switch (e.KeyCode)
            {
                case Keys.Right:
                    direction = "Right";
                    break;
                case Keys.Left:
                    direction = "Left";
                    break;
                case Keys.Up:
                    direction = "Up";
                    break;
                case Keys.Down:
                    direction = "Down";
                    break;
            }

            if (!isMoving) // Ξεκινήστε τον χρονοδιακόπτη μόνο αν δεν είναι ήδη σε λειτουργία.
            {
                isMoving = true; // Θέστε την μεταβλητή κίνησης σε true.

                // Δημιουργήστε μια καθυστέρηση 500 ms πριν την κίνηση του άλογου.
                await Task.Delay(100);

                // Εδώ μπορείτε να τοποθετήσετε τον κώδικα για την κίνηση του άλογου.
                MoveHorse(direction);

                isMoving = false; // Ολοκληρώστε την κίνηση και θέστε την μεταβλητή κίνησης σε false.
            }
        }
        //Method for avoiding Obstacles
        private bool CheckCollisionWithObstacles(int x, int y, string c)
        {
            if ((x >= 261 && x <= 770) && (y >= 140 && y <= 260) || (x >= 630 && x <= 730) && (y >= 40 && y <= 147) || (y >= 184 && y <= 220))
            {
                switch (c) 
                {
                    case "R":
                        drivingHorsePictureBox.Image = Properties.Resources.horse_right;
                        if (x >= 840) {
                            gardenForm = new GardensOfOlympusForm();
                            gardenForm.ShowDialog();
                            this.Close();
                            return true;
                        }
                        return false;
                    case "L":
                        //  drivingHorsePictureBox.ImageLocation = "C:/Users/PX/source/repos/ZeusPalace/ZeusPalace/Pictures/horse_left2.png";
                        drivingHorsePictureBox.Image = Properties.Resources.horse_left2;
                        if (x <= 190) 
                        {
                            return true;
                        }
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
           richTextBox1.Visible = false;
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            int mouseX = e.X;
            int mouseY = e.Y;
            string coordinates = $"X: {mouseX}, Y: {mouseY}";
           // richTextBox1.Text = coordinates + "\n";
            richTextBox1.AppendText(coordinates+"\n");
        }

    }
}
