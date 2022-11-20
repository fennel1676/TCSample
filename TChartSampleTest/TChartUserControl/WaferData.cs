using System;
using System.Data;

namespace TChartSampleTest
{
    /// <summary>
    /// 데이터
    /// </summary>
    public class WaferData
    {
        //////////////////////////////////////////////////////////////////////////////////////////////////// Field
        ////////////////////////////////////////////////////////////////////////////////////////// Private

        #region Field

        /// <summary>
        /// 제목
        /// </summary>
        private string title = string.Empty;

        /// <summary>
        /// X 필드
        /// </summary>
        private string xField = "X";

        /// <summary>
        /// Y 필드
        /// </summary>
        private string yField = "Y";

        /// <summary>
        /// Z 필드
        /// </summary>
        private string zField = "Z";

        /// <summary>
        /// 리스트 테이블
        /// </summary>
        private DataTable listTable = null;

        /// <summary>
        /// 리스트 행 컬렉션
        /// </summary>
        private DataRowCollection listRowCollection = null;

        /// <summary>
        /// 리스트 뷰
        /// </summary>
        private DataView listView = null;

        /// <summary>
        /// 필터
        /// </summary>
        private string filter = string.Empty;

        /// <summary>
        /// 순서
        /// </summary>
        private string order = string.Empty;

        /// <summary>
        /// 범위
        /// </summary>
        private DoubleRange doubleRange = new DoubleRange(1d, -1d);

        #endregion

        //////////////////////////////////////////////////////////////////////////////////////////////////// Field
        ////////////////////////////////////////////////////////////////////////////////////////// Public

        #region 제목 - Title

        /// <summary>
        /// 제목
        /// </summary>
        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                this.title = value;
            }
        }

        #endregion
        #region X 필드 - XField

        /// <summary>
        /// X 필드
        /// </summary>
        public string XField
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        #endregion
        #region Y 필드 - YField

        /// <summary>
        /// Y 필드
        /// </summary>
        public string YField
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }

        #endregion
        #region Z 필드 - ZField

        /// <summary>
        /// Z 필드
        /// </summary>
        public string ZField
        {
            get
            {
                return this.zField;
            }
            set
            {
                if(this.zField == value)
                {
                    return;
                }

                this.zField = value;

                SetRange();
            }
        }

        #endregion
        #region 리스트 테이블 - ListTable

        /// <summary>
        /// 리스트 테이블
        /// </summary>
        public DataTable ListTable
        {
            get
            {
                return this.listTable;
            }
            set
            {
                this.listTable = value;

                if(this.listTable != null)
                {
                    this.listRowCollection = this.listTable.Rows;

                    this.listView = this.listTable.DefaultView;

                    this.listView.RowFilter = this.filter;

                    this.listView.Sort = this.order;
                }
                else
                {
                    this.listRowCollection = null;

                    this.listView = null;
                }

                SetRange();
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
        public DataRowView this[int index]
        {
            get
            {
                return this.listView[index];
            }
        }

        #endregion
        #region 데이터 수 - Count

        /// <summary>
        /// 데이터 수
        /// </summary>
        public int Count
        {
            get
            {
                if(this.listTable == null)
                {
                    return 0;
                }
                else
                {
                    return this.listTable.Rows.Count;
                }
            }
        }

        #endregion
        #region 필터 데이터 수 - CountFiltered

        /// <summary>
        /// 필터 데이터 수
        /// </summary>
        public int CountFiltered
        {
            get
            {
                if(this.listView == null)
                {
                    return 0;
                }
                else
                {
                    this.listView.RowFilter = this.filter;
                    this.listView.Sort      = this.order;

                    int countFiltered = this.listView.Count;

                    this.listView.RowFilter = string.Empty;
                    this.listView.Sort      = string.Empty;

                    return countFiltered;
                }
            }
        }

        #endregion
        #region 필터 - Filter

        /// <summary>
        /// 필터
        /// </summary>
        public string Filter
        {
            get
            {
                return this.filter;
            }
            set
            {
                if(this.filter == value)
                {
                    return;
                }

                if(string.IsNullOrEmpty(value))
                {
                    this.filter = string.Empty;
                }
                else
                {
                    this.filter = value;
                }

                SetRange();
            }
        }

        #endregion
        #region 순서 - Order

        /// <summary>
        /// 순서
        /// </summary>
        public string Order
        {
            get
            {
                return this.order;
            }
            set
            {
                if(this.order == value)
                {
                    return;
                }

                if(string.IsNullOrEmpty(value))
                {
                    this.order = string.Empty;
                }
                else
                {
                    this.order = value;
                }

                SetRange();
            }
        }

        #endregion
        #region 범위 - Range

        /// <summary>
        /// 범위
        /// </summary>
        public DoubleRange Range
        {
            get
            {
                return this.doubleRange;
            }
        }

        #endregion
        #region 데이터 뷰 사용 여부 - UseDataView

        /// <summary>
        /// 데이터 뷰 사용 여부
        /// </summary>
        public bool UseDataView
        {
            get
            {
                if(string.IsNullOrEmpty(this.filter) && string.IsNullOrEmpty(this.order))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        #endregion

        //////////////////////////////////////////////////////////////////////////////////////////////////// Constructor
        ////////////////////////////////////////////////////////////////////////////////////////// Public

        #region 생성자 - WaferData(listTable)

        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="listTable">리스트 테이블</param>
        public WaferData(DataTable listTable)
        {
            ListTable = listTable;
        }

        #endregion
        #region 생성자 - WaferData()

        /// <summary>
        /// 생성자
        /// </summary>
        public WaferData()
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
            this.xField = null;

            this.yField = null;

            this.zField = null;

            if(this.listTable != null)
            {
                this.listTable.Dispose();

                this.listTable = null;
            }

            this.listRowCollection = null;

            this.listView = null;

            this.filter = null;

            this.order = null;

            this.doubleRange = null;
        }

        #endregion
        #region X 구하기 - GetX(index)

        /// <summary>
        /// X 구하기
        /// </summary>
        /// <param name="index">인덱스</param>
        /// <returns>X</returns>
        public double GetX(int index)
        {
            return (double)(this.listView[index][this.xField]);
        }

        #endregion
        #region Y 구하기 - GetY(index)

        /// <summary>
        /// Y 구하기
        /// </summary>
        /// <param name="index">인덱스</param>
        /// <returns>Y</returns>
        public double GetY(int index)
        {
            return (double)(this.listView[index][this.yField]);
        }

        #endregion
        #region Z 구하기 - GetZ(index)

        /// <summary>
        /// Z 구하기
        /// </summary>
        /// <param name="index">인덱스</param>
        /// <returns>Z</returns>
        public double GetZ(int index)
        {
            return (double)(this.listView[index][this.zField]);
        }

        #endregion

        ////////////////////////////////////////////////////////////////////////////////////////// Private

        #region 범위 설정하기 - SetRange()

        /// <summary>
        /// 범위 설정하기
        /// </summary>
        private void SetRange()
        {
            if(this.listTable != null)
            {
                this.doubleRange.Minimum = Convert.ToDouble(this.listTable.Compute("MIN(" + this.zField + ")", this.filter));
                this.doubleRange.Maximum = Convert.ToDouble(this.listTable.Compute("MAX(" + this.zField + ")", this.filter));
            }
            else
            {
                this.doubleRange.Minimum = -1d;
                this.doubleRange.Maximum = -1d;
            }
        }

        #endregion
    }
}