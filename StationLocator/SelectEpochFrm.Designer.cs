namespace StationLocator
{
    partial class SelectEpochFrm
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
            this.cbx_epoches = new System.Windows.Forms.ComboBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbx_epoches
            // 
            this.cbx_epoches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_epoches.Font = new System.Drawing.Font("宋体", 12F);
            this.cbx_epoches.FormattingEnabled = true;
            this.cbx_epoches.ItemHeight = 16;
            this.cbx_epoches.Location = new System.Drawing.Point(30, 30);
            this.cbx_epoches.Name = "cbx_epoches";
            this.cbx_epoches.Size = new System.Drawing.Size(250, 24);
            this.cbx_epoches.TabIndex = 0;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(120, 79);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 1;
            this.btn_OK.Text = "确定";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // SelectEpochFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 121);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.cbx_epoches);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectEpochFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择历元";
            this.Load += new System.EventHandler(this.SelectEpochFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_epoches;
        private System.Windows.Forms.Button btn_OK;
    }
}