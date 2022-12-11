using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Steema.TeeChart;
//using Steema.TeeChart.Drawing;
using System.Collections;
using Steema.TeeChart.Styles;

namespace TChartSampleTest
{
    public partial class WaferUserControl : UserControl
    {

        public FieldInfo g_field = new FieldInfo();
        public double waferRadius = 150d;

        List<Shape> fieldShapeList = new List<Shape>();
        List<Shape> dieShapeList = new List<Shape>();
        List<Shape> dieSpecShapeList = new List<Shape>();

        public int fieldXMinIndex = 0;
        public int fieldXMaxIndex = 0;
        public int fieldYMinIndex = 0;
        public int fieldYMaxIndex = 0;

        SortedList<int, Tuple<double, double>> fieldXIndex = new SortedList<int, Tuple<double, double>>();
        SortedList<int, Tuple<double, double>> fieldYIndex = new SortedList<int, Tuple<double, double>>();

        public WaferUserControl()
        {
            InitializeComponent();

            g_field.offset_x = 11.796;
            g_field.offset_y = 4.3175;
            g_field.pitch_x = 23.592;
            g_field.pitch_y = 32.735;
            g_field.shot_x_count = 6;
            g_field.shot_y_count = 5;

            //g_field.offset_x = 0;
            //g_field.offset_y = -4.1545;
            //g_field.pitch_x = 22.896;
            //g_field.pitch_y = 25.131;
            //g_field.shot_x_count = 4;
            //g_field.shot_y_count = 3;

            //g_field.offset_x = 0;
            //g_field.offset_y = -5.74;
            //g_field.pitch_x = 25.34;
            //g_field.pitch_y = 30.42;
            //g_field.shot_x_count = 2;
            //g_field.shot_y_count = 6;


            tChart.Aspect.View3D = false;
            tChart.Axes.Bottom.Automatic = false;
            tChart.Axes.Bottom.AutomaticMaximum = false;
            tChart.Axes.Bottom.AutomaticMinimum = false;
            tChart.Axes.Bottom.AxisPen.Color = Color.Red;
            tChart.Axes.Bottom.AxisPen.Width = 1;
            tChart.Axes.Bottom.Grid.Visible = true;
            tChart.Axes.Bottom.Increment = 1;
            tChart.Axes.Bottom.Labels.Style = Steema.TeeChart.AxisLabelStyle.Value;
            tChart.Axes.Bottom.Maximum = 170d;
            tChart.Axes.Bottom.Minimum = -170d;

            tChart.Axes.Left.Automatic = false;
            tChart.Axes.Left.AutomaticMaximum = false;
            tChart.Axes.Left.AutomaticMinimum = false;
            tChart.Axes.Left.AxisPen.Color = Color.Blue;
            tChart.Axes.Left.AxisPen.Width = 1;
            tChart.Axes.Left.Grid.Visible = true;
            tChart.Axes.Left.Increment = 1;
            tChart.Axes.Left.Labels.Style = Steema.TeeChart.AxisLabelStyle.Value;
            tChart.Axes.Left.Maximum = 170d;
            tChart.Axes.Left.Minimum = -170d;

            tChart.Legend.Visible = false;
            //

        }

        private void WaferUserControl_Load(object sender, EventArgs e)
        {
           // SetAxes();
        }


        public void InitWaferChart()
        {
            tChart.AutoRepaint = false;

            tChart.Series.Clear();
            tChart.Tools.Clear();
            tChart.Axes.Custom.Clear();

            fieldShapeList.Clear();
            dieShapeList.Clear();
            dieSpecShapeList.Clear();


            double fieldXPos = 0.0;
            double fieldYPos = 0.0;

            double dieXSize = g_field.pitch_x / g_field.shot_x_count;
            double dieYSize = g_field.pitch_y / g_field.shot_y_count;

            SortedList fieldXList = new SortedList();
            SortedList fieldYList = new SortedList();

            double xVal = g_field.offset_x - 0;
            double yVal = g_field.offset_y - 0;

            SetAxes();

            for (int i= fieldXMinIndex; i <= fieldXMaxIndex; i++)
            {
                double xTemp = xVal + (g_field.pitch_x * i);
                fieldXList.Add(i, xTemp);
            }

            for (int i = fieldYMinIndex; i <= fieldYMaxIndex; i++)
            {
                double yTemp = yVal + (g_field.pitch_y * i);
                fieldYList.Add(i, yTemp);
            }        

            for (int indexX = fieldXMinIndex; indexX <= fieldXMaxIndex; indexX++)
            {                                                          
                for (int indexY = fieldYMinIndex; indexY <= fieldYMaxIndex; indexY++)
                {
                    if (double.TryParse(fieldXList[indexX].ToString(), out fieldXPos) &&
                        double.TryParse(fieldYList[indexY].ToString(), out fieldYPos))
                    {

                        double fieldX0 = fieldXPos + g_field.offset_x - g_field.pitch_x / 2;
                        double fieldX1 = fieldXPos + g_field.offset_x + g_field.pitch_x / 2;
                        double fieldY0 = fieldYPos + g_field.offset_y - g_field.pitch_y / 2;
                        double fieldY1 = fieldYPos + g_field.offset_y + g_field.pitch_y / 2;


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

                            Shape fieldShape = GetFieldShapeSeries(string.Format("{0},{1}", indexX, indexY), fieldX0, fieldX1, fieldY0, fieldY1);
                            tChart.Series.Add(fieldShape);
                            dieSpecShapeList.Add(fieldShape);
                        }


                        if (fieldXIndex.Keys.Contains(indexX) == false)
                        {
                            fieldXIndex.Add(indexX, new Tuple<double, double>(fieldX0, fieldX1));
                        }

                        if (fieldYIndex.Keys.Contains(indexY) == false)
                        {
                            fieldYIndex.Add(indexY, new Tuple<double, double>(fieldY0, fieldY1));
                        }
                    }              


                }             
            }

