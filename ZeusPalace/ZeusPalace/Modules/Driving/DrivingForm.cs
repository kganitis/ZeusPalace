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

namespace ZeusPalace.Modules.Driving
{
    public partial class DrivingForm : EmbeddedForm
    {
        GardensOfOlympusForm go = new GardensOfOlympusForm();
        public DrivingForm()
        {
            InitializeComponent();
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
            int horseRight = x + drivingHorsePictureBox.Width; // Calculate right side of the horse
            int horseRightHalf = x + drivingHorsePictureBox.Width / 2;
            int horseHeightHalf = y + drivingHorsePictureBox.Height;
            switch (c)
            {
                case "R":
                    if (x > 1050 && y >= 310)
                    {
                        return true;
                    }
                    else if ((x < 1050) || (x >= 114 && x <= 1169 &&
                        y >= 217 && y <= 388))
                    {
                        drivingHorsePictureBox.Image = Properties.Resources.horse_right;
                        return false;
                    }
                    else if (horseRight >= 1160)
                    {
                        this.Hide();
                        go.ShowDialog();

                    }
                    break;
                case "L":
                    if (x > 70)
                    {
                        drivingHorsePictureBox.Image = null;
                        drivingHorsePictureBox.ImageLocation = "C:/Users/PX/source/repos/ZeusPalace/ZeusPalace/ZeusPalace/pictures/horse_left2.png";
                        return false;
                    }
                    break;
                case "U":
                    if ((x >= pictureBox2.Location.X && x <= pictureBox2.Location.X + pictureBox2.Width) &&
                        (y >= pictureBox2.Location.Y && y <= pictureBox2.Location.Y + pictureBox2.Height) ||
                        (horseRight > pictureBox2.Location.X && horseRight < pictureBox2.Location.X + pictureBox2.Width) &&
                         (y >= pictureBox2.Location.Y && y <= pictureBox2.Location.Y + pictureBox2.Height) ||
                         (horseRightHalf > pictureBox2.Location.X && horseRightHalf < pictureBox2.Location.X + pictureBox2.Width) &&
                         (y >= pictureBox2.Location.Y && y <= pictureBox2.Location.Y + pictureBox2.Height))
                    {
                        return true; // Overlapping with pictureBox2, don't allow movement
                    }
                    else if (y > 37)
                    {
                        return false; // Not overlapping, allow movement upwards
                    }
                    break;
                case "D":
                    if ((x >= pictureBox5.Location.X && x <= pictureBox5.Location.X + pictureBox5.Width) &&
                        (horseHeightHalf >= pictureBox5.Location.Y && horseHeightHalf <= pictureBox5.Location.Y + pictureBox5.Height) ||
                        (horseRight > pictureBox5.Location.X && horseRight < pictureBox5.Location.X + pictureBox5.Width) &&
                         (horseHeightHalf >= pictureBox5.Location.Y && horseHeightHalf <= pictureBox5.Location.Y + pictureBox5.Height) ||
                         (horseRightHalf > pictureBox5.Location.X && horseRightHalf < pictureBox5.Location.X + pictureBox5.Width) &&
                         (horseHeightHalf >= pictureBox5.Location.Y && horseHeightHalf <= pictureBox5.Location.Y + pictureBox5.Height))
                    {
                        return true;
                    }
                    else if (y < 470)
                    {
                        return false;
                    }
                    break;
            }
            return true;
        }



        private void DrivingForm_MouseMove(object sender, MouseEventArgs e)
        {
            richTextBox1.Text = e.Location.ToString();
        }

        private void DrivingForm_Load(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
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
    }
}
