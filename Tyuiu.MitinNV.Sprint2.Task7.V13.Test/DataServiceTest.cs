using Tyuiu.MitinNV.Sprint2.Task7.V13.Lib;

namespace Tyuiu.MitinNV.Sprint2.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            Assert.AreEqual(true, dataService.CheckDotInShadedArea(1, 1));
        }
    }
}