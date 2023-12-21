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
using System.Threading;
using MathNet.Numerics.LinearAlgebra.Double;

namespace SatelliteLocator
{
    public partial class MultiProcessFrm : Form
    {
        MainFrm main;
        OpenFileDialog OFD;
        public static DataTable tb_result = new DataTable();

        #region 参数定义
        /// <summary>
        /// 卫星号
        /// </summary>
        string satellite_num;
        /// <summary>
        /// 星历表参考历元
        /// </summary>
        double toe;
        /// <summary>
        /// 按参考历元toe计算的升交点赤经(rad)
        /// </summary>
        double Omg0;
        /// <summary>
        /// 按参考历元toe计算的轨道倾角(rad)
        /// </summary>
        double i0;
        /// <summary>
        /// 轨道长半径的平方根(m^(0.5))
        /// </summary>
        double genhaoa;
        /// <summary>
        /// 轨道偏心率
        /// </summary>
        double E;
        /// <summary>
        /// 近地点角距(rad)
        /// </summary>
        double w;
        /// <summary>
        /// 按参考历元toe计算的平近点角(rad)
        /// </summary>
        double M0;
        /// <summary>
        /// 由精密星历计算得到的卫星平均角速度与按给定参数计算所得的平均角速度之差(rad/s)
        /// </summary>
        double dn;
        /// <summary>
        /// 升交点赤经变化率(rad/s)
        /// </summary>
        double Omgdot;
        /// <summary>
        /// 轨道倾角变化率(rad/s)
        /// </summary>
        double Idot;
        /// <summary>
        /// 纬度幅角的的正弦调和项改正的振幅(rad)
        /// </summary>
        double Cus;
        /// <summary>
        /// 纬度幅角的的余弦调和项改正的振幅(rad)
        /// </summary>
        double Cuc;
        /// <summary>
        /// 轨道半径的的正弦调和项改正的振幅(rad)
        /// </summary>
        double Crs;
        /// <summary>
        /// 轨道半径的的余弦调和项改正的振幅(rad)
        /// </summary>
        double Crc;
        /// <summary>
        /// 轨道倾角的的正弦调和项改正的振幅(rad)
        /// </summary>
        double Cis;
        /// <summary>
        /// 轨道倾角的的余弦调和项改正的振幅(rad)
        /// </summary>
        double Cic;
        /// <summary>
        /// 观测时刻的周内时(s)
        /// </summary>
        double t;
        /// <summary>
        /// GPS采用的地球引力常数(m3/s2)
        /// </summary>
        double GM_GPS = 3.986005e14;
        /// <summary>
        /// GPS采用的地球自转的速率(rad/s)
        /// </summary>
        double we_GPS = 7.29211567e-5;
        /// <summary>
        /// BDS采用的地球引力常数(m3/s2)
        /// </summary>
        double GM_BDS = 3.986004418e14;
        /// <summary>
        /// BDS采用的地球自转的速率(rad/s)
        /// </summary>
        double we_BDS = 7.2921150e-5;
        /// <summary>
        /// 卫星系统类型
        /// </summary>
        public string NavigationSystem = "";

        #endregion

        public MultiProcessFrm(OpenFileDialog ofd, MainFrm mainFrm)
        {
            InitializeComponent();
            main = mainFrm;
            OFD = ofd;
            if(!tb_result.Columns.Contains("卫星号"))
                tb_result.Columns.Add("卫星号", typeof(string));
            if (!tb_result.Columns.Contains("观测历元"))
                tb_result.Columns.Add("观测历元", typeof(string));
            if (!tb_result.Columns.Contains("Xk(m)"))
                tb_result.Columns.Add("Xk(m)", typeof(string));
            if (!tb_result.Columns.Contains("Yk(m)"))
                tb_result.Columns.Add("Yk(m)", typeof(string));
            if (!tb_result.Columns.Contains("Zk(m)"))
                tb_result.Columns.Add("Zk(m)", typeof(string));
        }

