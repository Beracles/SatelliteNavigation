using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationLocator
{
    public partial class SelectEpochFrm : Form
    {
        List<string> Epoches;
        public SelectEpochFrm(List<string> epoches)
        {
            InitializeComponent();
            Epoches = epoches;
        }

        private void SelectEpochFrm_Load(object sender, EventArgs e)
        {
            cbx_epoches.Items.AddRange(Epoches.ToArray());
            if (cbx_epoches.Items.Count > 0)
                cbx_epoches.SelectedIndex = 0;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            MainFrm.epochIndex = cbx_epoches.SelectedIndex;
            Close();
        }
    }
}
