using System;
using System.Windows;
using System.Windows.Media;
using GreenFox;
using System.Collections.Generic;

namespace GreenFox
{
    public static class Helper
    {
        public static Color RandomColor(Random random)
        {
            return Color.FromArgb((byte)random.Next(),
                (byte)random.Next(),
                (byte)random.Next(),
                (byte)random.Next());
        }

        public static void DrawHexagon(int xPosition, 
            int yPosition, 
            int edge, 
            Color lineColor,
            Color shapeColor,
            FoxDraw foxDraw)
        {
            foxDraw.FillColor(shapeColor);
            foxDraw.StrokeColor(lineColor);
            foxDraw.DrawPolygon(new List<Point>
            {
                new Point(xPosition - edge / 2, yPosition - edge * 0.866), // 0
                new Point(xPosition + edge / 2, yPosition - edge * 0.866), // 1
                new Point(xPosition + edge, yPosition), // 2
                new Point(xPosition + edge / 2, yPosition + edge * 0.866), // 3
                new Point(xPosition - edge / 2, yPosition + edge * 0.866), // 4
                new Point(xPosition - edge, yPosition), // 5
                new Point(xPosition - edge / 2, yPosition - edge * 0.866) // 0
            });
        }
    }
}