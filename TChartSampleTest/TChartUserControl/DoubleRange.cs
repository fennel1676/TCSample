namespace TChartSampleTest
{
    /// <summary>
    /// 배정도 실수 범위
    /// </summary>
    public class DoubleRange
    {
        //////////////////////////////////////////////////////////////////////////////////////////////////// Field
        ////////////////////////////////////////////////////////////////////////////////////////// Private

        #region Field

        /// <summary>
        /// 최소 값
        /// </summary>
        private double minimum;

        /// <summary>
        /// 최대 값
        /// </summary>
        private double maximum;

        #endregion

        //////////////////////////////////////////////////////////////////////////////////////////////////// Property
        ////////////////////////////////////////////////////////////////////////////////////////// Public

        #region 최소 값 - Minimum

        /// <summary>
        /// 최소 값
        /// </summary>
        public double Minimum
        {
            get
            {
                return this.minimum;
            }
            set
            {
                this.minimum = value;
            }
        }

        #endregion
        #region 최대 값 - Maximum

        /// <summary>
        /// 최대 값
        /// </summary>
        public double Maximum
        {
            get
            {
                return this.maximum;
            }
            set
            {
                this.maximum = value;
            }
        }

        #endregion
        #region 길이 - Length

        /// <summary>
        /// 길이
        /// </summary>
        public double Length
        {
            get
            {
                return this.maximum - this.minimum;
            }
        }

        #endregion

        //////////////////////////////////////////////////////////////////////////////////////////////////// Constructor
        ////////////////////////////////////////////////////////////////////////////////////////// Public

        #region 생성자 - DoubleRange(minimum, maximum)

        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="minimum">최소 값</param>
        /// <param name="maximum">최대 값</param>
        public DoubleRange(double minimum, double maximum)
        {
            this.minimum = minimum;
            this.maximum = maximum;
        }

        #endregion

        ////////////////////////////////////////////////////////////////////////////////////////// Private

        #region 생성자 - DoubleRange()

        /// <summary>
        /// 생성자
        /// </summary>
        private DoubleRange()
        {
        }

        #endregion

        //////////////////////////////////////////////////////////////////////////////////////////////////// Method
        ////////////////////////////////////////////////////////////////////////////////////////// Public

        #region 포함 여부 조사하기 - IsInside(x)

        /// <summary>
        /// 포함 여부 조사하기
        /// </summary>
        /// <param name="x">X</param>
        /// <returns>포함 여부 조사 결과</returns>
        public bool IsInside(double x)
        {
            return (x >= this.minimum) && (x <= this.maximum);
        }

        #endregion
        #region 포함 여부 조사하기 - IsInside(doubleRange)

        /// <summary>
        /// 포함 여부 조사하기
        /// </summary>
        /// <param name="doubleRange">배정도 실수 범위</param>
        /// <returns>포함 여부 조사 결과</returns>
        public bool IsInside(DoubleRange doubleRange)
        {
            return (IsInside(doubleRange.Minimum)) && (IsInside(doubleRange.Maximum));
        }

        #endregion
        #region 중첩 여부 조사하기 - IsOverlapping(doubleRange)

        /// <summary>
        /// 중첩 여부 조사하기
        /// </summary>
        /// <param name="doubleRange">배정도 실수 범위</param>
        /// <returns>중첩 여부 조사하기</returns>
        public bool IsOverlapping(DoubleRange doubleRange)
        {
            return (IsInside(doubleRange.Minimum)) || (IsInside(doubleRange.Maximum));
        }

        #endregion
    }
}