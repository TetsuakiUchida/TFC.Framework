namespace TFC.Framework.Core
{
    /// <summary>
    /// 値検証ユーティリティクラス
    /// </summary>
    public static class ValidateUtil
    {
        /// <summary>
        /// 指定したオブジェクトが数値型かどうかを判定します。
        /// </summary>
        /// <param name="value">判定するオブジェクト</param>
        /// <returns>数値型である場合は True</returns>
        public static bool IsNumeric(this object value)
        {
            return ConvertUtil.ToDecimalOrNull(value).HasValue;
        }
    }
}