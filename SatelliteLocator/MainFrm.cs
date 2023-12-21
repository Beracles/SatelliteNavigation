using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.LinearAlgebra.Double;
using System.IO;

namespace SatelliteLocator
{
    public partial class MainFrm : Form
    {
        private static string data_mark="";
        public static string Data_mark { get => data_mark; set => data_mark = value; }
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
        #endregion

        private void btn_calc_Click(object sender, EventArgs e)
        {
            double n0, n, tk, Mk, Ek, Vk, Fk, du, dr, di, uk, rk, ik, xk, yk, Omgk, Xk, Yk, Zk;
            int SatelliteSerialNum = -1;
            try
            {
                satellite_num = txtBx_satellite_num.Text;
                DateTime date = Convert.ToDateTime(txtBx_viewtime.Text);
                int weekday = InnerWeekTime(date);
                if (satellite_num[0]=='C')
                {
                    t = weekday * 3600 * 24 + date.Hour * 3600 + date.Minute * 60 + date.Second + date.Millisecond / 1000 - 14;
                    SatelliteSerialNum = Convert.ToInt32(TakeStringPiece(satellite_num, 2, 2));
                }
                else
                    t = weekday * 3600 * 24 + date.Hour * 3600 + date.Minute * 60 + date.Second+date.Millisecond/1000;
                toe = Convert.ToDouble(txtBx_toe.Text);
                Omg0 = Convert.ToDouble(txtBx_Omg0.Text);
                i0 = Convert.ToDouble(txtBx_i0.Text);
                genhaoa = Convert.ToDouble(txtBx_genhaoa.Text);
                E = Convert.ToDouble(txtBx_e.Text);
                w = Convert.ToDouble(txtBx_w.Text);
                M0 = Convert.ToDouble(txtBx_M0.Text);
                dn = Convert.ToDouble(txtBx_dn.Text);
                Omgdot = Convert.ToDouble(txtBx_OmgDot.Text);
                Idot = Convert.ToDouble(txtBx_Idot.Text);
                Cus = Convert.ToDouble(txtBx_Cus.Text);
                Cuc = Convert.ToDouble(txtBx_Cuc.Text);
                Crs = Convert.ToDouble(txtBx_Crs.Text);
                Crc = Convert.ToDouble(txtBx_Crc.Text);
                Cis = Convert.ToDouble(txtBx_Cis.Text);
                Cic = Convert.ToDouble(txtBx_Cic.Text);
            }
            catch
            {
                MessageBox.Show("参数输入有误！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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
            if (tk> 302400)
                tk -= 604800;
            else if(tk<-302400)
                tk += 604800;
            //第三步 计算卫星平近点角
            Mk = M0 + n * tk;
            //第四步 计算卫星偏近点角
            Ek = Mk;
            double temp;
            while (true)
            {
                temp = Ek;
                Ek = Mk + E * Math.Sin(Ek);
                if (Math.Abs(Ek - temp) < 1e-13) break;
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
                    //2 GEO卫星在自定义坐标系中的空间直角坐标系
                    Xk = xk * Math.Cos(Omgk) - yk * Math.Cos(ik) * Math.Sin(Omgk);
                    Yk = xk * Math.Sin(Omgk) + yk * Math.Cos(ik) * Math.Cos(Omgk);
                    Zk = yk * Math.Sin(ik);
                    //3 CGCS2000地固坐标系空间直角坐标系
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
            txtBx_Xk.Text = Xk.ToString("f3") + "m";
            txtBx_Yk.Text = Yk.ToString("f3") + "m";
            txtBx_Zk.Text = Zk.ToString("f3") + "m";
        }

        public MainFrm()
        {
            InitializeComponent();
        }


        private void btn_clear_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("你确定要清空所有参数吗？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.Cancel) return;
            foreach(Control c in gpBx_input.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    c.Text = "";
                }
            }
        }

        private void tsmi_importData_Click(object sender, EventArgs e)
        {
            DialogResult dr = OFD.ShowDialog();
            if (dr == DialogResult.Cancel) return;
            Form frm = new GetDataNumFrm(OFD);
            frm.ShowDialog();
            if (Data_mark == "") return;

            FileStream fs;
            try
            {
                fs = File.Open(OFD.FileName, FileMode.Open);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            StreamReader sr = new StreamReader(fs);
            string data, time, satellite_num;
            int year, month, day, hour, min;
            double sec;
            string MarkedString;
            if (OFD.FileName.EndsWith(".20n"))
            {
                ReadFileHeader(sr);
                while((data = sr.ReadLine()) != null)
                {
                    satellite_num = TakeStringPiece(data, 1, 2);
                    year = Convert.ToInt32(TakeStringPiece(data, 4, 2));
                    month = Convert.ToInt32(TakeStringPiece(data, 7, 2));
                    day = Convert.ToInt32(TakeStringPiece(data, 10, 2));
                    hour = Convert.ToInt32(TakeStringPiece(data, 13, 2));
                    min = Convert.ToInt32(TakeStringPiece(data, 16, 2));
                    sec = Convert.ToDouble(TakeStringPiece(data, 19, 4));
                    time = "20" + year + "-" + month.ToString("d2") + "-" + day.ToString("d2") + " " +
                    hour.ToString("d2") + ":" + min.ToString("d2") + ":" + ((int)sec).ToString("d2") + "." + ((sec - (int)sec) * 1000).ToString();
                    MarkedString = satellite_num + "*" + time;
                    if (MarkedString == Data_mark)
                    {
                        data += ReadLines(sr, 7);
                        txtBx_satellite_num.Text = Data_mark.Split('*')[0];
                        txtBx_viewtime.Text = time;
                        txtBx_toe.Text = TakeStringPiece(data, 3 * 79 + 4, 19).Replace('D', 'E');
                        txtBx_Omg0.Text = TakeStringPiece(data, 3 * 79 + 4 + 2 * 19, 19).Replace('D', 'E');
                        txtBx_i0.Text = TakeStringPiece(data, 4 * 79 + 4, 19).Replace('D', 'E');
                        txtBx_genhaoa.Text = TakeStringPiece(data, 2 * 79 + 4 + 3 * 19, 19).Replace('D', 'E');
                        txtBx_e.Text = TakeStringPiece(data, 2 * 79 + 4 + 19, 19).Replace('D', 'E');
                        txtBx_w.Text = TakeStringPiece(data, 4 * 79 + 4 + 2 * 19, 19).Replace('D', 'E');
                        txtBx_M0.Text = TakeStringPiece(data, 1 * 79 + 4 + 3 * 19, 19).Replace('D', 'E');
                        txtBx_dn.Text = TakeStringPiece(data, 1 * 79 + 4 + 2 * 19, 19).Replace('D', 'E');
                        txtBx_OmgDot.Text = TakeStringPiece(data, 4 * 79 + 4 + 3 * 19, 19).Replace('D', 'E');
                        txtBx_Idot.Text = TakeStringPiece(data, 5 * 79 + 4, 19).Replace('D', 'E');
                        txtBx_Cus.Text = TakeStringPiece(data, 2 * 79 + 4 + 2 * 19, 19).Replace('D', 'E');
                        txtBx_Cuc.Text = TakeStringPiece(data, 2 * 79 + 4, 19).Replace('D', 'E');
                        txtBx_Crs.Text = TakeStringPiece(data, 1 * 79 + 4 + 19, 19).Replace('D', 'E');
                        txtBx_Crc.Text = TakeStringPiece(data, 4 * 79 + 4 + 19, 19).Replace('D', 'E');
                        txtBx_Cis.Text = TakeStringPiece(data, 3 * 79 + 4 + 3 * 19, 19).Replace('D', 'E');
                        txtBx_Cic.Text = TakeStringPiece(data, 3 * 79 + 4 + 19, 19).Replace('D', 'E');
                        break;
                    }
                }
            }
            else if(OFD.FileName.EndsWith(".20p"))
            {
                ReadFileHeader(sr);
                while ((data = sr.ReadLine()) != null)
                {
                    if (data[0] == ' ')
                    {
                        ReadLines(sr, 3);
                        continue;
                    }
                    satellite_num = TakeStringPiece(data, 1, 3);
                    year = Convert.ToInt32(TakeStringPiece(data, 5, 4));
                    month = Convert.ToInt32(TakeStringPiece(data, 10, 2));
                    day = Convert.ToInt32(TakeStringPiece(data, 13, 2));
                    hour = Convert.ToInt32(TakeStringPiece(data, 16, 2));
                    min = Convert.ToInt32(TakeStringPiece(data, 19, 2));
                    sec = Convert.ToDouble(TakeStringPiece(data, 22, 2));
                    time = year + "-" + month.ToString("d2") + "-" + day.ToString("d2") + " " +
                        hour.ToString("d2") + ":" + min.ToString("d2") + ":" + ((int)sec).ToString("d2") + "." + ((sec - (int)sec) * 1000).ToString();
                    MarkedString = satellite_num + "*" + time;
                    if (MarkedString == Data_mark)
                    {
                        data += ReadLines(sr, 7);
                        txtBx_satellite_num.Text = satellite_num;
                        txtBx_viewtime.Text = time;
                        txtBx_toe.Text = TakeStringPiece(data, 3 * 80 + 5, 19);
                        txtBx_Omg0.Text = TakeStringPiece(data, 3 * 80 + 5 + 2 * 19, 19);
                        txtBx_i0.Text = TakeStringPiece(data, 4 * 80 + 5, 19);
                        txtBx_genhaoa.Text = TakeStringPiece(data, 2 * 80 + 5 + 3 * 19, 19);
                        txtBx_e.Text = TakeStringPiece(data, 2 * 80 + 5 + 19, 19);
                        txtBx_w.Text = TakeStringPiece(data, 4 * 80 + 5 + 2 * 19, 19);
                        txtBx_M0.Text = TakeStringPiece(data, 1 * 80 + 5 + 3 * 19, 19);
                        txtBx_dn.Text = TakeStringPiece(data, 1 * 80 + 5 + 2 * 19, 19);
                        txtBx_OmgDot.Text = TakeStringPiece(data, 4 * 80 + 5 + 3 * 19, 19);
                        txtBx_Idot.Text = TakeStringPiece(data, 5 * 80 + 5, 19);
                        txtBx_Cus.Text = TakeStringPiece(data, 2 * 80 + 5 + 2 * 19, 19);
                        txtBx_Cuc.Text = TakeStringPiece(data, 2 * 80 + 5, 19);
                        txtBx_Crs.Text = TakeStringPiece(data, 1 * 80 + 5 + 19, 19);
                        txtBx_Crc.Text = TakeStringPiece(data, 4 * 80 + 5 + 19, 19);
                        txtBx_Cis.Text = TakeStringPiece(data, 3 * 80 + 5 + 3 * 19, 19);
                        txtBx_Cic.Text = TakeStringPiece(data, 3 * 80 + 5 + 19, 19);
                        break;
                    }
                    ReadLines(sr, 3);
                }
            }
            sr.Close();fs.Close();
        }

        /// <summary>
        /// 读取文件流中的多行
        /// </summary>
        /// <param name="sr">流读取器</param>
        /// <param name="n">要读取行数</param>
        /// <returns></returns>
        public static string ReadLines(StreamReader sr, int n)
        {
            string temp="";
            for (int i = 0; i < n; i++)
            {
                temp += sr.ReadLine();
            }
            return temp;
        }

        /// <summary>
        /// 从字符串指定位置获取指定长度的片段
        /// </summary>
        /// <param name="str">要从中截取片段的字符串</param>
        /// <param name="start">开始位置</param>
        /// <param name="length">截取的片段长度</param>
        /// <returns></returns>
        public static string TakeStringPiece(string str, int start, int length)
        {
            string temp = "";
            for (int i = 0; i < length; i++)
            {
                temp += str[start + i - 1];
            }
            return temp;
        }

        /// <summary>
        /// 返回不同星期对应的GPS周内日
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static int InnerWeekTime(DateTime date)
        {
            int weeks=0;
            switch (date.DayOfWeek.ToString().ToLower())
            {
                case "sunday":weeks = 0;break;
                case "monday":weeks = 1;break;
                case "tuesday":weeks = 2;break;
                case "wednesday":weeks = 3;break;
                case "thursday":weeks = 4;break;
                case "friday":weeks = 5;break;
                case "saturday":weeks = 6;break;
            }
            return weeks;
        }

        private void tsmi_multiprocess_Click(object sender, EventArgs e)
        {
            DialogResult dr = OFD.ShowDialog();
            if (dr == DialogResult.Cancel) return;
            MultiProcessFrm multiProcessFrm = new MultiProcessFrm(OFD,this);
            multiProcessFrm.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// 读取数据时跳过数据文件的文件头
        /// </summary>
        /// <param name="sr">流读取器，使用之前指针要重新指向开始位置</param>
        public static void ReadFileHeader(StreamReader sr)
        {
            string temp;
            while (true)
            {
                temp = sr.ReadLine();
                if (temp.Contains("END OF HEADER"))
                {
                    break;
                }
            }
        }
    }
}
