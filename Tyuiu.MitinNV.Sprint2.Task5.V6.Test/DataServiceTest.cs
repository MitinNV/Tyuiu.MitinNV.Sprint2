using Tyuiu.MitinNV.Sprint2.Task5.V6.Lib;

namespace Tyuiu.MitinNV.Sprint2.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual("туз пик", ds.FindCardNameAndValue(1, 14));
        }
    }
}