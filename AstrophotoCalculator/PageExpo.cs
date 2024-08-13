using System.Windows;
using System.Windows.Controls;

namespace AstrophotoCalculator
{
    public partial class MainWindow : Window
    {
        private void 辨一框_TextChanged(object sender, TextChangedEventArgs e)
        {
            辨二框.Text = 辨一框.Text;

            if (double.TryParse(辨一框.Text, out 辨率) && 辨率 > 0)
            {
                计算曝光();
                计算效率();
            }
        }

        private void 赤纬框_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (double.TryParse(赤纬框.Text, out 赤纬) && 赤纬 >= -90 && 赤纬 <= 90)
                计算曝光();
            else 赤纬 = -180;
        }

        private void 半宽框_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (double.TryParse(半宽框.Text, out 半宽) && 半宽 > 0)
                计算曝光();
        }

        private void 快门框_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (double.TryParse(快门框.Text, out 快门) && 快门 > 0)
            {
                计算曝光();
                计算效率();
            }
        }

        private void 半宽框_LostFocus(object sender, RoutedEventArgs e)
        {
            if (target == 0)
                target = -1;
        }

        private void 快门框_LostFocus(object sender, RoutedEventArgs e)
        {
            if (target == 1)
                target = -1;
        }
    }
}
