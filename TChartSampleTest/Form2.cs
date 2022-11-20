using Steema.TeeChart;
using Steema.TeeChart.Functions;
using Steema.TeeChart.Styles;
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
    public partial class Form2 : Form
    {

        #region Field

        /// <summary>
        /// Wafer 원
        /// </summary>
        private WaferCircle waferCircle = new WaferCircle(300d);

        /// <summary>
        /// Shot 정보
        /// </summary>
        private ShotInformation shotInformation = null;

        /// <summary>
        /// Chip 정보
        /// </summary>
        private ChipInformation chipInformation = null;

        /// <summary>
        /// 웨이퍼 데이터
        /// </summary>
        private WaferData waferData = null;

        /// <summary>
        /// 사용자 그리기 사용 여부
        /// </summary>
        private bool useUserDrawing = false;

        /// <summary>
        /// 사용자 정의 범위 사용 여부
        /// </summary>
        private bool useUserDefinedRange = false;

        /// <summary>
        /// 사용자 정의 범위
        /// </summary>
        private DoubleRange userDefinedRange = new DoubleRange(1d, -1d);

        /// <summary>
        /// 웨이퍼 데이터 범위
        /// </summary>
        private DoubleRange waferDataRange = new DoubleRange(1d, -1d);

        /// <summary>
        /// 그리기 범위
        /// </summary>
        private DoubleRange drawingRange = new DoubleRange(1d, -1d);

        /// <summary>
        /// 포인트 크기
        /// </summary>
        private int pointSize = 1;

        /// <summary>
        /// 포인트 경계 표시 여부
        /// </summary>
        private bool showPointBorder = false;

        /// <summary>
        /// 캡처 가능 여부
        /// </summary>
        private bool canCapture = false;

        /// <summary>
        /// 드래그 여부
        /// </summary>
        private bool isDragging = false;

        /// <summary>
        /// 드래그 시작점
        /// </summary>
        private Point dragStartPoint = Point.Empty;

        /// <summary>
        /// 드래그 종료점
        /// </summary>
        private Point dragEndPoint = new Point(int.MinValue, int.MinValue);

        /// <summary>
        /// 균형 출력 여부
        /// </summary>
        private bool displayProportionally = false;

        #endregion


        #region Wafer 원 - CWaferCircle

        /// <summary>
        /// Wafer 원
        /// </summary>
        public WaferCircle CWaferCircle
        {
            get
            {
                return this.waferCircle;
            }
            set
            {
                if (this.waferCircle == value)
                {
                    return;
                }

                this.waferCircle = value;

                Refresh();
            }
        }

        #endregion
        #region Shot 정보 - ShotInformation

        /// <summary>
        /// Shot 정보
        /// </summary>
        public ShotInformation ShotInformation
        {
            get
            {
                return this.shotInformation;
            }
            set
            {
                if (this.shotInformation == value)
                {
                    return;
                }

                this.shotInformation = value;

                Refresh();
            }
        }

        #endregion
        #region Chip 정보 - ChipInformation

        /// <summary>
        /// Chip 정보
        /// </summary>
        public ChipInformation ChipInformation
        {
            get
            {
                return this.chipInformation;
            }
            set
            {
                if (this.chipInformation == value)
                {
                    return;
                }

                this.chipInformation = value;

                Refresh();
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
            set
            {
                this.waferData = value;

                if (this.waferData == null)
                {
                    this.waferDataRange.Minimum = -1d;
                    this.waferDataRange.Maximum = -1d;
                }
                else
                {
                    this.waferDataRange = this.waferData.Range;

                    if (!this.useUserDefinedRange)
                    {
                        this.drawingRange = this.waferDataRange;
                    }

                    DrawData();
                }
            }
        }

        #endregion
        #region 사용자 그리기 여부 - UseUserDrawing

        /// <summary>
        /// 사용자 그리기 여부
        /// </summary>
        public bool UseUserDrawing
        {
            get
            {
                return this.useUserDrawing;
            }
            set
            {
                if (this.useUserDrawing == value)
                {
                    return;
                }

                this.useUserDrawing = value;

                DrawData();
            }
        }

        #endregion
        #region 사용자 정의 범위 사용 여부 - UseUserDefinedRange

        /// <summary>
        /// 사용자 정의 범위 사용 여부
        /// </summary>
        public bool UseUserDefinedRange
        {
            get
            {
                return this.useUserDefinedRange;
            }
            set
            {
                if (this.useUserDefinedRange == value)
                {
                    return;
                }

                this.useUserDefinedRange = value;

                if (this.useUserDefinedRange)
                {
                    this.drawingRange = this.userDefinedRange;

                    DrawData();
                }
                else
                {
                    this.drawingRange = this.waferDataRange;

                    DrawData();
                }
            }
        }

        #endregion
        #region 사용자 정의 범위 - UserDefinedRange

        /// <summary>
        /// 사용자 정의 범위
        /// </summary>
        public DoubleRange UserDefinedRange
        {
            get
            {
                return this.userDefinedRange;
            }
            set
            {
                if (this.userDefinedRange.Minimum == value.Minimum && this.userDefinedRange.Maximum == value.Maximum)
                {
                    return;
                }

                this.userDefinedRange = value;

                if (this.useUserDefinedRange)
                {
                    this.drawingRange = this.userDefinedRange;

                    DrawData();
                }
            }
        }

        #endregion
        #region 웨이퍼 데이터 범위 - WaferDataRange

        /// <summary>
        /// 웨이퍼 데이터 범위
        /// </summary>
        public DoubleRange WaferDataRange
        {
            get
            {
                return this.waferDataRange;
            }
            set
            {
                if (this.waferDataRange.Minimum == value.Minimum && this.waferDataRange.Maximum == value.Maximum)
                {
                    return;
                }

                this.waferDataRange = value;

                if (!this.useUserDefinedRange)
                {
                    this.drawingRange = this.waferDataRange;

                    DrawData();
                }
            }
        }

        #endregion
        #region 그리기 범위 - DrawingRange

        /// <summary>
        /// 그리기 범위
        /// </summary>
        public DoubleRange DrawingRange
        {
            get
            {
                return this.drawingRange;
            }
            set
            {
                this.drawingRange = value;
            }
        }

        #endregion
        #region 포인트 크기 - PointSize

        /// <summary>
        /// 포인트 크기
        /// </summary>
        public int PointSize
        {
            get
            {
                return this.pointSize;
            }
            set
            {
                if (this.pointSize == value)
                {
                    return;
                }

                this.pointSize = value;

                DrawData();
            }
        }

        #endregion
        #region 포인트 경계 표시 여부 - ShowPointBorder

        /// <summary>
        /// 포인트 경계 표시 여부
        /// </summary>
        public bool ShowPointBorder
        {
            get
            {
                return this.showPointBorder;
            }
            set
            {
                if (this.showPointBorder == value)
                {
                    return;
                }

                this.showPointBorder = value;

                DrawData();
            }
        }

        #endregion
        #region 머리말 제목 - HeaderTitle

        /// <summary>
        /// 머리말 제목
        /// </summary>
        public string HeaderTitle
        {
            get
            {
                return tChart.Header.Text;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    tChart.Header.Visible = false;
                }
                else
                {
                    tChart.Header.Visible = true;
                }

                tChart.Header.Text = value;
            }
        }

        #endregion
        #region 꼬리말 제목 - FooterTitle

        /// <summary>
        /// 꼬리말 제목
        /// </summary>
        public string FooterTitle
        {
            get
            {
                return tChart.Footer.Text;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    tChart.Footer.Visible = false;
                }
                else
                {
                    tChart.Footer.Visible = true;
                }

                tChart.Footer.Text = value;
            }
        }

        #endregion
        #region Capture 가능 여부 - CanCapture

        /// <summary>
        /// Capture 가능 여부
        /// </summary>
        public bool CanCapture
        {
            get
            {
                return this.canCapture;
            }
            set
            {
                this.canCapture = value;

                if (this.canCapture)
                {
                    tChart.Zoom.Allow = false;
                    tChart.Panning.Allow = Steema.TeeChart.ScrollModes.None;

                    Refresh();
                }
                else
                {
                    tChart.Zoom.Allow = true;
                    tChart.Panning.Allow = Steema.TeeChart.ScrollModes.Both;

                    Refresh();
                }
            }
        }

        #endregion
        #region 메뉴 - Menu

        /// <summary>
        /// 메뉴
        /// </summary>
        //public ContextMenuStrip Menu
        //{
        //    get
        //    {
        //        return contextMenu;
        //    }
        //}

        #endregion
        #region 균형 출력 여부 - DisplayProportionally

        /// <summary>
        /// 균형 출력 여부
        /// </summary>
        public bool DisplayProportionally
        {
            get
            {
                return this.displayProportionally;
            }
            set
            {
                if (this.displayProportionally == value)
                {
                    return;
                }

                this.displayProportionally = value;

                OnSizeChanged(EventArgs.Empty);
            }
        }

        #endregion


        public Form2()
        {
            InitializeComponent();

            tChart.Aspect.View3D = false;
            tChart.Axes.Bottom.Automatic = false;
            tChart.Axes.Bottom.AutomaticMaximum = false;
            tChart.Axes.Bottom.AutomaticMinimum = false;
            tChart.Axes.Bottom.AxisPen.Color = Color.Red;
            tChart.Axes.Bottom.AxisPen.Width = 1;
            tChart.Axes.Bottom.Grid.Visible = true;
            tChart.Axes.Bottom.Increment = 10;
            tChart.Axes.Bottom.Labels.Style = Steema.TeeChart.AxisLabelStyle.Value;
            tChart.Axes.Bottom.Maximum = 180d;
            tChart.Axes.Bottom.Minimum = -180d;

            tChart.Axes.Left.Automatic = false;
            tChart.Axes.Left.AutomaticMaximum = false;
            tChart.Axes.Left.AutomaticMinimum = false;
            tChart.Axes.Left.AxisPen.Color = Color.Black;
            tChart.Axes.Left.AxisPen.Width = 1;
            tChart.Axes.Left.Grid.Visible = true;
            tChart.Axes.Left.Increment = 10;
            tChart.Axes.Left.Labels.Style = Steema.TeeChart.AxisLabelStyle.Value;
            tChart.Axes.Left.Maximum = 180d;
            tChart.Axes.Left.Minimum = -180d;

            tChart.Axes.Right.Visible = true;
            tChart.Axes.Top.Visible = true;

            tChart.BackColor = Color.White;
            tChart.Footer.Font.Color = Color.Red;
            tChart.Footer.Font.Size = 10;
            tChart.Header.Font.Color = Color.Blue;
            tChart.Header.Font.Size = 10;

            tChart.Legend.Visible = true;

            tChart.Panel.Bevel.ColorOne = Color.Red;
            tChart.Panel.Bevel.ColorTwo = Color.Yellow;
            tChart.Panel.Brush.Gradient.Visible = false;

            tChart.Walls.Back.Color = Color.Red;
            tChart.Walls.Back.Gradient.Visible = false;
            tChart.Walls.Visible = true;

            tChart.BeforeDrawSeries += new Steema.TeeChart.PaintChartEventHandler(Control_BeforeDrawSeries);
            tChart.AfterDraw += new Steema.TeeChart.PaintChartEventHandler(Control_AfterDraw);

            tChart.Panning.Allow = Steema.TeeChart.ScrollModes.None;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            DataTable sourceTable = GetEmptyTable();

            CreateWaferTableData(sourceTable);

            WaferData waferData = new WaferData(sourceTable);

            this.WaferData = waferData;

        }


        private DataTable GetEmptyTable()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add(new DataColumn("X", typeof(double)));
            dataTable.Columns.Add(new DataColumn("Y", typeof(double)));
            dataTable.Columns.Add(new DataColumn("Z", typeof(double)));

            return dataTable;
        }
        private void CreateWaferTableData(DataTable sourceTable)
        {
            Random random = new Random(DateTime.Now.Millisecond);

            double distance;

            DataRow row = null;

            for (double y = -150; y <= 150; y += 10)
            {
                for (double x = -150; x <= 150; x += 10)
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


            //for (double y = -10; y <= 10; y += 1)
            //{
            //    for (double x = -10; x <= 10; x += 1)
            //    {
            //        //distance = Math.Sqrt(x * x + y * y);

            //        //if (distance > 145d)
            //        //{
            //        //    continue;
            //        //}

            //        row = sourceTable.NewRow();

            //        row[0] = x;
            //        row[1] = y;
            //        row[2] = 0.0;// random.Next(9);

            //        sourceTable.Rows.Add(row);
            //    }
            //}
        }


        #region 차트 데이터 지우기 - ClearChartData()

        /// <summary>
        /// 차트 데이터 지우기
        /// </summary>
        public void ClearChartData()
        {
            tChart.Series.Clear();

            tChart.Tools.Clear();
        }

        #endregion
        #region 데이터 지우기 - ClearData()

        /// <summary>
        /// 데이터 지우기
        /// </summary>
        public void ClearData()
        {
            if (this.waferCircle != null)
            {
                this.waferCircle.ClearData();

                this.waferCircle = null;
            }

            if (this.shotInformation != null)
            {
                this.shotInformation.ClearData();

                this.shotInformation = null;
            }

            if (this.chipInformation != null)
            {
                this.chipInformation.ClearData();

                this.chipInformation = null;
            }

            this.userDefinedRange = null;

            this.waferDataRange = null;

            this.drawingRange = null;

            if (this.waferData != null)
            {
                this.waferData.ClearData();

                this.waferData = null;
            }

            ClearChartData();

            tChart.Axes.Custom.Clear();
        }

        #endregion
        #region 데이터 그리기 - DrawData()

        /// <summary>
        /// 데이터 그리기
        /// </summary>
        public void DrawData()
        {
            ClearChartData();

            //if (this.useUserDrawing)
            //{
            //    if (DrawChartData != null)
            //    {
            //        DrawChartData(this, EventArgs.Empty);
            //    }

            //    return;
            //}

            if (this.waferData == null)
            {
                return;
            }

            if (this.waferData.Count == 0)
            {
                return;
            }

            DrawPointSeries(this.waferData, this.pointSize, this.showPointBorder);
        }

        #endregion

        #region 버블 시리즈 구하기 - GetBubbleSeries(title)

        /// <summary>
        /// 버블 시리즈 구하기
        /// </summary>
        /// <param name="title">제목</param>
        /// <returns>버블 시리즈</returns>
        public Steema.TeeChart.Styles.Bubble GetBubbleSeries(string title)
        {
            Steema.TeeChart.Styles.Bubble bubble = new Steema.TeeChart.Styles.Bubble();

            bubble.Marks.Visible = false;
            bubble.Pointer.Pen.Visible = false;
            bubble.Title = title;

            return bubble;
        }

        #endregion
        #region 포인트 시리즈 구하기 - GetPointSeries(title, pointSize, showPointBorder)

        /// <summary>
        /// 포인트 시리즈 구하기
        /// </summary>
        /// <param name="title">제목</param>
        /// <param name="pointSize">포인트 크기</param>
        /// <param name="showPointBorder">포인트 경계 표시 여부</param>
        /// <returns>포인트 시리즈</returns>
        public Steema.TeeChart.Styles.Points GetPointSeries(string title, int pointSize, bool showPointBorder)
        {
            Steema.TeeChart.Styles.Points points = new Steema.TeeChart.Styles.Points();

            points.ColorEach = false;
            points.Color = Color.FromArgb(68, 102, 163);
            points.LinePen.Color = Color.FromArgb(41, 61, 98);
            points.Marks.Visible = false;
            points.Pointer.Brush.Visible = true;
            points.Pointer.HorizSize = pointSize;
            points.Pointer.VertSize = pointSize;
            points.Pointer.Pen.Visible = showPointBorder;
            points.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            points.Title = title;
            points.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.None;
            points.YValues.Order = Steema.TeeChart.Styles.ValueListOrder.None;

            return points;
        }

        #endregion





        #region 포인트 시리즈 그리기 - DrawPointSeries(waferData, pointSize, showPointBorder)

        /// <summary>
        /// 포인트 시리즈 그리기
        /// </summary>
        /// <param name="tChart">TChart</param>
        /// <param name="waferData">웨이퍼 데이터</param>
        /// <param name="pointSize">포인트 크기</param>
        /// <param name="showPointBorder">포인트 경계 표시 여부</param>
        public void DrawPointSeries(WaferData waferData, int pointSize, bool showPointBorder)
        {
            Steema.TeeChart.Styles.Points points = GetPointSeries(waferData.Title, pointSize, showPointBorder);

            if (this.waferData.UseDataView)
            {
                DataView view = this.waferData.ListTable.DefaultView;

                view.RowFilter = this.waferData.Filter;
                view.Sort = this.waferData.Order;

                for (int i = 0; i < view.Count; i++)
                {
                    points.Add
                    (
                        (double)(view[i][this.waferData.XField]),
                        (double)(view[i][this.waferData.YField]),
                        ColorHelper.GetRangeColor(this.drawingRange.Minimum, this.drawingRange.Maximum, (double)(view[i][this.waferData.ZField]))
                    );
                }

                view.RowFilter = string.Empty;
                view.Sort = string.Empty;
            }
            else
            {
                DataRowCollection rowCollection = this.waferData.ListTable.Rows;

                for (int i = 0; i < rowCollection.Count; i++)
                {
                    points.Add
                    (
                        (double)(rowCollection[i][this.waferData.XField]),
                        (double)(rowCollection[i][this.waferData.YField]),
                        ColorHelper.GetRangeColor(this.drawingRange.Minimum, this.drawingRange.Maximum, (double)(rowCollection[i][this.waferData.ZField]))
                    );
                }
            }

            points.ColorEach = true;

            tChart.Series.Add(points);
        }

        #endregion


        #region 시리즈 그리기 전 처리하기 - Control_BeforeDrawSeries(sender, graphics3D)

        /// <summary>
        /// 시리즈 그리기 전 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="graphics3D">이벤트 인자</param>
        private void Control_BeforeDrawSeries(object sender, Steema.TeeChart.Drawing.Graphics3D graphics3D)
        {
            //Steema.TeeChart.TChart tChart = sender as Steema.TeeChart.TChart;

            DrawWafer(graphics3D);

            DrawShot(graphics3D);

            DrawChip(graphics3D);
        }


        #endregion
        #region 그리기 후 처리하기 - Control_AfterDraw(sender, graphics3D)

        /// <summary>
        /// 그리기 후 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="graphics3D">이벤트 인자</param>
        private void Control_AfterDraw(object sender, Steema.TeeChart.Drawing.Graphics3D graphics3D)
        {
            if (this.canCapture)
            {
                if (this.isDragging)
                {
                    if (this.dragStartPoint == this.dragEndPoint)
                    {
                        return;
                    }

                    if (this.dragEndPoint.X == int.MinValue && this.dragEndPoint.Y == int.MinValue)
                    {
                        return;
                    }

                    graphics3D.Brush.Color = Color.Red;
                    graphics3D.Brush.Visible = false;
                    graphics3D.Pen.Color = Color.Red;
                    graphics3D.Pen.Style = System.Drawing.Drawing2D.DashStyle.Solid;
                    graphics3D.Pen.Width = 1;
                    graphics3D.Pen.Visible = true;

                    graphics3D.Rectangle(this.dragStartPoint.X, this.dragStartPoint.Y, this.dragEndPoint.X, this.dragEndPoint.Y);
                }
            }
        }

        #endregion

        #region Wafer 그리기 - DrawWafer(tChart, graphics3D)

        /// <summary>
        /// Wafer 그리기
        /// </summary>
        /// <param name="tChart">TChart</param>
        /// <param name="graphics3D">Graphics3D</param>
        private void DrawWafer(Steema.TeeChart.Drawing.Graphics3D graphics3D)
        {
            graphics3D.Pen.Color = this.waferCircle.PenColor;
            graphics3D.Pen.Width = this.waferCircle.PenWidth;
            graphics3D.Pen.Transparency = this.waferCircle.Transparency;
            graphics3D.Brush.Color = this.waferCircle.BrushColor;
            graphics3D.Brush.Transparency = this.waferCircle.Transparency;

            graphics3D.Ellipse
            (
                tChart.Axes.Bottom.CalcXPosValue(this.waferCircle.GetLeftPosition()),
                tChart.Axes.Left.CalcYPosValue(this.waferCircle.GetTopPosition()),
                tChart.Axes.Bottom.CalcXPosValue(this.waferCircle.GetRightPosition()),
                tChart.Axes.Left.CalcYPosValue(this.waferCircle.GetBottomPosition())
            );
        }

        #endregion
        #region Shot 그리기 - DrawShot(tChart, graphics3D)

        /// <summary>
        /// Shot 그리기
        /// </summary>
        /// <param name="tChart">TChart</param>
        /// <param name="graphics3D">Graphics3D</param>
        private void DrawShot(Steema.TeeChart.Drawing.Graphics3D graphics3D)
        {
            if (this.shotInformation == null)
            {
                return;
            }

            if (!this.shotInformation.HasShotData)
            {
                return;
            }

            graphics3D.Pen.Color = this.shotInformation.ShotPenColor;
            graphics3D.Pen.Width = this.shotInformation.ShotPenWidth;
            graphics3D.Pen.Transparency = this.shotInformation.ShotTransparency;
            graphics3D.Brush.Color = this.shotInformation.ShotBrushColor;
            graphics3D.Brush.Transparency = this.shotInformation.ShotTransparency;

            for (int i = 0; i < this.shotInformation.ShotCount; i++)
            {
                graphics3D.Rectangle
                (
                    tChart.Axes.Bottom.CalcXPosValue(this.shotInformation.GetShotLeftPosition(i)),
                    tChart.Axes.Left.CalcYPosValue(this.shotInformation.GetShotTopPosition(i)),
                    tChart.Axes.Bottom.CalcXPosValue(this.shotInformation.GetShotRightPosition(i)),
                    tChart.Axes.Left.CalcYPosValue(this.shotInformation.GetShotBottomPosition(i))
                );
            }
        }

        #endregion
        #region Chip 그리기 - DrawChip(tChart, graphics3D)

        /// <summary>
        /// Chip 그리기
        /// </summary>
        /// <param name="tChart">TChart</param>
        /// <param name="graphics3D">Graphics3D</param>
        private void DrawChip(Steema.TeeChart.Drawing.Graphics3D graphics3D)
        {
            if (this.chipInformation == null)
            {
                return;
            }

            if (!this.chipInformation.HasChipData)
            {
                return;
            }

            graphics3D.Pen.Color = this.chipInformation.ChipPenColor;
            graphics3D.Pen.Width = this.chipInformation.ChipPenWidth;
            graphics3D.Pen.Transparency = this.chipInformation.ChipTransparency;
            graphics3D.Brush.Color = this.chipInformation.ChipBrushColor;
            graphics3D.Brush.Transparency = this.chipInformation.ChipTransparency;

            for (int i = 0; i < this.chipInformation.ChipCount; i++)
            {
                graphics3D.Rectangle
                (
                    tChart.Axes.Bottom.CalcXPosValue(this.chipInformation.GetChipLeftPosition(i)),
                    tChart.Axes.Left.CalcYPosValue(this.chipInformation.GetChipTopPosition(i)),
                    tChart.Axes.Bottom.CalcXPosValue(this.chipInformation.GetChipRightPosition(i)),
                    tChart.Axes.Left.CalcYPosValue(this.chipInformation.GetChipBottomPosition(i))
                );
            }
        }

        #endregion
    }
}
