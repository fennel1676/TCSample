using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Steema.TeeChart;
using Steema.TeeChart.Styles;

namespace TChartSampleTest
{
    public partial class Form11 : Form
    {
        public FieldInfo g_field = new FieldInfo();
        public double waferRadius = 100d;
        public double fieldRadius = 50d;

        List<Shape> fieldShapeList = new List<Shape>();
        List<Shape> dieShapeList = new List<Shape>();
        List<Shape> dieSpecShapeList = new List<Shape>();

        private Steema.TeeChart.Styles.Points specPoints = null;

        public int fieldXMinIndex = 0;
        public int fieldXMaxIndex = 0;
        public int fieldYMinIndex = 0;
        public int fieldYMaxIndex = 0;

        SortedList<int, Tuple<double, double>> fieldXIndex = new SortedList<int, Tuple<double, double>>();
        SortedList<int, Tuple<double, double>> fieldYIndex = new SortedList<int, Tuple<double, double>>();

        public Form11()
        {
            InitializeComponent();

            
        }

        private void Form11_Load(object sender, EventArgs e)
        {        
            tChart.Series.Clear();
            tChart.Tools.Clear();

            tChart.Aspect.View3D = false;
            tChart.Panel.Color = Color.White;
            tChart.Panel.MarginBottom = 4;
            tChart.Panel.MarginLeft = 4;
            tChart.Panel.MarginRight = 4;
            tChart.Panel.MarginTop = 4;
            tChart.Panel.MarginUnits = PanelMarginUnits.Pixels;
            tChart.Panel.Pen.Visible = false;
            tChart.Panel.Gradient.Visible = false;
            tChart.Panel.Bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.None;
            tChart.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;

            tChart.Walls.Visible = false;
            tChart.Walls.Back.Gradient.Visible = false;
            tChart.Walls.Back.Color = Color.Transparent;

            tChart.Header.Visible = false;
            tChart.SubHeader.Visible = false;
            tChart.Footer.Visible = false;
            tChart.SubFooter.Visible = false;

            tChart.Axes.Left.Title.Visible = false;
            tChart.Axes.Left.AxisPen.Visible = false;
            tChart.Axes.Left.MinorTicks.Visible = false;
            tChart.Axes.Left.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            tChart.Axes.Left.MaximumOffset = 0;
            tChart.Axes.Left.MinimumOffset = 0;
            tChart.Axes.Left.Automatic = false;
            tChart.Axes.Left.AutomaticMaximum = false;
            tChart.Axes.Left.AutomaticMinimum = false;
            tChart.Axes.Left.Increment = 1;
            tChart.Axes.Left.Labels.Style = AxisLabelStyle.None;
            tChart.Axes.Left.Labels.Pen.Color = Color.White;
            tChart.Axes.Left.Labels.Font.Color = Color.White;
            //tChart.Axes.Left.Labels.ValueFormat = "#.0";
            tChart.Axes.Left.Labels.Visible = false;

            tChart.Axes.Bottom.Title.Visible = false;
            tChart.Axes.Bottom.AxisPen.Visible = false;
            tChart.Axes.Bottom.MinorTicks.Visible = false;
            tChart.Axes.Bottom.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            tChart.Axes.Bottom.MaximumOffset = 0;
            tChart.Axes.Bottom.MinimumOffset = 0;
            tChart.Axes.Bottom.Automatic = false;
            tChart.Axes.Bottom.AutomaticMaximum = false;
            tChart.Axes.Bottom.AutomaticMinimum = false;
            tChart.Axes.Bottom.Increment = 1;
            tChart.Axes.Bottom.Labels.Style = AxisLabelStyle.None;
            tChart.Axes.Bottom.Labels.Pen.Color = Color.White;
            tChart.Axes.Bottom.Labels.Font.Color = Color.White;
            //tChart.Axes.Bottom.Labels.ValueFormat = "#.0";
            tChart.Axes.Bottom.Labels.Visible = false;

            tChart.Legend.Visible = false;

            InitWaferChart();


            //double a = 0d;
            //double b = 300d;
            //double c = 150d;
            //double d = 5000d;
            //double e1 = 10000d;

            //double result = Calculate_ZeroSpan_HighLow_Scale(a, b, c, d, e1);

        }

