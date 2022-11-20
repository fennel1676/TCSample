using Steema.TeeChart.Drawing;
using Steema.TeeChart.Styles;
using Steema.TeeChart.Tools;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.tChart.Aspect.View3D = false;




            Points point1 = new Points();

            point1.FillSampleValues(5);

            tChart.Series.Add(point1);



            //this.tChart1.ClickLegend += TChart1_ClickLegend;
            //this.tChart1.MouseClick += TChart1_MouseClick;
            this.tChart.AfterDraw += tChart_AfterDraw;
        }

        //private void TChart1_ClickLegend(object sender, MouseEventArgs e)
        //{
        //    int index = this.tChart1.Legend.Clicked(e.X, e.Y);

        //    if (index > -1)
        //    {
        //        for (int i = 0; i < this.tChart1.Series.Count; i++)
        //        {
        //            // 선택된 Legend 강조
        //            this.tChart1[i].Transparency = 0;

        //            if (i != index)
        //            {
        //                // 선택되지 않은 항목 반?투명하게 처리
        //                this.tChart1[i].Transparency = 100;
        //            }
        //        }
        //    }
        //}

        //private void TChart1_MouseClick(object sender, MouseEventArgs e)
        //{
        //    // Legend 영역이 아닌 경우 모두 원상태로 돌리기
        //    int index = this.tChart1.Legend.Clicked(e.X, e.Y);

        //    if (index > -1)
        //    {
        //        return;
        //    }
        //    else
        //    {
        //        for (int i = 0; i < this.tChart1.Series.Count; i++)
        //        {
        //            this.tChart1[i].Transparency = 0;
        //        }
        //    }
        //}

        private void tChart_AfterDraw(object sender, Graphics3D graphics3D)
        {
            //Point startPoint = new Point(this.tChart.Axes.Left.Position, this.tChart.Axes.Top.Position);
            //Point endPoint = new Point(this.tChart.Axes.Right.Position, this.tChart.Axes.Bottom.Position);

            //graphics3D.MoveTo(startPoint);
            //graphics3D.LineTo(endPoint, 0);
        }
    }
}
