namespace SatelliteLocator
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
            this.txtBx_toe = new System.Windows.Forms.TextBox();
            this.lbl_toe = new System.Windows.Forms.Label();
            this.gpBx_input = new System.Windows.Forms.GroupBox();
            this.txtBx_satellite_num = new System.Windows.Forms.TextBox();
            this.lbl_satellite_num = new System.Windows.Forms.Label();
            this.txtBx_viewtime = new System.Windows.Forms.TextBox();
            this.lbl_viewtime = new System.Windows.Forms.Label();
            this.txtBx_Crc = new System.Windows.Forms.TextBox();
            this.txtBx_Cic = new System.Windows.Forms.TextBox();
            this.txtBx_Cis = new System.Windows.Forms.TextBox();
            this.txtBx_Omg0 = new System.Windows.Forms.TextBox();
            this.txtBx_i0 = new System.Windows.Forms.TextBox();
            this.txtBx_genhaoa = new System.Windows.Forms.TextBox();
            this.txtBx_e = new System.Windows.Forms.TextBox();
            this.txtBx_w = new System.Windows.Forms.TextBox();
            this.txtBx_M0 = new System.Windows.Forms.TextBox();
            this.txtBx_dn = new System.Windows.Forms.TextBox();
            this.txtBx_OmgDot = new System.Windows.Forms.TextBox();
            this.txtBx_Crs = new System.Windows.Forms.TextBox();
            this.txtBx_Cus = new System.Windows.Forms.TextBox();
            this.txtBx_Cuc = new System.Windows.Forms.TextBox();
            this.txtBx_Idot = new System.Windows.Forms.TextBox();
            this.lbl_Cuc = new System.Windows.Forms.Label();
            this.lbl_Idot = new System.Windows.Forms.Label();
            this.lbl_omgdot = new System.Windows.Forms.Label();
            this.lbl_dn = new System.Windows.Forms.Label();
            this.lbl_M0 = new System.Windows.Forms.Label();
            this.lbl_w = new System.Windows.Forms.Label();
            this.lbl_e = new System.Windows.Forms.Label();
            this.lbl_genhaoa = new System.Windows.Forms.Label();
            this.lbl_Cus = new System.Windows.Forms.Label();
            this.lbl_Crc = new System.Windows.Forms.Label();
            this.lbl_Crs = new System.Windows.Forms.Label();
            this.lbl_Cic = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_I = new System.Windows.Forms.Label();
            this.lbl_Omg = new System.Windows.Forms.Label();
            this.gpBx_output = new System.Windows.Forms.GroupBox();
            this.txtBx_Zk = new System.Windows.Forms.TextBox();
            this.txtBx_Yk = new System.Windows.Forms.TextBox();
            this.txtBx_Xk = new System.Windows.Forms.TextBox();
            this.lbl_Yk = new System.Windows.Forms.Label();
            this.lbl_Zk = new System.Windows.Forms.Label();
            this.lbl_Xk = new System.Windows.Forms.Label();
            this.btn_calc = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.mS = new System.Windows.Forms.MenuStrip();
            this.tsmi_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_importData = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_multiprocess = new System.Windows.Forms.ToolStripMenuItem();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.gpBx_input.SuspendLayout();
            this.gpBx_output.SuspendLayout();
            this.mS.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBx_toe
            // 
            this.txtBx_toe.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBx_toe.Location = new System.Drawing.Point(500, 40);
            this.txtBx_toe.Name = "txtBx_toe";
            this.txtBx_toe.Size = new System.Drawing.Size(180, 26);
            this.txtBx_toe.TabIndex = 0;
            // 
            // lbl_toe
            // 
            this.lbl_toe.AutoSize = true;
            this.lbl_toe.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_toe.Location = new System.Drawing.Point(500, 20);
            this.lbl_toe.Name = "lbl_toe";
            this.lbl_toe.Size = new System.Drawing.Size(160, 16);
            this.lbl_toe.TabIndex = 1;
            this.lbl_toe.Text = "星历表参考历元toe：";
            this.lbl_toe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gpBx_input
            // 
            this.gpBx_input.Controls.Add(this.txtBx_satellite_num);
            this.gpBx_input.Controls.Add(this.lbl_satellite_num);
            this.gpBx_input.Controls.Add(this.txtBx_viewtime);
            this.gpBx_input.Controls.Add(this.lbl_viewtime);
            this.gpBx_input.Controls.Add(this.txtBx_Crc);
            this.gpBx_input.Controls.Add(this.txtBx_Cic);
            this.gpBx_input.Controls.Add(this.txtBx_Cis);
            this.gpBx_input.Controls.Add(this.txtBx_Omg0);
            this.gpBx_input.Controls.Add(this.txtBx_i0);
            this.gpBx_input.Controls.Add(this.txtBx_genhaoa);
            this.gpBx_input.Controls.Add(this.txtBx_e);
            this.gpBx_input.Controls.Add(this.txtBx_w);
            this.gpBx_input.Controls.Add(this.txtBx_M0);
            this.gpBx_input.Controls.Add(this.txtBx_dn);
            this.gpBx_input.Controls.Add(this.txtBx_OmgDot);
            this.gpBx_input.Controls.Add(this.txtBx_Crs);
            this.gpBx_input.Controls.Add(this.txtBx_Cus);
            this.gpBx_input.Controls.Add(this.txtBx_Cuc);
            this.gpBx_input.Controls.Add(this.txtBx_Idot);
            this.gpBx_input.Controls.Add(this.lbl_Cuc);
            this.gpBx_input.Controls.Add(this.lbl_Idot);
            this.gpBx_input.Controls.Add(this.lbl_omgdot);
            this.gpBx_input.Controls.Add(this.lbl_dn);
            this.gpBx_input.Controls.Add(this.lbl_M0);
            this.gpBx_input.Controls.Add(this.lbl_w);
            this.gpBx_input.Controls.Add(this.lbl_e);
            this.gpBx_input.Controls.Add(this.lbl_genhaoa);
            this.gpBx_input.Controls.Add(this.lbl_Cus);
            this.gpBx_input.Controls.Add(this.lbl_Crc);
            this.gpBx_input.Controls.Add(this.lbl_Crs);
            this.gpBx_input.Controls.Add(this.lbl_Cic);
            this.gpBx_input.Controls.Add(this.label3);
            this.gpBx_input.Controls.Add(this.lbl_I);
            this.gpBx_input.Controls.Add(this.lbl_Omg);
            this.gpBx_input.Controls.Add(this.lbl_toe);
            this.gpBx_input.Controls.Add(this.txtBx_toe);
            this.gpBx_input.Location = new System.Drawing.Point(40, 30);
            this.gpBx_input.Name = "gpBx_input";
            this.gpBx_input.Size = new System.Drawing.Size(700, 360);
            this.gpBx_input.TabIndex = 2;
            this.gpBx_input.TabStop = false;
            this.gpBx_input.Text = "参数输入";
            // 
            // txtBx_satellite_num
            // 
            this.txtBx_satellite_num.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBx_satellite_num.Location = new System.Drawing.Point(30, 40);
            this.txtBx_satellite_num.Name = "txtBx_satellite_num";
            this.txtBx_satellite_num.Size = new System.Drawing.Size(110, 26);
            this.txtBx_satellite_num.TabIndex = 35;
            // 
            // lbl_satellite_num
            // 
            this.lbl_satellite_num.AutoSize = true;
            this.lbl_satellite_num.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_satellite_num.Location = new System.Drawing.Point(30, 20);
            this.lbl_satellite_num.Name = "lbl_satellite_num";
            this.lbl_satellite_num.Size = new System.Drawing.Size(72, 16);
            this.lbl_satellite_num.TabIndex = 34;
            this.lbl_satellite_num.Text = "卫星号：";
            this.lbl_satellite_num.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBx_viewtime
            // 
            this.txtBx_viewtime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBx_viewtime.Location = new System.Drawing.Point(195, 40);
            this.txtBx_viewtime.Name = "txtBx_viewtime";
            this.txtBx_viewtime.Size = new System.Drawing.Size(250, 26);
            this.txtBx_viewtime.TabIndex = 33;
            // 
            // lbl_viewtime
            // 
            this.lbl_viewtime.AutoSize = true;
            this.lbl_viewtime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_viewtime.Location = new System.Drawing.Point(195, 20);
            this.lbl_viewtime.Name = "lbl_viewtime";
            this.lbl_viewtime.Size = new System.Drawing.Size(288, 16);
            this.lbl_viewtime.TabIndex = 32;
            this.lbl_viewtime.Text = "观测历元(yyyy-MM-dd HH:mm:ss.fff)：";
            this.lbl_viewtime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBx_Crc
            // 
            this.txtBx_Crc.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBx_Crc.Location = new System.Drawing.Point(500, 260);
            this.txtBx_Crc.Name = "txtBx_Crc";
            this.txtBx_Crc.Size = new System.Drawing.Size(180, 26);
            this.txtBx_Crc.TabIndex = 12;
            // 
            // txtBx_Cic
            // 
            this.txtBx_Cic.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBx_Cic.Location = new System.Drawing.Point(500, 310);
            this.txtBx_Cic.Name = "txtBx_Cic";
            this.txtBx_Cic.Size = new System.Drawing.Size(180, 26);
            this.txtBx_Cic.TabIndex = 15;
            // 
            // txtBx_Cis
            // 
            this.txtBx_Cis.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBx_Cis.Location = new System.Drawing.Point(265, 310);
            this.txtBx_Cis.Name = "txtBx_Cis";
            this.txtBx_Cis.Size = new System.Drawing.Size(180, 26);
            this.txtBx_Cis.TabIndex = 14;
            // 
            // txtBx_Omg0
            // 
            this.txtBx_Omg0.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBx_Omg0.Location = new System.Drawing.Point(30, 100);
            this.txtBx_Omg0.Name = "txtBx_Omg0";
            this.txtBx_Omg0.Size = new System.Drawing.Size(180, 26);
            this.txtBx_Omg0.TabIndex = 1;
            // 
            // txtBx_i0
            // 
            this.txtBx_i0.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBx_i0.Location = new System.Drawing.Point(265, 100);
            this.txtBx_i0.Name = "txtBx_i0";
            this.txtBx_i0.Size = new System.Drawing.Size(180, 26);
            this.txtBx_i0.TabIndex = 2;
            // 
            // txtBx_genhaoa
            // 
            this.txtBx_genhaoa.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBx_genhaoa.Location = new System.Drawing.Point(500, 100);
            this.txtBx_genhaoa.Name = "txtBx_genhaoa";
            this.txtBx_genhaoa.Size = new System.Drawing.Size(180, 26);
            this.txtBx_genhaoa.TabIndex = 3;
            // 
            // txtBx_e
            // 
            this.txtBx_e.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBx_e.Location = new System.Drawing.Point(30, 150);
            this.txtBx_e.Name = "txtBx_e";
            this.txtBx_e.Size = new System.Drawing.Size(180, 26);
            this.txtBx_e.TabIndex = 4;
            // 
            // txtBx_w
            // 
            this.txtBx_w.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBx_w.Location = new System.Drawing.Point(265, 150);
            this.txtBx_w.Name = "txtBx_w";
            this.txtBx_w.Size = new System.Drawing.Size(180, 26);
            this.txtBx_w.TabIndex = 5;
            // 
            // txtBx_M0
            // 
            this.txtBx_M0.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBx_M0.Location = new System.Drawing.Point(500, 150);
            this.txtBx_M0.Name = "txtBx_M0";
            this.txtBx_M0.Size = new System.Drawing.Size(180, 26);
            this.txtBx_M0.TabIndex = 9;
            // 
            // txtBx_dn
            // 
            this.txtBx_dn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBx_dn.Location = new System.Drawing.Point(30, 210);
            this.txtBx_dn.Name = "txtBx_dn";
            this.txtBx_dn.Size = new System.Drawing.Size(180, 26);
            this.txtBx_dn.TabIndex = 7;
            // 
            // txtBx_OmgDot
            // 
            this.txtBx_OmgDot.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBx_OmgDot.Location = new System.Drawing.Point(30, 260);
            this.txtBx_OmgDot.Name = "txtBx_OmgDot";
            this.txtBx_OmgDot.Size = new System.Drawing.Size(180, 26);
            this.txtBx_OmgDot.TabIndex = 10;
            // 
            // txtBx_Crs
            // 
            this.txtBx_Crs.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBx_Crs.Location = new System.Drawing.Point(265, 260);
            this.txtBx_Crs.Name = "txtBx_Crs";
            this.txtBx_Crs.Size = new System.Drawing.Size(180, 26);
            this.txtBx_Crs.TabIndex = 11;
            // 
            // txtBx_Cus
            // 
            this.txtBx_Cus.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBx_Cus.Location = new System.Drawing.Point(265, 210);
            this.txtBx_Cus.Name = "txtBx_Cus";
            this.txtBx_Cus.Size = new System.Drawing.Size(180, 26);
            this.txtBx_Cus.TabIndex = 8;
            // 
            // txtBx_Cuc
            // 
            this.txtBx_Cuc.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBx_Cuc.Location = new System.Drawing.Point(500, 210);
            this.txtBx_Cuc.Name = "txtBx_Cuc";
            this.txtBx_Cuc.Size = new System.Drawing.Size(180, 26);
            this.txtBx_Cuc.TabIndex = 9;
            // 
            // txtBx_Idot
            // 
            this.txtBx_Idot.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBx_Idot.Location = new System.Drawing.Point(30, 310);
            this.txtBx_Idot.Name = "txtBx_Idot";
            this.txtBx_Idot.Size = new System.Drawing.Size(180, 26);
            this.txtBx_Idot.TabIndex = 13;
            // 
            // lbl_Cuc
            // 
            this.lbl_Cuc.AutoSize = true;
            this.lbl_Cuc.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Cuc.Location = new System.Drawing.Point(500, 190);
            this.lbl_Cuc.Name = "lbl_Cuc";
            this.lbl_Cuc.Size = new System.Drawing.Size(192, 16);
            this.lbl_Cuc.TabIndex = 24;
            this.lbl_Cuc.Text = "升交点赤经余弦改正Cuc：";
            // 
            // lbl_Idot
            // 
            this.lbl_Idot.AutoSize = true;
            this.lbl_Idot.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Idot.Location = new System.Drawing.Point(30, 290);
            this.lbl_Idot.Name = "lbl_Idot";
            this.lbl_Idot.Size = new System.Drawing.Size(168, 16);
            this.lbl_Idot.TabIndex = 28;
            this.lbl_Idot.Text = "轨道倾角变化率Idot：";
            // 
            // lbl_omgdot
            // 
            this.lbl_omgdot.AutoSize = true;
            this.lbl_omgdot.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_omgdot.Location = new System.Drawing.Point(30, 240);
            this.lbl_omgdot.Name = "lbl_omgdot";
            this.lbl_omgdot.Size = new System.Drawing.Size(192, 16);
            this.lbl_omgdot.TabIndex = 25;
            this.lbl_omgdot.Text = "升交点赤经变化率Ωdot：";
            // 
            // lbl_dn
            // 
            this.lbl_dn.AutoSize = true;
            this.lbl_dn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_dn.Location = new System.Drawing.Point(30, 190);
            this.lbl_dn.Name = "lbl_dn";
            this.lbl_dn.Size = new System.Drawing.Size(160, 16);
            this.lbl_dn.TabIndex = 22;
            this.lbl_dn.Text = "平均角速度之差△n：";
            // 
            // lbl_M0
            // 
            this.lbl_M0.AutoSize = true;
            this.lbl_M0.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_M0.Location = new System.Drawing.Point(500, 130);
            this.lbl_M0.Name = "lbl_M0";
            this.lbl_M0.Size = new System.Drawing.Size(160, 16);
            this.lbl_M0.TabIndex = 21;
            this.lbl_M0.Text = "toe时的平近点角M0：";
            // 
            // lbl_w
            // 
            this.lbl_w.AutoSize = true;
            this.lbl_w.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_w.Location = new System.Drawing.Point(265, 130);
            this.lbl_w.Name = "lbl_w";
            this.lbl_w.Size = new System.Drawing.Size(112, 16);
            this.lbl_w.TabIndex = 20;
            this.lbl_w.Text = "近地点角距w：";
            // 
            // lbl_e
            // 
            this.lbl_e.AutoSize = true;
            this.lbl_e.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_e.Location = new System.Drawing.Point(30, 130);
            this.lbl_e.Name = "lbl_e";
            this.lbl_e.Size = new System.Drawing.Size(112, 16);
            this.lbl_e.TabIndex = 19;
            this.lbl_e.Text = "轨道偏心率e：";
            // 
            // lbl_genhaoa
            // 
            this.lbl_genhaoa.AutoSize = true;
            this.lbl_genhaoa.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_genhaoa.Location = new System.Drawing.Point(500, 80);
            this.lbl_genhaoa.Name = "lbl_genhaoa";
            this.lbl_genhaoa.Size = new System.Drawing.Size(192, 16);
            this.lbl_genhaoa.TabIndex = 18;
            this.lbl_genhaoa.Text = "轨道长半径的平方根√a：";
            // 
            // lbl_Cus
            // 
            this.lbl_Cus.AutoSize = true;
            this.lbl_Cus.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Cus.Location = new System.Drawing.Point(265, 190);
            this.lbl_Cus.Name = "lbl_Cus";
            this.lbl_Cus.Size = new System.Drawing.Size(192, 16);
            this.lbl_Cus.TabIndex = 23;
            this.lbl_Cus.Text = "升交点赤经正弦改正Cus：";
            // 
            // lbl_Crc
            // 
            this.lbl_Crc.AutoSize = true;
            this.lbl_Crc.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Crc.Location = new System.Drawing.Point(500, 240);
            this.lbl_Crc.Name = "lbl_Crc";
            this.lbl_Crc.Size = new System.Drawing.Size(144, 16);
            this.lbl_Crc.TabIndex = 27;
            this.lbl_Crc.Text = "向径余弦改正Crc：";
            // 
            // lbl_Crs
            // 
            this.lbl_Crs.AutoSize = true;
            this.lbl_Crs.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Crs.Location = new System.Drawing.Point(265, 240);
            this.lbl_Crs.Name = "lbl_Crs";
            this.lbl_Crs.Size = new System.Drawing.Size(144, 16);
            this.lbl_Crs.TabIndex = 26;
            this.lbl_Crs.Text = "向径正弦改正Crs：";
            // 
            // lbl_Cic
            // 
            this.lbl_Cic.AutoSize = true;
            this.lbl_Cic.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Cic.Location = new System.Drawing.Point(500, 290);
            this.lbl_Cic.Name = "lbl_Cic";
            this.lbl_Cic.Size = new System.Drawing.Size(176, 16);
            this.lbl_Cic.TabIndex = 30;
            this.lbl_Cic.Text = "轨道倾角余弦改正Cic：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(265, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "轨道倾角正弦改正Cis：";
            // 
            // lbl_I
            // 
            this.lbl_I.AutoSize = true;
            this.lbl_I.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_I.Location = new System.Drawing.Point(265, 80);
            this.lbl_I.Name = "lbl_I";
            this.lbl_I.Size = new System.Drawing.Size(160, 16);
            this.lbl_I.TabIndex = 17;
            this.lbl_I.Text = "toe时的轨道倾角i0：";
            // 
            // lbl_Omg
            // 
            this.lbl_Omg.AutoSize = true;
            this.lbl_Omg.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Omg.Location = new System.Drawing.Point(30, 80);
            this.lbl_Omg.Name = "lbl_Omg";
            this.lbl_Omg.Size = new System.Drawing.Size(184, 16);
            this.lbl_Omg.TabIndex = 16;
            this.lbl_Omg.Text = "toe时的升交点赤经Ω0：";
            // 
            // gpBx_output
            // 
            this.gpBx_output.Controls.Add(this.txtBx_Zk);
            this.gpBx_output.Controls.Add(this.txtBx_Yk);
            this.gpBx_output.Controls.Add(this.txtBx_Xk);
            this.gpBx_output.Controls.Add(this.lbl_Yk);
            this.gpBx_output.Controls.Add(this.lbl_Zk);
            this.gpBx_output.Controls.Add(this.lbl_Xk);
            this.gpBx_output.Location = new System.Drawing.Point(230, 450);
            this.gpBx_output.Name = "gpBx_output";
            this.gpBx_output.Size = new System.Drawing.Size(300, 100);
            this.gpBx_output.TabIndex = 3;
            this.gpBx_output.TabStop = false;
            this.gpBx_output.Text = "输出";
            // 
            // txtBx_Zk
            // 
            this.txtBx_Zk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_Zk.Location = new System.Drawing.Point(70, 76);
            this.txtBx_Zk.Name = "txtBx_Zk";
            this.txtBx_Zk.ReadOnly = true;
            this.txtBx_Zk.Size = new System.Drawing.Size(200, 14);
            this.txtBx_Zk.TabIndex = 54;
            // 
            // txtBx_Yk
            // 
            this.txtBx_Yk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_Yk.Location = new System.Drawing.Point(70, 51);
            this.txtBx_Yk.Name = "txtBx_Yk";
            this.txtBx_Yk.ReadOnly = true;
            this.txtBx_Yk.Size = new System.Drawing.Size(200, 14);
            this.txtBx_Yk.TabIndex = 53;
            // 
            // txtBx_Xk
            // 
            this.txtBx_Xk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_Xk.Location = new System.Drawing.Point(70, 26);
            this.txtBx_Xk.Name = "txtBx_Xk";
            this.txtBx_Xk.ReadOnly = true;
            this.txtBx_Xk.Size = new System.Drawing.Size(200, 14);
            this.txtBx_Xk.TabIndex = 52;
            // 
            // lbl_Yk
            // 
            this.lbl_Yk.AutoSize = true;
            this.lbl_Yk.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Yk.Location = new System.Drawing.Point(25, 50);
            this.lbl_Yk.Name = "lbl_Yk";
            this.lbl_Yk.Size = new System.Drawing.Size(40, 16);
            this.lbl_Yk.TabIndex = 51;
            this.lbl_Yk.Text = "Yk：";
            // 
            // lbl_Zk
            // 
            this.lbl_Zk.AutoSize = true;
            this.lbl_Zk.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Zk.Location = new System.Drawing.Point(25, 75);
            this.lbl_Zk.Name = "lbl_Zk";
            this.lbl_Zk.Size = new System.Drawing.Size(40, 16);
            this.lbl_Zk.TabIndex = 50;
            this.lbl_Zk.Text = "Zk：";
            // 
            // lbl_Xk
            // 
            this.lbl_Xk.AutoSize = true;
            this.lbl_Xk.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Xk.Location = new System.Drawing.Point(25, 25);
            this.lbl_Xk.Name = "lbl_Xk";
            this.lbl_Xk.Size = new System.Drawing.Size(40, 16);
            this.lbl_Xk.TabIndex = 49;
            this.lbl_Xk.Text = "Xk：";
            // 
            // btn_calc
            // 
            this.btn_calc.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_calc.Location = new System.Drawing.Point(430, 410);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(100, 30);
            this.btn_calc.TabIndex = 4;
            this.btn_calc.Text = "计算";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_clear.Location = new System.Drawing.Point(250, 410);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(100, 30);
            this.btn_clear.TabIndex = 5;
            this.btn_clear.Text = "清空参数";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // mS
            // 
            this.mS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Menu});
            this.mS.Location = new System.Drawing.Point(0, 0);
            this.mS.Name = "mS";
            this.mS.Size = new System.Drawing.Size(784, 25);
            this.mS.TabIndex = 6;
            this.mS.Text = "menuStrip1";
            // 
            // tsmi_Menu
            // 
            this.tsmi_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_importData,
            this.tsmi_multiprocess});
            this.tsmi_Menu.Name = "tsmi_Menu";
            this.tsmi_Menu.Size = new System.Drawing.Size(44, 21);
            this.tsmi_Menu.Text = "菜单";
            // 
            // tsmi_importData
            // 
            this.tsmi_importData.Name = "tsmi_importData";
            this.tsmi_importData.Size = new System.Drawing.Size(180, 22);
            this.tsmi_importData.Text = "导入数据";
            this.tsmi_importData.Click += new System.EventHandler(this.tsmi_importData_Click);
            // 
            // tsmi_multiprocess
            // 
            this.tsmi_multiprocess.Name = "tsmi_multiprocess";
            this.tsmi_multiprocess.Size = new System.Drawing.Size(180, 22);
            this.tsmi_multiprocess.Text = "批量计算";
            this.tsmi_multiprocess.Click += new System.EventHandler(this.tsmi_multiprocess_Click);
            // 
            // OFD
            // 
            this.OFD.Filter = "GPS文件(*.20n)|*.20n|BDS文件(*.20p)|*.20p";
            // 
            // MainFrm
            // 
            this.AcceptButton = this.btn_calc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.gpBx_output);
            this.Controls.Add(this.gpBx_input);
            this.Controls.Add(this.mS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "卫星位置解算";
            this.gpBx_input.ResumeLayout(false);
            this.gpBx_input.PerformLayout();
            this.gpBx_output.ResumeLayout(false);
            this.gpBx_output.PerformLayout();
            this.mS.ResumeLayout(false);
            this.mS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBx_toe;
        private System.Windows.Forms.Label lbl_toe;
        private System.Windows.Forms.GroupBox gpBx_input;
        private System.Windows.Forms.TextBox txtBx_Omg0;
        private System.Windows.Forms.TextBox txtBx_i0;
        private System.Windows.Forms.TextBox txtBx_genhaoa;
        private System.Windows.Forms.TextBox txtBx_e;
        private System.Windows.Forms.TextBox txtBx_w;
        private System.Windows.Forms.TextBox txtBx_M0;
        private System.Windows.Forms.TextBox txtBx_dn;
        private System.Windows.Forms.TextBox txtBx_OmgDot;
        private System.Windows.Forms.TextBox txtBx_Crs;
        private System.Windows.Forms.TextBox txtBx_Cus;
        private System.Windows.Forms.TextBox txtBx_Cuc;
        private System.Windows.Forms.TextBox txtBx_Idot;
        private System.Windows.Forms.Label lbl_Cuc;
        private System.Windows.Forms.Label lbl_Idot;
        private System.Windows.Forms.Label lbl_omgdot;
        private System.Windows.Forms.Label lbl_dn;
        private System.Windows.Forms.Label lbl_M0;
        private System.Windows.Forms.Label lbl_w;
        private System.Windows.Forms.Label lbl_e;
        private System.Windows.Forms.Label lbl_genhaoa;
        private System.Windows.Forms.Label lbl_Cus;
        private System.Windows.Forms.Label lbl_Crc;
        private System.Windows.Forms.Label lbl_Crs;
        private System.Windows.Forms.Label lbl_Cic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_I;
        private System.Windows.Forms.Label lbl_Omg;
        private System.Windows.Forms.TextBox txtBx_Crc;
        private System.Windows.Forms.TextBox txtBx_Cic;
        private System.Windows.Forms.TextBox txtBx_Cis;
        private System.Windows.Forms.GroupBox gpBx_output;
        private System.Windows.Forms.TextBox txtBx_Zk;
        private System.Windows.Forms.TextBox txtBx_Yk;
        private System.Windows.Forms.TextBox txtBx_Xk;
        private System.Windows.Forms.Label lbl_Yk;
        private System.Windows.Forms.Label lbl_Zk;
        private System.Windows.Forms.Label lbl_Xk;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.MenuStrip mS;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Menu;
        private System.Windows.Forms.ToolStripMenuItem tsmi_importData;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.Label lbl_viewtime;
        private System.Windows.Forms.TextBox txtBx_viewtime;
        private System.Windows.Forms.ToolStripMenuItem tsmi_multiprocess;
        private System.Windows.Forms.TextBox txtBx_satellite_num;
        private System.Windows.Forms.Label lbl_satellite_num;
    }
}

