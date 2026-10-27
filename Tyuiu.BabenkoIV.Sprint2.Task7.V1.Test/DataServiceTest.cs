using Tyuiu.BabenkoIV.Sprint2.Task7.V1.Lib;
namespace Tyuiu.BabenkoIV.Sprint2.Task7.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = false;
            Assert.AreEqual(wait, res);

        }
    }
}
