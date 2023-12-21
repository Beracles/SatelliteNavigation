using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SatelliteLocator
{
    public partial class SelectNavigationSystemFrm : Form
    {
        StreamReader SR;
        Form ParentFrm;
        public SelectNavigationSystemFrm(StreamReader sr,Form frm)
        {
            InitializeComponent();
            SR = sr;
            ParentFrm = frm;
        }

        private void cBx_NaviSystem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBx_NaviSystem.SelectedIndex != -1)
            {
                btn_OK.Enabled = true;
            }
            else
            {
                btn_OK.Enabled = false;
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if(ParentFrm.GetType()==typeof(GetDataNumFrm))
                ((GetDataNumFrm)ParentFrm).NavigationSystem = cBx_NaviSystem.SelectedItem.ToString();
            else if(ParentFrm.GetType() == typeof(MultiProcessFrm))
                ((MultiProcessFrm)ParentFrm).NavigationSystem = cBx_NaviSystem.SelectedItem.ToString();
            Close();
        }

        private void SelectNavigationSystemFrm_Load(object sender, EventArgs e)
        {
            string temp;
            MainFrm.ReadFileHeader(SR);
            while ((temp = SR.ReadLine()) != null)
            {
                if (temp[0] == 'G' && !cBx_NaviSystem.Items.Contains("GPS"))
                {
                    cBx_NaviSystem.Items.Add("GPS");
                }
                if (temp[0] == 'C' && !cBx_NaviSystem.Items.Contains("BDS"))
                {
                    cBx_NaviSystem.Items.Add("BDS");
                }
                if (temp[0] == 'E' && !cBx_NaviSystem.Items.Contains("Galileo"))
                {
                    cBx_NaviSystem.Items.Add("Galileo");
                }
                if (temp[0] == 'R' && !cBx_NaviSystem.Items.Contains("GLONASS"))
                {
                    cBx_NaviSystem.Items.Add("GLONASS");
                }
                if (temp[0] == 'J' && !cBx_NaviSystem.Items.Contains("QZSS"))
                {
                    cBx_NaviSystem.Items.Add("QZSS");
                }
                if (temp[0] == 'S' && !cBx_NaviSystem.Items.Contains("SBAS"))
                {
                    cBx_NaviSystem.Items.Add("SBAS");
                }
                if (temp[0] == 'I' && !cBx_NaviSystem.Items.Contains("IRNSS"))
                {
                    cBx_NaviSystem.Items.Add("IRNSS");
                }
                MainFrm.ReadLines(SR, 3);
            }
            cBx_NaviSystem.SelectedIndex = 0;
        }
    }
}
