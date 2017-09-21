using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GreenFox;

namespace SquareFractal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            Random random = new Random();
            DrawBackGround(50, 50, 500, foxDraw);
            DrawHashmark(50, 50, 500, foxDraw, random, 5);
            
        }

        private void DrawBackGround(int xPosition, int yPosition, int edge, FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Aquamarine);
            foxDraw.FillColor(Colors.Aquamarine);
            foxDraw.DrawRectangle(xPosition,
                yPosition,
                edge,
                edge);
        }

        private void DrawHashmark(int xPosition, int yPosition, int edge, FoxDraw foxDraw, Random random, int depth)
        {
            if(depth == 0)
            {
                return;
            }
            foxDraw.StrokeColor(Colors.Blue);
            // left
            foxDraw.DrawLine(xPosition + edge / 3,
                yPosition, 
                xPosition + edge / 3, 
                yPosition + edge);
            // right
            foxDraw.DrawLine(xPosition + 2* edge / 3, yPosition, xPosition + 2*edge / 3, yPosition + edge);
            // upper
            foxDraw.DrawLine(xPosition, yPosition + edge / 3, xPosition + edge, yPosition + edge / 3);
            // lower
            foxDraw.DrawLine(xPosition, yPosition + 2 * edge / 3, xPosition + edge, yPosition + 2 * edge / 3);

            // left hashmark
            DrawHashmark(xPosition, yPosition+ edge/3, edge / 3, foxDraw, random, depth - 1);
            // right hashmark
            DrawHashmark(xPosition + 2 * edge / 3, yPosition + edge / 3, edge / 3, foxDraw, random, depth - 1);
            // upper hashmark
            DrawHashmark(xPosition + edge / 3, yPosition, edge / 3, foxDraw, random, depth - 1);
            // lower hashmark
            DrawHashmark(xPosition + edge / 3, yPosition + 2 * edge / 3, edge / 3, foxDraw, random, depth - 1);


        }
    }
}
