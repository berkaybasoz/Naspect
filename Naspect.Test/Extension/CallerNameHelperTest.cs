using Microsoft.VisualStudio.TestTools.UnitTesting;
using Naspect.Core.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naspect.Test.Extension
{
    [TestClass]
    public class CallerNameHelperTest
    {
        private string param1 = "blabla";

        [TestMethod]
        [TestCategory(Category.UnitTest)]
        public void Test_CallerNameHelper_Returns_As_Expected()
        {
            Assert.AreEqual(string.Format("{0}->{1}", "MethodName1", param1), MethodName1());
        }

        public string MethodName1()
        {
            return CallerNameHelper.GetCurrentMethodName(param1);
        }

    }
}
