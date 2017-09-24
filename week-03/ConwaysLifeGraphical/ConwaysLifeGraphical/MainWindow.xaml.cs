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
using ConwaysLife;

namespace ConwaysLifeGraphical
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
            ConsoleKeyInfo key;

            Universe universe = new Universe();
            UniverseDrawer universeDrawer = new UniverseDrawer(foxDraw, canvas);
            universeDrawer.Display(universe);

            //while (true)
            //{
            //    //universe.Update();
            //    //universeDrawer.Display(universe);
            //}

        }
    }
}
