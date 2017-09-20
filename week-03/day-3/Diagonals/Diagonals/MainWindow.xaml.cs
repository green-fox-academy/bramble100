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

namespace Diagonals
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
            // draw the canvas' diagonals in green.

            var startPoint = new Point(0, 0);
            var endPoint = new Point(300, 300);
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(startPoint, endPoint);

            startPoint = new Point(300, 0);
            endPoint = new Point(0, 300);
            foxDraw.DrawLine(startPoint, endPoint);
        }
    }
}
