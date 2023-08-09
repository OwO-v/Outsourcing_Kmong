namespace WebViewUiTool
{
    partial class viewUC
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.wv_contents = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.btn_navigate = new System.Windows.Forms.Button();
            this.tb_location = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wv_contents)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.wv_contents, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(537, 384);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // wv_contents
            // 
            this.wv_contents.AllowExternalDrop = true;
            this.wv_contents.CreationProperties = null;
            this.wv_contents.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wv_contents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wv_contents.Location = new System.Drawing.Point(3, 24);
            this.wv_contents.Name = "wv_contents";
            this.wv_contents.Size = new System.Drawing.Size(531, 363);
            this.wv_contents.TabIndex = 0;
            this.wv_contents.ZoomFactor = 1D;
            // 
            // btn_navigate
            // 
            this.btn_navigate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_navigate.Location = new System.Drawing.Point(0, 0);
            this.btn_navigate.Margin = new System.Windows.Forms.Padding(0);
            this.btn_navigate.Name = "btn_navigate";
            this.btn_navigate.Size = new System.Drawing.Size(50, 21);
            this.btn_navigate.TabIndex = 3;
            this.btn_navigate.Text = "〓▷";
            this.btn_navigate.UseVisualStyleBackColor = true;
            this.btn_navigate.Click += new System.EventHandler(this.btn_navigate_Click);
            // 
            // tb_location
            // 
            this.tb_location.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_location.Location = new System.Drawing.Point(50, 0);
            this.tb_location.Margin = new System.Windows.Forms.Padding(0);
            this.tb_location.Name = "tb_location";
            this.tb_location.Size = new System.Drawing.Size(487, 21);
            this.tb_location.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.btn_navigate, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_location, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(537, 21);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // viewUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "viewUC";
            this.Size = new System.Drawing.Size(537, 384);
            this.Load += new System.EventHandler(this.viewUC_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wv_contents)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox tb_location;
        private System.Windows.Forms.Button btn_navigate;
        private Microsoft.Web.WebView2.WinForms.WebView2 wv_contents;
    }
}
