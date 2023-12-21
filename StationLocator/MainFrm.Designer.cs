namespace StationLocator
{
    partial class MainFrm
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
            this.btn_calc = new System.Windows.Forms.Button();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.dgv_data = new System.Windows.Forms.DataGridView();
            this.satellitenum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weiju = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ys = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmi_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_ImportWeiju = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_ImportXYZs = new System.Windows.Forms.ToolStripMenuItem();
            this.txtbx_X = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gpbx_result = new System.Windows.Forms.GroupBox();
            this.txtbx_Z = new System.Windows.Forms.TextBox();
            this.txtbx_Y = new System.Windows.Forms.TextBox();
            this.btn_clearUselessData = new System.Windows.Forms.Button();
            this.gpbx_deviation = new System.Windows.Forms.GroupBox();
            this.txtbx_mz = new System.Windows.Forms.TextBox();
            this.txtbx_my = new System.Windows.Forms.TextBox();
            this.txtbx_mx = new System.Windows.Forms.TextBox();
            this.lbl_mx = new System.Windows.Forms.Label();
            this.lbl_mz = new System.Windows.Forms.Label();
            this.lbl_my = new System.Windows.Forms.Label();
            this.lbl_mt = new System.Windows.Forms.Label();
            this.txtbx_mt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gpbx_result.SuspendLayout();
            this.gpbx_deviation.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_calc
            // 
            this.btn_calc.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_calc.Location = new System.Drawing.Point(364, 351);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(75, 27);
            this.btn_calc.TabIndex = 3;
            this.btn_calc.Text = "计算";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // dgv_data
            // 
            this.dgv_data.ColumnHeadersHeight = 20;
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.satellitenum,
            this.weiju,
            this.Xs,
            this.Ys,
            this.Zs,
            this.dts});
            this.dgv_data.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_data.Location = new System.Drawing.Point(0, 25);
            this.dgv_data.MultiSelect = false;
            this.dgv_data.Name = "dgv_data";
            this.dgv_data.ReadOnly = true;
            this.dgv_data.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgv_data.RowTemplate.Height = 23;
            this.dgv_data.Size = new System.Drawing.Size(654, 320);
            this.dgv_data.TabIndex = 4;
            // 
            // satellitenum
            // 
            this.satellitenum.HeaderText = "卫星号";
            this.satellitenum.Name = "satellitenum";
            this.satellitenum.ReadOnly = true;
            this.satellitenum.Width = 50;
            // 
            // weiju
            // 
            this.weiju.HeaderText = "伪距(m)";
            this.weiju.Name = "weiju";
            this.weiju.ReadOnly = true;
            // 
            // Xs
            // 
            this.Xs.HeaderText = "Xs(km)";
            this.Xs.Name = "Xs";
            this.Xs.ReadOnly = true;
            // 
            // Ys
            // 
            this.Ys.HeaderText = "Ys(km)";
            this.Ys.Name = "Ys";
            this.Ys.ReadOnly = true;
            // 
            // Zs
            // 
            this.Zs.HeaderText = "Zs(km)";
            this.Zs.Name = "Zs";
            this.Zs.ReadOnly = true;
            // 
            // dts
            // 
            this.dts.HeaderText = "卫星钟差(us)";
            this.dts.Name = "dts";
            this.dts.ReadOnly = true;
            this.dts.Width = 150;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(654, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmi_menu
            // 
            this.tsmi_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_ImportWeiju,
            this.tsmi_ImportXYZs});
            this.tsmi_menu.Name = "tsmi_menu";
            this.tsmi_menu.Size = new System.Drawing.Size(44, 21);
            this.tsmi_menu.Text = "菜单";
            // 
            // tsmi_ImportWeiju
            // 
            this.tsmi_ImportWeiju.Name = "tsmi_ImportWeiju";
            this.tsmi_ImportWeiju.Size = new System.Drawing.Size(184, 22);
            this.tsmi_ImportWeiju.Text = "导入卫星伪距";
            this.tsmi_ImportWeiju.Click += new System.EventHandler(this.tsmi_ImportWeiju_Click);
            // 
            // tsmi_ImportXYZs
            // 
            this.tsmi_ImportXYZs.Name = "tsmi_ImportXYZs";
            this.tsmi_ImportXYZs.Size = new System.Drawing.Size(184, 22);
            this.tsmi_ImportXYZs.Text = "导入卫星坐标及钟差";
            this.tsmi_ImportXYZs.Click += new System.EventHandler(this.tsmi_ImportXYZs_Click);
            // 
            // txtbx_X
            // 
            this.txtbx_X.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbx_X.Font = new System.Drawing.Font("宋体", 12F);
            this.txtbx_X.Location = new System.Drawing.Point(70, 27);
            this.txtbx_X.Name = "txtbx_X";
            this.txtbx_X.ReadOnly = true;
            this.txtbx_X.Size = new System.Drawing.Size(120, 19);
            this.txtbx_X.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(30, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Z：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(30, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Y：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(30, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "X：";
            // 
            // gpbx_result
            // 
            this.gpbx_result.Controls.Add(this.txtbx_Z);
            this.gpbx_result.Controls.Add(this.txtbx_Y);
            this.gpbx_result.Controls.Add(this.txtbx_X);
            this.gpbx_result.Controls.Add(this.label4);
            this.gpbx_result.Controls.Add(this.label2);
            this.gpbx_result.Controls.Add(this.label3);
            this.gpbx_result.Font = new System.Drawing.Font("宋体", 12F);
            this.gpbx_result.Location = new System.Drawing.Point(50, 400);
            this.gpbx_result.Name = "gpbx_result";
            this.gpbx_result.Size = new System.Drawing.Size(240, 150);
            this.gpbx_result.TabIndex = 11;
            this.gpbx_result.TabStop = false;
            this.gpbx_result.Text = "测站坐标计算结果";
            // 
            // txtbx_Z
            // 
            this.txtbx_Z.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbx_Z.Font = new System.Drawing.Font("宋体", 12F);
            this.txtbx_Z.Location = new System.Drawing.Point(70, 107);
            this.txtbx_Z.Name = "txtbx_Z";
            this.txtbx_Z.ReadOnly = true;
            this.txtbx_Z.Size = new System.Drawing.Size(120, 19);
            this.txtbx_Z.TabIndex = 12;
            // 
            // txtbx_Y
            // 
            this.txtbx_Y.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbx_Y.Font = new System.Drawing.Font("宋体", 12F);
            this.txtbx_Y.Location = new System.Drawing.Point(70, 67);
            this.txtbx_Y.Name = "txtbx_Y";
            this.txtbx_Y.ReadOnly = true;
            this.txtbx_Y.Size = new System.Drawing.Size(120, 19);
            this.txtbx_Y.TabIndex = 11;
            // 
            // btn_clearUselessData
            // 
            this.btn_clearUselessData.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_clearUselessData.Location = new System.Drawing.Point(210, 351);
            this.btn_clearUselessData.Name = "btn_clearUselessData";
            this.btn_clearUselessData.Size = new System.Drawing.Size(113, 27);
            this.btn_clearUselessData.TabIndex = 12;
            this.btn_clearUselessData.Text = "清除无用数据";
            this.btn_clearUselessData.UseVisualStyleBackColor = true;
            this.btn_clearUselessData.Click += new System.EventHandler(this.btn_clearUselessData_Click);
            // 
            // gpbx_deviation
            // 
            this.gpbx_deviation.Controls.Add(this.txtbx_mt);
            this.gpbx_deviation.Controls.Add(this.lbl_mt);
            this.gpbx_deviation.Controls.Add(this.txtbx_mz);
            this.gpbx_deviation.Controls.Add(this.txtbx_my);
            this.gpbx_deviation.Controls.Add(this.txtbx_mx);
            this.gpbx_deviation.Controls.Add(this.lbl_mx);
            this.gpbx_deviation.Controls.Add(this.lbl_mz);
            this.gpbx_deviation.Controls.Add(this.lbl_my);
            this.gpbx_deviation.Font = new System.Drawing.Font("宋体", 12F);
            this.gpbx_deviation.Location = new System.Drawing.Point(350, 400);
            this.gpbx_deviation.Name = "gpbx_deviation";
            this.gpbx_deviation.Size = new System.Drawing.Size(240, 150);
            this.gpbx_deviation.TabIndex = 13;
            this.gpbx_deviation.TabStop = false;
            this.gpbx_deviation.Text = "精度评定";
            // 
            // txtbx_mz
            // 
            this.txtbx_mz.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbx_mz.Font = new System.Drawing.Font("宋体", 12F);
            this.txtbx_mz.Location = new System.Drawing.Point(90, 87);
            this.txtbx_mz.Name = "txtbx_mz";
            this.txtbx_mz.ReadOnly = true;
            this.txtbx_mz.Size = new System.Drawing.Size(120, 19);
            this.txtbx_mz.TabIndex = 12;
            // 
            // txtbx_my
            // 
            this.txtbx_my.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbx_my.Font = new System.Drawing.Font("宋体", 12F);
            this.txtbx_my.Location = new System.Drawing.Point(90, 57);
            this.txtbx_my.Name = "txtbx_my";
            this.txtbx_my.ReadOnly = true;
            this.txtbx_my.Size = new System.Drawing.Size(120, 19);
            this.txtbx_my.TabIndex = 11;
            // 
            // txtbx_mx
            // 
            this.txtbx_mx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbx_mx.Font = new System.Drawing.Font("宋体", 12F);
            this.txtbx_mx.Location = new System.Drawing.Point(90, 27);
            this.txtbx_mx.Name = "txtbx_mx";
            this.txtbx_mx.ReadOnly = true;
            this.txtbx_mx.Size = new System.Drawing.Size(120, 19);
            this.txtbx_mx.TabIndex = 7;
            // 
            // lbl_mx
            // 
            this.lbl_mx.AutoSize = true;
            this.lbl_mx.Font = new System.Drawing.Font("宋体", 12F);
            this.lbl_mx.Location = new System.Drawing.Point(30, 30);
            this.lbl_mx.Name = "lbl_mx";
            this.lbl_mx.Size = new System.Drawing.Size(40, 16);
            this.lbl_mx.TabIndex = 10;
            this.lbl_mx.Text = "mX：";
            // 
            // lbl_mz
            // 
            this.lbl_mz.AutoSize = true;
            this.lbl_mz.Font = new System.Drawing.Font("宋体", 12F);
            this.lbl_mz.Location = new System.Drawing.Point(30, 90);
            this.lbl_mz.Name = "lbl_mz";
            this.lbl_mz.Size = new System.Drawing.Size(40, 16);
            this.lbl_mz.TabIndex = 8;
            this.lbl_mz.Text = "mZ：";
            // 
            // lbl_my
            // 
            this.lbl_my.AutoSize = true;
            this.lbl_my.Font = new System.Drawing.Font("宋体", 12F);
            this.lbl_my.Location = new System.Drawing.Point(30, 60);
            this.lbl_my.Name = "lbl_my";
            this.lbl_my.Size = new System.Drawing.Size(40, 16);
            this.lbl_my.TabIndex = 9;
            this.lbl_my.Text = "mY：";
            // 
            // lbl_mt
            // 
            this.lbl_mt.AutoSize = true;
            this.lbl_mt.Font = new System.Drawing.Font("宋体", 12F);
            this.lbl_mt.Location = new System.Drawing.Point(30, 120);
            this.lbl_mt.Name = "lbl_mt";
            this.lbl_mt.Size = new System.Drawing.Size(40, 16);
            this.lbl_mt.TabIndex = 13;
            this.lbl_mt.Text = "mt：";
            // 
            // txtbx_mt
            // 
            this.txtbx_mt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbx_mt.Font = new System.Drawing.Font("宋体", 12F);
            this.txtbx_mt.Location = new System.Drawing.Point(90, 117);
            this.txtbx_mt.Name = "txtbx_mt";
            this.txtbx_mt.ReadOnly = true;
            this.txtbx_mt.Size = new System.Drawing.Size(120, 19);
            this.txtbx_mt.TabIndex = 14;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 561);
            this.Controls.Add(this.gpbx_deviation);
            this.Controls.Add(this.btn_clearUselessData);
            this.Controls.Add(this.gpbx_result);
            this.Controls.Add(this.dgv_data);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "伪距测量(暂未考虑模型改正)";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gpbx_result.ResumeLayout(false);
            this.gpbx_result.PerformLayout();
            this.gpbx_deviation.ResumeLayout(false);
            this.gpbx_deviation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.DataGridView dgv_data;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_menu;
        private System.Windows.Forms.ToolStripMenuItem tsmi_ImportXYZs;
        private System.Windows.Forms.TextBox txtbx_X;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gpbx_result;
        private System.Windows.Forms.TextBox txtbx_Z;
        private System.Windows.Forms.TextBox txtbx_Y;
        private System.Windows.Forms.Button btn_clearUselessData;
        private System.Windows.Forms.ToolStripMenuItem tsmi_ImportWeiju;
        private System.Windows.Forms.DataGridViewTextBoxColumn satellitenum;
        private System.Windows.Forms.DataGridViewTextBoxColumn weiju;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ys;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zs;
        private System.Windows.Forms.DataGridViewTextBoxColumn dts;
        private System.Windows.Forms.GroupBox gpbx_deviation;
        private System.Windows.Forms.TextBox txtbx_mt;
        private System.Windows.Forms.Label lbl_mt;
        private System.Windows.Forms.TextBox txtbx_mz;
        private System.Windows.Forms.TextBox txtbx_my;
        private System.Windows.Forms.TextBox txtbx_mx;
        private System.Windows.Forms.Label lbl_mx;
        private System.Windows.Forms.Label lbl_mz;
        private System.Windows.Forms.Label lbl_my;
    }
}

