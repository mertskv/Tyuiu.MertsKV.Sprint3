﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MertsKV.Sprint3.Task5.V18.Lib;
namespace Tyuiu.MertsKV.Sprint3.Task5.V18.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataServise ds = new DataServise();

            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 11;

            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            double wait = 768.361;

            Assert.AreEqual(wait, res);

        }
    }
}
