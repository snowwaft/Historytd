using System;
using System.Text;

namespace Newinfosoft.Historytd.Entity
{
    /// <summary>
    /// 日期
    /// </summary>
    public class Date
    {
        /// <summary>
        /// 公元年
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// 公元月
        /// </summary>
        public int Month { get; set; }

        /// <summary>
        /// 公园日
        /// </summary>
        public int Day { get; set; }

        /// <summary>
        /// 返回公历年月日字符串
        /// </summary>
        /// <returns>年月日字符串</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();

            if (Year < 0)
            {
                sb.Append("公元前 ");
            }
            sb.Append(Year.ToString());
            sb.Append("年");
            if (Month != 0)
            {
                sb.Append(" ");
                sb.Append(Month.ToString());
                sb.Append("月");

                if (Day != 0)
                {
                    sb.Append(" ");
                    sb.Append(Day.ToString());
                    sb.Append("日");
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// 转换成数字格式
        /// </summary>
        /// <returns></returns>
        public int ToInt32()
        {
            return Year * 10000 + Month * 100 + Day;
        }

        public static Date Parse(int i)
        {
            return new Date
            {
                Year = i / 10000,
                Month = (i % 10000) / 100,
                Day = i % 100
            };
        }
    }
}
