using System;
using System.Windows;
using System.Windows.Media;

namespace GreenFox
{
    public static class Helper
    {
        public static Color RandomColor(Random random)
        {
            return Color.FromArgb((byte)random.Next(),
                (byte)random.Next(),
                (byte)random.Next(),
                (byte)random.Next());
        }
    }
}