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


namespace ColoredBox
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
            // draw a box that has different colored lines on each edge.

            var LeftUp = new Point(100, 100);
            var RightUp = new Point(200, 100);
            var RightBottom = new Point(200, 200);
            var LeftBottom = new Point(100, 200);

            foxDraw.StrokeColor(Colors.Black);
            foxDraw.DrawLine(LeftUp, RightUp);

            foxDraw.StrokeColor(Colors.Blue);
            foxDraw.DrawLine(RightUp, RightBottom);

            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(RightBottom, LeftBottom);

            foxDraw.StrokeColor(Colors.Magenta);
            foxDraw.DrawLine(LeftBottom, LeftUp);
        }
    }
}
