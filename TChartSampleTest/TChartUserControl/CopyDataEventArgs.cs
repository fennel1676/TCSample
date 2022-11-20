using System;

namespace TChartSampleTest
{
    /// <summary>
    /// 데이터 복사하기 이벤트 인자
    /// </summary>
    public class CopyDataEventArgs : EventArgs
    {
        //////////////////////////////////////////////////////////////////////////////////////////////////// Field
        ////////////////////////////////////////////////////////////////////////////////////////// Private

        #region Field

        /// <summary>
        /// 웨이퍼 데이터
        /// </summary>
        private WaferData waferData = null;

        #endregion

        //////////////////////////////////////////////////////////////////////////////////////////////////// Property
        ////////////////////////////////////////////////////////////////////////////////////////// Public

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

        //////////////////////////////////////////////////////////////////////////////////////////////////// Constructor
        ////////////////////////////////////////////////////////////////////////////////////////// Public

        #region 생성자 - CopyDataEventArgs(waferData)

        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="waferData">웨이퍼 데이터</param>
        public CopyDataEventArgs(WaferData waferData)
        {
            this.waferData = waferData;
        }

        #endregion
    }
}