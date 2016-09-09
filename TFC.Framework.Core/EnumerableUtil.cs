using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TFC.Framework.Core
{
    /// <summary>
    /// IEnumerableに関するユーティリティ
    /// </summary>
    public static class EnumerableUtil
    {
        public static IEnumerable<T> ToEnumerable<T>(this T value)
        {
            return new T[] { value };
        }
    }
}
