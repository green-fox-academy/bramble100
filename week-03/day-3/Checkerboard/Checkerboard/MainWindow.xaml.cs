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

namespace Checkerboard
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

            int fieldSize = 30;
            int numberOfFieldsInEdge = 8;
            for (int i = 0; i < numberOfFieldsInEdge; i++)
            {
                for (int j = 0; j < numberOfFieldsInEdge; j++)
                {
                    foxDraw.FillColor((i + j) % 2 == 0 ? Colors.Red : Colors.Pink);
                    foxDraw.DrawRectangle(fieldSize * j, fieldSize * i, fieldSize, fieldSize);
                }
            }
        }
    }
}
