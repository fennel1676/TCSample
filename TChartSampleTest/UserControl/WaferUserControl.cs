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

namespace TChartSampleTest
{
    public partial class WaferUserControl : UserControl
    {

        public FieldInfo g_field = new FieldInfo();
        public double waferRadius = 150;

        public double fieldXMinIndex = 0;
        public double fieldXMaxIndex = 0;
        public double fieldYMinIndex = 0;
        public double fieldYMaxIndex = 0;

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
            tChart.Axes.Left.AxisPen.Color = Color.Black;
            tChart.Axes.Left.AxisPen.Width = 1;
            tChart.Axes.Left.Grid.Visible = true;
            tChart.Axes.Left.Increment = 1;
            tChart.Axes.Left.Labels.Style = Steema.TeeChart.AxisLabelStyle.Value;
            tChart.Axes.Left.Maximum = 170d;
            tChart.Axes.Left.Minimum = -170d;


        }

        private void WaferUserControl_Load(object sender, EventArgs e)
        {
            SetAxes();
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
                g.Pen.Color = Color.Blue;
                g.Brush.Color = Color.White;
                g.Ellipse(rect);
            }
        }
    }
}