        private void SetAxes()
        {
            //double bottomMin = g_field.offset_x - g_field.pitch_x / 2;
            //double bottomMax = g_field.offset_x + g_field.pitch_x / 2;

            //double leftMin = g_field.offset_y - g_field.pitch_y / 2;
            //double leftMax = g_field.offset_y + g_field.pitch_y / 2;

            //while (bottomMin > -waferRadius)
            //{
            //    bottomMin -= g_field.pitch_x;
            //    fieldXMinIndex--;
            //}

            //while (bottomMax < waferRadius)
            //{
            //    bottomMax += g_field.pitch_x;
            //    fieldXMaxIndex++;
            //}

            //while (leftMin > -waferRadius)
            //{
            //    leftMin -= g_field.pitch_y;
            //    fieldYMinIndex--;
            //}

            //while (leftMax < waferRadius)
            //{
            //    leftMax += g_field.pitch_y;
            //    fieldYMaxIndex++;
            //}

            //bottomMin += g_field.offset_x;
            //bottomMax += g_field.offset_x;

            //leftMin += g_field.offset_y;
            //leftMax += g_field.offset_y;

            //Axis bottomAxis = tChart.Axes.Bottom;
            //bottomAxis.Increment = g_field.pitch_x;
            //bottomAxis.SetMinMax(bottomMin, bottomMax);

            //Axis leftAxis = tChart.Axes.Left;
            //leftAxis.Increment = g_field.pitch_y;
            //leftAxis.SetMinMax(leftMin, leftMax);


            Axis bottomAxis = tChart.Axes.Bottom;
            bottomAxis.Increment = 1;// g_field.pitch_x;
            bottomAxis.SetMinMax(-70, 70);

            Axis leftAxis = tChart.Axes.Left;
            leftAxis.Increment = 1;// g_field.pitch_y;
            leftAxis.SetMinMax(-70, 70);
        }

