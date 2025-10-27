using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MertsKV.Sprint3.Task6.V18.Lib;
namespace Tyuiu.MertsKV.Sprint3.Task6.V18.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataServise ds = new DataServise();

            int startValue = 9;
            int stopValue = 18;

            int res = ds.GetSumTheDivisors(startValue, stopValue);

            int wait = 95;

            Assert.AreEqual(wait, res);
        }
    }
}
