namespace TChartSampleTest
{
    partial class WaferControl
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._tsmiSaveData = new System.Windows.Forms.ToolStripMenuItem();
            this._tsmiSaveImage = new System.Windows.Forms.ToolStripMenuItem();
            this._tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._tsmiCopyDataToClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this._tsmiCopyImageToClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tsmiSaveData,
            this._tsmiSaveImage,
            this._tssSeparator1,
            this._tsmiCopyDataToClipboard,
            this._tsmiCopyImageToClipboard});
            this.contextMenu.Name = "_cmsMenu";
            this.contextMenu.Size = new System.Drawing.Size(227, 98);
            // 
            // _tsmiSaveData
            // 
            this._tsmiSaveData.Name = "_tsmiSaveData";
            this._tsmiSaveData.Size = new System.Drawing.Size(226, 22);
            this._tsmiSaveData.Text = "데이터 저장하기";
            this._tsmiSaveData.Click += new System.EventHandler(this.saveDataMenuItem_Click);
            // 
            // _tsmiSaveImage
            // 
            this._tsmiSaveImage.Name = "_tsmiSaveImage";
            this._tsmiSaveImage.Size = new System.Drawing.Size(226, 22);
            this._tsmiSaveImage.Text = "이미지 저장하기";
            this._tsmiSaveImage.Click += new System.EventHandler(this.saveImageMenuItem_Click);
            // 
            // _tssSeparator1
            // 
            this._tssSeparator1.Name = "_tssSeparator1";
            this._tssSeparator1.Size = new System.Drawing.Size(223, 6);
            // 
            // _tsmiCopyDataToClipboard
            // 
            this._tsmiCopyDataToClipboard.Name = "_tsmiCopyDataToClipboard";
            this._tsmiCopyDataToClipboard.Size = new System.Drawing.Size(226, 22);
            this._tsmiCopyDataToClipboard.Text = "클립보드에 데이터 저장하기";
            this._tsmiCopyDataToClipboard.Click += new System.EventHandler(this.copyDataToClipboardMenuItem_Click);
            // 
            // _tsmiCopyImageToClipboard
            // 
            this._tsmiCopyImageToClipboard.Name = "_tsmiCopyImageToClipboard";
            this._tsmiCopyImageToClipboard.Size = new System.Drawing.Size(226, 22);
            this._tsmiCopyImageToClipboard.Text = "클립보드에 이미지 저장하기";
            this._tsmiCopyImageToClipboard.Click += new System.EventHandler(this.copyImageToClipboardMenuItem_Click);
            // 
            // XWaferChart
            // 
            // 
            // 
            // 
            this.Aspect.ZOffset = 0D;
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem _tsmiSaveData;
        private System.Windows.Forms.ToolStripMenuItem _tsmiSaveImage;
        private System.Windows.Forms.ToolStripSeparator _tssSeparator1;
        private System.Windows.Forms.ToolStripMenuItem _tsmiCopyDataToClipboard;
        private System.Windows.Forms.ToolStripMenuItem _tsmiCopyImageToClipboard;

    }
}