        public void InitWaferChart()
        {
           // tChart.AutoRepaint = false;

            tChart.Series.Clear();
            tChart.Tools.Clear();
            tChart.Axes.Custom.Clear();

            fieldShapeList.Clear();
            dieShapeList.Clear();
            dieSpecShapeList.Clear();


            double fieldXPos = 0.0;
            double fieldYPos = 0.0;


            SortedList fieldXList = new SortedList();
            SortedList fieldYList = new SortedList();


            //SetAxes();

            //for (int i = fieldXMinIndex; i <= fieldXMaxIndex; i++)
            //{
            //    double xTemp = xVal + (g_field.pitch_x * i);
            //    fieldXList.Add(i, xTemp);
            //}

            //for (int i = fieldYMinIndex; i <= fieldYMaxIndex; i++)
            //{
            //    double yTemp = yVal + (g_field.pitch_y * i);
            //    fieldYList.Add(i, yTemp);
            //}

            //for (int indexX = fieldXMinIndex; indexX <= fieldXMaxIndex; indexX++)
            //{
            //    for (int indexY = fieldYMinIndex; indexY <= fieldYMaxIndex; indexY++)
            //    {
            //        if (double.TryParse(fieldXList[indexX].ToString(), out fieldXPos) &&
            //            double.TryParse(fieldYList[indexY].ToString(), out fieldYPos))
            //        {

            //g_field.offset_x = 0;
            //g_field.offset_y = -5.74;
            //g_field.pitch_x = 25.34;
            //g_field.pitch_y = 30.42;
            //g_field.shot_x_count = 2;
            //g_field.shot_y_count = 6;


            int indexX = 0;
            int indexY = 0;

            //g_field.offset_x = 0;
            //g_field.offset_y = -4.1545;
            //g_field.pitch_x = 22.896;
            //g_field.pitch_y = 25.131;
            //g_field.shot_x_count = 4;
            //g_field.shot_y_count = 3;

            g_field.offset_x = 11.796;
            g_field.offset_y = 4.3175;
            g_field.pitch_x = 23.592;
            g_field.pitch_y = 32.735;
            g_field.shot_x_count = 6;
            g_field.shot_y_count = 5;

            //g_field.offset_x = 0;
            //g_field.offset_y = -5.74;
            //g_field.pitch_x = 25.34;
            //g_field.pitch_y = 30.42;
            //g_field.shot_x_count = 2;
            //g_field.shot_y_count = 6;

            // double dieXSize = (g_field.pitch_x / g_field.shot_x_count) * 2;
            // double dieYSize = (g_field.pitch_y / g_field.shot_y_count) * 2;

            int chartBottom = tChart.Chart.ChartRect.Bottom;
            int chartLeft = tChart.Chart.ChartRect.Left;



            int sizex = tChart.Panel.Width;
            int sizey = tChart.Panel.Height;

            double xVal = g_field.offset_x - 0;
            double yVal = g_field.offset_y - 0;



            Axis bottomAxis = tChart.Axes.Bottom;
            bottomAxis.Increment =  g_field.pitch_x;
            bottomAxis.SetMinMax(-fieldRadius, fieldRadius);

            Axis leftAxis = tChart.Axes.Left;
            leftAxis.Increment =  g_field.pitch_y;
            leftAxis.SetMinMax(-fieldRadius, fieldRadius);

            //double fieldX01 = -50d;
            //double fieldX11 = 50d;
            //double fieldY01 = -50d;
            //double fieldY11 = 50d;


            //double fieldX0 = 50 + g_field.offset_x - g_field.pitch_x / 2;
            //double fieldX1 = 50 + g_field.offset_x + g_field.pitch_x / 2;
            //double fieldY0 = 50 + g_field.offset_y - g_field.pitch_y / 2;
            //double fieldY1 = 50 + g_field.offset_y + g_field.pitch_y / 2;

            double fieldX0 = -fieldRadius;
            double fieldX1 = fieldRadius;
            double fieldY0 = -fieldRadius;
            double fieldY1 = fieldRadius;

            double dieXSize = (fieldRadius / g_field.shot_x_count) * 2;
            double dieYSize = (fieldRadius / g_field.shot_y_count) * 2;


            //die 추가
            for (int countX = 0; countX < g_field.shot_x_count; countX++)
            {
                double dieXPos = fieldX0 + (dieXSize * countX);

                for (int countY = 0; countY < g_field.shot_y_count; countY++)
                {
                    double dieYPos = fieldY0 + (dieYSize * countY);

                    Shape dieShape = GetDieShapeSeries(string.Format("{0},{1}", countX, countY), dieXPos, dieXPos + dieXSize, dieYPos, dieYPos + dieYSize);
                    tChart.Series.Add(dieShape);
                    dieShapeList.Add(dieShape);
                }                           
            }

            fieldXIndex.Add(indexX, new Tuple<double, double>(fieldX0, fieldX1));
            fieldYIndex.Add(indexY, new Tuple<double, double>(fieldY0, fieldY1));


            //Shape fieldShape = GetFieldShapeSeries(string.Format("{0},{1}", indexX, indexY), fieldX0, fieldX1, fieldY0, fieldY1);
            //tChart.Series.Add(fieldShape);
            //dieSpecShapeList.Add(fieldShape);

            //if (fieldXIndex.Keys.Contains(indexX) == false)
            //            {
            //                fieldXIndex.Add(indexX, new Tuple<double, double>(fieldX0, fieldX1));
            //            }

            //            if (fieldYIndex.Keys.Contains(indexY) == false)
            //            {
            //                fieldYIndex.Add(indexY, new Tuple<double, double>(fieldY0, fieldY1));
            //            }
            //        }
            //    }
            //}

            //tChart.AutoRepaint = true;
            //tChart.Refresh();
        }









