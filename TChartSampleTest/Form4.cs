using Steema.TeeChart;
using Steema.TeeChart.Drawing;
using Steema.TeeChart.Functions;
using Steema.TeeChart.Styles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TChartSampleTest
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();


            Text = "Trend Chart Test";
            tChart.Header.Text = Text;

            tChart.Aspect.View3D = false;

            tChart.Panel.Pen = new ChartPen(Color.Black);

            Axis leftAxis = tChart.Axes.Left;
            leftAxis.AxisPen.Color = Color.Red;
            leftAxis.Title.Font.Color = Color.Red;
            leftAxis.Title.Font.Bold = true;
            leftAxis.StartPosition = 0d;

            //  leftAxis.Title.Text = "Alarm count";
            //leftAxis.Horizontal = true;
            leftAxis.SetMinMax(0, 20);

            Axis bottomAxis = tChart.Axes.Bottom;
            bottomAxis.AxisPen.Color = Color.Red;
            bottomAxis.Title.Font.Color = Color.Red;
            bottomAxis.Title.Font.Bold = true;
            bottomAxis.StartPosition = 0d;

            //  bottomAxis.Title.Text = "Date time";
            //  bottomAxis.Horizontal = true;
            bottomAxis.SetMinMax(0, 10);

            Line line = new Line(tChart.Chart);
            line.Pointer.Style = PointerStyles.Rectangle;
            line.Pointer.HorizSize = 2;
            line.Pointer.VertSize = 2;
            line.Pointer.Visible = true;
            line.Marks.Visible = false;
            line.Add(1, 2);
            line.Add(2, 3);
            line.Add(3, 4);


            // Volume volume = new Volume(this.tChart.Chart);

            // volume.VertAxis = VerticalAxis.Custom;




            //
            //  
            //  this.tChart.Axes.Left.EndPosition = 55d;
            //  this.tChart.Legend.Visible = false;

            //   Axis axis = new Axis();

            // axis.Horizontal = false;
            //  axis.OtherSide = true;
            //  axis.StartPosition = 60d;
            //  axis.EndPosition = 100d;

            //   this.tChart.Axes.Custom.Add(axis);

            //Candle candle = new Candle(this.tChart.Chart);

            //candle.FillSampleValues(200);

            //ACFunction acFuncation = new ACFunction(this.tChart.Chart);

            //Volume volume = new Volume(this.tChart.Chart);

            //volume.VertAxis = VerticalAxis.Custom;
            //volume.CustomVertAxis = axis;
            //volume.DataSource = candle;
            //volume.Function = acFuncation;
            //  



            //line.Add(3, 50);
            //line.Add(4, 150);
            //line.Add(5, 100);
            //line.Add(6, 100);
            //line.Add(7, 50);
            //line.Add(8, 150);
            //line.Add(9, 100);



            tChart.BeforeDraw += new Steema.TeeChart.PaintChartEventHandler(this.tChart_BeforeDraw);
            tChart.AfterDraw += new Steema.TeeChart.PaintChartEventHandler(this.tChart_AfterDraw);

            //this.tChart.BeforeDraw += tChart_BeforeDraw;
            //this.tChart.BeforeDrawAxes += tChart_BeforeDrawAxes;
            //this.tChart.BeforeDrawSeries += tChart_BeforeDrawSeries;
            //this.tChart.AfterDraw += tChart_AfterDraw;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Points points = tChart.Series[0] as Points;

            int screenX1 = tChart.Axes.Bottom.CalcXPosValue(2);
            int screenX2 = tChart.Axes.Bottom.CalcXPosValue(5);

            int screenY1 = tChart.Axes.Left.CalcYPosValue(tChart.Axes.Left.MinYValue);
            int screenY2 = tChart.Axes.Left.CalcYPosValue(tChart.Axes.Left.MaxYValue);

            int screenWidth = screenX2 - screenX1;
            int screenHeight = screenY2 - screenY1;

            Rectangle zoomRectangle = new Rectangle(screenX1, screenY1, screenWidth, screenHeight);

            tChart.Zoom.ZoomRect(zoomRectangle);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           //Points points = new Points();

           // // points.FillSampleValues(20);

           //// this.tChart.AutoRepaint = false;

           // // for (int i = 0; i < 1_000_000; i++)
           // {
           //     points.Add(10, 5);
           //     points.Add(20, 25);
           //     points.Add(15, 10);
           // }

           // tChart.Series.Add(points);

           // this.tChart.AutoRepaint = true;
        }

        private void tChart_BeforeDraw(object sender, Graphics3D graphics3D)
        {
          //  if (this.beforeSeriesRadioButton.Checked)
            {
             //   DrawShape();
            }
        }

        private void tChart_AfterDraw(object sender, Graphics3D g)
        {
            DrawShape();
        }

        private void DrawShape()
        {
            this.tChart.Graphics3D.Pen.Style = DashStyle.Dot;
            this.tChart.Graphics3D.Brush.Visible = true;
            this.tChart.Graphics3D.Brush.Color = Color.FromArgb(243, 156, 53);

            this.tChart.Graphics3D.Ellipse
            (
                1,
                1,
                this.tChart.Graphics3D.Chart.Width - 1,
                this.tChart.Graphics3D.Chart.Height - 1
            );
        }

      
    }
}
