using System;
using System.Drawing;
using System.Windows.Forms;

public class VerticalProgressBar : ProgressBar
{
    // Public property to set/get the progress bar color
    public Color ProgressBarColor { get; set; } = Color.FromArgb(0, 102, 204); // Default color

    public VerticalProgressBar()
    {
        this.SetStyle(ControlStyles.UserPaint, true);
        this.SetStyle(ControlStyles.DoubleBuffer, true);
        this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        this.SetStyle(ControlStyles.ResizeRedraw, true);
        this.Size = new Size(20, 150); // Adjust the size as needed
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
        ProgressBarRenderer.DrawVerticalBar(e.Graphics, rect);

        rect.Height = (int)(rect.Height * ((double)Value / Maximum)) - 4;
        rect.Y = this.Height - rect.Height;

        // Fill the progress bar with the specified color
        using (SolidBrush brush = new SolidBrush(ProgressBarColor))
        {
            e.Graphics.FillRectangle(brush, 2, rect.Y, this.Width - 4, rect.Height);
        }
    }
}
