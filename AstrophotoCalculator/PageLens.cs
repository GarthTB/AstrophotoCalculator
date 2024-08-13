using System.Windows;
using System.Windows.Controls;

namespace AstrophotoCalculator
{
    public partial class MainWindow : Window
    {
        private void 焦距框_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (double.TryParse(焦距框.Text, out 焦距) && 焦距 > 0)
            {
                计算镜头();
                计算视场();
                计算辨率();
            }
        }

        private void 焦比框_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (double.TryParse(焦比框.Text, out 焦比) && 焦比 > 0)
                计算镜头();
        }

        private void 入瞳框_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (double.TryParse(入瞳框.Text, out 入瞳) && 入瞳 > 0)
            {
                计算镜头();
                计算衍射();
                计算效率();
            }
        }

        private void 波下框_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (double.TryParse(波下框.Text, out 波下) && 波下 > 0)
                计算衍射();
        }

        private void 波上框_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (double.TryParse(波上框.Text, out 波上) && 波上 > 0)
                计算衍射();
        }

        private void 焦距框_LostFocus(object sender, RoutedEventArgs e)
        {
            if (target == 0)
                target = -1;
        }

        private void 焦比框_LostFocus(object sender, RoutedEventArgs e)
        {
            if (target == 1)
                target = -1;
        }

        private void 入瞳框_LostFocus(object sender, RoutedEventArgs e)
        {
            if (target == 2)
                target = -1;
        }
    }
}
