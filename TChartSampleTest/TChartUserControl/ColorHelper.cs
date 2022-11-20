using System;
using System.Drawing;

namespace TChartSampleTest
{
    /// <summary>
    /// 색상 헬퍼
    /// </summary>
    public static class ColorHelper
    {
        //////////////////////////////////////////////////////////////////////////////////////////////////// Method
        ////////////////////////////////////////////////////////////////////////////////////////// Static
        //////////////////////////////////////////////////////////////////////////////// Public

        #region 범위 색상 구하기 - GetRangeColor(minimum, maximum, value)

        /// <summary>
        /// 범위 색상 구하기
        /// </summary>
        /// <param name="minimum">최소값</param>
        /// <param name="maximum">최대값</param>
        /// <param name="value">값</param>
        /// <returns>범위 색상</returns>
        public static Color GetRangeColor(double minimum, double maximum, double value)
        {
            if(minimum == maximum)
            {
                return Color.Gray;
            }

            if(value <= minimum)
            {
                return Color.Blue;
            }

            if(value >= maximum)
            {
                return Color.Red;
            }

            double valuePercent = (value - minimum) / (maximum - minimum);

            if(valuePercent < 0.25d)
            {
                return Color.FromArgb
                (
                    0,
                    255 - Convert.ToInt32(254d * valuePercent / 0.25d),
                    255
                );
            }
            else if(valuePercent < 0.5d)
            {
                return Color.FromArgb
                (
                    0,
                    255,
                    Convert.ToInt32(254d * valuePercent - 0.25d / 0.25d)
                );
            }
            else if(valuePercent < 0.75d)
            {
                return Color.FromArgb
                (
                    255 - Convert.ToInt32(254d * valuePercent - 0.5d / 0.25d),
                    255,
                    0
                );
            }
            else
            {
                return Color.FromArgb
                (
                    255,
                    Convert.ToInt32(254d * valuePercent - 0.75d / 0.25d),
                    0
                );
            }
        }

        #endregion
    }
}