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

namespace Hexagon
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
            DrawHexagon((int)(canvas.Width / 2),
                (int)(canvas.Height / 2),
                250,
                random,
                foxDraw,
                6);
        }

        public void DrawHexagon(int xPosition, 
            int yPosition, 
            int edge, 
            Random random,
            FoxDraw foxDraw,
            int level = 1)
        {
            if(level == 0)
            {
                return;
            }
            Helper.DrawHexagon(xPosition,
                yPosition,
                edge,
                Helper.RandomColor(random),
                Helper.RandomColor(random),
                foxDraw);
            DrawHexagon(xPosition - edge / 4,
                (int)(yPosition - edge * 0.433),
                edge / 2,
                random,
                foxDraw,
                level - 1);
            DrawHexagon(xPosition + edge / 2,
                yPosition,
                edge / 2,
                random,
                foxDraw,
                level - 1);
            DrawHexagon(xPosition - edge / 4,
                (int)(yPosition + edge * 0.433),
                edge / 2,
                random,
                foxDraw,
                level - 1);
        }
    }
}
