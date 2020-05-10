using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLayer.Tests
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        [DataSource("MyDataSource")]
        [TestMethod]
        public void DataTest()
        {
            var manager = new OperationManager();

            int x = Convert.ToInt32(TestContext.DataRow["x"]);
            int y = Convert.ToInt32(TestContext.DataRow["y"]);
            int expected = Convert.ToInt32(TestContext.DataRow["expected"]);

            int actual = manager.Sum(x, y);

            Assert.AreEqual(expected, actual);
        }
    }
}