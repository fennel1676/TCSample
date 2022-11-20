namespace TChartSampleTest
{
    partial class Form1
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            TChartSampleTest.WaferCircle waferCircle1 = new TChartSampleTest.WaferCircle();
            Steema.TeeChart.Margins margins1 = new Steema.TeeChart.Margins();
            this.captureCheckBox = new System.Windows.Forms.CheckBox();
            this.waferControl = new TChartSampleTest.WaferControl();
            this.SuspendLayout();
            // 
            // captureCheckBox
            // 
            this.captureCheckBox.AutoSize = true;
            this.captureCheckBox.Location = new System.Drawing.Point(50, 427);
            this.captureCheckBox.Name = "captureCheckBox";
            this.captureCheckBox.Size = new System.Drawing.Size(124, 16);
            this.captureCheckBox.TabIndex = 1;
            this.captureCheckBox.Text = "captureCheckBox";
            this.captureCheckBox.UseVisualStyleBackColor = true;
            this.captureCheckBox.CheckedChanged += new System.EventHandler(this.captureCheckBox_CheckedChanged);
            // 
            // waferControl
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Axes.Bottom.Automatic = false;
            this.waferControl.Axes.Bottom.AutomaticMaximum = false;
            this.waferControl.Axes.Bottom.AutomaticMinimum = false;
            // 
            // 
            // 
            this.waferControl.Axes.Bottom.AxisPen.Color = System.Drawing.Color.Black;
            this.waferControl.Axes.Bottom.AxisPen.Width = 1;
            this.waferControl.Axes.Bottom.Increment = 50D;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Axes.Bottom.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.waferControl.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            this.waferControl.Axes.Bottom.Labels.Brush.Solid = true;
            this.waferControl.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.waferControl.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.waferControl.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.waferControl.Axes.Bottom.Labels.Font.Brush.Solid = true;
            this.waferControl.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.waferControl.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            this.waferControl.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            this.waferControl.Axes.Bottom.Labels.Font.Size = 9;
            this.waferControl.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.waferControl.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            this.waferControl.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.waferControl.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            this.waferControl.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            this.waferControl.Axes.Bottom.Labels.Style = Steema.TeeChart.AxisLabelStyle.Value;
            this.waferControl.Axes.Bottom.Maximum = 180D;
            this.waferControl.Axes.Bottom.Minimum = -180D;
            // 
            // 
            // 
            this.waferControl.Axes.Bottom.Title.Angle = 0;
            // 
            // 
            // 
            this.waferControl.Axes.Bottom.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.waferControl.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            this.waferControl.Axes.Bottom.Title.Brush.Solid = true;
            this.waferControl.Axes.Bottom.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.waferControl.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            this.waferControl.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.waferControl.Axes.Bottom.Title.Font.Brush.Solid = true;
            this.waferControl.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.waferControl.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            this.waferControl.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            this.waferControl.Axes.Bottom.Title.Font.Size = 11;
            this.waferControl.Axes.Bottom.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.waferControl.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            this.waferControl.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.waferControl.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            this.waferControl.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            this.waferControl.Axes.Bottom.UseMaxPixelPos = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Axes.Depth.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.waferControl.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            this.waferControl.Axes.Depth.Labels.Brush.Solid = true;
            this.waferControl.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.waferControl.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.waferControl.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.waferControl.Axes.Depth.Labels.Font.Brush.Solid = true;
            this.waferControl.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.waferControl.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            this.waferControl.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            this.waferControl.Axes.Depth.Labels.Font.Size = 9;
            this.waferControl.Axes.Depth.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.waferControl.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            this.waferControl.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.waferControl.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            this.waferControl.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.waferControl.Axes.Depth.Title.Angle = 0;
            // 
            // 
            // 
            this.waferControl.Axes.Depth.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.waferControl.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            this.waferControl.Axes.Depth.Title.Brush.Solid = true;
            this.waferControl.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.waferControl.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            this.waferControl.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.waferControl.Axes.Depth.Title.Font.Brush.Solid = true;
            this.waferControl.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.waferControl.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            this.waferControl.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            this.waferControl.Axes.Depth.Title.Font.Size = 11;
            this.waferControl.Axes.Depth.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.waferControl.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            this.waferControl.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.waferControl.Axes.Depth.Title.Shadow.Brush.Solid = true;
            this.waferControl.Axes.Depth.Title.Shadow.Brush.Visible = true;
            this.waferControl.Axes.Depth.UseMaxPixelPos = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Axes.DepthTop.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.waferControl.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            this.waferControl.Axes.DepthTop.Labels.Brush.Solid = true;
            this.waferControl.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.waferControl.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.waferControl.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.waferControl.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            this.waferControl.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.waferControl.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            this.waferControl.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            this.waferControl.Axes.DepthTop.Labels.Font.Size = 9;
            this.waferControl.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.waferControl.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            this.waferControl.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.waferControl.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            this.waferControl.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.waferControl.Axes.DepthTop.Title.Angle = 0;
            // 
            // 
            // 
            this.waferControl.Axes.DepthTop.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.waferControl.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            this.waferControl.Axes.DepthTop.Title.Brush.Solid = true;
            this.waferControl.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.waferControl.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            this.waferControl.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.waferControl.Axes.DepthTop.Title.Font.Brush.Solid = true;
            this.waferControl.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.waferControl.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            this.waferControl.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            this.waferControl.Axes.DepthTop.Title.Font.Size = 11;
            this.waferControl.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.waferControl.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            this.waferControl.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.waferControl.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            this.waferControl.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            this.waferControl.Axes.DepthTop.UseMaxPixelPos = true;
            // 
            // 
            // 
            this.waferControl.Axes.Left.Automatic = false;
            this.waferControl.Axes.Left.AutomaticMaximum = false;
            this.waferControl.Axes.Left.AutomaticMinimum = false;
            // 
            // 
            // 
            this.waferControl.Axes.Left.AxisPen.Color = System.Drawing.Color.Black;
            this.waferControl.Axes.Left.AxisPen.Width = 1;
            // 
            // 
            // 
            this.waferControl.Axes.Left.Grid.Visible = false;
            this.waferControl.Axes.Left.Increment = 50D;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Axes.Left.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.waferControl.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            this.waferControl.Axes.Left.Labels.Brush.Solid = true;
            this.waferControl.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.waferControl.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.waferControl.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.waferControl.Axes.Left.Labels.Font.Brush.Solid = true;
            this.waferControl.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.waferControl.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            this.waferControl.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            this.waferControl.Axes.Left.Labels.Font.Size = 9;
            this.waferControl.Axes.Left.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.waferControl.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            this.waferControl.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.waferControl.Axes.Left.Labels.Shadow.Brush.Solid = true;
            this.waferControl.Axes.Left.Labels.Shadow.Brush.Visible = true;
            this.waferControl.Axes.Left.Labels.Style = Steema.TeeChart.AxisLabelStyle.Value;
            this.waferControl.Axes.Left.Maximum = 180D;
            this.waferControl.Axes.Left.Minimum = -180D;
            // 
            // 
            // 
            this.waferControl.Axes.Left.Title.Angle = 90;
            // 
            // 
            // 
            this.waferControl.Axes.Left.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.waferControl.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            this.waferControl.Axes.Left.Title.Brush.Solid = true;
            this.waferControl.Axes.Left.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.waferControl.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            this.waferControl.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.waferControl.Axes.Left.Title.Font.Brush.Solid = true;
            this.waferControl.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.waferControl.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            this.waferControl.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            this.waferControl.Axes.Left.Title.Font.Size = 11;
            this.waferControl.Axes.Left.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.waferControl.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            this.waferControl.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.waferControl.Axes.Left.Title.Shadow.Brush.Solid = true;
            this.waferControl.Axes.Left.Title.Shadow.Brush.Visible = true;
            this.waferControl.Axes.Left.UseMaxPixelPos = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Axes.Right.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.waferControl.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            this.waferControl.Axes.Right.Labels.Brush.Solid = true;
            this.waferControl.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.waferControl.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.waferControl.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.waferControl.Axes.Right.Labels.Font.Brush.Solid = true;
            this.waferControl.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.waferControl.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            this.waferControl.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            this.waferControl.Axes.Right.Labels.Font.Size = 9;
            this.waferControl.Axes.Right.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.waferControl.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            this.waferControl.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.waferControl.Axes.Right.Labels.Shadow.Brush.Solid = true;
            this.waferControl.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.waferControl.Axes.Right.Title.Angle = 270;
            // 
            // 
            // 
            this.waferControl.Axes.Right.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.waferControl.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            this.waferControl.Axes.Right.Title.Brush.Solid = true;
            this.waferControl.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.waferControl.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            this.waferControl.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.waferControl.Axes.Right.Title.Font.Brush.Solid = true;
            this.waferControl.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.waferControl.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            this.waferControl.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            this.waferControl.Axes.Right.Title.Font.Size = 11;
            this.waferControl.Axes.Right.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.waferControl.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            this.waferControl.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.waferControl.Axes.Right.Title.Shadow.Brush.Solid = true;
            this.waferControl.Axes.Right.Title.Shadow.Brush.Visible = true;
            this.waferControl.Axes.Right.UseMaxPixelPos = true;
            this.waferControl.Axes.Right.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Axes.Top.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.waferControl.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            this.waferControl.Axes.Top.Labels.Brush.Solid = true;
            this.waferControl.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.waferControl.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.waferControl.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.waferControl.Axes.Top.Labels.Font.Brush.Solid = true;
            this.waferControl.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.waferControl.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            this.waferControl.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            this.waferControl.Axes.Top.Labels.Font.Size = 9;
            this.waferControl.Axes.Top.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.waferControl.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            this.waferControl.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.waferControl.Axes.Top.Labels.Shadow.Brush.Solid = true;
            this.waferControl.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.waferControl.Axes.Top.Title.Angle = 0;
            // 
            // 
            // 
            this.waferControl.Axes.Top.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.waferControl.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            this.waferControl.Axes.Top.Title.Brush.Solid = true;
            this.waferControl.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.waferControl.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            this.waferControl.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.waferControl.Axes.Top.Title.Font.Brush.Solid = true;
            this.waferControl.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.waferControl.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            this.waferControl.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            this.waferControl.Axes.Top.Title.Font.Size = 11;
            this.waferControl.Axes.Top.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.waferControl.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            this.waferControl.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.waferControl.Axes.Top.Title.Shadow.Brush.Solid = true;
            this.waferControl.Axes.Top.Title.Shadow.Brush.Visible = true;
            this.waferControl.Axes.Top.UseMaxPixelPos = true;
            this.waferControl.Axes.Top.Visible = false;
            this.waferControl.BackColor = System.Drawing.Color.White;
            this.waferControl.CanCapture = false;
            this.waferControl.ChipInformation = null;
            waferCircle1.BrushColor = System.Drawing.Color.Transparent;
            waferCircle1.Diameter = 300D;
            waferCircle1.PenColor = System.Drawing.Color.Black;
            waferCircle1.PenWidth = 1;
            waferCircle1.Radius = 150D;
            waferCircle1.Transparency = 50;
            this.waferControl.CWaferCircle = waferCircle1;
            this.waferControl.DisplayProportionally = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Footer.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.waferControl.Footer.Brush.Color = System.Drawing.Color.Silver;
            this.waferControl.Footer.Brush.Solid = true;
            this.waferControl.Footer.Brush.Visible = true;
            // 
            // 
            // 
            this.waferControl.Footer.Font.Bold = false;
            // 
            // 
            // 
            this.waferControl.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            this.waferControl.Footer.Font.Brush.Solid = true;
            this.waferControl.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.waferControl.Footer.Font.Shadow.Brush.Solid = true;
            this.waferControl.Footer.Font.Shadow.Brush.Visible = true;
            this.waferControl.Footer.Font.Size = 10;
            this.waferControl.Footer.Font.SizeFloat = 10F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.waferControl.Footer.ImageBevel.Brush.Solid = true;
            this.waferControl.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.waferControl.Footer.Shadow.Brush.Solid = true;
            this.waferControl.Footer.Shadow.Brush.Visible = true;
            this.waferControl.FooterTitle = "";
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Header.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.waferControl.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.waferControl.Header.Brush.Solid = true;
            this.waferControl.Header.Brush.Visible = true;
            // 
            // 
            // 
            this.waferControl.Header.Font.Bold = false;
            // 
            // 
            // 
            this.waferControl.Header.Font.Brush.Color = System.Drawing.Color.Blue;
            this.waferControl.Header.Font.Brush.Solid = true;
            this.waferControl.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.waferControl.Header.Font.Shadow.Brush.Solid = true;
            this.waferControl.Header.Font.Shadow.Brush.Visible = true;
            this.waferControl.Header.Font.Size = 10;
            this.waferControl.Header.Font.SizeFloat = 10F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.waferControl.Header.ImageBevel.Brush.Solid = true;
            this.waferControl.Header.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.waferControl.Header.Shadow.Brush.Solid = true;
            this.waferControl.Header.Shadow.Brush.Visible = true;
            this.waferControl.HeaderTitle = "TeeChart";
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.waferControl.Legend.Brush.Color = System.Drawing.Color.White;
            this.waferControl.Legend.Brush.Solid = true;
            this.waferControl.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.waferControl.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.waferControl.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.waferControl.Legend.Font.Brush.Solid = true;
            this.waferControl.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.waferControl.Legend.Font.Shadow.Brush.Solid = true;
            this.waferControl.Legend.Font.Shadow.Brush.Visible = true;
            this.waferControl.Legend.Font.Size = 9;
            this.waferControl.Legend.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.waferControl.Legend.ImageBevel.Brush.Solid = true;
            this.waferControl.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.waferControl.Legend.Shadow.Brush.Solid = true;
            this.waferControl.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.waferControl.Legend.Symbol.Shadow.Brush.Solid = true;
            this.waferControl.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Legend.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.waferControl.Legend.Title.Brush.Color = System.Drawing.Color.White;
            this.waferControl.Legend.Title.Brush.Solid = true;
            this.waferControl.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.waferControl.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.waferControl.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            this.waferControl.Legend.Title.Font.Brush.Solid = true;
            this.waferControl.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.waferControl.Legend.Title.Font.Shadow.Brush.Solid = true;
            this.waferControl.Legend.Title.Font.Shadow.Brush.Visible = true;
            this.waferControl.Legend.Title.Font.Size = 8;
            this.waferControl.Legend.Title.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.waferControl.Legend.Title.ImageBevel.Brush.Solid = true;
            this.waferControl.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.waferControl.Legend.Title.Shadow.Brush.Solid = true;
            this.waferControl.Legend.Title.Shadow.Brush.Visible = true;
            this.waferControl.Legend.Visible = false;
            this.waferControl.Location = new System.Drawing.Point(50, 21);
            this.waferControl.Name = "waferControl";
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Panel.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.waferControl.Panel.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.waferControl.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            this.waferControl.Panel.Bevel.StringColorOne = "FF000000";
            this.waferControl.Panel.Bevel.StringColorTwo = "FF000000";
            // 
            // 
            // 
            this.waferControl.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.waferControl.Panel.Brush.Solid = true;
            this.waferControl.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.waferControl.Panel.ImageBevel.Brush.Solid = true;
            this.waferControl.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.waferControl.Panel.Shadow.Brush.Solid = true;
            this.waferControl.Panel.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.waferControl.Panning.Allow = Steema.TeeChart.ScrollModes.None;
            this.waferControl.PointSize = 1;
            // 
            // 
            // 
            margins1.Bottom = 100;
            margins1.Left = 100;
            margins1.Right = 100;
            margins1.Top = 100;
            this.waferControl.Printer.Margins = margins1;
            this.waferControl.ShotInformation = null;
            this.waferControl.ShowPointBorder = false;
            this.waferControl.Size = new System.Drawing.Size(494, 400);
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.SubFooter.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.waferControl.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            this.waferControl.SubFooter.Brush.Solid = true;
            this.waferControl.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            this.waferControl.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            this.waferControl.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            this.waferControl.SubFooter.Font.Brush.Solid = true;
            this.waferControl.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.waferControl.SubFooter.Font.Shadow.Brush.Solid = true;
            this.waferControl.SubFooter.Font.Shadow.Brush.Visible = true;
            this.waferControl.SubFooter.Font.Size = 8;
            this.waferControl.SubFooter.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.waferControl.SubFooter.ImageBevel.Brush.Solid = true;
            this.waferControl.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.waferControl.SubFooter.Shadow.Brush.Solid = true;
            this.waferControl.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.SubHeader.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.waferControl.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.waferControl.SubHeader.Brush.Solid = true;
            this.waferControl.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            this.waferControl.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            this.waferControl.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.waferControl.SubHeader.Font.Brush.Solid = true;
            this.waferControl.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.waferControl.SubHeader.Font.Shadow.Brush.Solid = true;
            this.waferControl.SubHeader.Font.Shadow.Brush.Visible = true;
            this.waferControl.SubHeader.Font.Size = 12;
            this.waferControl.SubHeader.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.waferControl.SubHeader.ImageBevel.Brush.Solid = true;
            this.waferControl.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.waferControl.SubHeader.Shadow.Brush.Solid = true;
            this.waferControl.SubHeader.Shadow.Brush.Visible = true;
            this.waferControl.TabIndex = 0;
            this.waferControl.UseUserDefinedRange = false;
            this.waferControl.UseUserDrawing = false;
            this.waferControl.WaferData = null;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Walls.Back.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.waferControl.Walls.Back.Brush.Color = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.waferControl.Walls.Back.Brush.Gradient.Visible = false;
            this.waferControl.Walls.Back.Brush.Solid = true;
            this.waferControl.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.waferControl.Walls.Back.ImageBevel.Brush.Solid = true;
            this.waferControl.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.waferControl.Walls.Back.Shadow.Brush.Solid = true;
            this.waferControl.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Walls.Bottom.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.waferControl.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            this.waferControl.Walls.Bottom.Brush.Solid = true;
            this.waferControl.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.waferControl.Walls.Bottom.ImageBevel.Brush.Solid = true;
            this.waferControl.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.waferControl.Walls.Bottom.Shadow.Brush.Solid = true;
            this.waferControl.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Walls.Left.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.waferControl.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            this.waferControl.Walls.Left.Brush.Solid = true;
            this.waferControl.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.waferControl.Walls.Left.ImageBevel.Brush.Solid = true;
            this.waferControl.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.waferControl.Walls.Left.Shadow.Brush.Solid = true;
            this.waferControl.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Walls.Right.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.waferControl.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
            this.waferControl.Walls.Right.Brush.Solid = true;
            this.waferControl.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.waferControl.Walls.Right.ImageBevel.Brush.Solid = true;
            this.waferControl.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.waferControl.Walls.Right.Shadow.Brush.Solid = true;
            this.waferControl.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.waferControl.Zoom.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.waferControl.Zoom.Brush.Solid = true;
            this.waferControl.Zoom.Brush.Visible = false;
            this.waferControl.ClickChartSeries += new TChartSampleTest.ClickChartSeriesEventHandler(this.waferControl_ClickChartSeries);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 450);
            this.Controls.Add(this.captureCheckBox);
            this.Controls.Add(this.waferControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WaferControl waferControl;
        private System.Windows.Forms.CheckBox captureCheckBox;
    }
}

