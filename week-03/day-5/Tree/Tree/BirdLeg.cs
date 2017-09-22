using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;

namespace Tree
{
    public class BirdLeg
    {
        FoxDraw foxDraw;
        Random random;
        bool isRandom = false;
        bool isRandomColored = false;
        int numberOfToes = 3;

        public BirdLeg(FoxDraw foxDraw,
            Random random,
            Canvas canvas,
            bool isRandom = false, 
            bool isRandomColored = false, 
            int numberOfToes = 3)
        {
            this.foxDraw = foxDraw;
            this.random = random;
            this.isRandom = isRandom;
            this.numberOfToes = numberOfToes;
            this.isRandomColored = isRandomColored;
            foxDraw.FillColor(Colors.FloralWhite);
            foxDraw.StrokeColor(Colors.FloralWhite);
            foxDraw.DrawRectangle(0, 0, canvas.Width, canvas.Height);
        }
        /// <summary>
        /// Draw one line and recursively calls itself three times.
        /// </summary>
        /// <param name="startPoint"></param>
        /// <param name="direction"></param>
        /// <param name="length"></param>
        /// <param name="depth"></param>
        internal void Draw(Point startPoint, 
            double direction,
            double length, 
            int depth)
        {
            if (depth < 1)
            {
                return;
            }
            foxDraw.FillColor(isRandomColored ? Helper.RandomColor(random) : Colors.Firebrick);
            foxDraw.StrokeColor(isRandomColored ? Helper.RandomColor(random) : Colors.Firebrick);
            Point endPoint = Helper.CalculatePointOffset(startPoint, length, direction);
            //sole
            foxDraw.DrawLine(startPoint, endPoint);
            // toes
            double newLength = length * 2.0 / (isRandom ? random.NextDouble()/2.0 + 2.75 : 3.0);
            double baseDirection = direction + (isRandom ?  random.Next(40) - 20:0);
            Draw(endPoint, baseDirection - 20, newLength, depth - 1);
            Draw(endPoint, baseDirection, newLength, depth - 1);
            Draw(endPoint, baseDirection + 20, newLength, depth - 1);
        }
    }
}
