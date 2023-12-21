using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatelliteLocator
{
    public partial class ShowMultiProcessResultFrm : Form
    {
        public static Timer timer = new Timer()
        {
            Enabled = true
        };
        
        public ShowMultiProcessResultFrm()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(UpdateProcessResult);
        }

        private void UpdateProcessResult(object sender, EventArgs e)
        {
            dgv_Result.DataSource = MultiProcessFrm.tb_result;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowMultiProcessResultFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            MultiProcessFrm.tb_result.Clear();
        }
    }
}
