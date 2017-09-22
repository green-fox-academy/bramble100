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
            this.isRandomColored = false;
            foxDraw.FillColor(Colors.Aqua);
            foxDraw.StrokeColor(Colors.Aqua);
            foxDraw.DrawRectangle(0, 0, canvas.Width, canvas.Height);
        }

        internal void Draw(Point startPoint, 
            int length = 100, 
            int depth = 1)
        {
            foxDraw.FillColor(Colors.Red);

        }
    }
}
