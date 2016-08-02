using System;
using System.Globalization;

namespace TFC.Framework.Core
{
    /// <summary>
    /// 型変換ユーティリティクラス
    /// </summary>
    public static class ConvertUtil
    {
        /// <summary>
        /// 指定したオブジェクトを等価の 32 ビット符号付き整数に変換します。
        /// 変換できない場合はNullを返します。
        /// </summary>
        /// <param name="value">変換する数値を格納するオブジェクト</param>
        /// <returns></returns>
        public static int? ToNullableInt32(object value)
        {
            int d;
            if (int.TryParse(Convert.ToString(value), out d))
            {
                return d;
            }
            return null;
        }

        /// <summary>
        /// 指定したオブジェクトを等価の decimal型 に変換します。
        /// 変換できない場合はNullを返します。
        /// </summary>
        /// <param name="value">変換する数値を格納するオブジェクト</param>
        /// <returns></returns>
        public static decimal? ToNullableDecimal(object value)
        {
            decimal d;
            if (decimal.TryParse(Convert.ToString(value), out d))
            {
                return d;
            }

            return null;
        }

        /// <summary>
        /// 指定したオブジェクトを等価のBoolean型に変換します。
        /// 変換できない場合はNullを返します。
        /// </summary>
        /// <param name="value">変換する数値を格納するオブジェクト</param>
        /// <returns></returns>
        public static bool? ToNullableBoolean(object value)
        {
            var strValue = Convert.ToString(value);
            if (strValue == "1") return true;

            bool d;
            if (bool.TryParse(strValue, out d))
            {
                return d;
            }

            return null;
        }

        /// <summary>
        /// 指定したオブジェクトを等価のDateTime型に変換します。
        /// 変換できない場合はNullを返します。
        /// </summary>
        /// <param name="value">変換する数値を格納するオブジェクト</param>
        /// <returns></returns>
        public static DateTime? ToNullableDateTime(object value)
        {
            DateTime d;
            if (DateTime.TryParse(Convert.ToString(value), out d))
            {
                return d;
            }

            return null;
        }

        /// <summary>
        /// 現在のカルチャで、フォーマットを指定して、指定したオブジェクトを等価のDateTime型に変換します。
        /// 変換できない場合はNullを返します。
        /// </summary>
        /// <param name="value">変換する数値を格納するオブジェクト</param>
        /// <returns></returns>
        public static DateTime? ToNullableDateTime(object value, string format)
        {
            DateTime d;
            if (DateTime.TryParseExact(Convert.ToString(value), format, DateTimeFormatInfo.CurrentInfo, DateTimeStyles.None, out d))
            {
                return d;
            }

            return null;
        }
    }
}