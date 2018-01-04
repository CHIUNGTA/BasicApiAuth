using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webapiBasic.Utility
{
    public class MyTime
    {
        /// <summary>
        /// 回傳時間區間
        /// </summary>
        /// <param name="from"></param>
        /// <param name="thru"></param>
        /// <returns></returns>
        public static IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
        {
            for (var day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
                yield return day;
        }
    }
}