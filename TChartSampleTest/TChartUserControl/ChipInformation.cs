using System.Data;
using System.Drawing;

namespace TChartSampleTest
{
    /// <summary>
    /// Chip 정보
    /// </summary>
    public class ChipInformation
    {
        //////////////////////////////////////////////////////////////////////////////////////////////////// Field
        ////////////////////////////////////////////////////////////////////////////////////////// Static
        //////////////////////////////////////////////////////////////////////////////// Private

        #region Field

        /// <summary>
        /// Chip ID 필드
        /// </summary>
        private static string _chipIDField = "ID";

        /// <summary>
        /// Chip 중심 X 필드
        /// </summary>
        private static string _chipCenterXField = "CenterX";

        /// <summary>
        /// Chip 중심 Y 필드
        /// </summary>
        private static string _chipCenterYField = "CenterY";

        /// <summary>
        /// Chip 인덱스 X 필드
        /// </summary>
        private static string _chipIndexXField = "IndexX";

        /// <summary>
        /// Chip 인덱스 Y 필드
        /// </summary>
        private static string _chipIndexYField = "IndexY";

        #endregion

        ////////////////////////////////////////////////////////////////////////////////////////// Instance
        //////////////////////////////////////////////////////////////////////////////// Private

        #region Field

        /// <summary>
        /// Line ID
        /// </summary>
        private int lineID = 0;

        /// <summary>
        /// Step
        /// </summary>
        private string step = null;

        /// <summary>
        /// Chip 너비
        /// </summary>
        private double chipWidth = 0d;

        /// <summary>
        /// Chip 너비 1/2
        /// </summary>
        private double chipHalfWidth = 0d;

        /// <summary>
        /// Chip 높이
        /// </summary>
        private double chipHeight = 0d;

        /// <summary>
        /// Chip 높이 1/2
        /// </summary>
        private double chipHalfHeight = 0d;

        /// <summary>
        /// Chip 펜 색상
        /// </summary>
        private Color chipPenColor = Color.Green;

        /// <summary>
        /// Chip 펜 너비
        /// </summary>
        private int chipPenWidth = 1;

        /// <summary>
        /// Chip 브러시 색상
        /// </summary>
        private Color chipBrushColor = Color.Transparent;

        /// <summary>
        /// Chip 투명도
        /// </summary>
        private int chipTransparency = 50;

        /// <summary>
        /// Chip 테이블
        /// </summary>
        private DataTable chipTable = null;

        /// <summary>
        /// Chip 행 컬렉션
        /// </summary>
        private DataRowCollection chipRowCollection = null;

        #endregion

        //////////////////////////////////////////////////////////////////////////////////////////////////// Property
        ////////////////////////////////////////////////////////////////////////////////////////// Static
        //////////////////////////////////////////////////////////////////////////////// Public

        #region Chip ID 필드 - ChipIDField

        /// <summary>
        /// Chip ID 필드
        /// </summary>
        public static string ChipIDField
        {
            get
            {
                return _chipIDField;
            }
            set
            {
                _chipIDField = value;
            }
        }

        #endregion
        #region Chip 중심 X 필드 - ChipCenterXField

        /// <summary>
        /// Chip 중심 X 필드
        /// </summary>
        public static string ChipCenterXField
        {
            get
            {
                return _chipCenterXField;
            }
            set
            {
                _chipCenterXField = value;
            }
        }

        #endregion
        #region Chip 중심 Y 필드 - ChipCenterYField

        /// <summary>
        /// Chip 중심 Y 필드
        /// </summary>
        public static string ChipCenterYField
        {
            get
            {
                return _chipCenterYField;
            }
            set
            {
                _chipCenterYField = value;
            }
        }

        #endregion
        #region Chip 인덱스 X 필드 - ChipIndexXField

        /// <summary>
        /// Chip 인덱스 X 필드
        /// </summary>
        public static string ChipIndexXField
        {
            get
            {
                return _chipIndexXField;
            }
            set
            {
                _chipIndexXField = value;
            }
        }

        #endregion
        #region Chip 인덱스 Y 필드 - ChipIndexYField

        /// <summary>
        /// Chip 인덱스 Y 필드
        /// </summary>
        public static string ChipIndexYField
        {
            get
            {
                return _chipIndexYField;
            }
            set
            {
                _chipIndexYField = value;
            }
        }

        #endregion

        ////////////////////////////////////////////////////////////////////////////////////////// Instance
        //////////////////////////////////////////////////////////////////////////////// Public

        #region Line ID - LineID