            tChart.AutoRepaint = true;
            tChart.Refresh();
        }


        private void SetAxes()
        {
            double bottomMin = g_field.offset_x - g_field.pitch_x / 2;
            double bottomMax = g_field.offset_x + g_field.pitch_x / 2;

            double leftMin = g_field.offset_y - g_field.pitch_y / 2;
            double leftMax = g_field.offset_y + g_field.pitch_y / 2;

            while(bottomMin > -waferRadius)
            {
                bottomMin -= g_field.pitch_x;
                fieldXMinIndex--;
            }

            while (bottomMax < waferRadius)
            {
                bottomMax += g_field.pitch_x;
                fieldXMaxIndex++;
            }

            while (leftMin > -waferRadius)
            {
                leftMin -= g_field.pitch_y;
                fieldYMinIndex--;
            }

            while (leftMax < waferRadius)
            {
                leftMax += g_field.pitch_y;
                fieldYMaxIndex++;
            }

            bottomMin += g_field.offset_x;
            bottomMax += g_field.offset_x;

            leftMin += g_field.offset_y;
            leftMax += g_field.offset_y;           

            Axis bottomAxis = tChart.Axes.Bottom;
            bottomAxis.Increment = g_field.pitch_x;
            bottomAxis.SetMinMax(bottomMin, bottomMax);

            Axis leftAxis = tChart.Axes.Left;
            leftAxis.Increment = g_field.pitch_y; 
            leftAxis.SetMinMax(leftMin, leftMax);
        }

        private void tChart_AfterDraw(object sender, Steema.TeeChart.Drawing.Graphics3D g)
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
            foreach(KeyValuePair<int , Tuple<double, double>> field in fieldXIndex)
            {
                textOut = field.Key.ToString();
                textHeight = Convert.ToInt32(g.TextHeight(textOut));
                textWidth = Convert.ToInt32(g.TextWidth(textOut));

                posItem1 = tChart.Axes.Bottom.CalcXPosValue(field.Value.Item1);
                posItem2 = tChart.Axes.Bottom.CalcXPosValue(field.Value.Item2);

                if (field.Value.Item1 >= tChart.Axes.Bottom.Minimum && field.Value.Item1 <= tChart.Axes.Bottom.Maximum)
                {
                    g.Line(new Point(posItem1, chartBottom), new Point(posItem1, chartBottom + 4));
                }

                if (field.Value.Item2 >= tChart.Axes.Bottom.Minimum && field.Value.Item2 <= tChart.Axes.Bottom.Maximum)
                {
                    g.Line(new Point(posItem2, chartBottom), new Point(posItem2, chartBottom + 4));
                }

                g.TextOut((posItem1 + posItem2 - textHeight) / 2, chartBottom, + 2 , textOut);
            }

            //y
            foreach (KeyValuePair<int, Tuple<double, double>> field in fieldYIndex)
            {
                textOut = field.Key.ToString();
                textHeight = Convert.ToInt32(g.TextHeight(textOut));
                textWidth = Convert.ToInt32(g.TextWidth(textOut));

                posItem1 = tChart.Axes.Left.CalcYPosValue(field.Value.Item1);
                posItem2 = tChart.Axes.Left.CalcYPosValue(field.Value.Item2);

                if (field.Value.Item1 >= tChart.Axes.Left.Minimum && field.Value.Item1 <= tChart.Axes.Left.Maximum)
                {
                    g.Line(new Point(posItem1, chartLeft), new Point(posItem1, chartLeft - 4));
                }

                if (field.Value.Item2 >= tChart.Axes.Left.Minimum && field.Value.Item2 <= tChart.Axes.Left.Maximum)
                {
                    g.Line(new Point(posItem2, chartLeft), new Point(posItem2, chartLeft - 4));
                }


                g.TextOut(chartLeft - textWidth - 2, (posItem1 + posItem2 - textHeight) / 2, field.Key.ToString());
            }          
        }

        private void tChart_BeforeDrawSeries(object sender, Steema.TeeChart.Drawing.Graphics3D g)
        {
            int centerX = tChart.Axes.Bottom.CalcXPosValue(g_field.offset_x);
            int centerY = tChart.Axes.Left.CalcYPosValue(g_field.offset_y);

            int width = tChart.Axes.Bottom.CalcSizeValue(waferRadius * 2d);
            int height = tChart.Axes.Left.CalcSizeValue(waferRadius * 2d);

            if (width > 0 && height > 0)
            {
                Size size = new Size(width, height);
                Point point = new Point(centerX - (size.Width / 2), centerY - (size.Height / 2));

                Rectangle rect = new Rectangle(point, size);
                g.Pen.Color = Color.Black;
                g.Brush.Color = Color.White;
                g.Ellipse(rect);
            }
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


    }
}
