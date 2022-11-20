using Steema.TeeChart.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TChartSampleTest
{
    public partial class Form1 : Form
    {
        #region Field

        /// <summary>
        /// 샘플 배열
        /// </summary>
        /// <remarks>
        /// 임의로 데이터를 생성하기 위한 샘플 데이터
        /// </remarks>
        private int[] sampleArray = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable sourceTable = GetEmptyTable();

            CreateWaferTableData(sourceTable);

            WaferData waferData = new WaferData(sourceTable);

            this.waferControl.WaferData = waferData;
        }

        #region Capture 체크 변경시 처리하기 - captureCheckBox_CheckedChanged(sender, e)

        /// <summary>
        /// Capture 체크 변경시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void captureCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.waferControl.CanCapture = this.captureCheckBox.Checked;
        }
        #endregion

        #region WaferChart 차트 시리즈 클릭시 처리하기 - waferChart_ClickChartSeries(sender, e)

        /// <summary>
        /// WaferChart 차트 시리즈 클릭시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void waferControl_ClickChartSeries(object sender, ClickChartSeriesEventArgs e)
        {
            WaferData waferData = e.WaferData;
            int valueIndex = e.ValueIndex;

            if (waferData.UseDataView)
            {
                DataView dataView = waferData.ListTable.DefaultView;

                dataView.RowFilter = waferData.Filter;
                dataView.Sort = waferData.Order;

                MessageBox.Show
                (
                    string.Format
                    (
                        "X, Y, Z = {0}, {1}, {2}",
                        dataView[valueIndex][waferData.XField],
                        dataView[valueIndex][waferData.YField],
                        dataView[valueIndex][waferData.ZField]
                    ),
                    "확인",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                dataView.RowFilter = string.Empty;
                dataView.Sort = string.Empty;
            }
            else
            {
                DataTable dataTable = waferData.ListTable;
                DataRowCollection dataRowCollection = dataTable.Rows;

                MessageBox.Show
                (
                    string.Format
                    (
                        "X, Y, Z = {0}, {1}, {2}",
                        dataRowCollection[valueIndex][waferData.XField],
                        dataRowCollection[valueIndex][waferData.YField],
                        dataRowCollection[valueIndex][waferData.ZField]
                    ),
                    "확인",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        #endregion

        #region 비어있는 테이블 구하기 - GetEmptyTable()

        /// <summary>
        /// 비어있는 테이블 구하기
        /// </summary>
        /// <returns>비어있는 테이블</returns>
        private DataTable GetEmptyTable()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add(new DataColumn("X", typeof(double)));
            dataTable.Columns.Add(new DataColumn("Y", typeof(double)));
            dataTable.Columns.Add(new DataColumn("Z", typeof(double)));

            return dataTable;
        }

        #endregion
        #region 웨이퍼 테이블 데이터 생성하기 - CreateWaferTableData(sourceTable)

        /// <summary>
        /// 웨이퍼 테이블 데이터 생성하기
        /// </summary>
        /// <param name="sourceTable">소스 테이블</param>
        private void CreateWaferTableData(DataTable sourceTable)
        {
            Random random = new Random(DateTime.Now.Millisecond);

            double distance;

            DataRow row = null;

            for (double y = -150; y <= 150; y += 1)
            {
                for (double x = -150; x <= 150; x += 1)
                {
                    distance = Math.Sqrt(x * x + y * y);

                    if (distance > 145d)
                    {
                        continue;
                    }

                    row = sourceTable.NewRow();

                    row[0] = x;
                    row[1] = y;
                    row[2] = random.Next(9);

                    sourceTable.Rows.Add(row);
                }
            }
        }

        #endregion
    }
}