        /// <summary>
        /// Line ID
        /// </summary>
        public int LineID
        {
            get
            {
                return this.lineID;
            }
            set
            {
                this.lineID = value;
            }
        }

        #endregion
        #region Step - Step

        /// <summary>
        /// Step
        /// </summary>
        public string Step
        {
            get
            {
                return this.step;
            }
            set
            {
                this.step = value;
            }
        }

        #endregion
        #region Chip 너비 - ChipWidth

        /// <summary>
        /// Chip 너비
        /// </summary>
        public double ChipWidth
        {
            get
            {
                return this.chipWidth;
            }
            set
            {
                this.chipWidth = value;

                this.chipHalfWidth = this.chipWidth / 2d;
            }
        }

        #endregion
        #region Chip 높이 - ChipHeight

        /// <summary>
        /// Chip 높이
        /// </summary>
        public double ChipHeight
        {
            get
            {
                return this.chipHeight;
            }
            set
            {
                this.chipHeight = value;

                this.chipHalfHeight = this.chipHeight / 2d;
            }
        }

        #endregion
        #region Chip 펜 색상 - ChipPenColor

        /// <summary>
        /// Chip 펜 색상
        /// </summary>
        public Color ChipPenColor
        {
            get
            {
                return this.chipPenColor;
            }
            set
            {
                this.chipPenColor = value;
            }
        }

        #endregion
        #region Chip 펜 너비 - ChipPenWidth

        /// <summary>
        /// Chip 펜 너비
        /// </summary>
        public int ChipPenWidth
        {
            get
            {
                return this.chipPenWidth;
            }
            set
            {
                this.chipPenWidth = value;
            }
        }

        #endregion
        #region Chip 브러시 색상 - ChipBrushColor

        /// <summary>
        /// Chip 브러시 색상
        /// </summary>
        public Color ChipBrushColor
        {
            get
            {
                return this.chipBrushColor;
            }
            set
            {
                this.chipBrushColor = value;
            }
        }

        #endregion
        #region Chip 투명도 - ChipTransparency

        /// <summary>
        /// Chip 투명도
        /// </summary>
        public int ChipTransparency
        {
            get
            {
                return this.chipTransparency;
            }
            set
            {
                this.chipTransparency = value;
            }
        }

        #endregion
        #region Chip 테이블 - ChipTable

        /// <summary>
        /// Chip 테이블
        /// </summary>
        public DataTable ChipTable
        {
            get
            {
                return this.chipTable;
            }
            set
            {
                this.chipTable = value;

                if(this.chipTable != null)
                {
                    this.chipRowCollection = this.chipTable.Rows;
                }
                else
                {
                    this.chipRowCollection = null;
                }
            }
        }

        #endregion
        #region Chip 수 - ChipCount

        /// <summary>
        /// Chip 수
        /// </summary>
        public int ChipCount
        {
            get
            {
                if(this.chipTable == null)
                {
                    return 0;
                }
                else
                {
                    return this.chipTable.Rows.Count;
                }
            }
        }

        #endregion
        #region 인덱서 - this[index]

        /// <summary>
        /// 인덱서
        /// </summary>
        /// <param name="index">인덱스</param>
        /// <returns>데이터 행</returns>
        /// <remarks>
        /// - 성능 향상을 위해 검사 코드를 생략하였다.
        /// </remarks>
        public DataRow this[int index]
        {
            get
            {
                return this.chipRowCollection[index];
            }
        }

        #endregion
        #region Chip 데이터 소유 여부 - HasChipData

        /// <summary>
        /// Chip 데이터 소유 여부
        /// </summary>
        public bool HasChipData
        {
            get
            {
                if(this.lineID == -1)
                {
                    return false;
                }

                if(string.IsNullOrEmpty(this.step))
                {
                    return false;
                }

                if(this.chipWidth <= 0d || this.chipHeight <= 0d)
                {
                    return false;
                }

                if(this.chipTable == null || this.chipTable.Rows.Count == 0)
                {
                    return false;
                }

                return true;
            }
        }

        #endregion

        //////////////////////////////////////////////////////////////////////////////////////////////////// Constructor
        ////////////////////////////////////////////////////////////////////////////////////////// Public

