using System.Windows;
using System.Windows.Controls;

namespace AstrophotoCalculator
{
    public partial class MainWindow : Window
    {
        private void 辨二框_TextChanged(object sender, TextChangedEventArgs e)
        {
            辨一框.Text = 辨二框.Text; // 辨一框处理剩余逻辑
        }

        private void 靶角框_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (double.TryParse(靶角框.Text, out 不定靶角) && 不定靶角 > 0)
            {
                计算靶角();
                计算占据();
            }
        }

        private void 占据框_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (double.TryParse(占据框.Text, out 占据) && 占据 > 0)
                计算占据();
        }

        private void 单位选_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (不定靶角 > 0)
                计算靶角();
        }

        private void 辨二框_LostFocus(object sender, RoutedEventArgs e)
        {
            if (target == 0)
                target = -1;
        }

        private void 靶角框_LostFocus(object sender, RoutedEventArgs e)
        {
            if (target == 1)
                target = -1;
        }

        private void 占据框_LostFocus(object sender, RoutedEventArgs e)
        {
            if (target == 2)
                target = -1;
        }
    }
}
