using System;

namespace TChartSampleTest
{
    /// <summary>
    /// 차트 시리즈 클릭 이벤트 인자
    /// </summary>
    public class ClickChartSeriesEventArgs : EventArgs
    {
        //////////////////////////////////////////////////////////////////////////////////////////////////// Field
        ////////////////////////////////////////////////////////////////////////////////////////// Private

        #region Field

        /// <summary>
        /// 사용자 그리기 사용 여부
        /// </summary>
        private bool useUserDrawing = false;

        /// <summary>
        /// 웨이퍼 데이터
        /// </summary>
        private WaferData waferData = null;

        /// <summary>
        /// 값 인덱스
        /// </summary>
        private int valueIndex = -1;

        #endregion

        //////////////////////////////////////////////////////////////////////////////////////////////////// Property
        ////////////////////////////////////////////////////////////////////////////////////////// Public

        #region 사용자 그리기 사용 여부 - UseUserDrawing

        /// <summary>
        /// 사용자 그리기 사용 여부
        /// </summary>
        public bool UseUserDrawing
        {
            get
            {
                return this.useUserDrawing;
            }
        }

        #endregion
        #region 웨이퍼 데이터 - WaferData

        /// <summary>
        /// 웨이퍼 데이터
        /// </summary>
        public WaferData WaferData
        {
            get
            {
                return this.waferData;
            }
        }

        #endregion
        #region 값 인덱스 - ValueIndex

        /// <summary>
        /// 값 인덱스
        /// </summary>
        public int ValueIndex
        {
            get
            {
                return this.valueIndex;
            }
        }

        #endregion

        //////////////////////////////////////////////////////////////////////////////////////////////////// Constructor
        ////////////////////////////////////////////////////////////////////////////////////////// Public

        #region 생성자 - ClickChartSeriesEventArgs(useUserDrawing, waferData, valueIndex)

        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="waferData">웨이퍼 데이터</param>
        /// <param name="valueIndex">값 인덱스</param>
        public ClickChartSeriesEventArgs(bool useUserDrawing, WaferData waferData, int valueIndex)
        {
            this.useUserDrawing = useUserDrawing;
            this.waferData      = waferData;
            this.valueIndex     = valueIndex;
        }

        #endregion
    }
}