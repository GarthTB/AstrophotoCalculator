using System.Windows;
using System.Windows.Controls;

namespace AstrophotoCalculator
{
    public partial class MainWindow : Window
    {
        private void 底片选_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (底片选.SelectedIndex)
            {
                case 0: // IMX071
                    底宽 = 23.66;
                    底高 = 15.71;
                    宽数 = 4944;
                    高数 = 3284;
                    单尺 = 4.78;
                    底宽框.Text = "23.66";
                    底高框.Text = "15.71";
                    宽数框.Text = "4944";
                    高数框.Text = "3284";
                    单尺框.Text = "4.78";
                    break;
                case 1: // IMX410
                    底宽 = 36.02;
                    底高 = 24.00;
                    宽数 = 6064;
                    高数 = 4040;
                    单尺 = 5.94;
                    底宽框.Text = "36.02";
                    底高框.Text = "24.00";
                    宽数框.Text = "6064";
                    高数框.Text = "4040";
                    单尺框.Text = "5.94";
                    break;
                case 2: // IMX455
                    底宽 = 35.98;
                    底高 = 23.99;
                    宽数 = 9568;
                    高数 = 6380;
                    单尺 = 3.76;
                    底宽框.Text = "35.98";
                    底高框.Text = "23.99";
                    宽数框.Text = "9568";
                    高数框.Text = "6380";
                    单尺框.Text = "3.76";
                    break;
                case 3: // IMX461
                    底宽 = 44.22;
                    底高 = 33.45;
                    宽数 = 11760;
                    高数 = 8896;
                    单尺 = 3.76;
                    底宽框.Text = "44.22";
                    底高框.Text = "33.45";
                    宽数框.Text = "11760";
                    高数框.Text = "8896";
                    单尺框.Text = "3.76";
                    break;
                case 4: // IMX533"
                    底宽 = 11.31;
                    底高 = 11.31;
                    宽数 = 3008;
                    高数 = 3008;
                    单尺 = 3.76;
                    底宽框.Text = "11.31";
                    底高框.Text = "11.31";
                    宽数框.Text = "3008";
                    高数框.Text = "3008";
                    单尺框.Text = "3.76";
                    break;
                case 5: // IMX571
                    底宽 = 23.48;
                    底高 = 15.67;
                    宽数 = 6244;
                    高数 = 4168;
                    单尺 = 3.76;
                    底宽框.Text = "23.48";
                    底高框.Text = "15.67";
                    宽数框.Text = "6244";
                    高数框.Text = "4168";
                    单尺框.Text = "3.76";
                    break;
            }
        }

        private void 底宽框_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (double.TryParse(底宽框.Text, out 底宽) && 底宽 > 0)
            {
                计算像素();
                计算视场();
            }
        }

        private void 底高框_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (double.TryParse(底高框.Text, out 底高) && 底高 > 0)
            {
                计算像素();
                计算视场();
            }
        }

        private void 宽数框_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (int.TryParse(宽数框.Text, out 宽数) && 宽数 > 0)
                计算像素();
        }

        private void 高数框_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (int.TryParse(高数框.Text, out 高数) && 高数 > 0)
                计算像素();
        }

        private void 单尺框_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (double.TryParse(单尺框.Text, out 单尺) && 单尺 > 0)
                计算辨率();
        }
    }
}
