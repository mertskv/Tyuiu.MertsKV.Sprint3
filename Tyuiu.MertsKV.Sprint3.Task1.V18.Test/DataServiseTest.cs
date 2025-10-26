using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MertsKV.Sprint3.Task1.V18.Lib;
namespace Tyuiu.MertsKV.Sprint3.Task1.V18.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        [TestMethod]
        public void GetSumSeries()
        {
            DataServise ds = new DataServise();

            int s = 1;
            int st = 2;
            Assert.AreEqual(ds.GetSumSeries(s, st), 0.109);
        }
    }
}

