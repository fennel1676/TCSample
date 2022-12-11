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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            fieldUserControl.InitializeFieldChart();
            fieldUserControl.InitializePointsSeries("spec");



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
            dt.Rows.Add(11.0390996560454, 29434.3070983887, -126.7, -5.74);
            dt.Rows.Add(25316.40625, 29509.6130371094, -126.7, 24.68);
            dt.Rows.Add(25316.7896270752, 919.169428964355, -101.36, -66.58);
            dt.Rows.Add(11.1974005993731, 993.984580039978, -101.36, -36.16);
            dt.Rows.Add(10698.8025665283, 15239.0880584717, -101.36, -5.74);


            fieldUserControl.DrawTrendChart(dt);

        }
    }
}
