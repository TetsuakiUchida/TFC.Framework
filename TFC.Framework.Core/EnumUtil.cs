using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TFC.Framework.Core
{
    /// <summary>
    /// Enumに関するユーティリティ
    /// </summary>
    public static class EnumUtil
    {
        public static IEnumerable<T> GetValues<T>() where T : struct
        {
            var t = typeof(T);
            if (!t.IsEnum) throw new ArgumentException($"T is not typeof enum:{t.ToString()}");

            foreach (T item in Enum.GetValues(t))
            {
                yield return item;
            }
        }
    }
}
