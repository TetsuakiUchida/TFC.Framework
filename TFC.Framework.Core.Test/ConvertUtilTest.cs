using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TFC.Framework.Core
{
    [TestClass]
    public class ConvertUtilTest
    {
        [TestMethod]
        public void ToNullableDateTime_HasValue()
        {
            var test = "2016/07/26";
            var actual = ConvertUtil.ToNullableDateTime(test);

            Assert.IsTrue(actual.HasValue);
            Assert.AreEqual(new DateTime(2016, 7, 26), actual.Value);
        }

        [TestMethod]
        public void ToNullableDateTime_Null()
        {
            var test = "20160726";
            var actual = ConvertUtil.ToNullableDateTime(test);

            Assert.IsFalse(actual.HasValue);
        }

        [TestMethod]
        public void ToNullableDateTime_WithFormat_HasValue()
        {
            var test = "20160726";
            var actual = ConvertUtil.ToNullableDateTime(test, "yyyyMMdd");
            Assert.IsTrue(actual.HasValue);
            Assert.AreEqual(new DateTime(2016, 7, 26), actual.Value);
        }

        [TestMethod]
        public void ToNullableDateTime_WithFormat_Null()
        {
            var test = "20160-726";
            var actual = ConvertUtil.ToNullableDateTime(test, "yyyyMMdd");
            Assert.IsFalse(actual.HasValue);
        }
    }
}
