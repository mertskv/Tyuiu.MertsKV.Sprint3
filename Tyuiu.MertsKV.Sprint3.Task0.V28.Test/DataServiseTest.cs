using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MertsKV.Sprint3.Task0.V28.Lib;
namespace Tyuiu.MertsKV.Sprint3.Task0.V28.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataServise ds = new DataServise();
            double value = 0.25;
            int startValue = 1;
            int stopValue = 17;
            double wait = 411589.537;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            Assert.AreEqual(wait, res);
        }
    }

   
}