        private void tChart1_AfterDraw(object sender, Steema.TeeChart.Drawing.Graphics3D g)
        {
            string textOut = string.Empty;
            int posItem1 = 0;
            int posItem2 = 0;
            int textHeight = 0;
            int textWidth = 0;

            //g.Font.Name = "arial";
            //g.Font.Size = 8;
            //g.Font.Bold = true;
            //g.Font.Color = Color.Red;
            //g.Pen.Color = Color.Green;
            //g.Pen.Width = 1;

            int chartBottom = tChart.Chart.ChartRect.Bottom;
            int chartLeft = tChart.Chart.ChartRect.Left;

            //x
            //foreach (KeyValuePair<int, Tuple<double, double>> field in fieldXIndex)
            //{
            //    textOut = field.Key.ToString();
            //    textHeight = Convert.ToInt32(g.TextHeight(textOut));
            //    textWidth = Convert.ToInt32(g.TextWidth(textOut));

            //    posItem1 = tChart.Axes.Bottom.CalcXPosValue(field.Value.Item1);
            //    posItem2 = tChart.Axes.Bottom.CalcXPosValue(field.Value.Item2);

            //    if (field.Value.Item1 >= tChart.Axes.Bottom.Minimum && field.Value.Item1 <= tChart.Axes.Bottom.Maximum)
            //    {
            //        g.Line(new Point(posItem1, chartBottom), new Point(posItem1, chartBottom /*+ 4*/));
            //    }

            //    if (field.Value.Item2 >= tChart.Axes.Bottom.Minimum && field.Value.Item2 <= tChart.Axes.Bottom.Maximum)
            //    {
            //        g.Line(new Point(posItem2, chartBottom), new Point(posItem2, chartBottom /*+ 4*/));
            //    }

            //    g.TextOut((posItem1 + posItem2 - textHeight) / 2, chartBottom, +2, textOut);
            //}

            ////y
            //foreach (KeyValuePair<int, Tuple<double, double>> field in fieldYIndex)
            //{
            //    textOut = field.Key.ToString();
            //    textHeight = Convert.ToInt32(g.TextHeight(textOut));
            //    textWidth = Convert.ToInt32(g.TextWidth(textOut));

            //    posItem1 = tChart.Axes.Left.CalcYPosValue(field.Value.Item1);
            //    posItem2 = tChart.Axes.Left.CalcYPosValue(field.Value.Item2);

            //    if (field.Value.Item1 >= tChart.Axes.Left.Minimum && field.Value.Item1 <= tChart.Axes.Left.Maximum)
            //    {
            //        g.Line(new Point(posItem1, chartLeft), new Point(posItem1, chartLeft/* - 4*/));
            //    }

            //    if (field.Value.Item2 >= tChart.Axes.Left.Minimum && field.Value.Item2 <= tChart.Axes.Left.Maximum)
            //    {
            //        g.Line(new Point(posItem2, chartLeft), new Point(posItem2, chartLeft/* - 4*/));
            //    }


            //    g.TextOut(chartLeft - textWidth - 2, (posItem1 + posItem2 - textHeight) / 2, field.Key.ToString());
            //}

        }

        private void tChart1_BeforeDrawSeries(object sender, Steema.TeeChart.Drawing.Graphics3D g)
        {
            int centerX = tChart.Axes.Bottom.CalcXPosValue(g_field.offset_x);
            int centerY = tChart.Axes.Left.CalcYPosValue(g_field.offset_y);

            int width = tChart.Axes.Bottom.CalcSizeValue(waferRadius);// * 2d);
            int height = tChart.Axes.Left.CalcSizeValue(waferRadius);// * 2d);

            //if (width > 0 && height > 0)
            //{
            //    Size size = new Size(width, height);
            //    Point point = new Point(centerX - (size.Width / 2), centerY - (size.Height / 2));

            //    Rectangle rect = new Rectangle(point, size);
            //    g.Pen.Color = Color.Black;
            //    g.Brush.Color = Color.White;
            //    g.Ellipse(rect);
            //}
        }



