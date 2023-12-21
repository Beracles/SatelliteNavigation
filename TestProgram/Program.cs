using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //double a = 0.978554086786E+00;
            //Console.WriteLine(a);
            //Console.ReadLine();

            //double GM = 3.986005e14;
            //double genhaoa = 0.515363998604D + 04;
            //double result1 = Math.Sqrt(GM / Math.Pow(genhaoa, 6));
            //double result2 = Math.Sqrt(GM) / Math.Pow(genhaoa, 3);
            //Console.WriteLine(result1 + "\n" + result2);
            //Console.ReadLine();

            //time[i] = "20" + (Convert.ToInt32(year)).ToString("d2") + "-" +
            //        (Convert.ToInt32(month)).ToString("d2") + "-" +
            //        (Convert.ToInt32(day)).ToString("d2") + " " +
            //        (Convert.ToInt32(hour)).ToString("d2") + ":" +
            //        (Convert.ToInt32(min)).ToString("d2") + ":" +
            //        ((int)Convert.ToDouble(sec)).ToString("d2") + "." +
            //        ((Convert.ToDouble(sec) - (int)Convert.ToDouble(sec)) * 1000).ToString();

            //string str = "   3   4   5        6";
            //string[] strs = NewSplit(str, ' ');
            //foreach (string st in strs)
            //{
            //    Console.WriteLine(st);
            //}

            //int a = 35;
            //int b = a / 12+(a % 12 == 0 ? 0 : 1);
            //int c = a % 12 == 0 ? 0 : 1;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            string str = "i love you";
            string substr = "love";
            Console.WriteLine(NewIndexOf(str, substr));

            //卫星钟差
            //SdSignPoTemp.dt = ((nFileData)nData[nTheFitPoint]).dclkBias + ((nFileData)nData[nTheFitPoint]).dclkDrift * (ts.lSecond - nGTOC.lSecond) + ((nFileData)nData[nTheFitPoint]).dclkDriftRate * Math.Pow((ts.lSecond - nGTOC.lSecond), 2);


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
            for (int i = 0; i < str.Length - substr.Length; i++)
            {
                if (TakeStringPiece(str, i + 1, substr.Length) == substr)
                {
                    return i;
                }
            }
            return -1;
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
    }
}
