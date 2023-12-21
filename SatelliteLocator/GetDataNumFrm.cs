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
    public partial class GetDataNumFrm : Form
    {
        public string NavigationSystem = "";
        OpenFileDialog OFD;
        public GetDataNumFrm(OpenFileDialog ofd)
        {
            InitializeComponent();
            OFD = ofd;
        }

        private void GetDataNumFrm_Load(object sender, EventArgs e)
        {
            FileStream fs;
            try
            {
                fs = File.Open(OFD.FileName, FileMode.Open);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                return;
            }
            StreamReader sr = new StreamReader(fs);

            string temp, satellite_num;
            int year, month, day, hour, min;
            double sec;
            if (OFD.FileName.EndsWith(".20n"))
            {
                MainFrm.ReadFileHeader(sr);
                while ((temp = sr.ReadLine()) != null)
                {
                    satellite_num = MainFrm.TakeStringPiece(temp, 1, 2);
                    year = Convert.ToInt32(MainFrm.TakeStringPiece(temp, 4, 2));
                    month = Convert.ToInt32(MainFrm.TakeStringPiece(temp, 7, 2));
                    day = Convert.ToInt32(MainFrm.TakeStringPiece(temp, 10, 2));
                    hour = Convert.ToInt32(MainFrm.TakeStringPiece(temp, 13, 2));
                    min = Convert.ToInt32(MainFrm.TakeStringPiece(temp, 16, 2));
                    sec = Convert.ToDouble(MainFrm.TakeStringPiece(temp, 19, 4));
                    temp = string.Format("20{0}-{1}-{2} {3}:{4}:{5}.{6}", year, month.ToString("D2"),
                        day.ToString("D2"), hour.ToString("D2"), min.ToString("D2"), ((int)sec).ToString("D2"), ((sec - (int)sec) * 1000).ToString());
                    ListViewItem item = new ListViewItem(satellite_num);
                    item.SubItems.Add(temp);
                    lv_SelectData.Items.Add(item);
                    MainFrm.ReadLines(sr, 7);
                }
            }
            else if (OFD.FileName.EndsWith(".20p"))
            {
                SelectNavigationSystemFrm selectfrm = new SelectNavigationSystemFrm(sr,this);
                selectfrm.ShowDialog();

                char NS;
                switch (NavigationSystem)
                {
                    case "GPS":NS = 'G';break;
                    case "BDS":NS = 'C';break;
                    case "Galileo":NS = 'E';break;
                    //case "QZSS":NS = 'J';break;
                    //case "GLONASS":NS = 'R';break;
                    //case "SBAS":NS = 'S';break;
                    //case "IRNSS":NS = 'I';break;
                    default:
                        if (NavigationSystem != "")
                            MessageBox.Show("暂时无法处理该卫星系统的星历数据！\n请选择GPS、BDS、或Galileo卫星系统", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                        return;
                }
                fs.Seek(0, SeekOrigin.Begin);
                MainFrm.ReadFileHeader(sr);
                while ((temp = sr.ReadLine()) != null)
                {
                    if (temp[0] != NS)
                    {
                        MainFrm.ReadLines(sr, 3);
                        continue;
                    }
                    satellite_num = MainFrm.TakeStringPiece(temp, 1, 3);
                    year = Convert.ToInt32(MainFrm.TakeStringPiece(temp, 5, 4));
                    month = Convert.ToInt32(MainFrm.TakeStringPiece(temp, 10, 2));
                    day = Convert.ToInt32(MainFrm.TakeStringPiece(temp, 13, 2));
                    hour = Convert.ToInt32(MainFrm.TakeStringPiece(temp, 16, 2));
                    min = Convert.ToInt32(MainFrm.TakeStringPiece(temp, 19, 2));
                    sec = Convert.ToDouble(MainFrm.TakeStringPiece(temp, 22, 2));
                    temp = string.Format("{0}-{1}-{2} {3}:{4}:{5}.{6}", year, month.ToString("D2"),
                        day.ToString("D2"), hour.ToString("D2"), min.ToString("D2"), ((int)sec).ToString("D2"), ((sec - (int)sec) * 1000).ToString());
                    ListViewItem item = new ListViewItem(satellite_num);
                    item.SubItems.Add(temp);
                    lv_SelectData.Items.Add(item);
                    MainFrm.ReadLines(sr, 3);
                }
            }
            sr.Close();
            fs.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            MainFrm.Data_mark = lv_SelectData.SelectedItems[0].SubItems[0].Text.ToString() + "*" + lv_SelectData.SelectedItems[0].SubItems[1].Text.ToString();
            this.Dispose();
            this.Close();
        }
        
        private void lv_SelectData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_SelectData.SelectedItems.Count != 0)
            {
                btn_OK.Enabled = true;
            }
            else
            {
                btn_OK.Enabled = false;
            }

        }
        
    }
}