        private Shape GetDieShapeSeries(string title, double x0, double x1, double y0, double y1)
        {
            Steema.TeeChart.Styles.Shape sp = null;

            sp = new Steema.TeeChart.Styles.Shape();

            sp.Title = title;
            sp.Style = ShapeStyles.Rectangle;
            sp.Color = Color.Yellow;
            sp.Transparency = 40;
            sp.Transparent = true;
            sp.Active = true;
            

            sp.X0 = x0;
            sp.X1 = x1;
            sp.Y0 = y0;
            sp.Y1 = y1;


            return sp;
        }

        private Shape GetFieldShapeSeries(string title, double x0, double x1, double y0, double y1)
        {
            //Steema.TeeChart.Drawing.Shape sp = null;

            Steema.TeeChart.Styles.Shape sp = null;

            sp = new Steema.TeeChart.Styles.Shape();

            sp.Title = title;
            sp.Style = ShapeStyles.Rectangle;
            sp.Color = Color.Blue;
            sp.Transparency = 40;
            sp.Transparent = true;
            sp.Active = true;

            sp.X0 = x0;
            sp.X1 = x1;
            sp.Y0 = y0;
            sp.Y1 = y1;


            return sp;
        }


        public void DrawTrendChart(DataTable dt)
        {
            specPoints.Clear();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    double targetX = double.Parse(row["TargetX"].ToString());
                    double targetY = double.Parse(row["TargetY"].ToString());

                    double fieldX = double.Parse(row["FieldX"].ToString());
                    double fieldY = double.Parse(row["FieldY"].ToString());

                    double point_x_pos = g_field.offset_x + (targetX / 1000.0 - g_field.pitch_x / 2.0);
                    double point_y_pos = g_field.offset_y + (targetY / 1000.0 - g_field.pitch_y / 2.0);

                    specPoints.Add(point_x_pos, point_y_pos, "", Color.Red);
                }
            }
        }

        


        public void InitializePointsSeries(string title)
        {
           // tChart.Series.Clear();

            specPoints = new Steema.TeeChart.Styles.Points();
            specPoints.Title = string.Empty;
            specPoints.ColorEach = false;

            specPoints.Pointer.Style = PointerStyles.Rectangle;
            specPoints.Pointer.HorizSize = 2;
            specPoints.Pointer.VertSize = 2;
            specPoints.Pointer.Brush.Color = Color.Yellow;
            specPoints.Pointer.Brush.Transparency = 0;
            specPoints.Pointer.Brush.Visible = true;
            specPoints.Pointer.Pen.Color = Color.Red;
            specPoints.Pointer.Pen.Transparency = 0;
            specPoints.Pointer.Pen.Visible = true;

            specPoints.XValues.DateTime = false;

            specPoints.XValues.Order = ValueListOrder.None;
            specPoints.YValues.Order = ValueListOrder.None;

            tChart.Series.Add(specPoints);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TargetX", typeof(double));
            dt.Columns.Add("TargetY", typeof(double));
            dt.Columns.Add("FieldX", typeof(double));
            dt.Columns.Add("FieldY", typeof(double));

            //dt.Rows.Add(9229.20036315918, 16239.2663955688, -126.7, -36.16);
            //dt.Rows.Add(9229.20036315918, 16239.2663955688, -126.7, -5.74);
            //dt.Rows.Add(9229.20036315918, 16239.2663955688, -126.7, 24.68);
            //dt.Rows.Add(9229.20036315918, 16239.2663955688, -101.36, -66.58);
            //dt.Rows.Add(9229.20036315918, 16239.2663955688, -101.36, -36.16);
            //dt.Rows.Add(9229.20036315918, 16239.2663955688, -101.36, -5.74);
            //dt.Rows.Add(9229.20036315918, 16239.2663955688, -101.36, 24.68);
            //dt.Rows.Add(9229.20036315918, 16239.2663955688, -101.36, 55.1);
            //dt.Rows.Add(9229.20036315918, 16239.2663955688, -101.36, 85.52);

            dt.Rows.Add(9229.20036315918, 15239.2663955688, -126.7, -36.16);
            dt.Rows.Add(11467.0390996560454, 29434.3070983887, -126.7, -5.74);
            dt.Rows.Add(25316.40625, 29509.6130371094, -126.7, 24.68);
            dt.Rows.Add(25316.7896270752, 919.169428964355, -101.36, -66.58);
            dt.Rows.Add(114567.1974005993731, 993.984580039978, -101.36, -36.16);
            dt.Rows.Add(10698.8025665283, 15239.0880584717, -101.36, -5.74);

            InitializePointsSeries("aaa");
            DrawTrendChart2(dt);
        }

        public void DrawTrendChart2(DataTable dt)
        {
            specPoints.Clear();


            int chartBottom = tChart.Chart.ChartRect.Bottom;
            int chartLeft = tChart.Chart.ChartRect.Left;


            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    double targetX = double.Parse(row["TargetX"].ToString());
                    double targetY = double.Parse(row["TargetY"].ToString());

                    //double fieldX = double.Parse(row["FieldX"].ToString());
                    //double fieldY = double.Parse(row["FieldY"].ToString());

                    double x1 = targetX / 1000.0;
                    double x2 = targetY / 1000.0;

                    double xx1 = g_field.pitch_x / 2.0;
                    double xx2 = g_field.pitch_y / 2.0;

                    double xxx1 = x1 - xx1;
                    double xxx2 = x2 - xx2;

                    double point_x_pos = g_field.offset_x + xxx1;
                    double point_y_pos = g_field.offset_y + xxx2;


                    //g_field.offset_x = 11.796;
                    //g_field.offset_y = 4.3175;
                    //g_field.pitch_x = 23.592;
                    //g_field.pitch_y = 32.735;
                    //g_field.shot_x_count = 6;
                    //g_field.shot_y_count = 5;

                    //double resultX = Calculate_ZeroSpan_HighLow_Scale(-50d, 50d, point_x_pos, g_field.pitch_x, g_field.pitch_y);
                    //double resultY = Calculate_ZeroSpan_HighLow_Scale(-50d, 50d, point_y_pos, g_field.pitch_x, g_field.pitch_y);

                    //double point_x_pos = g_field.offset_x + (targetX / 1000.0 - g_field.pitch_x / 2.0);
                    //double point_y_pos = g_field.offset_y + (targetY / 1000.0 - g_field.pitch_y / 2.0);

                    // point_x_pos = 0d;
                    // point_y_pos = 0d;

                    specPoints.Add(point_x_pos, point_y_pos, "", Color.Red);
                }
            }
        }


        double Calculate_ZeroSpan_HighLow_Scale(double fAdcZero, double fAdcSpan, double fAdcData, double fScaleLow, double fScaleHigh)
        {
            double fScaleData = 0;
            if ((fAdcZero == 0 && fAdcSpan == 0) || ((fAdcZero - fAdcSpan) == 0))       // 나누기 값이 0이 되면 시스템 폴트가 나므로 나누기 값을 검사한다.(0 이외의 값이면 문제 없다.)
                fScaleData = 0;
            else
                fScaleData = fScaleLow - (((fAdcZero - fAdcData) * (fScaleLow - fScaleHigh)) / (fAdcZero - fAdcSpan));

            if (fScaleData > fScaleHigh)
                fScaleData = fScaleHigh;
            if (fScaleData < fScaleLow)
                fScaleData = fScaleLow;
            return fScaleData;
        }
    }
}
