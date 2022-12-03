namespace TChartSampleTest
{
    partial class Form10
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.waferUserControl1 = new TChartSampleTest.WaferUserControl();
            this.SuspendLayout();
            // 
            // waferUserControl1
            // 
            this.waferUserControl1.Location = new System.Drawing.Point(12, 12);
            this.waferUserControl1.Name = "waferUserControl1";
            this.waferUserControl1.Size = new System.Drawing.Size(560, 530);
            this.waferUserControl1.TabIndex = 0;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 554);
            this.Controls.Add(this.waferUserControl1);
            this.Name = "Form10";
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private WaferUserControl waferUserControl1;
    }
}