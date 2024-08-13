using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace AstrophotoCalculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(HotKeys);
        }

        private void HotKeys(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.F1:
                    Help.Show();
                    break;
                case Key.F5:
                    Reset();
                    break;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) => Help.Show();

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e) => target = -1;

        private void Reset()
        {
            target = -1;
            焦距框.Clear();
            焦比框.Clear();
            入瞳框.Clear();
            波下框.Text = "400";
            波上框.Text = "700";
            衍下框.Clear();
            衍上框.Clear();
            底宽框.Clear();
            底高框.Clear();
            宽数框.Clear();
            高数框.Clear();
            单尺框.Clear();
            场宽框.Clear();
            场高框.Clear();
            辨一框.Clear();
            赤纬框.Clear();
            半宽框.Clear();
            快门框.Clear();
            效率框.Clear();
            辨二框.Clear();
            靶角框.Clear();
            占据框.Clear();
        }
    }
}
