using System.Drawing;

namespace TChartSampleTest
{
    /// <summary>
    /// Wafer 원
    /// </summary>
    public class WaferCircle
    {
        //////////////////////////////////////////////////////////////////////////////////////////////////// Field
        ////////////////////////////////////////////////////////////////////////////////////////// Private

        #region Field

        /// <summary>
        /// 지름
        /// </summary>
        private double diameter = 300d;

        /// <summary>
        /// 반지름
        /// </summary>
        private double radius = 150d;

        /// <summary>
        /// 펜 색상
        /// </summary>
        private Color penColor = Color.Black;

        /// <summary>
        /// 펜 너비
        /// </summary>
        private int penWidth = 1;

        /// <summary>
        /// 브러시 색상
        /// </summary>
        private Color brushColor = Color.Transparent;

        /// <summary>
        /// 투명도
        /// </summary>
        private int transparency = 50;

        #endregion

        //////////////////////////////////////////////////////////////////////////////////////////////////// Property
        ////////////////////////////////////////////////////////////////////////////////////////// Public

        #region 지름 - Diameter

        /// <summary>
        /// 지름
        /// </summary>
        public double Diameter
        {
            get
            {
                return this.diameter;
            }
            set
            {
                this.diameter = value;

                this.radius = this.diameter / 2d;
            }
        }

        #endregion
        #region 반지름 - Radius

        /// <summary>
        /// 반지름
        /// </summary>
        public double Radius
        {
            get
            {
                return this.radius;
            }
            set
            {
                this.radius = value;

                this.diameter = this.radius * 2d;
            }
        }

        #endregion
        #region 펜 색상 - PenColor

        /// <summary>
        /// 펜 색상
        /// </summary>
        public Color PenColor
        {
            get
            {
                return this.penColor;
            }
            set
            {
                this.penColor = value;
            }
        }

        #endregion
        #region 펜 너비 - PenWidth

        /// <summary>
        /// 펜 너비
        /// </summary>
        public int PenWidth
        {
            get
            {
                return this.penWidth;
            }
            set
            {
                this.penWidth = value;
            }
        }

        #endregion
        #region 브러시 색상 - BrushColor

        /// <summary>
        /// 브러시 색상
        /// </summary>
        public Color BrushColor
        {
            get
            {
                return this.brushColor;
            }
            set
            {
                this.brushColor = value;
            }
        }

        #endregion
        #region 투명도 - Transparency

        /// <summary>
        /// 투명도
        /// </summary>
        public int Transparency
        {
            get
            {
                return this.transparency;
            }
            set
            {
                this.transparency = value;
            }
        }

        #endregion

        //////////////////////////////////////////////////////////////////////////////////////////////////// Constructor
        ////////////////////////////////////////////////////////////////////////////////////////// Public

        #region 생성자 - WaferCircle(diameter)

        /// <summary>
        /// 생성자
        /// </summary>
        public WaferCircle(double diameter)
        {
            this.diameter = diameter;

            this.radius   = this.diameter / 2d;
        }

        #endregion
        #region 생성자 - WaferCircle()

        /// <summary>
        /// 생성자
        /// </summary>
        public WaferCircle()
        {
        }

        #endregion

        //////////////////////////////////////////////////////////////////////////////////////////////////// Method
        ////////////////////////////////////////////////////////////////////////////////////////// Public

        #region 데이터 지우기 - ClearData()

        /// <summary>
        /// 데이터 지우기
        /// </summary>
        public void ClearData()
        {
        }

        #endregion
        #region 왼쪽 위치 구하기 - GetLeftPosition()

        /// <summary>
        /// 왼쪽 위치 구하기
        /// </summary>
        /// <returns>왼쪽 위치</returns>
        public double GetLeftPosition()
        {
            return -this.radius;
        }

        #endregion
        #region 위쪽 위치 구하기 - GetTopPosition()

        /// <summary>
        /// 위쪽 위치 구하기
        /// </summary>
        /// <returns>위쪽 위치</returns>
        public double GetTopPosition()
        {
            return -this.radius;
        }

        #endregion
        #region 오른쪽 위치 구하기 - GetRightPosition()

        /// <summary>
        /// 오른쪽 위치 구하기
        /// </summary>
        /// <returns>오른쪽 위치</returns>
        public double GetRightPosition()
        {
            return this.radius;
        }

        #endregion
        #region 아래쪽 위치 구하기 - GetBottomPosition()

        /// <summary>
        /// 아래쪽 위치 구하기
        /// </summary>
        /// <returns>아래쪽 위치</returns>
        public double GetBottomPosition()
        {
            return this.radius;
        }

        #endregion
    }
}