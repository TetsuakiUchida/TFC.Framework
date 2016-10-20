using System;

namespace TFC.Framework.Core
{
    /// <summary>
    /// 日付ユーティリティ
    /// </summary>
    public static class DateTimeExtensions
    {
        /// <summary>
        /// 年初日付を取得します。
        /// </summary>
        /// <param name="value">日付</param>
        /// <returns></returns>
        public static DateTime GetBeginningOfYear(this DateTime value)
        {
            return new DateTime(value.Year, 1, 1);
        }

        /// <summary>
        /// 年末日付を取得します。
        /// </summary>
        /// <param name="value">日付</param>
        /// <returns></returns>
        public static DateTime GetEndOfYear(this DateTime value)
        {
            return new DateTime(value.Year, 12, 31);
        }

        /// <summary>
        /// 月初日付を取得します。
        /// </summary>
        /// <param name="value">日付</param>
        /// <returns></returns>
        public static DateTime GetBeginningOfMonth(this DateTime value)
        {
            return new DateTime(value.Year, value.Month, 1);
        }

        /// <summary>
        /// 月末日付を取得します。
        /// </summary>
        /// <param name="value">日付</param>
        /// <returns></returns>
        public static DateTime GetEndOfMonth(this DateTime value)
        {
            if (value == DateTime.MaxValue) return value;
            return value.AddMonths(1).GetBeginningOfMonth().AddDays(-1);
        }

        /// <summary>
        /// 日本標準時（UTC+9）に変換します
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DateTime ToLocalTimeJPN(this DateTime value)
        {
            return value.ToUniversalTime().AddHours(9);
        }
    }
}