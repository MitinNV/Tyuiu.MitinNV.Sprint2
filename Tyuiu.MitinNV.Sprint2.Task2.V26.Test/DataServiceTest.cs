using Tyuiu.MitinNV.Sprint2.Task2.V26.Lib;

namespace Tyuiu.MitinNV.Sprint2.Task2.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(true, ds.CheckDotInShadedArea(8, 7));
        }
    }
}