        private void MultiProcessFrm_Load(object sender, EventArgs e)
        {
            FileStream fs;
            try
            {
                fs = File.Open(OFD.FileName, FileMode.Open);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                return;
            }
            StreamReader sr = new StreamReader(fs);

            string data, time, satellite_num;
            int year, month, day, hour, min;
            double sec;
            if (OFD.FileName.EndsWith(".20n"))
            {
                main.Hide();
                MainFrm.ReadFileHeader(sr);
                while ((data = MainFrm.ReadLines(sr,8)) != null)
                {
                    year = Convert.ToInt32(MainFrm.TakeStringPiece(data, 4, 2));
                    month = Convert.ToInt32(MainFrm.TakeStringPiece(data, 7, 2));
                    day = Convert.ToInt32(MainFrm.TakeStringPiece(data, 10, 2));
                    hour = Convert.ToInt32(MainFrm.TakeStringPiece(data, 13, 2));
                    min = Convert.ToInt32(MainFrm.TakeStringPiece(data, 16, 2));
                    sec = Convert.ToDouble(MainFrm.TakeStringPiece(data, 19, 4));
                    time = "20" + year + "-" + month.ToString("d2") + "-" + day.ToString("d2") + " " +
                        hour.ToString("d2") + ":" + min.ToString("d2") + ":" + ((int)sec).ToString("d2") + "." + ((sec - (int)sec) * 1000).ToString();
                    satellite_num = MainFrm.TakeStringPiece(data, 1, 2);
                    ListViewItem item = new ListViewItem(satellite_num);
                    item.SubItems.Add(time);//观测历元
                    item.SubItems.Add(MainFrm.TakeStringPiece(data, 3 * 79 + 4, 19).Replace('D', 'E'));//toe
                    item.SubItems.Add(MainFrm.TakeStringPiece(data, 3 * 79 + 4 + 2 * 19, 19).Replace('D', 'E'));//Omg0
                    item.SubItems.Add(MainFrm.TakeStringPiece(data, 4 * 79 + 4, 19).Replace('D', 'E'));//i0
                    item.SubItems.Add(MainFrm.TakeStringPiece(data, 2 * 79 + 4 + 3 * 19, 19).Replace('D', 'E'));//genhaoa
                    item.SubItems.Add(MainFrm.TakeStringPiece(data, 2 * 79 + 4 + 19, 19).Replace('D', 'E'));//e
                    item.SubItems.Add(MainFrm.TakeStringPiece(data, 4 * 79 + 4 + 2 * 19, 19).Replace('D', 'E'));//w
                    item.SubItems.Add(MainFrm.TakeStringPiece(data, 1 * 79 + 4 + 3 * 19, 19).Replace('D', 'E'));//M0
                    item.SubItems.Add(MainFrm.TakeStringPiece(data, 1 * 79 + 4 + 2 * 19, 19).Replace('D', 'E'));//dn
                    item.SubItems.Add(MainFrm.TakeStringPiece(data, 4 * 79 + 4 + 3 * 19, 19).Replace('D', 'E'));//Omgdot
                    item.SubItems.Add(MainFrm.TakeStringPiece(data, 5 * 79 + 4, 19).Replace('D', 'E'));//Idot
                    item.SubItems.Add(MainFrm.TakeStringPiece(data, 2 * 79 + 4 + 2 * 19, 19).Replace('D', 'E'));//Cus
                    item.SubItems.Add(MainFrm.TakeStringPiece(data, 2 * 79 + 4, 19).Replace('D', 'E'));//Cuc
                    item.SubItems.Add(MainFrm.TakeStringPiece(data, 1 * 79 + 4 + 19, 19).Replace('D', 'E'));//Crs
                    item.SubItems.Add(MainFrm.TakeStringPiece(data, 4 * 79 + 4 + 19, 19).Replace('D', 'E'));//Crc
                    item.SubItems.Add(MainFrm.TakeStringPiece(data, 3 * 79 + 4 + 3 * 19, 19).Replace('D', 'E'));//Cis
                    item.SubItems.Add(MainFrm.TakeStringPiece(data, 3 * 79 + 4 + 19, 19).Replace('D', 'E'));//Cic
                    lv_SelectData.Items.Add(item);
                }
            }
            else if (OFD.FileName.EndsWith(".20p"))
            {
                SelectNavigationSystemFrm selectfrm = new SelectNavigationSystemFrm(sr,this);
                selectfrm.ShowDialog();
                main.Hide();

                char NS;
                switch (NavigationSystem)
                {
                    case "GPS": NS = 'G'; break;
                    case "BDS": NS = 'C'; break;
                    case "Galileo": NS = 'E'; break;
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
                while ((data = sr.ReadLine()) != null)
                {
                    if (data[0] != NS)
                    {
                        MainFrm.ReadLines(sr, 3);
                        continue;
                    }
                    data += MainFrm.ReadLines(sr, 7);
                    satellite_num = MainFrm.TakeStringPiece(data, 1, 3);
                    year = Convert.ToInt32(MainFrm.TakeStringPiece(data, 5, 4));
                    month = Convert.ToInt32(MainFrm.TakeStringPiece(data, 10, 2));
                    day = Convert.ToInt32(MainFrm.TakeStringPiece(data, 13, 2));
                    hour = Convert.ToInt32(MainFrm.TakeStringPiece(data, 16, 2));
                    min = Convert.ToInt32(MainFrm.TakeStringPiece(data, 19, 2));
                    sec = Convert.ToDouble(MainFrm.TakeStringPiece(data, 22, 2));
                    time = string.Format("{0}-{1}-{2} {3}:{4}:{5}.{6}", year, month.ToString("D2"),
                        day.ToString("D2"), hour.ToString("D2"), min.ToString("D2"), ((int)sec).ToString("D2"), ((sec - (int)sec) * 1000).ToString());
                    ListViewItem item = new ListViewItem(satellite_num);
                    item.SubItems.Add(time);
                    item.SubItems.Add(MainFrm.TakeStringPiece(data, 3 * 80 + 5, 19));
                    item.SubItems.Add(MainFrm.TakeStringPiece(data, 3 * 80 + 5 + 2 * 19, 19));
                    item.SubItems.Add(MainFrm.TakeStringPiece(data, 4 * 80 + 5, 19));
                    item.SubItems.Add(MainFrm.TakeStringPiece(data, 2 * 80 + 5 + 3 * 19, 19));
                    item.SubItems.Add(MainFrm.TakeStringPiece(data, 2 * 80 + 5 + 19, 19));
                    item.SubItems.Add(MainFrm.TakeStringPiece(data, 4 * 80 + 5 + 2 * 19, 19));
                    item.SubItems.Add(MainFrm.TakeStringPiece(data, 1 * 80 + 5 + 3 * 19, 19));
                    item.SubItems.Add(MainFrm.TakeStringPiece(data, 1 * 80 + 5 + 2 * 19, 19));
                    item.SubItems.Add(MainFrm.TakeStringPiece(data, 4 * 80 + 5 + 3 * 19, 19));
                    item.SubItems.Add(MainFrm.TakeStringPiece(data, 5 * 80 + 5, 19));
                    item.SubItems.Add(MainFrm.TakeStringPiece(data, 2 * 80 + 5 + 2 * 19, 19));
                    item.SubItems.Add(MainFrm.TakeStringPiece(data, 2 * 80 + 5, 19));
                    item.SubItems.Add(MainFrm.TakeStringPiece(data, 1 * 80 + 5 + 19, 19));
                    item.SubItems.Add(MainFrm.TakeStringPiece(data, 4 * 80 + 5 + 19, 19));
                    item.SubItems.Add(MainFrm.TakeStringPiece(data, 3 * 80 + 5 + 3 * 19, 19));
                    item.SubItems.Add(MainFrm.TakeStringPiece(data, 3 * 80 + 5 + 19, 19));
                    item.SubItems.Add(data);
                    lv_SelectData.Items.Add(item);
                }
            }
            sr.Close();
            fs.Close();
        }

        private void btn_selectAll_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < lv_SelectData.Items.Count; i++)
            {
                lv_SelectData.Items[i].Selected = true;
            }
            lv_SelectData.Select();
        }

