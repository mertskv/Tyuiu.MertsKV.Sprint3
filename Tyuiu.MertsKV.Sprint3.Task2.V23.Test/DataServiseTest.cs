using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MertsKV.Sprint3.Task2.V23.Lib;
namespace Tyuiu.MertsKV.Sprint3.Task2.V23.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataServise ds = new DataServise();

            double value = 1.5;
            int startValue = 1;
            int stopValue = 13;

            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = -63.727;
            Assert.AreEqual(wait, res);
        }
    }

  
}
