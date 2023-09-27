using System;
using System.Drawing;
using System.Windows.Forms;

public class VerticalTemperatureProgressBar : ProgressBar
{
    public VerticalTemperatureProgressBar()
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

        // Calculate the percentage of progress within the temperature range
        int progressRange = Maximum - Minimum;
        int currentTemperature = Minimum + (int)((float)Value / Maximum * progressRange);

        // Map temperature range to a color gradient
        Color color = GetColorForTemperature(currentTemperature);

        rect.Height = (int)(rect.Height * ((double)(currentTemperature - Minimum) / progressRange)) - 4;
        rect.Y = this.Height - rect.Height;

        using (SolidBrush brush = new SolidBrush(color))
        {
            e.Graphics.FillRectangle(brush, 2, rect.Y, this.Width - 4, rect.Height);
        }
    }

    private Color GetColorForTemperature(int temperature)
    {
        // Define the temperature color gradient
        Color[] gradientColors = {
            Color.Blue, Color.Green, Color.Yellow, Color.Orange, Color.Red
        };

        // Calculate the step size between colors
        int gradientSteps = gradientColors.Length - 1;
        float stepSize = (float)Maximum / gradientSteps;

        // Determine the color based on the temperature
        int colorIndex = (int)(temperature / stepSize);
        if (colorIndex < 0) colorIndex = 0;
        if (colorIndex >= gradientSteps) colorIndex = gradientSteps - 1;

        // Interpolate between two gradient colors
        float progress = (float)(temperature - colorIndex * stepSize) / stepSize;
        Color startColor = gradientColors[colorIndex];
        Color endColor = gradientColors[colorIndex + 1];
        return InterpolateColors(startColor, endColor, progress);
    }

    private Color InterpolateColors(Color startColor, Color endColor, float progress)
    {
        int r = (int)(startColor.R + (endColor.R - startColor.R) * progress);
        int g = (int)(startColor.G + (endColor.G - startColor.G) * progress);
        int b = (int)(startColor.B + (endColor.B - startColor.B) * progress);
        return Color.FromArgb(r, g, b);
    }
}