        private void btn_selectNone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lv_SelectData.Items.Count; i++)
            {
                lv_SelectData.Items[i].Selected = false;
            }
            lv_SelectData.Select();
        }

        private void btn_selectRev_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lv_SelectData.Items.Count; i++)
            {
                if (lv_SelectData.Items[i].Selected == true)
                    lv_SelectData.Items[i].Selected = false;
                else
                    lv_SelectData.Items[i].Selected = true;
            }
            lv_SelectData.Select();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            Calculate();
            ShowResult();
        }
        
        private void ShowResult()
        {
            ShowMultiProcessResultFrm showresult = new ShowMultiProcessResultFrm();
            showresult.Show();
        }
        
        private void Calculate()
        {
            int SatelliteSerialNum = -1;
            DateTime date;
            int weekday;
            double n0, n, tk, Mk, Ek, temp, Vk, Fk, du, dr, di, uk, rk, ik, xk, yk, Omgk, Xk, Yk, Zk;
            proB_progress.Maximum = lv_SelectData.SelectedItems.Count;
            proB_progress.Visible = true;
            for (int i = 0; i < lv_SelectData.SelectedItems.Count; i++)
            {
                satellite_num = lv_SelectData.SelectedItems[i].SubItems[0].Text; 
                date = Convert.ToDateTime(lv_SelectData.SelectedItems[i].SubItems[1].Text);
                weekday = MainFrm.InnerWeekTime(date);
                if (satellite_num[0] == 'C')
                {
                    t = weekday * 3600 * 24 + date.Hour * 3600 + date.Minute * 60 + date.Second + date.Millisecond / 1000 - 14;
                    SatelliteSerialNum = Convert.ToInt32(MainFrm.TakeStringPiece(satellite_num, 2, 2));
                }
                else
                    t = weekday * 3600 * 24 + date.Hour * 3600 + date.Minute * 60 + date.Second + date.Millisecond / 1000;
                toe = Convert.ToDouble(lv_SelectData.SelectedItems[i].SubItems[2].Text);
                Omg0 = Convert.ToDouble(lv_SelectData.SelectedItems[i].SubItems[3].Text);
                i0 = Convert.ToDouble(lv_SelectData.SelectedItems[i].SubItems[4].Text);
                genhaoa = Convert.ToDouble(lv_SelectData.SelectedItems[i].SubItems[5].Text);
                E = Convert.ToDouble(lv_SelectData.SelectedItems[i].SubItems[6].Text);
                w = Convert.ToDouble(lv_SelectData.SelectedItems[i].SubItems[7].Text);
                M0 = Convert.ToDouble(lv_SelectData.SelectedItems[i].SubItems[8].Text);
                dn = Convert.ToDouble(lv_SelectData.SelectedItems[i].SubItems[9].Text);
                Omgdot = Convert.ToDouble(lv_SelectData.SelectedItems[i].SubItems[10].Text);
                Idot = Convert.ToDouble(lv_SelectData.SelectedItems[i].SubItems[11].Text);
                Cus = Convert.ToDouble(lv_SelectData.SelectedItems[i].SubItems[12].Text);
                Cuc = Convert.ToDouble(lv_SelectData.SelectedItems[i].SubItems[13].Text);
                Crs = Convert.ToDouble(lv_SelectData.SelectedItems[i].SubItems[14].Text);
                Crc = Convert.ToDouble(lv_SelectData.SelectedItems[i].SubItems[15].Text);
                Cis = Convert.ToDouble(lv_SelectData.SelectedItems[i].SubItems[16].Text);
                Cic = Convert.ToDouble(lv_SelectData.SelectedItems[i].SubItems[17].Text);

                //第一步 计算卫星运行的平均角速度
                if (satellite_num[0] == 'C')
                {
                    n0 = Math.Sqrt(GM_BDS) / Math.Pow(genhaoa, 3);
                }
                else
                    n0 = Math.Sqrt(GM_GPS) / Math.Pow(genhaoa, 3);
                n = n0 + dn;
                //第二步 计算归化时间
                tk = t - toe;
                if (tk > 302400)
                    tk -= 604800;
                else if (tk < -302400)
                    tk += 604800;
                //第三步 计算卫星平近点角
                Mk = M0 + n * tk;
                //第四步 计算卫星偏近点角
                Ek = Mk;
                double Ek0;
                while (true)
                {
                    Ek0 = Ek;
                    Ek = Mk + E * Math.Sin(Ek);
                    if (Math.Abs(Ek - Ek0) < 1e-13) break;
                }
                //第五步 计算卫星真近点角
                Vk = Math.Atan(Math.Sqrt(1 - Math.Pow(E, 2)) * Math.Sin(Ek) / (Math.Cos(Ek) - E));
                //判断Vk象限，Vk的象限应与Ek相同
                if (Vk - Ek > Math.PI / 2)
                    Vk -= Math.PI;
                else if (Vk - Ek < -Math.PI / 2)
                    Vk += Math.PI;
                //第六步 计算卫星升交距角
                Fk = Vk + w;
                //第七步 计算观测时刻升交距角，轨道倾角，卫星向径的摄动改正
                du = Cuc * Math.Cos(2 * Fk) + Cus * Math.Sin(2 * Fk);
                dr = Crc * Math.Cos(2 * Fk) + Crs * Math.Sin(2 * Fk);
                di = Cic * Math.Cos(2 * Fk) + Cis * Math.Sin(2 * Fk);
                //第八步 计算改正后的升交距角，卫星向径，轨道倾角
                uk = Fk + du;
                rk = Math.Pow(genhaoa, 2) * (1 - E * Math.Cos(Ek)) + dr;
                ik = i0 + Idot * tk + di;
                //第九步 计算卫星在轨道平面的位置
                xk = rk * Math.Cos(uk);
                yk = rk * Math.Sin(uk);

                //BDS
                if (satellite_num[0] == 'C')
                {
                    int[] nums = { 1, 2, 3, 4, 5, 59, 60 };
                    //GEO
                    if (nums.Contains<int>(SatelliteSerialNum))
                    {
                        //1 观测时刻卫星升交点经度
                        Omgk = Omg0 + Omgdot * tk - we_BDS * toe;
                        //2 GEO卫星在自定义坐标系中的空间直角坐标
                        Xk = xk * Math.Cos(Omgk) - yk * Math.Cos(ik) * Math.Sin(Omgk);
                        Yk = xk * Math.Sin(Omgk) + yk * Math.Cos(ik) * Math.Cos(Omgk);
                        Zk = yk * Math.Sin(ik);
                        //3 CGCS2000地固坐标系空间直角坐标
                        DenseVector xyzGk = new DenseVector(new double[] { Xk, Yk, Zk });
                        DenseMatrix Rx = new DenseMatrix(3, 3);
                        DenseMatrix Rz = new DenseMatrix(3, 3);
                        Rx[0, 0] = 1; Rx[1, 1] = Math.Cos(we_BDS * tk); Rx[1, 2] = Math.Sin(we_BDS * tk);
                        Rx[2, 1] = -Rx[1, 2]; Rx[2, 2] = Rx[1, 1];
                        double fivedegree = 5 / 180 * Math.PI;
                        Rz[0, 0] = Math.Cos(fivedegree); Rz[0, 1] = Math.Sin(fivedegree);
                        Rz[1, 0] = -Rz[0, 1]; Rz[1, 1] = Rz[0, 0]; Rz[2, 2] = 1;
                        DenseVector xyzk = Rz * Rx * xyzGk;
                        Xk = xyzk[0];
                        Yk = xyzk[1];
                        Zk = xyzk[2];
                    }
                    //IGSO、MEO
                    else
                    {
                        //1 观测时刻卫星升交点经度
                        Omgk = Omg0 + (Omgdot - we_BDS) * tk - we_BDS * toe;
                        //2 将卫星在轨道平面坐标转换到CGCS地固坐标系下
                        Xk = xk * Math.Cos(Omgk) - yk * Math.Cos(ik) * Math.Sin(Omgk);
                        Yk = xk * Math.Sin(Omgk) + yk * Math.Cos(ik) * Math.Cos(Omgk);
                        Zk = yk * Math.Sin(ik);
                    }
                }
                //GPS\Galileo
                else
                {
                    //1 观测时刻卫星升交点经度
                    Omgk = Omg0 + (Omgdot - we_GPS) * tk - we_GPS * toe;
                    //2 将卫星在轨道平面坐标转换到地固坐标系下
                    Xk = xk * Math.Cos(Omgk) - yk * Math.Cos(ik) * Math.Sin(Omgk);
                    Yk = xk * Math.Sin(Omgk) + yk * Math.Cos(ik) * Math.Cos(Omgk);
                    Zk = yk * Math.Sin(ik);
                }

                //显示结果
                tb_result.Rows.Add(lv_SelectData.SelectedItems[i].SubItems[0].Text, lv_SelectData.SelectedItems[i].SubItems[1].Text,
                    Xk.ToString("f3"), Yk.ToString("f3"), Zk.ToString("f3"));
                proB_progress.Value++;
            }
            proB_progress.Value = 0;
            proB_progress.Visible = false;
        }

        private void lv_SelectData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_SelectData.SelectedItems.Count == 0)
            {
                btn_calc.Enabled = false;
            }
            else
            {
                btn_calc.Enabled = true;
            }
        }

        private void MultiProcessFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
