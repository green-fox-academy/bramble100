using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;
using System.Windows.Controls;
using System.Windows.Media;
using ConwaysLife;

namespace ConwaysLifeGraphical
{
    public class UniverseDrawer
    {
        FoxDraw foxDraw;
        Canvas canvas;
        Color backGroundColor;
        Color foreGroundColor;

        public UniverseDrawer(FoxDraw foxDraw, Canvas canvas)
        {
            this.foxDraw = foxDraw;
            this.canvas = canvas;
            Color backGroundColor = Colors.Red;
            Color foreGroundColor = Colors.Azure;
        }

        public void Display(Universe universe)
        {
            int sizeX = (int)canvas.Width/universe.universe.GetLength(0);
            int sizeY = (int)canvas.Height / universe.universe.GetLength(1);
            int dotSize = sizeX > sizeY ? sizeY : sizeX; // get minimum

            foxDraw.FillColor(Colors.Coral);
            foxDraw.StrokeColor(Colors.Coral);
            foxDraw.DrawRectangle(0, 0, canvas.Width, canvas.Height);

            foxDraw.FillColor(Colors.CadetBlue);
            foxDraw.StrokeColor(Colors.CadetBlue);
            for (int height = 0; height < universe.universe.GetLength(0); height++)
            {
                for (int width = 0; width < universe.universe.GetLength(1); width++)
                {
                    if (universe.universe[height, width])
                    {
                        foxDraw.DrawEllipse(width * dotSize, height * dotSize, dotSize, dotSize);
                    }
                }
            }

        }
    }
}
