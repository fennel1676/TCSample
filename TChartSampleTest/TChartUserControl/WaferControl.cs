using Steema.TeeChart;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace TChartSampleTest
{
    /// <summary>
    /// 웨이퍼 컨트롤
    /// </summary>
    public partial class WaferControl : Steema.TeeChart.TChart
    {
        //////////////////////////////////////////////////////////////////////////////////////////////////// Declaration
        ////////////////////////////////////////////////////////////////////////////////////////// Public

        #region Event

        /// <summary>
        /// 차트 데이터 그리기 이벤트
        /// </summary>
        public event EventHandler DrawChartData;

        /// <summary>
        /// 시리즈 클릭 이벤트
        /// </summary>
        public event ClickChartSeriesEventHandler ClickChartSeries;

        /// <summary>
        /// 데이터 저장하기 이벤트
        /// </summary>
        public event SaveDataEventHandler SaveData;

        /// <summary>
        /// 데이터 복사하기 이벤트
        /// </summary>
        public event CopyDataEventHandler CopyData;

        #endregion

        //////////////////////////////////////////////////////////////////////////////////////////////////// Field
        ////////////////////////////////////////////////////////////////////////////////////////// Private

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

        //////////////////////////////////////////////////////////////////////////////////////////////////// Property
        ////////////////////////////////////////////////////////////////////////////////////////// Public

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
                if(this.waferCircle == value)
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
                if(this.shotInformation == value)
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
                if(this.chipInformation == value)
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

                if(this.waferData == null)
                {
                    this.waferDataRange.Minimum = -1d;
                    this.waferDataRange.Maximum = -1d;
                }
                else
                {
                    this.waferDataRange = this.waferData.Range;

                    if(!this.useUserDefinedRange)
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
                if(this.useUserDrawing == value)
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
                if(this.useUserDefinedRange == value)
                {
                    return;
                }

                this.useUserDefinedRange = value;

                if(this.useUserDefinedRange)
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
                if(this.userDefinedRange.Minimum == value.Minimum && this.userDefinedRange.Maximum == value.Maximum)
                {
                    return;
                }

                this.userDefinedRange = value;

                if(this.useUserDefinedRange)
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
                if(this.waferDataRange.Minimum == value.Minimum && this.waferDataRange.Maximum == value.Maximum)
                {
                    return;
                }

                this.waferDataRange = value;

                if(!this.useUserDefinedRange)
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
                if(this.pointSize == value)
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
                if(this.showPointBorder == value)
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
                return Header.Text;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    Header.Visible = false;
                }
                else
                {
                    Header.Visible = true;
                }

                Header.Text = value;
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
                return Footer.Text;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    Footer.Visible = false;
                }
                else
                {
                    Footer.Visible = true;
                }

                Footer.Text = value;
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

                if(this.canCapture)
                {
                    Zoom.Allow    = false;
                    Panning.Allow = Steema.TeeChart.ScrollModes.None;

                    Refresh();
                }
                else
                {
                    Zoom.Allow    = true;
                    Panning.Allow = Steema.TeeChart.ScrollModes.Both;

                    Refresh();
                }
            }
        }

        #endregion
        #region 메뉴 - Menu

        /// <summary>
        /// 메뉴
        /// </summary>
        public ContextMenuStrip Menu
        {
            get
            {
                return contextMenu;
            }
        }

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
                if(this.displayProportionally == value)
                {
                    return;
                }

                this.displayProportionally = value;

                OnSizeChanged(EventArgs.Empty);
            }
        }

        #endregion

        //////////////////////////////////////////////////////////////////////////////////////////////////// Constructor
        ////////////////////////////////////////////////////////////////////////////////////////// Public

        #region 생성자 - WaferControl()

        /// <summary>
        /// 생성자
        /// </summary>
        public WaferControl()
        {
            InitializeComponent();

            Aspect.View3D                   = false;
            Axes.Bottom.Automatic           = false;
            Axes.Bottom.AutomaticMaximum    = false;
            Axes.Bottom.AutomaticMinimum    = false;
            Axes.Bottom.AxisPen.Color       = Color.Black;
            Axes.Bottom.AxisPen.Width       = 1;
            Axes.Bottom.Grid.Visible        = false;
            Axes.Bottom.Increment           = 50;
            Axes.Bottom.Labels.Style        = Steema.TeeChart.AxisLabelStyle.Value;
            Axes.Bottom.Maximum             = 180d;
            Axes.Bottom.Minimum             = -180d;
            Axes.Left.Automatic             = false;
            Axes.Left.AutomaticMaximum      = false;
            Axes.Left.AutomaticMinimum      = false;
            Axes.Left.AxisPen.Color         = Color.Black;
            Axes.Left.AxisPen.Width         = 1;
            Axes.Left.Grid.Visible          = false;
            Axes.Left.Increment             = 50;
            Axes.Left.Labels.Style          = Steema.TeeChart.AxisLabelStyle.Value;
            Axes.Left.Maximum               = 180d;
            Axes.Left.Minimum               = -180d;
            Axes.Right.Visible              = false;
            Axes.Top.Visible                = false;
            BackColor                       = Color.White;
            Footer.Font.Color               = Color.Red;
            Footer.Font.Size                = 10;
            Header.Font.Color               = Color.Blue;
            Header.Font.Size                = 10;
            Legend.Visible                  = false;
            Panel.Bevel.ColorOne            = Color.Black;
            Panel.Bevel.ColorTwo            = Color.Black;
            Panel.Brush.Gradient.Visible    = false;
            Walls.Back.Color                = Color.Transparent;
            Walls.Back.Gradient.Visible     = false;
            Walls.Visible                   = true;

            BeforeDrawSeries += new Steema.TeeChart.PaintChartEventHandler(Control_BeforeDrawSeries);
            AfterDraw        += new Steema.TeeChart.PaintChartEventHandler(Control_AfterDraw);
            Zoomed           += new EventHandler(Control_Zoomed);
            UndoneZoom       += new EventHandler(Control_UndoneZoom);
            ClickSeries      += new SeriesEventHandler(Control_ClickSeries);

            Panning.Allow = Steema.TeeChart.ScrollModes.None;
        }

        #endregion

        //////////////////////////////////////////////////////////////////////////////////////////////////// Method
        ////////////////////////////////////////////////////////////////////////////////////////// Public
        //////////////////////////////////////////////////////////////////////////////// Method

        #region 차트 데이터 지우기 - ClearChartData()

        /// <summary>
        /// 차트 데이터 지우기
        /// </summary>
        public void ClearChartData()
        {
            Series.Clear();

            Tools.Clear();
        }

        #endregion
        #region 데이터 지우기 - ClearData()

        /// <summary>
        /// 데이터 지우기
        /// </summary>
        public void ClearData()
        {
            if(this.waferCircle != null)
            {
                this.waferCircle.ClearData();

                this.waferCircle = null;
            }

            if(this.shotInformation != null)
            {
                this.shotInformation.ClearData();

                this.shotInformation = null;
            }

            if(this.chipInformation != null)
            {
                this.chipInformation.ClearData();

                this.chipInformation = null;
            }

            this.userDefinedRange = null;

            this.waferDataRange = null; 

            this.drawingRange = null;

            if(this.waferData != null)
            {
                this.waferData.ClearData();

                this.waferData = null;
            }

            ClearChartData();

            Axes.Custom.Clear();
        }

        #endregion
        #region 데이터 그리기 - DrawData()

        /// <summary>
        /// 데이터 그리기
        /// </summary>
        public void DrawData()
        {
            ClearChartData();

            if(this.useUserDrawing)
            {
                if(DrawChartData != null)
                {
                    DrawChartData(this, EventArgs.Empty);
                }

                return;
            }

            if(this.waferData == null)
            {
                return;
            }

            if(this.waferData.Count == 0)
            {
                return;
            }

            DrawPointSeries(this, this.waferData, this.pointSize, this.showPointBorder);
        }

        #endregion

        ////////////////////////////////////////////////////////////////////// GetSeries...

        #region 버블 시리즈 구하기 - GetBubbleSeries(title)

        /// <summary>
        /// 버블 시리즈 구하기
        /// </summary>
        /// <param name="title">제목</param>
        /// <returns>버블 시리즈</returns>
        public Steema.TeeChart.Styles.Bubble GetBubbleSeries(string title)
        {
            Steema.TeeChart.Styles.Bubble bubble = new Steema.TeeChart.Styles.Bubble();

            bubble.Marks.Visible       = false;
            bubble.Pointer.Pen.Visible = false;
            bubble.Title               = title;

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

            points.ColorEach             = false;
            points.Color                 = Color.FromArgb(68, 102, 163);
            points.LinePen.Color         = Color.FromArgb(41, 61, 98);
            points.Marks.Visible         = false;
            points.Pointer.Brush.Visible = true;
            points.Pointer.HorizSize     = pointSize;
            points.Pointer.VertSize      = pointSize;
            points.Pointer.Pen.Visible   = showPointBorder;
            points.Pointer.Style         = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            points.Title                 = title;
            points.XValues.Order         = Steema.TeeChart.Styles.ValueListOrder.None;
            points.YValues.Order         = Steema.TeeChart.Styles.ValueListOrder.None;
            
            return points;
        }

        #endregion

        ////////////////////////////////////////////////////////////////////// DrawSeries...

        #region 포인트 시리즈 그리기 - DrawPointSeries(tChart, waferData, pointSize, showPointBorder)

        /// <summary>
        /// 포인트 시리즈 그리기
        /// </summary>
        /// <param name="tChart">TChart</param>
        /// <param name="waferData">웨이퍼 데이터</param>
        /// <param name="pointSize">포인트 크기</param>
        /// <param name="showPointBorder">포인트 경계 표시 여부</param>
        public void DrawPointSeries(Steema.TeeChart.TChart tChart, WaferData waferData, int pointSize, bool showPointBorder)
        {
            Steema.TeeChart.Styles.Points points = GetPointSeries(waferData.Title, pointSize, showPointBorder);

            if(this.waferData.UseDataView)
            {
                DataView view = this.waferData.ListTable.DefaultView;

                view.RowFilter = this.waferData.Filter;
                view.Sort      = this.waferData.Order;

                for(int i = 0; i < view.Count; i++)
                {
                    points.Add
                    (
                        (double)(view[i][this.waferData.XField]),
                        (double)(view[i][this.waferData.YField]),
                        ColorHelper.GetRangeColor(this.drawingRange.Minimum, this.drawingRange.Maximum, (double)(view[i][this.waferData.ZField]))
                    );
                }

                view.RowFilter = string.Empty;
                view.Sort      = string.Empty;
            }
            else
            {
                DataRowCollection rowCollection = this.waferData.ListTable.Rows;

                for(int i = 0; i < rowCollection.Count; i++)
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

        ////////////////////////////////////////////////////////////////////////////////////////// Protected

        #region 크기 변경시 처리하기 - OnSizeChanged(e)

        /// <summary>
        /// 크기 변경시 처리하기
        /// </summary>
        /// <param name="e">이벤트 인자</param>
        protected override void OnSizeChanged(EventArgs e)
        {
            double width  = Convert.ToDouble(Width);
            double height = Convert.ToDouble(Height);

            if(this.displayProportionally)
            {
                if(width / height != 400d / 429d)
                {
                    height = width * 429d / 400d;
                }

                Height = Convert.ToInt32(height);

                PointSize = Math.Max(1, Convert.ToInt32(width / 425d + 0.5d));
            };

            base.OnSizeChanged(e);
        }

        #endregion
        #region 마우스 버튼 눌림시 처리하기 - OnMouseDown(e)

        /// <summary>
        /// 마우스 버튼 눌림시 처리하기
        /// </summary>
        /// <param name="e">이벤트 인자</param>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if(this.canCapture)
            {
                this.isDragging = true;

                this.dragStartPoint = e.Location;

                Refresh();
            }

            base.OnMouseDown(e);
        }

        #endregion
        #region 마우스 이동시 처리하기 - OnMouseMove(e)

        /// <summary>
        /// 마우스 이동시 처리하기
        /// </summary>
        /// <param name="e">이벤트 인자</param>
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if(this.canCapture)
            {
                if(this.isDragging)
                {
                    this.dragEndPoint = e.Location;

                    Refresh();
                }
            }

            base.OnMouseMove(e);
        }

        #endregion
        #region 마우스 버튼 눌림 해제시 처리하기 - OnMouseUp(e)

        /// <summary>
        /// 마우스 버튼 눌림 해제시 처리하기
        /// </summary>
        /// <param name="e">이벤트 인자</param>
        protected override void OnMouseUp(MouseEventArgs e)
        {
            if(this.canCapture)
            {
                this.dragEndPoint = e.Location;

                this.isDragging = false;

                Refresh();

                CapturePoint(this.dragStartPoint, this.dragEndPoint);

                this.dragStartPoint = Point.Empty;
                this.dragEndPoint   = new Point(int.MinValue, int.MinValue);
            }

            base.OnMouseUp(e);
        }

        #endregion
        #region 마우스 클릭시 처리하기 - OnMouseClick(e)

        /// <summary>
        /// 마우스 클릭시 처리하기
        /// </summary>
        /// <param name="e">이벤트 인자</param>
        protected override void OnMouseClick(MouseEventArgs e)
        {
            if(this.canCapture)
            {
                return;
            }

            if(e.Button == MouseButtons.Right)
            {
                if(!Zoom.Zoomed)
                {
                    contextMenu.Show(this, e.Location);
                }
            }

            base.OnMouseClick(e);
        }

        #endregion

        ////////////////////////////////////////////////////////////////////////////////////////// Private
        //////////////////////////////////////////////////////////////////////////////// Event

        #region 시리즈 그리기 전 처리하기 - Control_BeforeDrawSeries(sender, graphics3D)

        /// <summary>
        /// 시리즈 그리기 전 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="graphics3D">이벤트 인자</param>
        private void Control_BeforeDrawSeries(object sender, Steema.TeeChart.Drawing.Graphics3D graphics3D)
        {
            Steema.TeeChart.TChart tChart = sender as Steema.TeeChart.TChart;

            DrawWafer(tChart, graphics3D);

            DrawShot(tChart, graphics3D);

            DrawChip(tChart, graphics3D);
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
            if(this.canCapture)
            {
                if(this.isDragging)
                {
                    if(this.dragStartPoint == this.dragEndPoint)
                    {
                        return;
                    }

                    if(this.dragEndPoint.X == int.MinValue && this.dragEndPoint.Y == int.MinValue)
                    {
                        return;
                    }

                    graphics3D.Brush.Color   = Color.Red;
                    graphics3D.Brush.Visible = false;
                    graphics3D.Pen.Color     = Color.Red;
                    graphics3D.Pen.Style     = System.Drawing.Drawing2D.DashStyle.Solid;
                    graphics3D.Pen.Width     = 1;
                    graphics3D.Pen.Visible   = true;
                    
                    graphics3D.Rectangle(this.dragStartPoint.X, this.dragStartPoint.Y, this.dragEndPoint.X, this.dragEndPoint.Y);
                }
            }
        }

        #endregion        
        #region 확대시 처리하기 - Control_Zoomed(sender, e)

        /// <summary>
        /// 확대시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void Control_Zoomed(object sender, EventArgs e)
        {
            Panning.Allow = Steema.TeeChart.ScrollModes.Both;
        }

        #endregion
        #region 확대 취소시 처리하기 - Control_UndoneZoom(sender, e)

        /// <summary>
        /// 확대 취소시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void Control_UndoneZoom(object sender, EventArgs e)
        {
            Panning.Allow = Steema.TeeChart.ScrollModes.None;
        }

        #endregion
        #region 시리즈 클릭시 처리하기 - Control_ClickSeries(sender, series, valueIndex, e)

        /// <summary>
        /// 시리즈 클릭시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="series">시리즈</param>
        /// <param name="valueIndex">값 인덱스</param>
        /// <param name="e">이벤트 인자</param>
        private void Control_ClickSeries(object sender, Steema.TeeChart.Styles.Series series, int valueIndex, MouseEventArgs e)
        {
            if(ClickChartSeries != null)
            {
                ClickChartSeries
                (
                    this,
                    new ClickChartSeriesEventArgs(this.useUserDrawing, this.waferData, valueIndex)
                );
            } 
        }

        #endregion

        #region 데이터 저장하기 메뉴 항목 클릭시 처리하기 - saveDataMenuItem_Click(sender, e)

        /// <summary>
        /// 데이터 저장하기 메뉴 항목 클릭시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void saveDataMenuItem_Click(object sender, EventArgs e)
        {
            if(SaveData != null)
            {
                SaveData(this, new SaveDataEventArgs(this.waferData));
            }
        }

        #endregion
        #region 클립보드에 데이터 복사하기 메뉴 항목 클릭시 처리하기 - copyDataToClipboardMenuItem_Click(sender, e)

        /// <summary>
        /// 클립보드에 데이터 복사하기 메뉴 항목 클릭시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void copyDataToClipboardMenuItem_Click(object sender, EventArgs e)
        {
            if(CopyData != null)
            {
                CopyData(this, new CopyDataEventArgs(this.waferData));
            }
        }

        #endregion
        #region 이미지 저장하기 메뉴 항목 클릭시 처리하기 - saveImageMenuItem_Click(sender, e)

        /// <summary>
        /// 이미지 저장하기 메뉴 항목 클릭시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void saveImageMenuItem_Click(object sender, EventArgs e)
        {
        }

        #endregion
        #region 클립보드에 이미지 복사하기 메뉴 항목 클릭시 처리하기 - copyImageToClipboardMenuItem_Click(sender, e)

        /// <summary>
        /// 클립보드에 이미지 복사하기 메뉴 항목 클릭시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void copyImageToClipboardMenuItem_Click(object sender, EventArgs e)
        {
        }

        #endregion

        //////////////////////////////////////////////////////////////////////////////// Function
        ////////////////////////////////////////////////////////////////////// Draw...

        #region Wafer 그리기 - DrawWafer(tChart, graphics3D)

        /// <summary>
        /// Wafer 그리기
        /// </summary>
        /// <param name="tChart">TChart</param>
        /// <param name="graphics3D">Graphics3D</param>
        private void DrawWafer(Steema.TeeChart.TChart tChart, Steema.TeeChart.Drawing.Graphics3D graphics3D)
        {
            graphics3D.Pen.Color          = this.waferCircle.PenColor;
            graphics3D.Pen.Width          = this.waferCircle.PenWidth;
            graphics3D.Pen.Transparency   = this.waferCircle.Transparency;
            graphics3D.Brush.Color        = this.waferCircle.BrushColor;
            graphics3D.Brush.Transparency = this.waferCircle.Transparency;

            graphics3D.Ellipse
            (
                tChart.Axes.Bottom.CalcXPosValue(this.waferCircle.GetLeftPosition  ()),
                tChart.Axes.Left.CalcYPosValue  (this.waferCircle.GetTopPosition   ()),
                tChart.Axes.Bottom.CalcXPosValue(this.waferCircle.GetRightPosition ()),
                tChart.Axes.Left.CalcYPosValue  (this.waferCircle.GetBottomPosition())
            );
        }

        #endregion
        #region Shot 그리기 - DrawShot(tChart, graphics3D)

        /// <summary>
        /// Shot 그리기
        /// </summary>
        /// <param name="tChart">TChart</param>
        /// <param name="graphics3D">Graphics3D</param>
        private void DrawShot(Steema.TeeChart.TChart tChart, Steema.TeeChart.Drawing.Graphics3D graphics3D)
        {
            if(this.shotInformation == null)
            {
                return;
            }

            if(!this.shotInformation.HasShotData)
            {
                return;
            }

            graphics3D.Pen.Color          = this.shotInformation.ShotPenColor;
            graphics3D.Pen.Width          = this.shotInformation.ShotPenWidth;
            graphics3D.Pen.Transparency   = this.shotInformation.ShotTransparency;
            graphics3D.Brush.Color        = this.shotInformation.ShotBrushColor;
            graphics3D.Brush.Transparency = this.shotInformation.ShotTransparency;

            for(int i = 0; i < this.shotInformation.ShotCount; i++)
            {
                graphics3D.Rectangle
                (
                    tChart.Axes.Bottom.CalcXPosValue(this.shotInformation.GetShotLeftPosition  (i)),
                    tChart.Axes.Left.CalcYPosValue  (this.shotInformation.GetShotTopPosition   (i)),
                    tChart.Axes.Bottom.CalcXPosValue(this.shotInformation.GetShotRightPosition (i)),
                    tChart.Axes.Left.CalcYPosValue  (this.shotInformation.GetShotBottomPosition(i))
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
        private void DrawChip(Steema.TeeChart.TChart tChart, Steema.TeeChart.Drawing.Graphics3D graphics3D)
        {
            if(this.chipInformation == null)
            {
                return;
            }

            if(!this.chipInformation.HasChipData)
            {
                return;
            }

            graphics3D.Pen.Color          = this.chipInformation.ChipPenColor;
            graphics3D.Pen.Width          = this.chipInformation.ChipPenWidth;
            graphics3D.Pen.Transparency   = this.chipInformation.ChipTransparency;
            graphics3D.Brush.Color        = this.chipInformation.ChipBrushColor;
            graphics3D.Brush.Transparency = this.chipInformation.ChipTransparency;

            for(int i = 0; i < this.chipInformation.ChipCount; i++)
            {
                graphics3D.Rectangle
                (
                    tChart.Axes.Bottom.CalcXPosValue(this.chipInformation.GetChipLeftPosition  (i)),
                    tChart.Axes.Left.CalcYPosValue  (this.chipInformation.GetChipTopPosition   (i)),
                    tChart.Axes.Bottom.CalcXPosValue(this.chipInformation.GetChipRightPosition (i)),
                    tChart.Axes.Left.CalcYPosValue  (this.chipInformation.GetChipBottomPosition(i))
                );
            }
        }

        #endregion

        ////////////////////////////////////////////////////////////////////// Others

        #region Point 캡처하기 - CapturePoint(dragStartPoint, dragEndPoint)

        /// <summary>
        /// Point 캡처하기
        /// </summary>
        /// <param name="dragStartPoint">드래그 시작점</param>
        /// <param name="dragEndPoint">드래그 종료점</param>
        private void CapturePoint(Point dragStartPoint, Point dragEndPoint)
        {

        }

        #endregion
    }
}