        #region 생성자 - ChipInformation(lineID, step, chipWidth, chipHeight, chipTable)

        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="lineID">Line ID</param>
        /// <param name="step">Step</param>
        /// <param name="chipWidth">Chip 너비</param>
        /// <param name="chipHeight">Chip 높이</param>
        /// <param name="chipTable">Chip 목록</param>
        public ChipInformation(int lineID, string step, double chipWidth, double chipHeight, DataTable chipTable)
        {
            this.lineID     = lineID;
            this.step       = step;
            this.chipWidth  = chipWidth;
            this.chipHeight = chipHeight;
            this.chipTable  = chipTable;

            if(this.chipTable != null)
            {
                this.chipRowCollection = this.chipTable.Rows;
            }
            else
            {
                this.chipRowCollection = null;
            }
        }

        #endregion
        #region 생성자 - ChipInformation()

        /// <summary>
        /// 생성자
        /// </summary>
        public ChipInformation()
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
            this.step = null;

            if(this.chipTable != null)
            {
	            this.chipTable.Dispose();

	            this.chipTable = null;
            }

            this.chipRowCollection = null;
        }

        #endregion
        #region Chip ID 구하기 - GetChipID(index)

        /// <summary>
        /// Chip ID 구하기
        /// </summary>
        /// <param name="index">인덱스</param>
        /// <returns>Chip ID</returns>
        public int GetChipID(int index)
        {
            return (int)(this.chipRowCollection[index][_chipIDField]);
        }

        #endregion
        #region Chip 중심 X 구하기 - GetChipCenterX(index)

        /// <summary>
        /// Chip 중심 X 구하기
        /// </summary>
        /// <param name="index">인덱스</param>
        /// <returns>Chip 중심 X</returns>
        public double GetChipCenterX(int index)
        {
            return (double)(this.chipRowCollection[index][_chipCenterXField]);
        }

        #endregion
        #region Chip 중심 Y 구하기 - GetChipCenterY(index)

        /// <summary>
        /// Chip 중심 Y 구하기
        /// </summary>
        /// <param name="index">인덱스</param>
        /// <returns>Chip 중심 Y</returns>
        public double GetChipCenterY(int index)
        {
            return (double)(this.chipRowCollection[index][_chipCenterYField]);
        }

        #endregion
        #region Chip 인덱스 X 구하기 - GetChipIndexX(index)

        /// <summary>
        /// Chip 인덱스 X 구하기
        /// </summary>
        /// <param name="index">인덱스</param>
        /// <returns>Chip 인덱스 X</returns>
        public double GetChipIndexX(int index)
        {
            return (double)(this.chipRowCollection[index][_chipIndexXField]);
        }

        #endregion
        #region Chip 인덱스 Y 구하기 - GetChipIndexY(index)

        /// <summary>
        /// Chip 인덱스 Y 구하기
        /// </summary>
        /// <param name="index">인덱스</param>
        /// <returns>Chip 인덱스 Y</returns>
        public double GetChipIndexY(int index)
        {
            return (double)(this.chipRowCollection[index][_chipIndexYField]);
        }

        #endregion
        #region Chip 왼쪽 위치 구하기 - GetChipLeftPosition(index)

        /// <summary>
        /// Chip 왼쪽 위치 구하기
        /// </summary>
        /// <param name="index">인덱스</param>
        /// <returns>Chip 왼쪽 위치</returns>
        public double GetChipLeftPosition(int index)
        {
            return (double)(this.chipRowCollection[index][_chipCenterXField]) - this.chipHalfWidth;
        }

        #endregion
        #region Chip 위쪽 위치 구하기 - GetChipTopPosition(index)

        /// <summary>
        /// Chip 위쪽 위치 구하기
        /// </summary>
        /// <param name="index">인덱스</param>
        /// <returns>Chip 위쪽 위치</returns>
        public double GetChipTopPosition(int index)
        {
            return (double)(this.chipRowCollection[index][_chipCenterYField]) - this.chipHalfHeight;
        }

        #endregion
        #region Chip 오른쪽 위치 구하기 - GetChipRightPosition(index)

        /// <summary>
        /// Chip 오른쪽 위치 구하기
        /// </summary>
        /// <param name="index">인덱스</param>
        /// <returns>Chip 오른쪽 위치</returns>
        public double GetChipRightPosition(int index)
        {
            return (double)(this.chipRowCollection[index][_chipCenterXField]) + this.chipHalfWidth;
        }

        #endregion
        #region Chip 아래쪽 위치 구하기 - GetChipBottomPosition(index)

        /// <summary>
        /// Chip 아래쪽 위치 구하기
        /// </summary>
        /// <param name="index">인덱스</param>
        /// <returns>Chip 아래쪽 위치</returns>
        public double GetChipBottomPosition(int index)
        {
            return (double)(this.chipRowCollection[index][_chipCenterYField]) + this.chipHalfHeight;
        }

        #endregion
    }
}