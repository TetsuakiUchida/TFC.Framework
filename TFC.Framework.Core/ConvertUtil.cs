using System;

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
        public static int? ToInt32OrNull(object value)
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
        public static decimal? ToDecimalOrNull(object value)
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
        public static bool? ToBooleanOrNull(object value)
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
    }
}