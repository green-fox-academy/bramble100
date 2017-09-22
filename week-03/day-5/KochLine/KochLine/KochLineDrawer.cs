using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;

namespace KochLine
{
    class KochLineDrawer
    {
        FoxDraw foxDraw;
        Canvas canvas;

        public KochLineDrawer(FoxDraw foxDraw, Canvas canvas)
        {
            this.foxDraw = foxDraw;
            this.canvas = canvas;

            foxDraw.FillColor(Colors.FloralWhite);
            foxDraw.StrokeColor(Colors.FloralWhite);
            foxDraw.DrawRectangle(0, 0, canvas.Width, canvas.Height);
        }

        public void Draw(Point startPoint, 
            double direction,
            double length,
            int depth)
        {
            foxDraw.FillColor(Colors.Firebrick);
            foxDraw.StrokeColor(Colors.Firebrick);
            Point endPoint = Helper.CalculatePointOffset(startPoint, length, direction);
            if(depth <= 0)
            {
                foxDraw.DrawLine(startPoint, endPoint);
                return;
            }
            Point breakPoint1 = Helper.CalculatePointOffset(startPoint, length / 3.0, direction);
            Point breakPoint2 = Helper.CalculatePointOffset(breakPoint1, length / 3.0, direction - 60);
            Point breakPoint3 = Helper.CalculatePointOffset(breakPoint2, length / 3.0, direction + 60);
            Draw(startPoint, direction, length / 3.0, depth - 1);
            Draw(breakPoint1, direction - 60, length / 3.0, depth - 1);
            Draw(breakPoint2, direction + 60, length / 3.0, depth - 1);
            Draw(breakPoint3, direction, length / 3.0, depth - 1);
        }
    }
}
