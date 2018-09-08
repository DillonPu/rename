namespace rename
{
    partial class form_main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_main));
            this.btn_convert = new System.Windows.Forms.Button();
            this.lbl_dirname = new System.Windows.Forms.Label();
            this.txtBox_showPath = new System.Windows.Forms.TextBox();
            this.btn_selectDir = new System.Windows.Forms.Button();
            this.lbl_beginNumber = new System.Windows.Forms.Label();
            this.lbl_numPostion = new System.Windows.Forms.Label();
            this.radioBtn_begin = new System.Windows.Forms.RadioButton();
            this.radioBtn_end = new System.Windows.Forms.RadioButton();
            this.lbl_prefix = new System.Windows.Forms.Label();
            this.txtBox_prefix = new System.Windows.Forms.TextBox();
            this.lbl_namePreview = new System.Windows.Forms.Label();
            this.lbl_showPreview = new System.Windows.Forms.Label();
            this.lbl_split = new System.Windows.Forms.Label();
            this.txtBox_split = new System.Windows.Forms.TextBox();
            this.txtxBox_beginNumber = new System.Windows.Forms.NumericUpDown();
            this.richTxtBox_result = new System.Windows.Forms.RichTextBox();
            this.lbl_mainName = new System.Windows.Forms.Label();
            this.txtBox_mainName = new System.Windows.Forms.TextBox();
            this.lbl_back = new System.Windows.Forms.Label();
            this.chkBox_isBack = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtxBox_beginNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(244, 464);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(75, 23);
            this.btn_convert.TabIndex = 0;
            this.btn_convert.Text = "转换";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // lbl_dirname
            // 
            this.lbl_dirname.AutoSize = true;
            this.lbl_dirname.Font = new System.Drawing.Font("宋体", 12F);
            this.lbl_dirname.Location = new System.Drawing.Point(12, 229);
            this.lbl_dirname.Name = "lbl_dirname";
            this.lbl_dirname.Size = new System.Drawing.Size(96, 16);
            this.lbl_dirname.TabIndex = 1;
            this.lbl_dirname.Text = "选择文件夹:";
            // 
            // txtBox_showPath
            // 
            this.txtBox_showPath.Location = new System.Drawing.Point(114, 224);
            this.txtBox_showPath.Name = "txtBox_showPath";
            this.txtBox_showPath.Size = new System.Drawing.Size(334, 21);
            this.txtBox_showPath.TabIndex = 2;
            // 
            // btn_selectDir
            // 
            this.btn_selectDir.Location = new System.Drawing.Point(466, 224);
            this.btn_selectDir.Name = "btn_selectDir";
            this.btn_selectDir.Size = new System.Drawing.Size(75, 23);
            this.btn_selectDir.TabIndex = 3;
            this.btn_selectDir.Text = "浏览";
            this.btn_selectDir.UseVisualStyleBackColor = true;
            this.btn_selectDir.Click += new System.EventHandler(this.btn_selectDir_Click);
            // 
            // lbl_beginNumber
            // 
            this.lbl_beginNumber.AutoSize = true;
            this.lbl_beginNumber.Font = new System.Drawing.Font("宋体", 12F);
            this.lbl_beginNumber.Location = new System.Drawing.Point(287, 9);
            this.lbl_beginNumber.Name = "lbl_beginNumber";
            this.lbl_beginNumber.Size = new System.Drawing.Size(80, 16);
            this.lbl_beginNumber.TabIndex = 5;
            this.lbl_beginNumber.Text = "开始编号:";
            // 
            // lbl_numPostion
            // 
            this.lbl_numPostion.AutoSize = true;
            this.lbl_numPostion.Font = new System.Drawing.Font("宋体", 12F);
            this.lbl_numPostion.Location = new System.Drawing.Point(28, 89);
            this.lbl_numPostion.Name = "lbl_numPostion";
            this.lbl_numPostion.Size = new System.Drawing.Size(80, 16);
            this.lbl_numPostion.TabIndex = 6;
            this.lbl_numPostion.Text = "编号位置:";
            // 
            // radioBtn_begin
            // 
            this.radioBtn_begin.AutoSize = true;
            this.radioBtn_begin.Checked = true;
            this.radioBtn_begin.Location = new System.Drawing.Point(114, 89);
            this.radioBtn_begin.Name = "radioBtn_begin";
            this.radioBtn_begin.Size = new System.Drawing.Size(35, 16);
            this.radioBtn_begin.TabIndex = 8;
            this.radioBtn_begin.TabStop = true;
            this.radioBtn_begin.Text = "首";
            this.radioBtn_begin.UseVisualStyleBackColor = true;
            this.radioBtn_begin.CheckedChanged += new System.EventHandler(this.radioBtn_begin_CheckedChanged);
            // 
            // radioBtn_end
            // 
            this.radioBtn_end.AutoSize = true;
            this.radioBtn_end.Location = new System.Drawing.Point(172, 88);
            this.radioBtn_end.Name = "radioBtn_end";
            this.radioBtn_end.Size = new System.Drawing.Size(35, 16);
            this.radioBtn_end.TabIndex = 9;
            this.radioBtn_end.Text = "尾";
            this.radioBtn_end.UseVisualStyleBackColor = true;
            this.radioBtn_end.CheckedChanged += new System.EventHandler(this.radioBtn_end_CheckedChanged);
            // 
            // lbl_prefix
            // 
            this.lbl_prefix.AutoSize = true;
            this.lbl_prefix.Font = new System.Drawing.Font("宋体", 12F);
            this.lbl_prefix.Location = new System.Drawing.Point(25, 9);
            this.lbl_prefix.Name = "lbl_prefix";
            this.lbl_prefix.Size = new System.Drawing.Size(80, 16);
            this.lbl_prefix.TabIndex = 10;
            this.lbl_prefix.Text = "命名前缀:";
            // 
            // txtBox_prefix
            // 
            this.txtBox_prefix.Location = new System.Drawing.Point(114, 9);
            this.txtBox_prefix.Name = "txtBox_prefix";
            this.txtBox_prefix.Size = new System.Drawing.Size(100, 21);
            this.txtBox_prefix.TabIndex = 11;
            this.txtBox_prefix.TextChanged += new System.EventHandler(this.txtBox_prefix_TextChanged);
            // 
            // lbl_namePreview
            // 
            this.lbl_namePreview.AutoSize = true;
            this.lbl_namePreview.Font = new System.Drawing.Font("宋体", 12F);
            this.lbl_namePreview.Location = new System.Drawing.Point(12, 196);
            this.lbl_namePreview.Name = "lbl_namePreview";
            this.lbl_namePreview.Size = new System.Drawing.Size(96, 16);
            this.lbl_namePreview.TabIndex = 12;
            this.lbl_namePreview.Text = "文件名预览:";
            // 
            // lbl_showPreview
            // 
            this.lbl_showPreview.AutoSize = true;
            this.lbl_showPreview.Location = new System.Drawing.Point(114, 196);
            this.lbl_showPreview.Name = "lbl_showPreview";
            this.lbl_showPreview.Size = new System.Drawing.Size(29, 12);
            this.lbl_showPreview.TabIndex = 13;
            this.lbl_showPreview.Text = "预览";
            // 
            // lbl_split
            // 
            this.lbl_split.AutoSize = true;
            this.lbl_split.Font = new System.Drawing.Font("宋体", 12F);
            this.lbl_split.Location = new System.Drawing.Point(41, 47);
            this.lbl_split.Name = "lbl_split";
            this.lbl_split.Size = new System.Drawing.Size(64, 16);
            this.lbl_split.TabIndex = 14;
            this.lbl_split.Text = "分隔符:";
            // 
            // txtBox_split
            // 
            this.txtBox_split.Location = new System.Drawing.Point(111, 47);
            this.txtBox_split.Name = "txtBox_split";
            this.txtBox_split.Size = new System.Drawing.Size(100, 21);
            this.txtBox_split.TabIndex = 15;
            this.txtBox_split.Text = "-";
            this.txtBox_split.TextChanged += new System.EventHandler(this.txtBox_split_TextChanged);
            // 
            // txtxBox_beginNumber
            // 
            this.txtxBox_beginNumber.Location = new System.Drawing.Point(373, 9);
            this.txtxBox_beginNumber.Name = "txtxBox_beginNumber";
            this.txtxBox_beginNumber.Size = new System.Drawing.Size(101, 21);
            this.txtxBox_beginNumber.TabIndex = 16;
            this.txtxBox_beginNumber.ValueChanged += new System.EventHandler(this.txtxBox_beginNumber_ValueChanged);
            // 
            // richTxtBox_result
            // 
            this.richTxtBox_result.Location = new System.Drawing.Point(15, 265);
            this.richTxtBox_result.Name = "richTxtBox_result";
            this.richTxtBox_result.Size = new System.Drawing.Size(527, 180);
            this.richTxtBox_result.TabIndex = 17;
            this.richTxtBox_result.Text = "";
            // 
            // lbl_mainName
            // 
            this.lbl_mainName.AutoSize = true;
            this.lbl_mainName.Font = new System.Drawing.Font("宋体", 12F);
            this.lbl_mainName.Location = new System.Drawing.Point(287, 47);
            this.lbl_mainName.Name = "lbl_mainName";
            this.lbl_mainName.Size = new System.Drawing.Size(80, 16);
            this.lbl_mainName.TabIndex = 18;
            this.lbl_mainName.Text = "主文件名:";
            // 
            // txtBox_mainName
            // 
            this.txtBox_mainName.Location = new System.Drawing.Point(372, 47);
            this.txtBox_mainName.Name = "txtBox_mainName";
            this.txtBox_mainName.Size = new System.Drawing.Size(100, 21);
            this.txtBox_mainName.TabIndex = 19;
            this.txtBox_mainName.Text = "文件主名";
            // 
            // lbl_back
            // 
            this.lbl_back.AutoSize = true;
            this.lbl_back.Font = new System.Drawing.Font("宋体", 12F);
            this.lbl_back.Location = new System.Drawing.Point(29, 131);
            this.lbl_back.Name = "lbl_back";
            this.lbl_back.Size = new System.Drawing.Size(80, 16);
            this.lbl_back.TabIndex = 20;
            this.lbl_back.Text = "是否备份:";
            // 
            // chkBox_isBack
            // 
            this.chkBox_isBack.AutoSize = true;
            this.chkBox_isBack.Checked = true;
            this.chkBox_isBack.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBox_isBack.Location = new System.Drawing.Point(116, 131);
            this.chkBox_isBack.Name = "chkBox_isBack";
            this.chkBox_isBack.Size = new System.Drawing.Size(48, 16);
            this.chkBox_isBack.TabIndex = 21;
            this.chkBox_isBack.Text = "备份";
            this.chkBox_isBack.UseVisualStyleBackColor = true;
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 537);
            this.Controls.Add(this.chkBox_isBack);
            this.Controls.Add(this.lbl_back);
            this.Controls.Add(this.txtBox_mainName);
            this.Controls.Add(this.lbl_mainName);
            this.Controls.Add(this.richTxtBox_result);
            this.Controls.Add(this.txtxBox_beginNumber);
            this.Controls.Add(this.txtBox_split);
            this.Controls.Add(this.lbl_split);
            this.Controls.Add(this.lbl_showPreview);
            this.Controls.Add(this.lbl_namePreview);
            this.Controls.Add(this.txtBox_prefix);
            this.Controls.Add(this.lbl_prefix);
            this.Controls.Add(this.radioBtn_end);
            this.Controls.Add(this.radioBtn_begin);
            this.Controls.Add(this.lbl_numPostion);
            this.Controls.Add(this.lbl_beginNumber);
            this.Controls.Add(this.btn_selectDir);
            this.Controls.Add(this.txtBox_showPath);
            this.Controls.Add(this.lbl_dirname);
            this.Controls.Add(this.btn_convert);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_main";
            this.Text = "rename";
            ((System.ComponentModel.ISupportInitialize)(this.txtxBox_beginNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.Label lbl_dirname;
        private System.Windows.Forms.TextBox txtBox_showPath;
        private System.Windows.Forms.Button btn_selectDir;
        private System.Windows.Forms.Label lbl_beginNumber;
        private System.Windows.Forms.Label lbl_numPostion;
        private System.Windows.Forms.RadioButton radioBtn_begin;
        private System.Windows.Forms.RadioButton radioBtn_end;
        private System.Windows.Forms.Label lbl_prefix;
        private System.Windows.Forms.TextBox txtBox_prefix;
        private System.Windows.Forms.Label lbl_namePreview;
        private System.Windows.Forms.Label lbl_showPreview;
        private System.Windows.Forms.Label lbl_split;
        private System.Windows.Forms.TextBox txtBox_split;
        private System.Windows.Forms.NumericUpDown txtxBox_beginNumber;
        private System.Windows.Forms.RichTextBox richTxtBox_result;
        private System.Windows.Forms.Label lbl_mainName;
        private System.Windows.Forms.TextBox txtBox_mainName;
        private System.Windows.Forms.Label lbl_back;
        private System.Windows.Forms.CheckBox chkBox_isBack;
    }
}

