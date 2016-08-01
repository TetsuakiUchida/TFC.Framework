using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TFC.Framework.Core
{

    /// <summary>
    /// Stringの拡張メソッドクラス
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// 値がNullでないことを保証します。
        /// Nullの場合は""を返します。
        /// </summary>
        /// <param name="value"> 値</param>
        /// <returns></returns>
        public static string EnsureNotNull(this string value)
        {
            return value ?? "";
        }


        /// <summary>
        /// 指定した文字列が最初に見つかった場所以降を切り捨てた文字列を返します。
        /// </summary>
        /// <param name="value"> 文字列</param>
        /// <param name="target"> 検索文字列 </param>
        /// <returns></returns>
        public static string Truncate(this string value, string target)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrEmpty(target)) return value;

            var index = value.IndexOf(target);

            if (index < 0) return value;

            return value.Substring(0, index);
        }

        /// <summary>
        /// 指定した文字列の、指定したインデックス以降を切り捨てた文字列を返します。
        /// </summary>
        /// <param name="value"> 文字列</param>
        /// <param name="index"> インデックス </param>
        /// <returns></returns>
        public static string Truncate(this string value, int index)
        {
            if (index < 0) throw new ArgumentException(string.Format("bad index:{0}", index));

            if (string.IsNullOrEmpty(value)) return value.EnsureNotNull();

            if (value.Length < index) index = value.Length;

            return value.Substring(0, index);
        }

        /// <summary>
        /// 指定した文字列が最後に見つかった場所以降を切り捨てた文字列を返します。
        /// </summary>
        /// <param name="value"> 文字列</param>
        /// <param name="target"> 検索文字列 </param>
        /// <returns></returns>
        public static string TruncateLast(this string value, string target)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrEmpty(target)) return value;

            var index = value.LastIndexOf(target);

            if (index < 0) return value;

            return value.Substring(0, index);
        }

        /// <summary>
        /// 指定した文字列が最初に見つかった場所以前を切り捨てた文字列を返します。
        /// </summary>
        /// <param name="value"> 文字列</param>
        /// <param name="target"> 検索文字列 </param>
        /// <returns></returns>
        public static string TruncateAhead(this string value, string target)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrEmpty(target)) return value;

            var index = value.IndexOf(target);

            if (index < 0) return value;

            return value.Substring(index + target.Length, value.Length - index - target.Length);
        }

        /// <summary>
        /// 文字列を指定した文字列で囲みます。
        /// </summary>
        /// <param name="value"> 文字列</param>
        /// <param name="enclosingValue"> 取り囲む文字列 </param>
        /// <returns></returns>
        public static string Enclose(this string value, string enclosingValue)
        {
            return string.Concat(
                enclosingValue.EnsureNotNull(),
                value.EnsureNotNull(),
                enclosingValue.EnsureNotNull());
        }

        /// <summary>
        /// 指定した文字列で囲まれた文字列から、囲まれた範囲の文字列を取得します。
        /// </summary>
        /// <param name="value"> 文字列</param>
        /// <param name="enclosingValue"> 取り囲んでいる文字列 </param>
        /// <returns></returns>
        public static string Disclose(this string value, string enclosingValue)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrEmpty(enclosingValue)) return value;

            var result = value;

            if (result.StartsWith(enclosingValue))
            {
                result = result.TruncateAhead(enclosingValue);

                if (!result.EndsWith(enclosingValue))
                {
                    return value;
                }

                result = result.TruncateLast(enclosingValue);
            }

            return result;
        }

        /// <summary>
        /// 文字列の末尾に改行コードを付加します。
        /// </summary>
        /// <param name="value"> 文字列</param>
        /// <returns></returns>
        public static string AddNewLine(this string value)
        {
            return string.Concat(value.EnsureNotNull(), Environment.NewLine);
        }

        /// <summary>
        /// 文字列が空文字の場合 Null を返します。
        /// </summary>
        /// <param name="value"> 文字列</param>
        /// <returns></returns>
        public static string ToNullIfEmpty(this string value)
        {
            return string.IsNullOrEmpty(value) ? null : value;
        }


        /// <summary>
        /// 大文字小文字の区別を無視して文字列を比較します。
        /// </summary>
        /// <param name="value"> 文字列</param>
        /// <param name="target"> 比較対象</param>
        /// <returns></returns>
        public static bool EqualsIgnoreCase(this string value, string target)
        {
            if (value == null) return false;
            return value.Equals(target, StringComparison.OrdinalIgnoreCase);
        }
    }
}