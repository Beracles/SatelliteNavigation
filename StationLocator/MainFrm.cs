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
using MathNet.Numerics.LinearAlgebra.Double;

namespace StationLocator
{
    public partial class MainFrm : Form
    {
        /// <summary>
        /// 伪距文件中记录的卫星的最大波段数
        /// </summary>
        public static int BandCount;
        /// <summary>
        /// C1波段的数据处于一组数据的第几个，从1开始
        /// </summary>
        public static int BandLocation;
        /// <summary>
        /// 历元所在的日期，作为区分一个历元的首行的标志
        /// </summary>
        public static string EpochDay;
        /// <summary>
        /// 历元索引
        /// </summary>
        public static int epochIndex = -1;
        /// <summary>
        /// 选择的历元
        /// </summary>
        public static string SelectedEpoch;
        /// <summary>
        /// 光速,m/s
        /// </summary>
        public static double c = 299792458.458;
        /// <summary>
        /// 地球自转速率(GPS)，rad/s
        /// </summary>
        public static double Omg = 7.29211567e-5;
        public MainFrm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 获取波段数、C1波段的位置和历元日期
        /// </summary>
        /// <param name="sr"></param>
        public static void GetHeadInfo(StreamReader sr)
        {
            string line;
            string[] pieces;
            while (!(line = sr.ReadLine()).EndsWith("# / TYPES OF OBSERV")) { }
            pieces = NewSplit(line);
            BandCount = Convert.ToInt32(pieces[0]);//波段数
            for (int i = 0; i < pieces.Length; i++)//C1波段位置
            {
                if (pieces[i] == "C1")
                {
                    BandLocation = i;
                    break;
                }
            }
            while (!(line = sr.ReadLine()).EndsWith("TIME OF FIRST OBS")) { }
            pieces = NewSplit(line);
            EpochDay = " " + TakeStringPiece(pieces[0], 3, 2) + " " + pieces[1].PadLeft(2, ' ') + " " + pieces[2].PadLeft(2, ' ');
        }

        /// <summary>
        /// 从字符串指定位置获取指定长度的片段
        /// </summary>
        /// <param name="str">要从中截取片段的字符串</param>
        /// <param name="start">开始位置，从1开始</param>
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
        /// <summary>
        /// 获取文件中所有的历元
        /// </summary>
        /// <param name="sr"></param>
        /// <returns></returns>
        public static List<string> GetEpoches(StreamReader sr)
        {
            List<string> epoches = new List<string>();
            string temp;
            while ((temp = sr.ReadLine()) != null)
            {
                if (temp.StartsWith(EpochDay))
                    epoches.Add(TakeStringPiece(temp, 1, 26));
            }
            return epoches;
        }

        /// <summary>
        /// 按某些符号分割，并剔除结果中的空字符串
        /// </summary>
        /// <param name="str"></param>
        /// <param name="pars"></param>
        /// <returns></returns>
        public static string[] NewSplit(string str, params char[] pars)
        {
            char[] target = { ' ' };
            if (pars.Length != 0)
            {
                target = pars;
            }
            List<string> pieces = new List<string>();
            pieces = str.Split(target).ToList<string>();
            while (pieces.Remove("")) { }
            return pieces.ToArray();
        }
        /// <summary>
        /// 指定子字符串在目标字符中中的第一个匹配项的位置，返回子字符串第一个字符在目标字符串中的位置；
        /// -1表示未找到匹配项
        /// </summary>
        /// <param name="str">目标字符串</param>
        /// <param name="substr">子字符串</param>
        /// <returns></returns>
        public static int NewIndexOf(string str, string substr)
        {
            for (int i = 0; i <= str.Length - substr.Length; i++)
            {
                if (TakeStringPiece(str, i + 1, substr.Length) == substr)
                {
                    return i;
                }
            }
            return -1;
        }

        private void btn_clearUselessData_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_data.Rows.Count - 1;)
            {
                if (dgv_data.Rows[i].Cells[0].Value.ToString()[0] != 'G' || dgv_data.Rows[i].Cells[2].ToString() == "")
                {
                    dgv_data.Rows.RemoveAt(i);
                }
                else
                    i++;
            }
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {

        }

