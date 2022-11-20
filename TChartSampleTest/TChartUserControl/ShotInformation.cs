using System.Data;
using System.Drawing;

namespace TChartSampleTest
{
    /// <summary>
    /// Shot 정보
    /// </summary>
    public class ShotInformation
    {
        //////////////////////////////////////////////////////////////////////////////////////////////////// Field
        ////////////////////////////////////////////////////////////////////////////////////////// Static
        //////////////////////////////////////////////////////////////////////////////// Private

        #region Field

        /// <summary>
        /// Shot ID 필드
        /// </summary>
        private static string _shotIDField = "ID";

        /// <summary>
        /// Shot 중심 X 필드
        /// </summary>
        private static string _shotCenterXField = "CenterX";

        /// <summary>
        /// Shot 중심 Y 필드
        /// </summary>
        private static string _shotCenterYField = "CenterY";

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
        /// Shot 너비
        /// </summary>
        private double shotWidth = 0d;

        /// <summary>
        /// Shot 너비 1/2
        /// </summary>
        private double shotHalfWidth = 0d;

        /// <summary>
        /// Shot 높이
        /// </summary>
        private double shotHeight = 0d;

        /// <summary>
        /// Shot 높이 1/2
        /// </summary>
        private double shotHalfHeight = 0d;

        /// <summary>
        /// Shot 펜 색상
        /// </summary>
        private Color shotPenColor = Color.RoyalBlue;

        /// <summary>
        /// Shot 펜 너비
        /// </summary>
        private int shotPenWidth = 1;

        /// <summary>
        /// Shot 브러시 색상
        /// </summary>
        private Color shotBrushColor = Color.Transparent;

        /// <summary>
        /// Shot 투명도
        /// </summary>
        private int shotTransparency = 50;

        /// <summary>
        /// Shot 테이블
        /// </summary>
        private DataTable shotTable = null;

        /// <summary>
        /// Shot 행 컬렉션
        /// </summary>
        private DataRowCollection shotRowCollection = null;

        #endregion

        //////////////////////////////////////////////////////////////////////////////////////////////////// Property
        ////////////////////////////////////////////////////////////////////////////////////////// Static
        //////////////////////////////////////////////////////////////////////////////// Public

        #region Shot ID 필드 - ShotIDField

        /// <summary>
        /// Shot ID 필드
        /// </summary>
        public static string ShotIDField
        {
            get
            {
                return _shotIDField;
            }
            set
            {
                _shotIDField = value;
            }
        }

        #endregion
        #region Shot 중심 X 필드 - ShotCenterXField

        /// <summary>
        /// Shot 중심 X 필드
        /// </summary>
        public static string ShotCenterXField
        {
            get
            {
                return _shotCenterXField;
            }
            set
            {
                _shotCenterXField = value;
            }
        }

        #endregion
        #region Shot 중심 Y 필드 - ShotCenterYField

        /// <summary>
        /// Shot 중심 Y 필드
        /// </summary>
        public static string ShotCenterYField
        {
            get
            {
                return _shotCenterYField;
            }
            set
            {
                _shotCenterYField = value;
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
        #region Shot 너비 - ShotWidth

        /// <summary>
        /// Shot 너비
        /// </summary>
        public double ShotWidth
        {
            get
            {
                return this.shotWidth;
            }
            set
            {
                this.shotWidth = value;

                this.shotHalfWidth = this.shotWidth / 2d;
            }
        }

        #endregion
        #region Shot 높이 - ShotHeight

        /// <summary>
        /// Shot 높이
        /// </summary>
        public double ShotHeight
        {
            get
            {
                return this.shotHeight;
            }
            set
            {
                this.shotHeight = value;

                this.shotHalfHeight = this.shotHeight / 2d;
            }
        }

        #endregion
        #region Shot 펜 색상 - ShotPenColor

        /// <summary>
        /// Shot 펜 색상
        /// </summary>
        public Color ShotPenColor
        {
            get
            {
                return this.shotPenColor;
            }
            set
            {
                this.shotPenColor = value;
            }
        }

        #endregion
        #region Shot 펜 너비 - ShotPenWidth

        /// <summary>
        /// Shot 펜 너비
        /// </summary>
        public int ShotPenWidth
        {
            get
            {
                return this.shotPenWidth;
            }
            set
            {
                this.shotPenWidth = value;
            }
        }

        #endregion
        #region Shot 브러시 색상 - ShotBrushColor

        /// <summary>
        /// Shot 브러시 색상
        /// </summary>
        public Color ShotBrushColor
        {
            get
            {
                return this.shotBrushColor;
            }
            set
            {
                this.shotBrushColor = value;
            }
        }

        #endregion
        #region Shot 투명도 - ShotTransparency

        /// <summary>
        /// Shot 투명도
        /// </summary>
        public int ShotTransparency
        {
            get
            {
                return this.shotTransparency;
            }
            set
            {
                this.shotTransparency = value;
            }
        }

        #endregion
        #region Shot 테이블 - ShotTable

        /// <summary>
        /// Shot 테이블
        /// </summary>
        public DataTable ShotTable
        {
            get
            {
                return this.shotTable;
            }
            set
            {
                this.shotTable = value;

                if(this.shotTable != null)
                {
                    this.shotRowCollection = this.shotTable.Rows;
                }
                else
                {
                    this.shotRowCollection = null;
                }
            }
        }

        #endregion
        #region Shot 수 - ShotCount

        /// <summary>
        /// Shot 수
        /// </summary>
        public int ShotCount
        {
            get
            {
                if(this.shotTable == null)
                {
                    return 0;
                }
                else
                {
                    return this.shotTable.Rows.Count;
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
                return this.shotRowCollection[index];
            }
        }

        #endregion
        #region Shot 데이터 소유 여부 - HasShotData

        /// <summary>
        /// Shot 데이터 소유 여부
        /// </summary>
        public bool HasShotData
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

                if(this.shotWidth <= 0d || this.shotHeight <= 0d)
                {
                    return false;
                }

                if(this.shotTable == null || this.shotTable.Rows.Count == 0)
                {
                    return false;
                }

                return true;
            }
        }

        #endregion

        //////////////////////////////////////////////////////////////////////////////////////////////////// Constructor
        ////////////////////////////////////////////////////////////////////////////////////////// Public

        #region 생성자 - CShot(lineID, step, shotWidth, shotHeight, shotTable)

        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="lineID">Line ID</param>
        /// <param name="step">Step</param>
        /// <param name="shotWidth">Shot 너비</param>
        /// <param name="shotHeight">Shot 높이</param>
        /// <param name="shotTable">Shot 테이블</param>
        public ShotInformation(int lineID, string step, double shotWidth, double shotHeight, DataTable shotTable)
        {
            this.lineID     = lineID;
            this.step       = step;
            this.shotWidth  = shotWidth;
            this.shotHeight = shotHeight;
            this.shotTable  = shotTable;

            if(this.shotTable != null)
            {
                this.shotRowCollection = this.shotTable.Rows;
            }
            else
            {
                this.shotRowCollection = null;
            }
        }

        #endregion
        #region 생성자 - CShot()

        /// <summary>
        /// 생성자
        /// </summary>
        public ShotInformation()
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

            if(this.shotTable != null)
            {
	            this.shotTable.Dispose();

	            this.shotTable = null;
            }

            this.shotRowCollection = null;
        }

