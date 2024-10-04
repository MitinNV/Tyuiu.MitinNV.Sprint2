using Tyuiu.MitinNV.Sprint2.Task1.V20.Lib;

namespace Tyuiu.MitinNV.Sprint2.Task1.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            Assert.AreEqual(false, ds.GetLogicOperations(242, 155, 456, 17)[0]);
        }
    }
}