        private void tsmi_ImportXYZs_Click(object sender, EventArgs e)
        {
            string EpochInSP3 = "*  " + SelectedEpoch;
            OFD.Filter = "精密星历(*.sp3)|*.sp3";
            DialogResult dr = OFD.ShowDialog();
            if (dr != DialogResult.OK) return;
            FileStream fs = File.OpenRead(OFD.FileName);
            StreamReader sr = new StreamReader(fs);
            string temp, OneSatellite;
            int indexofsatellite;
            while ((temp = sr.ReadLine()) != null)
            {
                if (temp == EpochInSP3) break;
            }
            if (temp == null)
            {
                MessageBox.Show("未在该文件中找到所采用历元!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string satelliteList = "";
            for(int i = 0; i < dgv_data.Rows.Count - 1; i++)
            {
                satelliteList += dgv_data.Rows[i].Cells[0].Value.ToString();
            }
            while (true)
            {
                OneSatellite = sr.ReadLine();
                if (OneSatellite[0] != 'P') break;//首字符不是P时，说明到了下一个历元，结束循环
                if (satelliteList.Contains(TakeStringPiece(OneSatellite, 2, 3)))
                {
                    indexofsatellite = (NewIndexOf(satelliteList, TakeStringPiece(OneSatellite, 2, 3)) + 3) / 3 - 1;
                    dgv_data.Rows[indexofsatellite].Cells[2].Value = TakeStringPiece(OneSatellite, 6, 13);
                    dgv_data.Rows[indexofsatellite].Cells[3].Value = TakeStringPiece(OneSatellite, 20, 13);
                    dgv_data.Rows[indexofsatellite].Cells[4].Value = TakeStringPiece(OneSatellite, 34, 13);
                    dgv_data.Rows[indexofsatellite].Cells[5].Value= TakeStringPiece(OneSatellite, 48, 13);
                }
            }
            sr.Close(); fs.Close();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            if (dgv_data.Rows.Count == 1) return;
            try
            {
                int demension = dgv_data.Rows.Count - 1;
                DenseMatrix B = new DenseMatrix(demension, 4);
                DenseVector dX = new DenseVector(4);
                DenseVector L = new DenseVector(demension);
                DenseVector X = new DenseVector(3);
                DenseMatrix P = DenseMatrix.CreateIdentity(demension);
                DenseVector rou0 = new DenseVector(demension);
                DenseVector rou = new DenseVector(demension);
                DenseMatrix XYZs = new DenseMatrix(demension, 3);//卫星坐标矩阵
                DenseVector S = new DenseVector(demension);
                DenseMatrix R = new DenseMatrix(3);//地球自转改正的卫星坐标转换矩阵
                DenseVector V = new DenseVector(demension);//误差向量
                DenseMatrix Q = new DenseMatrix(4);//协因数矩阵
                DenseMatrix D=new DenseMatrix(4);//协方差矩阵
                double m0;//中误差
                double r = Omg * 0.10;
                R[0, 0] = Math.Cos(r);R[0, 1] = Math.Sin(r);
                R[1, 0] = -Math.Sin(r);R[1, 1] = Math.Cos(r);
                R[2, 2] = 1;
                double dts;
                double Vion = 0, Vtrop = 0;
                for (int i = 0; i < dgv_data.Rows.Count - 1; i++)
                {
                    rou[i] = Convert.ToDouble(dgv_data.Rows[i].Cells[1].Value);//伪距
                    XYZs[i, 0] = Convert.ToDouble(dgv_data.Rows[i].Cells[2].Value) * 1000;
                    XYZs[i, 1] = Convert.ToDouble(dgv_data.Rows[i].Cells[3].Value) * 1000;
                    XYZs[i, 2] = Convert.ToDouble(dgv_data.Rows[i].Cells[4].Value) * 1000;
                    dts = dgv_data.Rows[i].Cells[5].Value == null ? 0 : Convert.ToDouble(dgv_data.Rows[i].Cells[5].Value)*1e-6;
                    S[i] = dts * c - Vion - Vtrop;
                    B[i, 3] = -1;
                }
                XYZs = (R * XYZs.Transpose()).Transpose() as DenseMatrix;//地球自转改正
                while (true)
                {
                    for (int i = 0; i < B.RowCount; i++)
                    {
                        rou0[i] = Math.Sqrt(Math.Pow(XYZs[i, 0] - X[0], 2) + Math.Pow(XYZs[i, 1] - X[1], 2) + Math.Pow(XYZs[i, 2] - X[2], 2));
                        L = rou - rou0 + S;
                        B[i, 0] = -(XYZs[i, 0] - X[0]) / rou0[i];
                        B[i, 1] = -(XYZs[i, 1] - X[1]) / rou0[i];
                        B[i, 2] = -(XYZs[i, 2] - X[2]) / rou0[i]; ;
                    }
                    dX = (B.Transpose() * P * B).Inverse() * B.Transpose() * P * L as DenseVector;
                    X += dX.SubVector(0, 3) as DenseVector;
                    if (dX[0] < 0.0001 && dX[1] < 0.0001 && dX[2] < 0.0001) break;
                }
                V = B * dX - L;
                m0 = Math.Sqrt((V.ToRowMatrix() * V.ToColumnMatrix())[0, 0] / (demension - dX.Count));
                Q = (B.Transpose() * B).Inverse() as DenseMatrix;
                D = Math.Pow(m0, 2) * Q;
                //显示
                txtbx_X.Text = X[0].ToString("f4") + "m";
                txtbx_Y.Text = X[1].ToString("f4") + "m";
                txtbx_Z.Text = X[2].ToString("f4") + "m";

                txtbx_mx.Text = Math.Sqrt(D[0, 0]).ToString("f4") + "m";
                txtbx_my.Text = Math.Sqrt(D[1, 1]).ToString("f4") + "m";
                txtbx_mz.Text = Math.Sqrt(D[2, 2]).ToString("f4") + "m";
                txtbx_mt.Text = Math.Sqrt(D[3, 3]).ToString("f4") + "m";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tsmi_ImportWeiju_Click(object sender, EventArgs e)
        {
            OFD.Filter = "伪距文件(*.20o)|*.20o";
            DialogResult dr = OFD.ShowDialog();
            if (dr != DialogResult.OK) return;
            FileStream fs = File.OpenRead(OFD.FileName);
            StreamReader sr = new StreamReader(fs);
            GetHeadInfo(sr);
            ReadFileHeader(sr);
            List<string> epoches = GetEpoches(sr);//读取所有历元，供用户选择
            SelectEpochFrm select = new SelectEpochFrm(epoches);//选择历元
            select.TopMost = true;
            select.ShowDialog();
            if (epochIndex == -1)
            {
                sr.Close(); fs.Close(); return;//未选择（用户直接关闭窗口），直接返回
            }
            SelectedEpoch = "20" + TakeStringPiece(epoches[epochIndex].Trim(' '), 1, 15) + Convert.ToDouble(TakeStringPiece(epoches[epochIndex].Trim(' '), 16, 10)).ToString("f8").PadLeft(11, ' ');
            this.Text = "伪距测量(暂未考虑模型改正)" + "     " + OFD.SafeFileName + "\\" + epoches[epochIndex].Trim(' ');//窗口标题栏显示文件名和历元
            fs.Seek(0, SeekOrigin.Begin);
            ReadFileHeader(sr);
            int LinesPerSatellite = BandCount / 5 + (BandCount % 5 == 0 ? 0 : 1);//每颗卫星波段数据的行数
            string temp, data, satelliteNum, weiju;
            while (!(temp = sr.ReadLine()).StartsWith(epoches[epochIndex])) { }
            int satellitecount = Convert.ToInt32(TakeStringPiece(temp, 31, 2));
            int dataheadlines = satellitecount / 12 + (satellitecount % 12 == 0 ? 0 : 1);//该历元元数据的行数
            for (int i = 0; i < dataheadlines - 1; i++)
            {
                temp += sr.ReadLine().Trim(' ');
            }
            //读取所观测到卫星的伪距
            dgv_data.Rows.Clear();
            for (int i = 0; i < satellitecount; i++)
            {
                satelliteNum = TakeStringPiece(temp, 33 + 3 * i, 3);
                data = "";
                //读取单个卫星伪距
                for (int j = 0; j < LinesPerSatellite; j++)
                {
                    data += sr.ReadLine().PadRight(80, ' ');
                }
                weiju = TakeStringPiece(data, BandLocation * 16 - 16 + 1, 14).Trim(' ');
                dgv_data.Rows.Add(satelliteNum, weiju);
            }
            sr.Close(); fs.Close();
        }
    }
}