        #endregion
        #region Shot ID 구하기 - GetShotID(index)

        /// <summary>
        /// Shot ID 구하기
        /// </summary>
        /// <param name="index">인덱스</param>
        /// <returns>Shot ID</returns>
        public int GetShotID(int index)
        {
            return (int)(this.shotRowCollection[index][_shotIDField]);
        }

        #endregion
        #region Shot 중심 X 구하기 - GetShotCenterX(index)

        /// <summary>
        /// Shot 중심 X 구하기
        /// </summary>
        /// <param name="index">인덱스</param>
        /// <returns>Shot 중심 X</returns>
        public double GetShotCenterX(int index)
        {
            return (double)(this.shotRowCollection[index][_shotCenterXField]);
        }

        #endregion
        #region Shot 중심 Y 구하기 - GetShotCenterY(index)

        /// <summary>
        /// Shot 중심 Y 구하기
        /// </summary>
        /// <param name="index">인덱스</param>
        /// <returns>Shot 중심 Y</returns>
        public double GetShotCenterY(int index)
        {
            return (double)(this.shotRowCollection[index][_shotCenterYField]);
        }

        #endregion
        #region Shot 왼쪽 위치 구하기 - GetShotLeftPosition(index)

        /// <summary>
        /// Shot 왼쪽 위치 구하기
        /// </summary>
        /// <param name="index">인덱스</param>
        /// <returns>Shot 왼쪽 위치</returns>
        public double GetShotLeftPosition(int index)
        {
            return (double)(this.shotRowCollection[index][_shotCenterXField]) - this.shotHalfWidth;
        }

        #endregion
        #region Shot 위쪽 위치 구하기 - GetShotTopPosition(index)

        /// <summary>
        /// Shot 위쪽 위치 구하기
        /// </summary>
        /// <param name="index">인덱스</param>
        /// <returns>Shot 위쪽 위치</returns>
        public double GetShotTopPosition(int index)
        {
            return (double)(this.shotRowCollection[index][_shotCenterYField]) - this.shotHalfHeight;
        }

        #endregion
        #region Shot 오른쪽 위치 구하기 - GetShotRightPosition(index)

        /// <summary>
        /// Shot 오른쪽 위치 구하기
        /// </summary>
        /// <param name="index">인덱스</param>
        /// <returns>Shot 오른쪽 위치</returns>
        public double GetShotRightPosition(int index)
        {
            return (double)(this.shotRowCollection[index][_shotCenterXField]) + this.shotHalfWidth;
        }

        #endregion
        #region Shot 아래쪽 위치 구하기 - GetShotBottomPosition(index)

        /// <summary>
        /// Shot 아래쪽 위치 구하기
        /// </summary>
        /// <param name="index">인덱스</param>
        /// <returns>Shot 아래쪽 위치</returns>
        public double GetShotBottomPosition(int index)
        {
            return (double)(this.shotRowCollection[index][_shotCenterYField]) + this.shotHalfHeight;
        }

        #endregion
    }
}