using System;
using System.Windows.Controls;
using System.Windows.Media;
using Xceed.Wpf.AvalonDock.Controls;
using Xceed.Wpf.Toolkit;

namespace Elections.Server.Handler.Others
{
    public class Validations
    {
        public static int ValidateFields(Object content)
        {
            var count = 0;
            var grid = (Grid)content;
            for (var index = 0; index < 6; index++)
            {
                var border = (Border) grid.Children[index];
                var textBox = (TextBox) border.Child;

                if (string.IsNullOrEmpty(textBox.Text) || string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.BorderBrush = new SolidColorBrush(color: Colors.Red);
                    count++;
                }
                else
                {
                    textBox.BorderBrush =  new SolidColorBrush(color:Colors.SteelBlue);
                }
            }
            return count;
        }
    }
}