using System.Windows;

namespace AstrophotoCalculator
{
    public partial class MainWindow : Window
    {
        private double 焦距, 焦比, 入瞳, 波下 = 400, 波上 = 700, 衍下, 衍上; // 第一页
        private double 底宽, 底高, 单尺, 场宽, 场高; // 第二页
        private int 宽数, 高数; // 第二页
        private double 辨率, 赤纬 = -180, 半宽, 快门, 效率; // 第三页
        private double 不定靶角, 靶角, 占据; // 第四页
        private int target = -1; // 当前计算的目标量

        private void 计算镜头()
        {
            if (焦距 > 0 && 焦比 > 0 && (入瞳 == 0 || target == 0))
            {
                target = 0;
                入瞳 = 焦距 / 焦比;
                入瞳框.Text = Tools.SigDigit(入瞳, 6);
            }
            else if (焦距 > 0 && 入瞳 > 0 && (焦比 == 0 || target == 1))
            {
                target = 1;
                焦比 = 焦距 / 入瞳;
                焦比框.Text = Tools.SigDigit(焦比, 6);
            }
            else if (焦比 > 0 && 入瞳 > 0 && (焦距 == 0 || target == 2))
            {
                target = 2;
                焦距 = 焦比 * 入瞳;
                焦距框.Text = Tools.SigDigit(焦距, 6);
            }
        }

        private void 计算衍射()
        {
            if (入瞳 > 0)
            {
                if (波下 > 0)
                {
                    衍下 = 0.79056 * 波下 / 入瞳 / Math.PI;
                    衍下框.Text = Tools.SigDigit(衍下, 6);
                }
                if (波上 > 0)
                {
                    衍上 = 0.79056 * 波上 / 入瞳 / Math.PI;
                    衍上框.Text = Tools.SigDigit(衍上, 6);
                }
            }
        }

        private void 计算像素()
        {
            if (底宽 > 0 && 宽数 > 0)
                单尺 = 底高 > 0 && 高数 > 0
                    ? Math.Sqrt(底宽 * 底高 / 宽数 / 高数 * 1000000)
                    : 底宽 / 宽数 * 1000;
            else if (底高 > 0 && 高数 > 0)
                单尺 = 底高 / 高数 * 1000;

            单尺框.Text = Tools.SigDigit(单尺, 6);
        }

        private void 计算视场()
        {
            if (焦距 > 0)
            {
                if (底宽 > 0)
                {
                    场宽 = 2 * Math.Atan(底宽 / 2 / 焦距);
                    场宽框.Text = Tools.RadToDeg(场宽);
                }
                if (底高 > 0)
                {
                    场高 = 2 * Math.Atan(底高 / 2 / 焦距);
                    场高框.Text = Tools.RadToDeg(场高);
                }
            }
        }

        private void 计算辨率()
        {
            if (焦距 > 0 && 单尺 > 0)
            {
                辨率 = 单尺 / 焦距 / 1000;
                辨一框.Text = 辨二框.Text = Tools.RadToSec(辨率);
            }
        }

        private void 计算曝光()
        {
            if (辨率 > 0 && 赤纬 != -180)
            {
                if (半宽 > 0 && (快门 == 0 || target == 0))
                {
                    target = 0;
                    快门 = 辨率 * 半宽 / Math.Cos(Tools.DegToRad(赤纬)) / 1296000 * 86164.09;
                    快门框.Text = Tools.SigDigit(快门, 6);
                }
                else if (快门 > 0 && (半宽 == 0 || target == 1))
                {
                    target = 1;
                    半宽 = 快门 / 辨率 * Math.Cos(Tools.DegToRad(赤纬)) * 1296000 / 86164.09;
                    半宽框.Text = Tools.SigDigit(半宽, 6);
                }
            }
        }

        private void 计算效率()
        {
            // 定义：
            // 某理想圆望远镜，口径为1米，
            // 每像素获得1平方角秒的“标准光”，
            // 曝光1秒，积累的能量为1。
            // 则：
            // 一次曝光中每像素获得的能量 = 口径(米) ^ 2 * 角分辨率(角秒) ^ 2 * 曝光时间(秒)

            if (入瞳 > 0 && 辨率 > 0 && 快门 > 0)
            {
                效率 = 入瞳 * 入瞳 / 1000000 * 辨率 * 辨率 * 快门;
                效率框.Text = Tools.SigDigit(效率, 6);
            }
        }

        private void 计算靶角()
        {
            if (不定靶角 > 0)
                靶角 = 不定靶角 * Math.Pow(60, 2 - 单位选.SelectedIndex);
        }

        private void 计算占据()
        {
            if (辨率 > 0 && 靶角 > 0 && (占据 == 0 || target == 0))
            {
                target = 0;
                占据 = 靶角 / 辨率;
                占据框.Text = Tools.SigDigit(占据, 6);
            }
            else if (辨率 > 0 && 占据 > 0 && (靶角 == 0 || target == 1))
            {
                target = 1;
                靶角 = 辨率 * 占据;
                不定靶角 = 靶角 / Math.Pow(60, 2 - 单位选.SelectedIndex);
                靶角框.Text = Tools.SigDigit(不定靶角, 6);
            }
            else if (靶角 > 0 && 占据 > 0 && (辨率 == 0 || target == 2))
            {
                target = 2;
                辨率 = 靶角 * 占据;
                辨二框.Text = Tools.SigDigit(辨率, 6);
            }
        }
    }
}
