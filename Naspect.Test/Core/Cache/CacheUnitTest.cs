using System;
using Microsoft.VisualStudio.TestTools.UnitTesting; 
using Moq;
using Naspect.Core.Cache;

namespace Naspect.Core.Cache.Test
{
    [TestClass]
    public class UnitTest1
    {
        private Mock<ICacheProvider> cacheProvider;

        [TestMethod]
        public void TestMethod1()
        {
            cacheProvider = new Mock<ICacheProvider>();
            cacheProvider.Setup((cacher) => cacher.SetData(It.IsAny<string>(), It.IsAny<object>()));
            object cacheObj;
            cacheProvider.Setup((cacher) => cacher.TryGetData(It.IsAny<string>(), out cacheObj))
          .Returns(true);
        }


        [TestMethod]
        [TestCategory(Naspect.Test.Category.UnitTest)]
        public void Test_GetCache_ReturnsAsExpected()
        {  //Arrange 
            string key = "key";
            object cacheObj;
            // Act 
            var response = cacheProvider.Object.TryGetData(key, out cacheObj);
            //Assert
            Assert.IsNotNull(cacheObj);
            Assert.IsTrue(response);
        }


    }


}
