namespace TChartSampleTest
{
    partial class WaferUserControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            Steema.TeeChart.Margins margins1 = new Steema.TeeChart.Margins();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tChart = new Steema.TeeChart.TChart();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tChart, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.420054F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.57995F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(443, 390);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tChart
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.Bottom.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChart.Axes.Bottom.Labels.Brush.Solid = true;
            this.tChart.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChart.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart.Axes.Bottom.Labels.Font.Brush.Solid = true;
            this.tChart.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            this.tChart.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            this.tChart.Axes.Bottom.Labels.Font.Size = 9;
            this.tChart.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            this.tChart.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            this.tChart.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart.Axes.Bottom.Title.Angle = 0;
            // 
            // 
            // 
            this.tChart.Axes.Bottom.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChart.Axes.Bottom.Title.Brush.Solid = true;
            this.tChart.Axes.Bottom.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChart.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart.Axes.Bottom.Title.Font.Brush.Solid = true;
            this.tChart.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            this.tChart.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            this.tChart.Axes.Bottom.Title.Font.Size = 11;
            this.tChart.Axes.Bottom.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            this.tChart.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            this.tChart.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            this.tChart.Axes.Bottom.UseMaxPixelPos = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.Depth.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChart.Axes.Depth.Labels.Brush.Solid = true;
            this.tChart.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChart.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart.Axes.Depth.Labels.Font.Brush.Solid = true;
            this.tChart.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            this.tChart.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            this.tChart.Axes.Depth.Labels.Font.Size = 9;
            this.tChart.Axes.Depth.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            this.tChart.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            this.tChart.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart.Axes.Depth.Title.Angle = 0;
            // 
            // 
            // 
            this.tChart.Axes.Depth.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChart.Axes.Depth.Title.Brush.Solid = true;
            this.tChart.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChart.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart.Axes.Depth.Title.Font.Brush.Solid = true;
            this.tChart.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            this.tChart.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            this.tChart.Axes.Depth.Title.Font.Size = 11;
            this.tChart.Axes.Depth.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            this.tChart.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart.Axes.Depth.Title.Shadow.Brush.Solid = true;
            this.tChart.Axes.Depth.Title.Shadow.Brush.Visible = true;
            this.tChart.Axes.Depth.UseMaxPixelPos = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.DepthTop.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChart.Axes.DepthTop.Labels.Brush.Solid = true;
            this.tChart.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChart.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            this.tChart.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            this.tChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            this.tChart.Axes.DepthTop.Labels.Font.Size = 9;
            this.tChart.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            this.tChart.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            this.tChart.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart.Axes.DepthTop.Title.Angle = 0;
            // 
            // 
            // 
            this.tChart.Axes.DepthTop.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChart.Axes.DepthTop.Title.Brush.Solid = true;
            this.tChart.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChart.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart.Axes.DepthTop.Title.Font.Brush.Solid = true;
            this.tChart.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            this.tChart.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            this.tChart.Axes.DepthTop.Title.Font.Size = 11;
            this.tChart.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            this.tChart.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            this.tChart.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            this.tChart.Axes.DepthTop.UseMaxPixelPos = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.Left.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChart.Axes.Left.Labels.Brush.Solid = true;
            this.tChart.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChart.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart.Axes.Left.Labels.Font.Brush.Solid = true;
            this.tChart.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            this.tChart.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            this.tChart.Axes.Left.Labels.Font.Size = 9;
            this.tChart.Axes.Left.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            this.tChart.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart.Axes.Left.Labels.Shadow.Brush.Solid = true;
            this.tChart.Axes.Left.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart.Axes.Left.Title.Angle = 90;
            // 
            // 
            // 
            this.tChart.Axes.Left.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChart.Axes.Left.Title.Brush.Solid = true;
            this.tChart.Axes.Left.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChart.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart.Axes.Left.Title.Font.Brush.Solid = true;
            this.tChart.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            this.tChart.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            this.tChart.Axes.Left.Title.Font.Size = 11;
            this.tChart.Axes.Left.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            this.tChart.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart.Axes.Left.Title.Shadow.Brush.Solid = true;
            this.tChart.Axes.Left.Title.Shadow.Brush.Visible = true;
            this.tChart.Axes.Left.UseMaxPixelPos = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.Right.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChart.Axes.Right.Labels.Brush.Solid = true;
            this.tChart.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChart.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart.Axes.Right.Labels.Font.Brush.Solid = true;
            this.tChart.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            this.tChart.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            this.tChart.Axes.Right.Labels.Font.Size = 9;
            this.tChart.Axes.Right.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            this.tChart.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart.Axes.Right.Labels.Shadow.Brush.Solid = true;
            this.tChart.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart.Axes.Right.Title.Angle = 270;
            // 
            // 
            // 
            this.tChart.Axes.Right.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChart.Axes.Right.Title.Brush.Solid = true;
            this.tChart.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChart.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart.Axes.Right.Title.Font.Brush.Solid = true;
            this.tChart.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            this.tChart.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            this.tChart.Axes.Right.Title.Font.Size = 11;
            this.tChart.Axes.Right.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            this.tChart.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart.Axes.Right.Title.Shadow.Brush.Solid = true;
            this.tChart.Axes.Right.Title.Shadow.Brush.Visible = true;
            this.tChart.Axes.Right.UseMaxPixelPos = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.Top.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChart.Axes.Top.Labels.Brush.Solid = true;
            this.tChart.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChart.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart.Axes.Top.Labels.Font.Brush.Solid = true;
            this.tChart.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            this.tChart.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            this.tChart.Axes.Top.Labels.Font.Size = 9;
            this.tChart.Axes.Top.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            this.tChart.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart.Axes.Top.Labels.Shadow.Brush.Solid = true;
            this.tChart.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart.Axes.Top.Title.Angle = 0;
            // 
            // 
            // 
            this.tChart.Axes.Top.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChart.Axes.Top.Title.Brush.Solid = true;
            this.tChart.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChart.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart.Axes.Top.Title.Font.Brush.Solid = true;
            this.tChart.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            this.tChart.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            this.tChart.Axes.Top.Title.Font.Size = 11;
            this.tChart.Axes.Top.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            this.tChart.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart.Axes.Top.Title.Shadow.Brush.Solid = true;
            this.tChart.Axes.Top.Title.Shadow.Brush.Visible = true;
            this.tChart.Axes.Top.UseMaxPixelPos = true;
            this.tChart.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Footer.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart.Footer.Brush.Color = System.Drawing.Color.Silver;
            this.tChart.Footer.Brush.Solid = true;
            this.tChart.Footer.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart.Footer.Font.Bold = false;
            // 
            // 
            // 
            this.tChart.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            this.tChart.Footer.Font.Brush.Solid = true;
            this.tChart.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart.Footer.Font.Shadow.Brush.Solid = true;
            this.tChart.Footer.Font.Shadow.Brush.Visible = true;
            this.tChart.Footer.Font.Size = 8;
            this.tChart.Footer.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart.Footer.ImageBevel.Brush.Solid = true;
            this.tChart.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart.Footer.Shadow.Brush.Solid = true;
            this.tChart.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Header.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tChart.Header.Brush.Solid = true;
            this.tChart.Header.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart.Header.Font.Bold = false;
            // 
            // 
            // 
            this.tChart.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart.Header.Font.Brush.Solid = true;
            this.tChart.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart.Header.Font.Shadow.Brush.Solid = true;
            this.tChart.Header.Font.Shadow.Brush.Visible = true;
            this.tChart.Header.Font.Size = 12;
            this.tChart.Header.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart.Header.ImageBevel.Brush.Solid = true;
            this.tChart.Header.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tChart.Header.Shadow.Brush.Solid = true;
            this.tChart.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart.Legend.Brush.Color = System.Drawing.Color.White;
            this.tChart.Legend.Brush.Solid = true;
            this.tChart.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.tChart.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart.Legend.Font.Brush.Solid = true;
            this.tChart.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart.Legend.Font.Shadow.Brush.Solid = true;
            this.tChart.Legend.Font.Shadow.Brush.Visible = true;
            this.tChart.Legend.Font.Size = 9;
            this.tChart.Legend.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart.Legend.ImageBevel.Brush.Solid = true;
            this.tChart.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart.Legend.Shadow.Brush.Solid = true;
            this.tChart.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart.Legend.Symbol.Shadow.Brush.Solid = true;
            this.tChart.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Legend.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart.Legend.Title.Brush.Color = System.Drawing.Color.White;
            this.tChart.Legend.Title.Brush.Solid = true;
            this.tChart.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.tChart.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            this.tChart.Legend.Title.Font.Brush.Solid = true;
            this.tChart.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart.Legend.Title.Font.Shadow.Brush.Solid = true;
            this.tChart.Legend.Title.Font.Shadow.Brush.Visible = true;
            this.tChart.Legend.Title.Font.Size = 8;
            this.tChart.Legend.Title.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart.Legend.Title.ImageBevel.Brush.Solid = true;
            this.tChart.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart.Legend.Title.Shadow.Brush.Solid = true;
            this.tChart.Legend.Title.Shadow.Brush.Visible = true;
            this.tChart.Location = new System.Drawing.Point(3, 23);
            this.tChart.Name = "tChart";
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart.Panel.Brush.Solid = true;
            this.tChart.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart.Panel.ImageBevel.Brush.Solid = true;
            this.tChart.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart.Panel.Shadow.Brush.Solid = true;
            this.tChart.Panel.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            margins1.Bottom = 100;
            margins1.Left = 100;
            margins1.Right = 100;
            margins1.Top = 100;
            this.tChart.Printer.Margins = margins1;
            this.tChart.Size = new System.Drawing.Size(437, 343);
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.SubFooter.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            this.tChart.SubFooter.Brush.Solid = true;
            this.tChart.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            this.tChart.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            this.tChart.SubFooter.Font.Brush.Solid = true;
            this.tChart.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart.SubFooter.Font.Shadow.Brush.Solid = true;
            this.tChart.SubFooter.Font.Shadow.Brush.Visible = true;
            this.tChart.SubFooter.Font.Size = 8;
            this.tChart.SubFooter.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart.SubFooter.ImageBevel.Brush.Solid = true;
            this.tChart.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart.SubFooter.Shadow.Brush.Solid = true;
            this.tChart.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.SubHeader.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tChart.SubHeader.Brush.Solid = true;
            this.tChart.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            this.tChart.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart.SubHeader.Font.Brush.Solid = true;
            this.tChart.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart.SubHeader.Font.Shadow.Brush.Solid = true;
            this.tChart.SubHeader.Font.Shadow.Brush.Visible = true;
            this.tChart.SubHeader.Font.Size = 12;
            this.tChart.SubHeader.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart.SubHeader.ImageBevel.Brush.Solid = true;
            this.tChart.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tChart.SubHeader.Shadow.Brush.Solid = true;
            this.tChart.SubHeader.Shadow.Brush.Visible = true;
            this.tChart.TabIndex = 1;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Walls.Back.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            this.tChart.Walls.Back.Brush.Solid = true;
            this.tChart.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart.Walls.Back.ImageBevel.Brush.Solid = true;
            this.tChart.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart.Walls.Back.Shadow.Brush.Solid = true;
            this.tChart.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Walls.Bottom.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            this.tChart.Walls.Bottom.Brush.Solid = true;
            this.tChart.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart.Walls.Bottom.ImageBevel.Brush.Solid = true;
            this.tChart.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart.Walls.Bottom.Shadow.Brush.Solid = true;
            this.tChart.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Walls.Left.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            this.tChart.Walls.Left.Brush.Solid = true;
            this.tChart.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart.Walls.Left.ImageBevel.Brush.Solid = true;
            this.tChart.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart.Walls.Left.Shadow.Brush.Solid = true;
            this.tChart.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Walls.Right.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
            this.tChart.Walls.Right.Brush.Solid = true;
            this.tChart.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart.Walls.Right.ImageBevel.Brush.Solid = true;
            this.tChart.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart.Walls.Right.Shadow.Brush.Solid = true;
            this.tChart.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Zoom.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.tChart.Zoom.Brush.Solid = true;
            this.tChart.Zoom.Brush.Visible = false;
            this.tChart.AfterDraw += new Steema.TeeChart.PaintChartEventHandler(this.tChart_AfterDraw);
            this.tChart.BeforeDrawSeries += new Steema.TeeChart.PaintChartEventHandler(this.tChart_BeforeDrawSeries);
            // 
            // WaferUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "WaferUserControl";
            this.Size = new System.Drawing.Size(443, 390);
            this.Load += new System.EventHandler(this.WaferUserControl_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Steema.TeeChart.TChart tChart;
    }
}
