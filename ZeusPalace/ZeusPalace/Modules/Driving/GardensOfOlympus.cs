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
    public partial class GardensOfOlympusForm : EmbeddedForm
    {
        DrivingForm drivingForm;
        public GardensOfOlympusForm()
        {
            InitializeComponent();
        }

        private void GardensOfOlympus_Load(object sender, EventArgs e)
        {
            drivingHorsePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            richTextBox1.Visible = false;
        }

        private void GardensOfOlympusForm_KeyDown(object sender, KeyEventArgs e)
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
        private bool CheckCollisionWithObstacles(int x, int y, string c)
        {
            int horseRight = x + drivingHorsePictureBox.Width; // Calculate right side of the horse
            int horseRightHalf = x + drivingHorsePictureBox.Width / 2;
            int horseHeightHalf = y + drivingHorsePictureBox.Height;
            switch (c)
            {
                case "R":
                    if (x > 1035)
                    {
                        return true;
                    }
                    else if (x <= 1035)
                    {
                        drivingHorsePictureBox.Image = Properties.Resources.horse_right;
                        return false;
                    }
                    break;
                case "L":
                    if (x < 11) 
                    {
                        drivingForm = new DrivingForm();
                        this.Hide();
                        drivingForm.Show();
                    }
                    if((x >70 && (y +drivingHorsePictureBox.Height <= 100)) ||
                      (x <70 && y >= 66 && y <= 100 && y+ drivingHorsePictureBox.Height >= 100 && y + drivingHorsePictureBox.Height <= 345) ||
                      (x < 70 && (y >= 100 && y <= 345) && (y + drivingHorsePictureBox.Height >= 345)))
                      {
                        return true;                    
                      }
                    else
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
                    else if (y < 450)
                    {
                        return false;
                    }
                    break;
            }
            return true;
        }

        private void GardensOfOlympusForm_MouseDown(object sender, MouseEventArgs e)
        {
            richTextBox1.AppendText(e.Location.ToString()+"\n");
        }
    }
}
