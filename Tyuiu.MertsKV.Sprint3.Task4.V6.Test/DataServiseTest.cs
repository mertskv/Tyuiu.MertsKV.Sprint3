using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MertsKV.Sprint3.Task4.V6.Lib;
namespace Tyuiu.MertsKV.Sprint3.Task4.V6.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataServise ds = new DataServise();

            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);

            double wait = 8.995;

            Assert.AreEqual(wait, res);
        }
    }
}
