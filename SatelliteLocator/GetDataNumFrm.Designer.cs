namespace SatelliteLocator
{
    partial class GetDataNumFrm
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
            this.lv_SelectData = new System.Windows.Forms.ListView();
            this.satellitenum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewtime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_SelectData
            // 
            this.lv_SelectData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.satellitenum,
            this.viewtime});
            this.lv_SelectData.Dock = System.Windows.Forms.DockStyle.Top;
            this.lv_SelectData.FullRowSelect = true;
            this.lv_SelectData.GridLines = true;
            this.lv_SelectData.HideSelection = false;
            this.lv_SelectData.Location = new System.Drawing.Point(0, 0);
            this.lv_SelectData.MultiSelect = false;
            this.lv_SelectData.Name = "lv_SelectData";
            this.lv_SelectData.Size = new System.Drawing.Size(384, 320);
            this.lv_SelectData.TabIndex = 0;
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
            this.viewtime.Width = 320;
            // 
            // btn_OK
            // 
            this.btn_OK.Enabled = false;
            this.btn_OK.Location = new System.Drawing.Point(280, 330);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 25);
            this.btn_OK.TabIndex = 1;
            this.btn_OK.Text = "确定";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // GetDataNumFrm
            // 
            this.AcceptButton = this.btn_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.lv_SelectData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GetDataNumFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择要采用的数据";
            this.Load += new System.EventHandler(this.GetDataNumFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_SelectData;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.ColumnHeader satellitenum;
        private System.Windows.Forms.ColumnHeader viewtime;
    }
}