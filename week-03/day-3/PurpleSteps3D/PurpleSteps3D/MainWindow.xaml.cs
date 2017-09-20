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

namespace PurpleSteps3D
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
            int pos = 10;
            for (int size = pos; size < 70; size += 10)
            {
                DrawRectangle(new Point(pos, pos), size , Helper.RandomColor(random), foxDraw);
                pos += size;
            }
        }

        public void DrawRectangle(Point point, int size, Color fillcolor, FoxDraw foxDraw)
        {
            foxDraw.FillColor(fillcolor);
            foxDraw.DrawRectangle(point.X, point.Y, size, size);
        }


    }
}
