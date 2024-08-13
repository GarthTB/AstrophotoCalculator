using System.Windows;

namespace AstrophotoCalculator
{
    internal static class Help
    {
        public static void Show()
        {
            Clipboard.SetText("https://github.com/GarthTB/AstrophotoCalculator");
            MessageBox.Show("本计算器适用于没有跟踪设备的星空摄影。\n"
                            + "只考虑地球自转，忽略其他因素影响。\n"
                            + "效率指数反映单张照片中每像素获得的能量。\n"
                            + "具体算法参见源码，仓库链接已复制到剪贴板。\n\n"
                            + "快捷键：F1查看帮助，F5归零。\n\n"
                            + "天文摄影计算器 v2.0\n"
                            + "©️ 2024 Garth", "帮助", MessageBoxButton.OK);
        }
    }
}
