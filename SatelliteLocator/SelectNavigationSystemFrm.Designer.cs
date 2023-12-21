namespace SatelliteLocator
{
    partial class SelectNavigationSystemFrm
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
            this.cBx_NaviSystem = new System.Windows.Forms.ComboBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cBx_NaviSystem
            // 
            this.cBx_NaviSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBx_NaviSystem.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cBx_NaviSystem.FormattingEnabled = true;
            this.cBx_NaviSystem.Location = new System.Drawing.Point(30, 30);
            this.cBx_NaviSystem.Name = "cBx_NaviSystem";
            this.cBx_NaviSystem.Size = new System.Drawing.Size(228, 24);
            this.cBx_NaviSystem.TabIndex = 0;
            this.cBx_NaviSystem.SelectedIndexChanged += new System.EventHandler(this.cBx_NaviSystem_SelectedIndexChanged);
            // 
            // btn_OK
            // 
            this.btn_OK.Enabled = false;
            this.btn_OK.Location = new System.Drawing.Point(100, 70);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 25);
            this.btn_OK.TabIndex = 1;
            this.btn_OK.Text = "确定";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // SelectNavigationSystemFrm
            // 
            this.AcceptButton = this.btn_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.cBx_NaviSystem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectNavigationSystemFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择导航系统类型";
            this.Load += new System.EventHandler(this.SelectNavigationSystemFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cBx_NaviSystem;
        private System.Windows.Forms.Button btn_OK;
    }
}