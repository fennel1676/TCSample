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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.dataGridView1.BorderStyle = BorderStyle.None;
            this.dataGridView1.CellBorderStyle =    DataGridViewCellBorderStyle.Single;
            this.dataGridView1.RowHeadersBorderStyle =       DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersBorderStyle =      DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.AutoSizeColumnsMode =   DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AllowUserToResizeColumns = true; // 수동 폭 조정
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells; // 수동 폭 조정

            DataTable dt = new DataTable();
            dt.Columns.Add("param", typeof(string));
            dt.Columns.Add("value1", typeof(double));
            dt.Columns.Add("value2", typeof(double));
            dt.Columns.Add("value3", typeof(double));

            dt.Rows.Add("k1", 15239.2663955688, -126.7, -36.16);
            dt.Rows.Add("k1,k2", 29434.3070983887, -126.7, -5.74);
            dt.Rows.Add("k1,k2,k4,k2,k4,k5,k11,k1,k2,k4,k11,k1,k2,k4", 29509.6130371094, -126.7, 24.68);
            dt.Rows.Add("k1,k2,k4,k5", 919.169428964355, -101.36, -66.58);
            dt.Rows.Add("k1,k2,k4,k5,k11,k1,k2,k4,k5,k11", 993.984580039978, -101.36, -36.16);
            
            dt.Columns.Add("Count", typeof(int));

            foreach (DataRow row in dt.Rows)
            {
                string strParam = row["param"].ToString();
                string[] words = strParam.Split(',');

                row["Count"] = words.Length;
                // int count = strParam.Count(f => (f == ','));
            }

            dataGridView1.DataSource = dt;

            dataGridView1.Columns["param"].DisplayIndex = 0;
            dataGridView1.Columns["value1"].DisplayIndex = 2;
            dataGridView1.Columns["value2"].DisplayIndex = 4;
            dataGridView1.Columns["value3"].DisplayIndex = 3;
            dataGridView1.Columns["Count"].DisplayIndex = 1;


            //dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            // dataGridView1.Columns[0].Resizable = DataGridViewTriState.True;

            //for (int i = 0; i <= dataGridView1.Columns.Count - 1; i++)
            //{
            //    // Store Auto Sized Widths:
            //    int colw = dataGridView1.Columns[i].Width;

            //    // Remove AutoSizing:
            //    dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            //    // Set Width to calculated AutoSize value:
            //    dataGridView1.Columns[i].Width = colw;

            //    dataGridView1.Columns[i].Resizable = DataGridViewTriState.True;
            //}

            // dataGridView1.Columns[dataGridView1.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
