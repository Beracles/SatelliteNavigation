namespace SatelliteLocator
{
    partial class MultiProcessFrm
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
            this.gpBx_data = new System.Windows.Forms.GroupBox();
            this.lv_SelectData = new System.Windows.Forms.ListView();
            this.satellitenum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewtime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_toe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Omg0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_i0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_genhaoa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_E = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_w = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_M0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_dn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Omgdot = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Idot = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Cus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Cuc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Crs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Crc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Cis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Cic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_selectAll = new System.Windows.Forms.Button();
            this.btn_calc = new System.Windows.Forms.Button();
            this.btn_selectNone = new System.Windows.Forms.Button();
            this.btn_selectRev = new System.Windows.Forms.Button();
            this.proB_progress = new System.Windows.Forms.ProgressBar();
            this.gpBx_data.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpBx_data
            // 
            this.gpBx_data.Controls.Add(this.lv_SelectData);
            this.gpBx_data.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpBx_data.Location = new System.Drawing.Point(0, 0);
            this.gpBx_data.Name = "gpBx_data";
            this.gpBx_data.Size = new System.Drawing.Size(884, 520);
            this.gpBx_data.TabIndex = 0;
            this.gpBx_data.TabStop = false;
            this.gpBx_data.Text = "请选择要进行处理的数据";
            // 
            // lv_SelectData
            // 
            this.lv_SelectData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.satellitenum,
            this.viewtime,
            this.col_toe,
            this.col_Omg0,
            this.col_i0,
            this.col_genhaoa,
            this.col_E,
            this.col_w,
            this.col_M0,
            this.col_dn,
            this.col_Omgdot,
            this.col_Idot,
            this.col_Cus,
            this.col_Cuc,
            this.col_Crs,
            this.col_Crc,
            this.col_Cis,
            this.col_Cic});
            this.lv_SelectData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_SelectData.FullRowSelect = true;
            this.lv_SelectData.GridLines = true;
            this.lv_SelectData.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_SelectData.HideSelection = false;
            this.lv_SelectData.Location = new System.Drawing.Point(3, 17);
            this.lv_SelectData.Name = "lv_SelectData";
            this.lv_SelectData.Size = new System.Drawing.Size(878, 500);
            this.lv_SelectData.TabIndex = 1;
            this.lv_SelectData.UseCompatibleStateImageBehavior = false;
            this.lv_SelectData.View = System.Windows.Forms.View.Details;
            this.lv_SelectData.SelectedIndexChanged += new System.EventHandler(this.lv_SelectData_SelectedIndexChanged);
            // 
            // satellitenum
            // 
            this.satellitenum.Text = "卫星号";
            this.satellitenum.Width = 50;
            // 
            // viewtime
            // 
            this.viewtime.Text = "观测历元";
            this.viewtime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.viewtime.Width = 160;
            // 
            // col_toe
            // 
            this.col_toe.Text = "toe";
            this.col_toe.Width = 130;
            // 
            // col_Omg0
            // 
            this.col_Omg0.Text = "Ω0";
            this.col_Omg0.Width = 130;
            // 
            // col_i0
            // 
            this.col_i0.Text = "i0";
            this.col_i0.Width = 130;
            // 
            // col_genhaoa
            // 
            this.col_genhaoa.Text = "√a";
            this.col_genhaoa.Width = 130;
            // 
            // col_E
            // 
            this.col_E.Text = "e";
            this.col_E.Width = 130;
            // 
            // col_w
            // 
            this.col_w.Text = "w";
            this.col_w.Width = 130;
            // 
            // col_M0
            // 
            this.col_M0.Text = "M0";
            this.col_M0.Width = 130;
            // 
            // col_dn
            // 
            this.col_dn.Text = "△n";
            this.col_dn.Width = 130;
            // 
            // col_Omgdot
            // 
            this.col_Omgdot.Text = "Ωdot";
            this.col_Omgdot.Width = 130;
            // 
            // col_Idot
            // 
            this.col_Idot.Text = "Idot";
            this.col_Idot.Width = 130;
            // 
            // col_Cus
            // 
            this.col_Cus.Text = "Cus";
            this.col_Cus.Width = 130;
            // 
            // col_Cuc
            // 
            this.col_Cuc.Text = "Cuc";
            this.col_Cuc.Width = 130;
            // 
            // col_Crs
            // 
            this.col_Crs.Text = "Crs";
            this.col_Crs.Width = 130;
            // 
            // col_Crc
            // 
            this.col_Crc.Text = "Crc";
            this.col_Crc.Width = 130;
            // 
            // col_Cis
            // 
            this.col_Cis.Text = "Cis";
            this.col_Cis.Width = 130;
            // 
            // col_Cic
            // 
            this.col_Cic.Text = "Cic";
            this.col_Cic.Width = 130;
            // 
            // btn_selectAll
            // 
            this.btn_selectAll.Location = new System.Drawing.Point(15, 525);
            this.btn_selectAll.Name = "btn_selectAll";
            this.btn_selectAll.Size = new System.Drawing.Size(60, 30);
            this.btn_selectAll.TabIndex = 1;
            this.btn_selectAll.Text = "全选";
            this.btn_selectAll.UseVisualStyleBackColor = true;
            this.btn_selectAll.Click += new System.EventHandler(this.btn_selectAll_Click);
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(780, 525);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(90, 30);
            this.btn_calc.TabIndex = 3;
            this.btn_calc.Text = "计算";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // btn_selectNone
            // 
            this.btn_selectNone.Location = new System.Drawing.Point(80, 525);
            this.btn_selectNone.Name = "btn_selectNone";
            this.btn_selectNone.Size = new System.Drawing.Size(60, 30);
            this.btn_selectNone.TabIndex = 4;
            this.btn_selectNone.Text = "全不选";
            this.btn_selectNone.UseVisualStyleBackColor = true;
            this.btn_selectNone.Click += new System.EventHandler(this.btn_selectNone_Click);
            // 
            // btn_selectRev
            // 
            this.btn_selectRev.Location = new System.Drawing.Point(145, 525);
            this.btn_selectRev.Name = "btn_selectRev";
            this.btn_selectRev.Size = new System.Drawing.Size(60, 30);
            this.btn_selectRev.TabIndex = 5;
            this.btn_selectRev.Text = "反选";
            this.btn_selectRev.UseVisualStyleBackColor = true;
            this.btn_selectRev.Click += new System.EventHandler(this.btn_selectRev_Click);
            // 
            // proB_progress
            // 
            this.proB_progress.Location = new System.Drawing.Point(300, 530);
            this.proB_progress.Name = "proB_progress";
            this.proB_progress.Size = new System.Drawing.Size(300, 20);
            this.proB_progress.Step = 1;
            this.proB_progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.proB_progress.TabIndex = 6;
            this.proB_progress.Visible = false;
            // 
            // MultiProcessFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.proB_progress);
            this.Controls.Add(this.btn_selectRev);
            this.Controls.Add(this.btn_selectNone);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.btn_selectAll);
            this.Controls.Add(this.gpBx_data);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MultiProcessFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "批量处理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MultiProcessFrm_FormClosed);
            this.Load += new System.EventHandler(this.MultiProcessFrm_Load);
            this.gpBx_data.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpBx_data;
        private System.Windows.Forms.ListView lv_SelectData;
        private System.Windows.Forms.ColumnHeader satellitenum;
        private System.Windows.Forms.ColumnHeader viewtime;
        private System.Windows.Forms.ColumnHeader col_toe;
        private System.Windows.Forms.ColumnHeader col_Omg0;
        private System.Windows.Forms.ColumnHeader col_i0;
        private System.Windows.Forms.ColumnHeader col_genhaoa;
        private System.Windows.Forms.ColumnHeader col_E;
        private System.Windows.Forms.ColumnHeader col_w;
        private System.Windows.Forms.ColumnHeader col_M0;
        private System.Windows.Forms.ColumnHeader col_dn;
        private System.Windows.Forms.ColumnHeader col_Omgdot;
        private System.Windows.Forms.ColumnHeader col_Idot;
        private System.Windows.Forms.ColumnHeader col_Cus;
        private System.Windows.Forms.ColumnHeader col_Cuc;
        private System.Windows.Forms.ColumnHeader col_Crs;
        private System.Windows.Forms.ColumnHeader col_Crc;
        private System.Windows.Forms.ColumnHeader col_Cis;
        private System.Windows.Forms.ColumnHeader col_Cic;
        private System.Windows.Forms.Button btn_selectAll;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Button btn_selectNone;
        private System.Windows.Forms.Button btn_selectRev;
        private System.Windows.Forms.ProgressBar proB_progress;
    }
}