using System.Globalization;

namespace AstrophotoCalculator
{
    internal static class Tools
    {
        public static string SigDigit(double d, int i) => d.ToString($"G{i}", CultureInfo.InvariantCulture);

        public static string RadToDeg(double rad)
        {
            if (rad == 0)
                return "0";

            double deg = rad * 180 / Math.PI;
            if (deg >= 1)
                return $"{SigDigit(deg, 6)}°";

            double min = deg * 60;
            if (min >= 1)
                return $"{SigDigit(min, 6)}'";

            double sec = min * 60;
            return $"{SigDigit(sec, 6)}\"";
        }

        public static string RadToSec(double rad)
        {
            if (rad == 0)
                return "0";

            double sec = rad * 648000 / Math.PI;
            return SigDigit(sec, 6);
        }

        public static double DegToRad(double deg) => deg * Math.PI / 180;
    }
}
