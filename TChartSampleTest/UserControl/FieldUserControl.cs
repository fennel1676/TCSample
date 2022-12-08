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
using Steema.TeeChart.Drawing;
using Steema.TeeChart.Styles;

namespace TChartSampleTest
{
    public partial class FieldUserControl : UserControl
    {

        private double axesBottomMin = 0;
        private double axesBottomMax = 0;
        private double axesLeftMin = 0;
        private double axesLeftMax = 0;

        public FieldInfo g_field = new FieldInfo();




        private Steema.TeeChart.Styles.Points specPoints = null;
        //private Steema.TeeChart.Styles.Series specPoints = null;

        double mMinValue = double.MaxValue;
        double mMaxValue = double.MaxValue;


        public FieldUserControl()
        {
            InitializeComponent();

            //g_field.offset_x = 0;
            //g_field.offset_y = -5.74;
            //g_field.pitch_x = 25.34;
            //g_field.pitch_y = 30.42;
            //g_field.shot_x_count = 2;
            //g_field.shot_y_count = 6;

            //g_field.offset_x = 11.796;
            //g_field.offset_y = 4.3175;
            //g_field.pitch_x = 23.592;
            //g_field.pitch_y = 32.735;
            //g_field.shot_x_count = 6;
            //g_field.shot_y_count = 5;

            g_field.offset_x = 0;
            g_field.offset_y = -4.1545;
            g_field.pitch_x = 22.896;
            g_field.pitch_y = 25.131;
            g_field.shot_x_count = 4;
            g_field.shot_y_count = 3;
        }

        private void FieldUserControl_Load(object sender, EventArgs e)
        {
            //tChart.AutoRepaint = false;
            tChart.Series.Clear();
            tChart.Tools.Clear();

            tChart.Aspect.View3D = false;
            tChart.Panel.Color = Color.White;
            tChart.Panel.MarginBottom = 4;
            tChart.Panel.MarginLeft = 4;
            tChart.Panel.MarginRight = 4;
            tChart.Panel.MarginTop = 4;
            tChart.Panel.MarginUnits = PanelMarginUnits.Percent;
            tChart.Panel.Pen.Visible = false;
            tChart.Panel.Gradient.Visible = false;
            tChart.Panel.Bevel.Inner = BevelStyles.None;
            tChart.Panel.Bevel.Outer = BevelStyles.None;

            tChart.Walls.Visible = false;
            tChart.Walls.Back.Gradient.Visible = false;
            tChart.Walls.Back.Color = Color.Transparent;

            tChart.Header.Visible = false;
            tChart.SubHeader.Visible = false;
            //tChart.Footer.Visible = false;
            //tChart.SubFooter.Visible = false;

            tChart.Axes.Left.Title.Visible = false;
            tChart.Axes.Left.AxisPen.Visible = false;
            tChart.Axes.Left.MinorTicks.Visible = false;
            tChart.Axes.Left.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            tChart.Axes.Left.MaximumOffset = 10;
            tChart.Axes.Left.MinimumOffset = 10;
            tChart.Axes.Left.Automatic = false;
            tChart.Axes.Left.AutomaticMaximum = false;
            tChart.Axes.Left.AutomaticMinimum = false;
            tChart.Axes.Left.Increment = 1;
            tChart.Axes.Left.Labels.Style = AxisLabelStyle.Value;
            tChart.Axes.Left.Labels.ValueFormat = "#.0";

            tChart.Axes.Bottom.Title.Visible = false;
            tChart.Axes.Bottom.AxisPen.Visible = true;
            tChart.Axes.Bottom.MinorTicks.Visible = true;
            tChart.Axes.Bottom.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            tChart.Axes.Bottom.MaximumOffset = 10;
            tChart.Axes.Bottom.MinimumOffset = 10;
            tChart.Axes.Bottom.Automatic = false;
            tChart.Axes.Bottom.AutomaticMaximum = false;
            tChart.Axes.Bottom.AutomaticMinimum = false;
            tChart.Axes.Bottom.Increment = 1;
            tChart.Axes.Bottom.Labels.Style = AxisLabelStyle.Value;
            tChart.Axes.Bottom.Labels.ValueFormat = "#.0";

            tChart.Legend.Visible = false;




        }


        public void InitializePointsSeries(string title)
        {
            tChart.Series.Clear();

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

        public void InitializeFieldChart()
        {
            axesBottomMin = g_field.offset_x - g_field.pitch_x / 2;
            axesBottomMax = g_field.offset_x + g_field.pitch_x / 2;

            axesLeftMin = g_field.offset_y - g_field.pitch_y / 2;
            axesLeftMax = g_field.offset_y + g_field.pitch_y / 2;

            tChart.Axes.Bottom.Increment = g_field.pitch_x / g_field.shot_x_count;
            tChart.Axes.Bottom.Grid.Color = Color.Red;
            tChart.Axes.Bottom.Grid.Width = 1;

            tChart.Axes.Left.Increment = g_field.pitch_y / g_field.shot_y_count;
            tChart.Axes.Left.Grid.Color = Color.Red;
            tChart.Axes.Left.Grid.Width = 1;

            tChart.Axes.Bottom.SetMinMax(axesBottomMin, axesBottomMax);
            tChart.Axes.Left.SetMinMax(axesLeftMin, axesLeftMax);
        }

        public void DrawTrendChart(DataTable dt)
        {
            specPoints.Clear();

            if (dt.Rows.Count > 0)
            {
                foreach(DataRow row in dt.Rows)
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

    }
}
