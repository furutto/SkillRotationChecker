namespace SkillRotationChecker
{
    partial class ACTTabControl
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelViewY = new System.Windows.Forms.Label();
            this.labelViewX = new System.Windows.Forms.Label();
            this.udViewY = new System.Windows.Forms.NumericUpDown();
            this.udViewX = new System.Windows.Forms.NumericUpDown();
            this.labelViewOrientation = new System.Windows.Forms.Label();
            this.trackBarOpacity = new System.Windows.Forms.TrackBar();
            this.labelCurrOpacity = new System.Windows.Forms.Label();
            this.labelOpacity = new System.Windows.Forms.Label();
            this.checkViewMouseEnable = new System.Windows.Forms.CheckBox();
            this.checkViewVisible = new System.Windows.Forms.CheckBox();
            this.groupView = new System.Windows.Forms.GroupBox();
            this.udViewLineCount = new System.Windows.Forms.NumericUpDown();
            this.labelViewLineCount = new System.Windows.Forms.Label();
            this.groupFile = new System.Windows.Forms.GroupBox();
            this.btnReflesh = new System.Windows.Forms.Button();
            this.btnFileLoad = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.labelFileName = new System.Windows.Forms.Label();
            this.btnFileDir = new System.Windows.Forms.Button();
            this.txtFileDir = new System.Windows.Forms.TextBox();
            this.labelFileDir = new System.Windows.Forms.Label();
            this.listFile = new System.Windows.Forms.ListBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.linkUpdate = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.udViewY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udViewX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpacity)).BeginInit();
            this.groupView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udViewLineCount)).BeginInit();
            this.groupFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelViewY
            // 
            this.labelViewY.AutoSize = true;
            this.labelViewY.Location = new System.Drawing.Point(222, 117);
            this.labelViewY.Name = "labelViewY";
            this.labelViewY.Size = new System.Drawing.Size(14, 12);
            this.labelViewY.TabIndex = 11;
            this.labelViewY.Text = "Y:";
            // 
            // labelViewX
            // 
            this.labelViewX.AutoSize = true;
            this.labelViewX.Location = new System.Drawing.Point(100, 117);
            this.labelViewX.Name = "labelViewX";
            this.labelViewX.Size = new System.Drawing.Size(14, 12);
            this.labelViewX.TabIndex = 12;
            this.labelViewX.Text = "X:";
            // 
            // udViewY
            // 
            this.udViewY.Location = new System.Drawing.Point(242, 115);
            this.udViewY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.udViewY.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.udViewY.Name = "udViewY";
            this.udViewY.Size = new System.Drawing.Size(80, 19);
            this.udViewY.TabIndex = 9;
            this.udViewY.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udViewY.ValueChanged += new System.EventHandler(this.udViewY_ValueChanged);
            // 
            // udViewX
            // 
            this.udViewX.Location = new System.Drawing.Point(120, 115);
            this.udViewX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.udViewX.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.udViewX.Name = "udViewX";
            this.udViewX.Size = new System.Drawing.Size(80, 19);
            this.udViewX.TabIndex = 10;
            this.udViewX.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.udViewX.ValueChanged += new System.EventHandler(this.udViewX_ValueChanged);
            // 
            // labelViewOrientation
            // 
            this.labelViewOrientation.AutoSize = true;
            this.labelViewOrientation.Location = new System.Drawing.Point(16, 117);
            this.labelViewOrientation.Name = "labelViewOrientation";
            this.labelViewOrientation.Size = new System.Drawing.Size(53, 12);
            this.labelViewOrientation.TabIndex = 8;
            this.labelViewOrientation.Text = "表示位置";
            // 
            // trackBarOpacity
            // 
            this.trackBarOpacity.Location = new System.Drawing.Point(93, 146);
            this.trackBarOpacity.Maximum = 100;
            this.trackBarOpacity.Minimum = 1;
            this.trackBarOpacity.Name = "trackBarOpacity";
            this.trackBarOpacity.Size = new System.Drawing.Size(234, 45);
            this.trackBarOpacity.TabIndex = 7;
            this.trackBarOpacity.TickFrequency = 10;
            this.trackBarOpacity.Value = 80;
            this.trackBarOpacity.ValueChanged += new System.EventHandler(this.trackBarOpacity_ValueChanged);
            // 
            // labelCurrOpacity
            // 
            this.labelCurrOpacity.AutoSize = true;
            this.labelCurrOpacity.Location = new System.Drawing.Point(329, 151);
            this.labelCurrOpacity.Name = "labelCurrOpacity";
            this.labelCurrOpacity.Size = new System.Drawing.Size(21, 12);
            this.labelCurrOpacity.TabIndex = 5;
            this.labelCurrOpacity.Text = "??%";
            // 
            // labelOpacity
            // 
            this.labelOpacity.AutoSize = true;
            this.labelOpacity.Location = new System.Drawing.Point(16, 151);
            this.labelOpacity.Name = "labelOpacity";
            this.labelOpacity.Size = new System.Drawing.Size(53, 12);
            this.labelOpacity.TabIndex = 6;
            this.labelOpacity.Text = "不透明度";
            // 
            // checkViewMouseEnable
            // 
            this.checkViewMouseEnable.AutoSize = true;
            this.checkViewMouseEnable.Checked = true;
            this.checkViewMouseEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkViewMouseEnable.Location = new System.Drawing.Point(16, 54);
            this.checkViewMouseEnable.Name = "checkViewMouseEnable";
            this.checkViewMouseEnable.Size = new System.Drawing.Size(157, 16);
            this.checkViewMouseEnable.TabIndex = 3;
            this.checkViewMouseEnable.Text = "マウスで移動できるようにする";
            this.checkViewMouseEnable.UseVisualStyleBackColor = true;
            this.checkViewMouseEnable.CheckedChanged += new System.EventHandler(this.checkViewMouseEnable_CheckedChanged);
            // 
            // checkViewVisible
            // 
            this.checkViewVisible.AutoSize = true;
            this.checkViewVisible.Checked = true;
            this.checkViewVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkViewVisible.Location = new System.Drawing.Point(16, 27);
            this.checkViewVisible.Name = "checkViewVisible";
            this.checkViewVisible.Size = new System.Drawing.Size(67, 16);
            this.checkViewVisible.TabIndex = 2;
            this.checkViewVisible.Text = "表示する";
            this.checkViewVisible.UseVisualStyleBackColor = true;
            this.checkViewVisible.CheckedChanged += new System.EventHandler(this.checkViewVisible_CheckedChanged);
            // 
            // groupView
            // 
            this.groupView.Controls.Add(this.udViewLineCount);
            this.groupView.Controls.Add(this.labelViewLineCount);
            this.groupView.Controls.Add(this.labelViewY);
            this.groupView.Controls.Add(this.labelViewX);
            this.groupView.Controls.Add(this.udViewY);
            this.groupView.Controls.Add(this.udViewX);
            this.groupView.Controls.Add(this.labelViewOrientation);
            this.groupView.Controls.Add(this.trackBarOpacity);
            this.groupView.Controls.Add(this.labelCurrOpacity);
            this.groupView.Controls.Add(this.labelOpacity);
            this.groupView.Controls.Add(this.checkViewMouseEnable);
            this.groupView.Controls.Add(this.checkViewVisible);
            this.groupView.Location = new System.Drawing.Point(15, 232);
            this.groupView.Name = "groupView";
            this.groupView.Size = new System.Drawing.Size(402, 199);
            this.groupView.TabIndex = 5;
            this.groupView.TabStop = false;
            this.groupView.Text = "ビューア";
            // 
            // udViewLineCount
            // 
            this.udViewLineCount.Location = new System.Drawing.Point(120, 84);
            this.udViewLineCount.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.udViewLineCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udViewLineCount.Name = "udViewLineCount";
            this.udViewLineCount.Size = new System.Drawing.Size(80, 19);
            this.udViewLineCount.TabIndex = 14;
            this.udViewLineCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.udViewLineCount.ValueChanged += new System.EventHandler(this.udViewLineCount_ValueChanged);
            // 
            // labelViewLineCount
            // 
            this.labelViewLineCount.AutoSize = true;
            this.labelViewLineCount.Location = new System.Drawing.Point(16, 86);
            this.labelViewLineCount.Name = "labelViewLineCount";
            this.labelViewLineCount.Size = new System.Drawing.Size(70, 12);
            this.labelViewLineCount.TabIndex = 13;
            this.labelViewLineCount.Text = "スキル表示数";
            // 
            // groupFile
            // 
            this.groupFile.Controls.Add(this.btnReflesh);
            this.groupFile.Controls.Add(this.btnFileLoad);
            this.groupFile.Controls.Add(this.txtFileName);
            this.groupFile.Controls.Add(this.labelFileName);
            this.groupFile.Controls.Add(this.btnFileDir);
            this.groupFile.Controls.Add(this.txtFileDir);
            this.groupFile.Controls.Add(this.labelFileDir);
            this.groupFile.Controls.Add(this.listFile);
            this.groupFile.Location = new System.Drawing.Point(15, 19);
            this.groupFile.Name = "groupFile";
            this.groupFile.Size = new System.Drawing.Size(402, 193);
            this.groupFile.TabIndex = 6;
            this.groupFile.TabStop = false;
            this.groupFile.Text = "データ";
            // 
            // btnReflesh
            // 
            this.btnReflesh.Location = new System.Drawing.Point(331, 48);
            this.btnReflesh.Name = "btnReflesh";
            this.btnReflesh.Size = new System.Drawing.Size(65, 23);
            this.btnReflesh.TabIndex = 20;
            this.btnReflesh.Text = "リフレッシュ";
            this.btnReflesh.UseVisualStyleBackColor = true;
            this.btnReflesh.Click += new System.EventHandler(this.btnReflesh_Click);
            // 
            // btnFileLoad
            // 
            this.btnFileLoad.Location = new System.Drawing.Point(331, 19);
            this.btnFileLoad.Name = "btnFileLoad";
            this.btnFileLoad.Size = new System.Drawing.Size(65, 23);
            this.btnFileLoad.TabIndex = 19;
            this.btnFileLoad.Text = "ロード";
            this.btnFileLoad.UseVisualStyleBackColor = true;
            this.btnFileLoad.Click += new System.EventHandler(this.btnFileLoad_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(110, 160);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(212, 19);
            this.txtFileName.TabIndex = 18;
            this.txtFileName.Text = "(<yyyyMMdd_HHmmss>)<name>";
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(16, 163);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(75, 12);
            this.labelFileName.TabIndex = 17;
            this.labelFileName.Text = "保存ファイル名";
            // 
            // btnFileDir
            // 
            this.btnFileDir.Location = new System.Drawing.Point(331, 127);
            this.btnFileDir.Name = "btnFileDir";
            this.btnFileDir.Size = new System.Drawing.Size(65, 23);
            this.btnFileDir.TabIndex = 16;
            this.btnFileDir.Text = "参照";
            this.btnFileDir.UseVisualStyleBackColor = true;
            this.btnFileDir.Click += new System.EventHandler(this.btnFileDir_Click);
            // 
            // txtFileDir
            // 
            this.txtFileDir.Location = new System.Drawing.Point(110, 129);
            this.txtFileDir.Name = "txtFileDir";
            this.txtFileDir.Size = new System.Drawing.Size(212, 19);
            this.txtFileDir.TabIndex = 15;
            // 
            // labelFileDir
            // 
            this.labelFileDir.AutoSize = true;
            this.labelFileDir.Location = new System.Drawing.Point(16, 132);
            this.labelFileDir.Name = "labelFileDir";
            this.labelFileDir.Size = new System.Drawing.Size(89, 12);
            this.labelFileDir.TabIndex = 14;
            this.labelFileDir.Text = "リソースディレクトリ";
            // 
            // listFile
            // 
            this.listFile.FormattingEnabled = true;
            this.listFile.ItemHeight = 12;
            this.listFile.Location = new System.Drawing.Point(18, 19);
            this.listFile.Name = "listFile";
            this.listFile.Size = new System.Drawing.Size(304, 100);
            this.listFile.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(15, 447);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "バージョン確認";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // linkUpdate
            // 
            this.linkUpdate.AutoSize = true;
            this.linkUpdate.Location = new System.Drawing.Point(136, 452);
            this.linkUpdate.Name = "linkUpdate";
            this.linkUpdate.Size = new System.Drawing.Size(94, 12);
            this.linkUpdate.TabIndex = 9;
            this.linkUpdate.TabStop = true;
            this.linkUpdate.Text = "最新バージョンです";
            this.linkUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkUpdate_LinkClicked);
            // 
            // ACTTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkUpdate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupFile);
            this.Controls.Add(this.groupView);
            this.Name = "ACTTabControl";
            this.Size = new System.Drawing.Size(439, 494);
            ((System.ComponentModel.ISupportInitialize)(this.udViewY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udViewX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpacity)).EndInit();
            this.groupView.ResumeLayout(false);
            this.groupView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udViewLineCount)).EndInit();
            this.groupFile.ResumeLayout(false);
            this.groupFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelViewY;
        private System.Windows.Forms.Label labelViewX;
        private System.Windows.Forms.Label labelViewOrientation;
        private System.Windows.Forms.Label labelCurrOpacity;
        private System.Windows.Forms.Label labelOpacity;
        private System.Windows.Forms.GroupBox groupView;
        private System.Windows.Forms.Label labelViewLineCount;
        private System.Windows.Forms.GroupBox groupFile;
        private System.Windows.Forms.Button btnFileLoad;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Button btnFileDir;
        private System.Windows.Forms.Label labelFileDir;
        private System.Windows.Forms.ListBox listFile;
        private System.Windows.Forms.Button btnReflesh;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.LinkLabel linkUpdate;
        public System.Windows.Forms.NumericUpDown udViewY;
        public System.Windows.Forms.NumericUpDown udViewX;
        public System.Windows.Forms.CheckBox checkViewMouseEnable;
        public System.Windows.Forms.CheckBox checkViewVisible;
        public System.Windows.Forms.NumericUpDown udViewLineCount;
        public System.Windows.Forms.TextBox txtFileName;
        public System.Windows.Forms.TextBox txtFileDir;
        public System.Windows.Forms.TrackBar trackBarOpacity;
    }
}
