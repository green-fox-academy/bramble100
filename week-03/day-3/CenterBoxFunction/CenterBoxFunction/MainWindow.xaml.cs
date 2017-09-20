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


namespace CenterBoxFunction
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
            // create a square drawing function that takes 1 parameter:
            // the square size
            // and draws a square of that size to the center of the canvas.
            // draw 3 squares with that function.
            Random rnd = new Random();
            for (int size = 150; size > 50; size -= 10) 
            {
                CenterBox(size, foxDraw, rnd);
            }
        }

        public void CenterBox(int size, FoxDraw foxDraw, Random rnd)
        {
            foxDraw.FillColor(Color.FromArgb(RandomByte(rnd), RandomByte(rnd), RandomByte(rnd), RandomByte(rnd)));
            foxDraw.DrawRectangle((canvas.Width - size) / 2, (canvas.Height - size) / 2, size, size);
        }

        public byte RandomByte(Random rnd)
        {
            return (byte)rnd.Next(256);
        }

    }
}
